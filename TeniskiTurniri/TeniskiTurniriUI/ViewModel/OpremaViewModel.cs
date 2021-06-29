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
    public class OpremaViewModel : BindableBase
    {
        private OpremaView view;
        private ObservableCollection<Oprema> opreme;
        private Oprema izabraniOprema;
        private OpremaDAO gdao = new OpremaDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Oprema> Opreme { get => opreme; set { opreme = value; OnPropertyChanged("Opreme"); } }
        public Oprema IzabraniOprema { get => izabraniOprema; set { izabraniOprema = value; OnPropertyChanged("IzabraniOprema"); } }



        public OpremaViewModel(OpremaView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniOprema = new Oprema();
            Opreme = new ObservableCollection<Oprema>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniOprema != null)
            {
                return IzabraniOprema.ido != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            OpremaIzmeniView newWindow = new OpremaIzmeniView();
            newWindow.DataContext = new OpremaIzmeniViewModel(newWindow, IzabraniOprema);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniOprema = new Oprema();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniOprema.ido))
            {

                gdao.Delete(IzabraniOprema.ido);
                Ucitaj();
                IzabraniOprema = new Oprema();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanu oprema, postoje igraci koji su vezani za nju!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            OpremaDodajView newWindow = new OpremaDodajView();
            newWindow.DataContext = new OpremaDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Opreme = new ObservableCollection<Oprema>();

            foreach (Oprema item in gdao.GetList())
            {
                Opreme.Add(item);
            }
        }
    }
}
