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
    public class GledalacIzmeniViewModel : BindableBase
    {
        public GledalacIzmeniViewModel(GledalacIzmeniView view, Gledalac gledalac)
        {

            this.view = view;
            Validacija = new GledalacValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniGledaoca);
            //AddCommand = new MyICommand(this.IzmeniGledaoca);
            SviTurniri = new List<ElementCheckBox>();

            Validacija.Gledalac = gledalac;
            UcitajTurnire();

        }
        private GledalacIzmeniView view;
        private GledalacValidacija validacija;
        private GledalacDAO gdao = new GledalacDAO();
        private TurnirDAO tdao = new TurnirDAO();

        private List<ElementCheckBox> sviTurniri;
        private string turnirIzabranGreska;
        public List<ElementCheckBox> SviTurniri { get => sviTurniri; set { sviTurniri = value; OnPropertyChanged("SviTurniri"); } }

        public string TurnirIzabranGreska { get => turnirIzabranGreska; set { turnirIzabranGreska = value; OnPropertyChanged("TurnirIzabranGreska"); } }



        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public GledalacValidacija Validacija
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

        public void IzmeniGledaoca()
        {
            Validacija.Validate();
            if (Validacija.IsValid)
            {
                GledalacDAO gdao = new GledalacDAO();




                DaLiJeIzabrano();

                gdao.Update(Validacija.Gledalac);


                view.Close();
            }
        }




        public bool CanAddGledaoca()
        {
            return true;
        }


        public void UcitajTurnire()
        {
            foreach (Turnir item in tdao.GetList())
            {
                string str = "id: " + item.idtur + " " + item.naztur;
                ElementCheckBox el = new ElementCheckBox(item.idtur, str, false);
                SviTurniri.Add(el);


                foreach (Turnir t in Validacija.Gledalac.Turnir)
                {
                    if (item.idtur == t.idtur)
                    {
                        el.IsSelected = true;
                    }
                }

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
