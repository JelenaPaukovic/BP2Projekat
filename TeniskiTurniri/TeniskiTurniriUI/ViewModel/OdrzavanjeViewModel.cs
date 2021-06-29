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
    public class OdrzavanjeViewModel : BindableBase
    {
        private OdrzavanjeView view;
        private ObservableCollection<Odrzavanje> odrzavanja;
        private Odrzavanje izabraniOdrzavanje;
        private OdrzavanjeDAO gdao = new OdrzavanjeDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Odrzavanje> Odrzavanja { get => odrzavanja; set { odrzavanja = value; OnPropertyChanged("Odrzavanja"); } }
        public Odrzavanje IzabraniOdrzavanje { get => izabraniOdrzavanje; set { izabraniOdrzavanje = value; OnPropertyChanged("IzabraniOdrzavanje"); } }



        public OdrzavanjeViewModel(OdrzavanjeView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniOdrzavanje = new Odrzavanje();
            Odrzavanja = new ObservableCollection<Odrzavanje>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniOdrzavanje != null)
            {
                return IzabraniOdrzavanje.idod != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            OdrzavanjeIzmeniView newWindow = new OdrzavanjeIzmeniView();
            newWindow.DataContext = new OdrzavanjeIzmeniViewModel(newWindow, IzabraniOdrzavanje);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniOdrzavanje = new Odrzavanje();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniOdrzavanje.idod))
            {

                gdao.Delete(IzabraniOdrzavanje.idod);
                Ucitaj();
                IzabraniOdrzavanje = new Odrzavanje();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovano odrzavanje, postoje turniri koji su vezani za njega!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            OdrzavanjeDodajView newWindow = new OdrzavanjeDodajView();
            newWindow.DataContext = new OdrzavanjeDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Odrzavanja = new ObservableCollection<Odrzavanje>();

            foreach (Odrzavanje item in gdao.GetList())
            {
                Odrzavanja.Add(item);
            }
        }
    }
}
