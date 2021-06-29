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
    public class KategorijaViewModel : BindableBase
    {
        private KategorijaView view;
        private ObservableCollection<Kategorija> kategorije;
        private Kategorija izabraniKategorija;
        private KategorijaDAO gdao = new KategorijaDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Kategorija> Kategorije { get => kategorije; set { kategorije = value; OnPropertyChanged("Kategorije"); } }
        public Kategorija IzabraniKategorija { get => izabraniKategorija; set { izabraniKategorija = value; OnPropertyChanged("IzabraniKategorija"); } }



        public KategorijaViewModel(KategorijaView view)
        {
            this.view = view;

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.Edit, CanEditRemove);
            RemoveCommand = new MyICommand(this.Remove, CanEditRemove);
            AddCommand = new MyICommand(this.Add, CanAdd);

            IzabraniKategorija = new Kategorija();
            Kategorije = new ObservableCollection<Kategorija>();

            Ucitaj();

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanEditRemove()
        {
            if (IzabraniKategorija != null)
            {
                return IzabraniKategorija.idkat != 0;
            }
            else
            {
                return false;
            }

        }

        public void Edit()
        {

            KategorijaIzmeniView newWindow = new KategorijaIzmeniView();

            IzabraniKategorija = Kategorije.Where(k => k.idkat == IzabraniKategorija.idkat).FirstOrDefault();
            newWindow.DataContext = new KategorijaIzmeniViewModel(newWindow, IzabraniKategorija);
            newWindow.ShowDialog();
            Ucitaj();
            IzabraniKategorija = new Kategorija();
        }

        public void Remove()
        {

            if (gdao.DaLiMozeDaSeObrise(IzabraniKategorija.idkat))
            {
                gdao.Delete(IzabraniKategorija.idkat);
                Ucitaj();
                IzabraniKategorija = new Kategorija();
            }
            else
            {
                MessageBox.Show("Ne mozete da obrisite selektovanu kategoriju, postoje turniri koji su vezani za nju!");
            }


        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            KategorijaDodajView newWindow = new KategorijaDodajView();
            newWindow.DataContext = new KategorijaDodajViewModel(newWindow);
            newWindow.ShowDialog();
            Ucitaj();
        }

        public void Ucitaj()
        {
            Kategorije = new ObservableCollection<Kategorija>();

            foreach (Kategorija item in gdao.GetList())
            {
                Kategorije.Add(item);
            }
        }
    }
}

