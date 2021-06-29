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
    public class OrganizatorViewModel : BindableBase
    {
        private OrganizatorView view;
        private ObservableCollection<Organizator> organizatori;
        private Organizator izabraniOrganizator;
        private OrganizatorDAO gdao = new OrganizatorDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Organizator> Organizatori { get => organizatori; set { organizatori = value; OnPropertyChanged("Organizatori"); } }
        public Organizator IzabraniOrganizator { get => izabraniOrganizator; set { izabraniOrganizator = value; OnPropertyChanged("IzabraniOrganizator"); } }



        public OrganizatorViewModel(OrganizatorView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniOrganizator = new Organizator();
            Organizatori = new ObservableCollection<Organizator>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniOrganizator != null)
            {
                return IzabraniOrganizator.idor != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            OrganizatorIzmeniView newWindow = new OrganizatorIzmeniView();
            newWindow.DataContext = new OrganizatorIzmeniViewModel(newWindow, IzabraniOrganizator);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniOrganizator = new Organizator();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabraniOrganizator.idor))
            {

                gdao.Delete(IzabraniOrganizator.idor);
                Ucitaj();
                IzabraniOrganizator = new Organizator();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanog organizatora, postoje turniri koji su vezani za njega!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            OrganizatorDodajView newWindow = new OrganizatorDodajView();
            newWindow.DataContext = new OrganizatorDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Organizatori = new ObservableCollection<Organizator>();

            foreach (Organizator item in gdao.GetList())
            {
                Organizatori.Add(item);
            }
        }
    }
}
