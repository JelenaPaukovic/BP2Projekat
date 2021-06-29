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
    public class VipUlaznicaViewModel : BindableBase
    {
        private VipUlaznicaView view;
        private ObservableCollection<VipUlaznica> ulaznice;
        private VipUlaznica izabraniUlaznica;
        private VipUlaznicaDAO gdao = new VipUlaznicaDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<VipUlaznica> Ulaznice { get => ulaznice; set { ulaznice = value; OnPropertyChanged("Gledaoci"); } }
        public VipUlaznica IzabraniUlaznica { get => izabraniUlaznica; set { izabraniUlaznica = value; OnPropertyChanged("IzabraniVipUlaznica"); } }



        public VipUlaznicaViewModel(VipUlaznicaView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniUlaznica = new VipUlaznica();
            Ulaznice = new ObservableCollection<VipUlaznica>();

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
                return IzabraniUlaznica.idvu != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            VipUlaznicaIzmeniView newWindow = new VipUlaznicaIzmeniView();
            newWindow.DataContext = new VipUlaznicaIzmeniViewModel(newWindow, IzabraniUlaznica);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniUlaznica = new VipUlaznica();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniUlaznica.idvu))
            {

                gdao.Delete(IzabraniUlaznica.idvu);
                Ucitaj();
                IzabraniUlaznica = new VipUlaznica();
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
            VipUlaznicaDodajView newWindow = new VipUlaznicaDodajView();
            newWindow.DataContext = new VipUlaznicaDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Ulaznice = new ObservableCollection<VipUlaznica>();

            foreach (VipUlaznica item in gdao.GetList())
            {
                Ulaznice.Add(item);
            }
        }
    }
}
