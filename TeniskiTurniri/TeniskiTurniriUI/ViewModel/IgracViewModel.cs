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
    public class IgracViewModel : BindableBase
    {
        private IgracView view;
        private ObservableCollection<Igrac> igraci;
        private Igrac izabraniIgrac;
        private IgracDAO idao = new IgracDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Igrac> Igraci { get => igraci; set { igraci = value; OnPropertyChanged("Igraci"); } }
        public Igrac IzabraniIgrac { get => izabraniIgrac; set { izabraniIgrac = value; OnPropertyChanged("IzabraniIgrac"); } }



        public IgracViewModel(IgracView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniIgrac = new Igrac();
            Igraci = new ObservableCollection<Igrac>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniIgrac != null)
            {
                return IzabraniIgrac.idig != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            IgracIzmeniView newWindow = new IgracIzmeniView();
            newWindow.DataContext = new IgracIzmeniViewModel(newWindow, IzabraniIgrac);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniIgrac = new Igrac();
        }

        public void Remove()
        {
            /* if (dao.DaLiMozeDaSeObrise(SelektovanKriticar.Jmbg))*/

            if (idao.DaLiMozeDaSeObrise(IzabraniIgrac.idig))
            {
                idao.Delete(IzabraniIgrac.idig);
                Ucitaj();
                IzabraniIgrac = new Igrac();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanog igraca, postoje turniri koji su vezani za njega!");
            }


            /* else
             {
                 MessageBox.Show("Ne mozete da obrisite selektovanog pisca, postoje recenzije koje su vezane za njega!");
             }*/

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            IgracDodajView newWindow = new IgracDodajView();
            newWindow.DataContext = new IgracDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Igraci = new ObservableCollection<Igrac>();

            foreach (Igrac item in idao.GetList())
            {
                Igraci.Add(item);
            }
        }
    }
}
