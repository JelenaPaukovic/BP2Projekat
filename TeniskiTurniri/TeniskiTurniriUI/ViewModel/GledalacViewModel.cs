using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TeniskiTurniri;
using TeniskiTurniri.dao;
using TeniskiTurniriUI.Model;
using TeniskiTurniriUI.View;

namespace TeniskiTurniriUI.ViewModel
{
    public class GledalacViewModel : BindableBase
    {
        private GledalacView view;
        private ObservableCollection<Gledalac> gledaoci;
        private Gledalac izabraniGledalac;
        private GledalacDAO gdao = new GledalacDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Gledalac> Gledaoci { get => gledaoci; set { gledaoci = value; OnPropertyChanged("Gledaoci"); } }
        public Gledalac IzabraniGledalac { get => izabraniGledalac; set { izabraniGledalac = value; OnPropertyChanged("IzabraniGledalac"); } }



        public GledalacViewModel(GledalacView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniGledalac = new Gledalac();
            Gledaoci = new ObservableCollection<Gledalac>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniGledalac != null)
            {
                return IzabraniGledalac.idg != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            GledalacIzmeniView newWindow = new GledalacIzmeniView();
            newWindow.DataContext = new GledalacIzmeniViewModel(newWindow, IzabraniGledalac);

            newWindow.ShowDialog();
            Ucitaj();
            IzabraniGledalac = new Gledalac();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniGledalac.idg))
            {
                gdao.Delete(IzabraniGledalac.idg);
                Ucitaj();
                IzabraniGledalac = new Gledalac();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanog gledaoca, postoje turniri koji su vezani za njega!");
            }


        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            GledalacDodajView newWindow = new GledalacDodajView();
            newWindow.DataContext = new GledalacDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Gledaoci = new ObservableCollection<Gledalac>();

            foreach (Gledalac item in gdao.GetList())
            {
                Gledaoci.Add(item);
            }
        }

    }
}
