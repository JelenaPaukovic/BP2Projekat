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
    public class TurnirIzmeniViewModel : BindableBase
    {
        public TurnirIzmeniViewModel(TurnirIzmeniView view, Turnir Turnir)
        {

            this.view = view;
            Validacija = new TurnirValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniTurnir);
            validacija.Turnir = Turnir;
            UcitajKategorije();
            IzabranaKategorija = "";

        }
        private TurnirIzmeniView view;
        private TurnirValidacija validacija;
        private List<string> spisakKategorija;
        private string izabranaKategorija;
        private string izabranaKategorijaGreska;
        //private bool daLiJeIzmena;
        private bool daLiJeEdit = false;

        private KategorijaDAO kdao = new KategorijaDAO();

        public List<string> SpisakKategorija { get => spisakKategorija; set { spisakKategorija = value; OnPropertyChanged("SpisakKategorija"); } }
        public string IzabranaKategorija { get => izabranaKategorija; set { izabranaKategorija = value; OnPropertyChanged("IzabranaKategorija"); } }
        public string IzabranaKategorijaGreska { get => izabranaKategorijaGreska; set { izabranaKategorijaGreska = value; OnPropertyChanged("IzabranaKategorijaGreska"); } }




        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public TurnirValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }




        public void Exit()
        {
            view.Close();
        }

        public void IzmeniTurnir()
        {
            /*Validacija.Validate();
            if (Validacija.IsValid)
           {
               TurnirDAO tdao = new TurnirDAO();






               tdao.Update(Validacija.Turnir);


               view.Close();
           }*/

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

                //if (daLiJeEdit)
                {
                    t.Update(Validacija.Turnir);
                }
                

                view.Close();
            }
        }


        public void UcitajKategorije()
        {
            SpisakKategorija = new List<string>();

            foreach (Kategorija item in kdao.GetList())
            {
                spisakKategorija.Add("ID:" + item.idkat.ToString() + " - Naziv:" + item.nazkat);

                
                
                    if (item.idkat == Validacija.Turnir.Kategorija_idkat)
                        IzabranaKategorija = "ID:" + item.idkat.ToString() + " - Naziv:" + item.nazkat;
                
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
