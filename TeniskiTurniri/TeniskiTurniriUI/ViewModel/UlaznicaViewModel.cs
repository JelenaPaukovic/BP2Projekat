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
    public class UlaznicaViewModel : BindableBase
    {
        private UlaznicaView view;
        private ObservableCollection<Ulaznica> ulaznice;
        private Ulaznica izabraniUlaznica;
        private UlaznicaDAO udao = new UlaznicaDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Ulaznica> Ulaznice { get => ulaznice; set { ulaznice = value; OnPropertyChanged("Ulaznice"); } }
        public Ulaznica IzabraniUlaznica { get => izabraniUlaznica; set { izabraniUlaznica = value; OnPropertyChanged("IzabraniUlaznica"); } }



        public UlaznicaViewModel(UlaznicaView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniUlaznica = new Ulaznica();
            Ulaznice = new ObservableCollection<Ulaznica>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniUlaznica != null)
            {
                return IzabraniUlaznica.idu != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            UlaznicaIzmeniView newWindow = new UlaznicaIzmeniView();
            newWindow.DataContext = new UlaznicaIzmeniViewModel(newWindow, IzabraniUlaznica);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniUlaznica = new Ulaznica();
        }

        public void Remove()
        {
            if (udao.DaLiMozeDaSeObrise(IzabraniUlaznica.idu))
            {

                udao.Delete(IzabraniUlaznica.idu);
                Ucitaj();
                IzabraniUlaznica = new Ulaznica();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanu ulaznicu, postoje turniri koji su vezani za nju!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            UlaznicaDodajView newWindow = new UlaznicaDodajView();
            newWindow.DataContext = new UlaznicaDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Ulaznice = new ObservableCollection<Ulaznica>();

            foreach (Ulaznica item in udao.GetList())
            {
                Ulaznice.Add(item);
            }
        }
    }
}
