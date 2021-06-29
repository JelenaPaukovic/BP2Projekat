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
    public class TurnirViewModel : BindableBase
    {
        private TurnirView view;
        private ObservableCollection<Turnir> turniri;
        private Turnir izabraniTurnir;
        private TurnirDAO gdao = new TurnirDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Turnir> Turniri { get => turniri; set { turniri = value; OnPropertyChanged("Turniri"); } }
        public Turnir IzabraniTurnir { get => izabraniTurnir; set { izabraniTurnir = value; OnPropertyChanged("IzabraniTurnir"); } }



        public TurnirViewModel(TurnirView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniTurnir = new Turnir();
            Turniri = new ObservableCollection<Turnir>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniTurnir != null)
            {
                return IzabraniTurnir.idtur != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            TurnirIzmeniView newWindow = new TurnirIzmeniView();
            newWindow.DataContext = new TurnirIzmeniViewModel(newWindow, IzabraniTurnir);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniTurnir = new Turnir();
        }

        public void Remove()
        {
            /*if (gdao.DaLiMozeDaSeObrise(IzabraniTurnir.Jmbg))

           gdao.Delete(IzabraniTurnir.idtur);
           Ucitaj();
           IzabraniTurnir = new Turnir();

            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanog pisca, postoje recenzije koje su vezane za njega!");
            }*/


            if (gdao.DaLiMozeDaSeObrise(IzabraniTurnir.idtur))
            {
                gdao.Delete(IzabraniTurnir.idtur);
                Ucitaj();
                IzabraniTurnir = new Turnir();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovani turnir, postoje ulaznice koje su vezane za njega!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            TurnirDodajView newWindow = new TurnirDodajView();
            newWindow.DataContext = new TurnirDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Turniri = new ObservableCollection<Turnir>();

            foreach (Turnir item in gdao.GetList())
            {
                Turniri.Add(item);
            }
        }
    }
}
