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
    public class OdrzavanjeDodajViewModel : BindableBase
    {
        private OdrzavanjeDodajView view;
        private OdrzavanjeValidacija validacija;
        private List<string> spisakTurnira;
        private string izabraniTurnir;
        private string izabraniTurnirGreska;
        //private bool daLiJeIzmena;
        private bool daLiJeEdit = false;

        private TurnirDAO tdao = new TurnirDAO();


        public List<string> SpisakTurnira { get => spisakTurnira; set { spisakTurnira = value; OnPropertyChanged("SpisakTurnira"); } }
        public string IzabraniTurnir { get => izabraniTurnir; set { izabraniTurnir = value; OnPropertyChanged("izabraniTurnir"); } }
        public string IzabraniTurnirGreska { get => izabraniTurnirGreska; set { izabraniTurnirGreska = value; OnPropertyChanged("IzabraniTurnirGreska"); } }



        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public OdrzavanjeValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public OdrzavanjeDodajViewModel(OdrzavanjeDodajView view)
        {
            this.view = view;
            Validacija = new OdrzavanjeValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajOdrzavanje, this.CanAddOdrzavanje);
            UcitajTurnire();
            IzabraniTurnir = "";

        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanAddOdrzavanje()
        {
            return true;
        }


        public void DodajOdrzavanje()
        {
             Validacija.Validate();

            if (izabraniTurnir == "")
            {
                izabraniTurnirGreska = "Morate izabrati turnir!";
            }
            else
            {
                izabraniTurnirGreska = "";
            }

            if (Validacija.IsValid && IzabraniTurnir != "")
            {
                OdrediTurnir();
                OdrzavanjeDAO o = new OdrzavanjeDAO();

                if (daLiJeEdit)
                {
                    o.Update(Validacija.Odrzavanje);
                }
                else
                {
                    o.Insert(Validacija.Odrzavanje);
                }

                view.Close();
            }
        }

        public void UcitajTurnire()
        {
            SpisakTurnira = new List<string>();

            foreach (Turnir item in tdao.GetList())
            {
                spisakTurnira.Add("ID:" + item.idtur.ToString() + " - Naziv:" + item.naztur);

                /*if (DaLiJeIzmena)
                {
                    if (item.idkat == Validacija.Turnir.OdeljenjeOdeljenjeId)
                        IzabranaKategorija = "ID:" + item.idkat.ToString() + " - Naziv:" + item.nazkat;
                }*/
            }
        }


        public void OdrediTurnir()
        {
            string[] niz = IzabraniTurnir.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.Odrzavanje.Turnir_idtur = broj;
        }




    }
}
