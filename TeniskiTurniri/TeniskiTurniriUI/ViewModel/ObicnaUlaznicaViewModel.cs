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
    public class ObicnaUlaznicaViewModel : BindableBase
    {
        private ObicnaUlaznicaView view;
        private ObservableCollection<ObicnaUlaznica> ulaznice;
        private ObicnaUlaznica izabraniUlaznica;
        private ObicnaUlaznicaDAO gdao = new ObicnaUlaznicaDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<ObicnaUlaznica> Ulaznice { get => ulaznice; set { ulaznice = value; OnPropertyChanged("Gledaoci"); } }
        public ObicnaUlaznica IzabraniUlaznica { get => izabraniUlaznica; set { izabraniUlaznica = value; OnPropertyChanged("IzabraniObicnaUlaznica"); } }



        public ObicnaUlaznicaViewModel(ObicnaUlaznicaView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniUlaznica = new ObicnaUlaznica();
            Ulaznice = new ObservableCollection<ObicnaUlaznica>();

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
                return IzabraniUlaznica.idou != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            ObicnaUlaznicaIzmeniView newWindow = new ObicnaUlaznicaIzmeniView();
            newWindow.DataContext = new ObicnaUlaznicaIzmeniViewModel(newWindow, IzabraniUlaznica);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniUlaznica = new ObicnaUlaznica();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniUlaznica.idou))
            {

                gdao.Delete(IzabraniUlaznica.idou);
                Ucitaj();
                IzabraniUlaznica = new ObicnaUlaznica();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanu ulaznicu, postoje druge ulaznice koje su vezane za nju!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            ObicnaUlaznicaDodajView newWindow = new ObicnaUlaznicaDodajView();
            newWindow.DataContext = new ObicnaUlaznicaDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Ulaznice = new ObservableCollection<ObicnaUlaznica>();

            foreach (ObicnaUlaznica item in gdao.GetList())
            {
                Ulaznice.Add(item);
            }
        }
    }
}
