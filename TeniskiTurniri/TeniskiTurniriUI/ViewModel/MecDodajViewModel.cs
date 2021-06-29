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
    public class MecDodajViewModel : BindableBase
    {
        private MecDodajView view;
        private MecValidacija validacija;
        private List<string> spisakStadiona;
        private string izabraniStadion;
        private string izabraniStadionGreska;
        //private bool daLiJeIzmena;
        private bool daLiJeEdit = false;
        private StadionDAO sdao = new StadionDAO();
        private KoloDAO kdao = new KoloDAO();
        private List<string> spisakKola;
        private string izabranoKolo;
        private string izabranoKoloGreska;


        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public MecValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public List<string> SpisakStadiona { get => spisakStadiona; set { spisakStadiona = value; OnPropertyChanged("SpisakStadiona"); } }
        public string IzabraniStadion { get => izabraniStadion; set { izabraniStadion = value; OnPropertyChanged("IzabraniStadion"); } }
        public string IzabraniStadionGreska { get => izabraniStadionGreska; set { izabraniStadionGreska = value; OnPropertyChanged("IzabraniStadionGreska"); } }

        public List<string> SpisakKola { get => spisakKola; set { spisakKola = value; OnPropertyChanged("SpisakKola"); } }
        public string IzabranoKolo { get => izabranoKolo; set { izabranoKolo = value; OnPropertyChanged("IzabranoKolo"); } }
        public string IzabranoKoloGreska { get => izabranoKoloGreska; set { izabranoKoloGreska = value; OnPropertyChanged("IzabranoKoloGreska"); } }
        public MecDodajViewModel(MecDodajView view)
        {
            this.view = view;
            Validacija = new MecValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajMec, this.CanAddMec);
            UcitajStadione();
            UcitajKola();
            IzabraniStadion = "";
            IzabranoKolo = "";


        }

        public bool CanAddMec()
        {
            return true;
        }

        public void Exit()
        {
            view.Close();
        }

        public void DodajMec()
        {
            Validacija.Validate();

            if (IzabraniStadion == "")
            {
                IzabraniStadionGreska = "Morate izabrati stadion!";
            }
            else
            {
                IzabraniStadionGreska = "";
            }

            if (IzabranoKolo == "")
            {
                IzabranoKoloGreska = "Morate izabrati kolo!";
            }
            else
            {
                IzabranoKoloGreska = "";
            }


             if (Validacija.IsValid && IzabraniStadion != "" && IzabranoKolo != "")  /// ???
            //if (Validacija.IsValid && IzabraniStadion != "")  //???
            {
                OdrediStadion();
                OdrediKolo();
                MecDAO m = new MecDAO();

                if (daLiJeEdit)
                {
                    m.Update(Validacija.Mec);
                }
                else
                {
                    Validacija.Mec.stdm = "Stadion";
                    m.Insert(Validacija.Mec);
                }

                view.Close();
            }
        }



        public void UcitajStadione()
        {
            SpisakStadiona = new List<string>();

            foreach (Stadion item in sdao.GetList())
            {
                spisakStadiona.Add("ID:" + item.idst.ToString() + " - Naziv:" + item.nazst);

                /*if (DaLiJeIzmena)
                {
                    if (item.idkat == Validacija.Turnir.OdeljenjeOdeljenjeId)
                        IzabranaKategorija = "ID:" + item.idkat.ToString() + " - Naziv:" + item.nazkat;
                }*/
            }
        }

        public void UcitajKola()
        {
            SpisakKola = new List<string>();

            foreach (Kolo item in kdao.GetList())
            {
                spisakKola.Add("ID:" + item.idk);

                /*if (DaLiJeIzmena)
                {
                    if (item.idkat == Validacija.Turnir.OdeljenjeOdeljenjeId)
                        IzabranaKategorija = "ID:" + item.idkat.ToString() + " - Naziv:" + item.nazkat;
                }*/
            }
        }


        public void OdrediStadion()
        {
            string[] niz = IzabraniStadion.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.Mec.Stadion_idst = broj;
        }

        public void OdrediKolo()
        {
            string[] niz = IzabranoKolo.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.Mec.Kolo_idk = broj;
        }



    }
}
