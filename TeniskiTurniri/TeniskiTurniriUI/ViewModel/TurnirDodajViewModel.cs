using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeniskiTurniri;
using TeniskiTurniri.dao;
using TeniskiTurniriUI.Model;
using TeniskiTurniriUI.View;

namespace TeniskiTurniriUI.ViewModel
{
    public class TurnirDodajViewModel : BindableBase
    {
        private TurnirDodajView view;
        private TurnirValidacija validacija;
        private List<string> spisakKategorija;
        private string izabranaKategorija;
        private string izabranaKategorijaGreska;
        //private bool daLiJeIzmena;
        private bool daLiJeEdit = false;

        private KategorijaDAO kdao = new KategorijaDAO();

        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public TurnirValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }

        public List<string> SpisakKategorija { get => spisakKategorija; set { spisakKategorija = value; OnPropertyChanged("SpisakKategorija"); } }
        public string IzabranaKategorija { get => izabranaKategorija; set { izabranaKategorija = value; OnPropertyChanged("IzabranaKategorija"); } }
        public string IzabranaKategorijaGreska { get => izabranaKategorijaGreska; set { izabranaKategorijaGreska = value; OnPropertyChanged("IzabranaKategorijaGreska"); } }

       // public bool DaLiJeIzmena { get => daLiJeIzmena; set { daLiJeIzmena = value; OnPropertyChanged("DaLiJeIzmena"); } }

        public TurnirDodajViewModel(TurnirDodajView view)
        {
            this.view = view;
            Validacija = new TurnirValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajTurnir, this.CanAddTurnir);
            UcitajKategorije();
            IzabranaKategorija = "";
            //DaLiJeIzmena = false;


        }

        public bool CanAddTurnir()
        {
            return true;
        }


        public void Exit()
        {
            view.Close();
        }


        public void DodajTurnir()
        {
            Validacija.Validate();

            if (izabranaKategorija == "")
            {
                izabranaKategorijaGreska = "Morate izabrati kategoriju!";
            }
            else
            {
                izabranaKategorijaGreska = "";
            }

            if (Validacija.IsValid && IzabranaKategorija != "")
            {
                OdrediKategoriju();
                TurnirDAO t = new TurnirDAO();

                if (daLiJeEdit)
                {
                    t.Update(Validacija.Turnir);
                }
                else
                {
                    t.Insert(Validacija.Turnir);
                }

                view.Close();
            }
        }




       /* public TurnirDodajViewModel(TurnirDodajView view, Turnir t)
        {
            daLiJeEdit = true;
            //DaLiJeIzmena = true;
            this.view = view;
            Validacija = new TurnirValidacija();
            Validacija.Validacija = t;

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajTurnir, this.CanAddTurnir);
            UcitajKategorije();

        }*/

        public void UcitajKategorije()
        {
            SpisakKategorija = new List<string>();

            foreach (Kategorija item in kdao.GetList())
            {
                spisakKategorija.Add("ID:" + item.idkat.ToString() + " - Naziv:" + item.nazkat);

                /*if (DaLiJeIzmena)
                {
                    if (item.idkat == Validacija.Turnir.OdeljenjeOdeljenjeId)
                        IzabranaKategorija = "ID:" + item.idkat.ToString() + " - Naziv:" + item.nazkat;
                }*/
            }
        }

        public void OdrediKategoriju()
        {
            string[] niz = IzabranaKategorija.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.Turnir.Kategorija_idkat = broj;
        }
    }
}
