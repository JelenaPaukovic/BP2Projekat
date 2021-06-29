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
    public class NagradaViewModel : BindableBase
    {
        private NagradaView view;
        private ObservableCollection<Nagrada> nagrade;
        private Nagrada izabraniNagrada;
        private NagradaDAO gdao = new NagradaDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Nagrada> Nagrade { get => nagrade; set { nagrade = value; OnPropertyChanged("Nagrade"); } }
        public Nagrada IzabraniNagrada { get => izabraniNagrada; set { izabraniNagrada = value; OnPropertyChanged("IzabraniNagrada"); } }



        public NagradaViewModel(NagradaView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniNagrada = new Nagrada();
            Nagrade = new ObservableCollection<Nagrada>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniNagrada != null)
            {
                return IzabraniNagrada.idn != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            NagradaIzmeniView newWindow = new NagradaIzmeniView();
            newWindow.DataContext = new NagradaIzmeniViewModel(newWindow, IzabraniNagrada);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniNagrada = new Nagrada();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniNagrada.idn))
            {

                gdao.Delete(IzabraniNagrada.idn);
                Ucitaj();
                IzabraniNagrada = new Nagrada();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanog pisca, postoje recenzije koje su vezane za njega!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            NagradaDodajView newWindow = new NagradaDodajView();
            newWindow.DataContext = new NagradaDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Nagrade = new ObservableCollection<Nagrada>();

            foreach (Nagrada item in gdao.GetList())
            {
                Nagrade.Add(item);
            }
        }
    }
}
