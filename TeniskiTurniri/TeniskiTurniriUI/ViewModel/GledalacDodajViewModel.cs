using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri.dao;
using TeniskiTurniriUI.View;
using System.Windows.Input;
using TeniskiTurniri;
using TeniskiTurniriUI.Model;

namespace TeniskiTurniriUI.ViewModel
{
    public class GledalacDodajViewModel : BindableBase
    {

        private GledalacDodajView view;
        private GledalacValidacija validacija;
        private List<ElementCheckBox> sviTurniri;
        private string turnirIzabranGreska;
        private GledalacDAO gdao = new GledalacDAO();
        private TurnirDAO tdao = new TurnirDAO();

        public List<ElementCheckBox> SviTurniri { get => sviTurniri; set { sviTurniri = value; OnPropertyChanged("SviTurniri"); } }

        public string TurnirIzabranGreska { get => turnirIzabranGreska; set { turnirIzabranGreska = value; OnPropertyChanged("TurnirIzabranGreska"); } }

        //public GledalacValidacija Validacija { get => validacija; set => validacija = value; }

        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public GledalacValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public GledalacDodajViewModel(GledalacDodajView view)
        {
            this.view = view;
            Validacija = new GledalacValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajGledaoca);
            SviTurniri = new List<ElementCheckBox>();
            UcitajTurnire();


        }


        public GledalacDodajViewModel(GledalacDodajView view, Gledalac g)
        {
            this.view = view;
            Validacija = new GledalacValidacija();
            Validacija.Gledalac = g;

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajGledaoca, this.CanAddGledaoca);
            SviTurniri = new List<ElementCheckBox>();
            UcitajTurnire();
        }



        public void Exit()
        {
            view.Close();
        }

        public bool CanAddGledaoca()
        {
            return true;
        }

        public void DodajGledaoca()
        {
            Validacija.Validate();
            if (Validacija.IsValid)
            {
                GledalacDAO Gdao = new GledalacDAO();


                List<long> turniri = new List<long>();

                foreach (var item in SviTurniri)
                {
                    if (item.IsSelected)
                    {
                        Turnir t = new Turnir();
                        turniri.Add(item.Id);
                    }
                }



                gdao.Insert(Validacija.Gledalac, turniri);


                view.Close();
            }
        }



        public void UcitajTurnire()
        {
            foreach (Turnir item in tdao.GetList())
            {
                string str = "id: " + item.idtur + " " + item.naztur;
                ElementCheckBox el = new ElementCheckBox(item.idtur, str, false);
                SviTurniri.Add(el);

                
            }

        }

        public List<int> odrediTurnire()
        {
            List<int> lista = new List<int>();

            foreach (var item in SviTurniri)
            {
                if (item.IsSelected)
                {
                    lista.Add((int)item.Id);
                }
            }

            return lista;
        }

        public bool DaLiJeIzabrano()
        {
            bool izabranoTur = false;
            

            foreach (var item in SviTurniri)
            {
                if (item.IsSelected)
                {
                    izabranoTur = true;
                    break;
                }
            }

            

            if (!izabranoTur)
            {
                TurnirIzabranGreska = "Morate odabrati bar jedan turnir!";
            }
            else
            {
                TurnirIzabranGreska = "";
            }





            return izabranoTur;
        }


    }
}
