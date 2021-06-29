﻿using System;
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
    public class KoloIzmeniViewModel : BindableBase
    {

        public KoloIzmeniViewModel(KoloIzmeniView view, Kolo kolo)
        {

            this.view = view;
            Validacija = new KoloValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniKolo);
            validacija.Kolo = kolo;
            //UcitajTurnire();
            UcitajOdrzavanja();
            IzabraniTurnir = "";
            IzabranoOdrzavanje = "";

        }
        private KoloIzmeniView view;
        private KoloValidacija validacija;


        private List<string> spisakTurnira;
        private string izabraniTurnir;
        private string izabraniTurnirGreska;
        //private bool daLiJeIzmena;
        private bool daLiJeEdit = false;

        private TurnirDAO tdao = new TurnirDAO();
        private OdrzavanjeDAO odao = new OdrzavanjeDAO();
        private string izabranoOdrzavanje;
        private string izabranoOdrzavanjeGreska;
        private List<string> spisakOdrzavanja;


        public List<string> SpisakTurnira { get => spisakTurnira; set { spisakTurnira = value; OnPropertyChanged("SpisakTurnira"); } }
        public string IzabraniTurnir { get => izabraniTurnir; set { izabraniTurnir = value; OnPropertyChanged("izabraniTurnir"); } }
        public string IzabraniTurnirGreska { get => izabraniTurnirGreska; set { izabraniTurnirGreska = value; OnPropertyChanged("IzabraniTurnirGreska"); } }

        public List<string> SpisakOdrzavanja { get => spisakOdrzavanja; set { spisakOdrzavanja = value; OnPropertyChanged("SpisakOdrzavanja"); } }
        public string IzabranoOdrzavanje { get => izabranoOdrzavanje; set { izabranoOdrzavanje = value; OnPropertyChanged("IzabranoOdrzavanje"); } }
        public string IzabranoOdrzavanjeGreska { get => IzabranoOdrzavanjeGreska; set { izabranoOdrzavanjeGreska = value; OnPropertyChanged("IzabranoOdrzavanje"); } }



        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public KoloValidacija Validacija
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

        public void IzmeniKolo()
        {
            Validacija.Validate();

           /* if (izabraniTurnir == "")
            {
                izabraniTurnirGreska = "Morate izabrati turnir!";
            }
            else
            {
                izabraniTurnirGreska = "";
            }*/

            if (izabranoOdrzavanje == "")
            {
                izabranoOdrzavanjeGreska = "Morate izabrati odrzavanje!";
            }
            else
            {
                izabranoOdrzavanjeGreska = "";
            }
            if (Validacija.IsValid)
            {
                KoloDAO kdao = new KoloDAO();






                kdao.Update(Validacija.Kolo);


                view.Close();
            }
        }



        /*public void UcitajTurnire()
        {
            SpisakTurnira = new List<string>();

            foreach (Turnir item in tdao.GetList())
            {
                spisakTurnira.Add("ID:" + item.idtur.ToString() + " - Naziv:" + item.naztur);


                if (item.idtur == Validacija.Kolo.OdrzavanjeTurnir_idtur)  //???
                    IzabraniTurnir = "ID:" + item.idtur.ToString() + " - Naziv:" + item.naztur;
            }
        }*/



        public void UcitajOdrzavanja()
        {
            SpisakOdrzavanja = new List<string>();

            foreach (Odrzavanje item in odao.GetList())
            {
                spisakOdrzavanja.Add("ID:" + item.idod.ToString());


                if (item.idod == Validacija.Kolo.Odrzavanje_idod)
                    IzabranoOdrzavanje = "ID:" + item.idod.ToString();
                
            }
        }


        /*public void OdrediTurnir()
        {
            string[] niz = IzabraniTurnir.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.Kolo.OdrzavanjeTurnir_idtur = broj;
        }*/

        public void OdrediOdrzavanje()
        {
            string[] niz = IzabranoOdrzavanje.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.Kolo.Odrzavanje_idod = broj;
        }

    }


}
