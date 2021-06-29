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
    public class KoloViewModel : BindableBase
    {
        private KoloView view;
        private ObservableCollection<Kolo> kola;
        private Kolo izabranoKolo;
        private KoloDAO gdao = new KoloDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Kolo> Kola { get => kola; set { kola = value; OnPropertyChanged("Kola"); } }
        public Kolo IzabranoKolo { get => izabranoKolo; set { izabranoKolo = value; OnPropertyChanged("IzabranoKolo"); } }



        public KoloViewModel(KoloView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabranoKolo = new Kolo();
            Kola = new ObservableCollection<Kolo>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabranoKolo != null)
            {
                return IzabranoKolo.idk != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {
            KoloIzmeniView newWindow = new KoloIzmeniView();
            newWindow.DataContext = new KoloIzmeniViewModel(newWindow, IzabranoKolo);
            newWindow.ShowDialog();
            Ucitaj();
            IzabranoKolo = new Kolo();
        }

        public void Remove()
        {
            if (gdao.DaLiMozeDaSeObrise(IzabranoKolo.idk))
            {

                gdao.Delete(IzabranoKolo.idk);
                Ucitaj();
                IzabranoKolo = new Kolo();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovano kolo, postoje mecevi koji su vezani za njega!");
            }

        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            KoloDodajView newWindow = new KoloDodajView();
            newWindow.DataContext = new KoloDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Kola = new ObservableCollection<Kolo>();

            foreach (Kolo item in gdao.GetList())
            {
                Kola.Add(item);
            }
        }
    }
}
