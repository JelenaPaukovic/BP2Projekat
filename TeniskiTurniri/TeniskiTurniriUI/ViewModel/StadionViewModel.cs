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
    public class StadionViewModel : BindableBase
    {
        private StadionView view;
        private ObservableCollection<Stadion> stadioni;
        private Stadion izabraniStadion;
        private StadionDAO gdao = new StadionDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Stadion> Stadioni { get => stadioni; set { stadioni = value; OnPropertyChanged("Stadioni"); } }
        public Stadion IzabraniStadion { get => izabraniStadion; set { izabraniStadion = value; OnPropertyChanged("IzabraniStadion"); } }



        public StadionViewModel(StadionView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniStadion = new Stadion();
            Stadioni = new ObservableCollection<Stadion>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniStadion != null)
            {
                return IzabraniStadion.idst != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            StadionIzmeniView newWindow = new StadionIzmeniView();
            newWindow.DataContext = new StadionIzmeniViewModel(newWindow, IzabraniStadion);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniStadion = new Stadion();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniStadion.idst))
            {

                gdao.Delete(IzabraniStadion.idst);
                Ucitaj();
                IzabraniStadion = new Stadion();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovani stadion, postoje mecevi koji su vezani za njega!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            StadionDodajView newWindow = new StadionDodajView();
            newWindow.DataContext = new StadionDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Stadioni = new ObservableCollection<Stadion>();

            foreach (Stadion item in gdao.GetList())
            {
                Stadioni.Add(item);
            }
        }
    }
}
