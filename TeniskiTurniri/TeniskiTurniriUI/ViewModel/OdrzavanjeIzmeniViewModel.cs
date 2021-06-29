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
    public class OdrzavanjeIzmeniViewModel : BindableBase
    {
        public OdrzavanjeIzmeniViewModel(OdrzavanjeIzmeniView view, Odrzavanje Odrzavanje)
        {

            this.view = view;
            Validacija = new OdrzavanjeValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniOdrzavanje);
            validacija.Odrzavanje = Odrzavanje;
            UcitajTurnire();
            IzabraniTurnir = "";


        }
        private OdrzavanjeIzmeniView view;
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
        public ICommand EditCommand { get; set; }

        public OdrzavanjeValidacija Validacija
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

        public void IzmeniOdrzavanje()
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
                OdrzavanjeDAO odao = new OdrzavanjeDAO();






                odao.Update(Validacija.Odrzavanje);


                view.Close();
            }
        }


        public void UcitajTurnire()
        {
            SpisakTurnira = new List<string>();

            foreach (Turnir item in tdao.GetList())
            {
                spisakTurnira.Add("ID:" + item.idtur.ToString() + " - Naziv:" + item.naztur);

                
                    if (item.idtur == Validacija.Odrzavanje.Turnir_idtur)
                        IzabraniTurnir = "ID:" + item.idtur.ToString() + " - Naziv:" + item.naztur;
                
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
