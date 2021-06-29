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
    public class MecViewModel : BindableBase
    {
        private MecView view;
        private ObservableCollection<Mec> mecevi;
        private Mec izabraniMec;
        private MecDAO gdao = new MecDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Mec> Mecevi { get => mecevi; set { mecevi = value; OnPropertyChanged("Mecevi"); } }
        public Mec IzabraniMec { get => izabraniMec; set { izabraniMec = value; OnPropertyChanged("IzabraniMec"); } }



        public MecViewModel(MecView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniMec = new Mec();
            Mecevi = new ObservableCollection<Mec>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniMec != null)
            {
                return IzabraniMec.idm != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            MecIzmeniView newWindow = new MecIzmeniView();
            newWindow.DataContext = new MecIzmeniViewModel(newWindow, IzabraniMec);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniMec = new Mec();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniMec.idm))
            {

                gdao.Delete(IzabraniMec.idm);
                Ucitaj();
                IzabraniMec = new Mec();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovani mec, postoji kolo koje je vezano za njega!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            MecDodajView newWindow = new MecDodajView();
            newWindow.DataContext = new MecDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Mecevi = new ObservableCollection<Mec>();

            foreach (Mec item in gdao.GetList())
            {
                Mecevi.Add(item);
            }
        }
    }
}
