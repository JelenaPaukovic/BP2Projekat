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
    public class OrganizatorDodajViewModel : BindableBase
    {
        private OrganizatorDodajView view;
        private OrganizatorValidacija validacija;
        private List<ElementCheckBox> sviTurniri;
        private string turnirIzabranGreska;
        private OrganizatorDAO odao = new OrganizatorDAO();
        private TurnirDAO tdao = new TurnirDAO();

        public List<ElementCheckBox> SviTurniri { get => sviTurniri; set { sviTurniri = value; OnPropertyChanged("SviTurniri"); } }

        public string TurnirIzabranGreska { get => turnirIzabranGreska; set { turnirIzabranGreska = value; OnPropertyChanged("TurnirIzabranGreska"); } }


        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public OrganizatorValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public OrganizatorDodajViewModel(OrganizatorDodajView view)
        {
            this.view = view;
            Validacija = new OrganizatorValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajOrganizatora);
            SviTurniri = new List<ElementCheckBox>();
            UcitajTurnire();

        }

        public OrganizatorDodajViewModel(OrganizatorDodajView view, Organizator o)
        {
            this.view = view;
            Validacija = new OrganizatorValidacija();
            Validacija.Organizator = o;

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajOrganizatora, this.CanAddOrganizatora);
            SviTurniri = new List<ElementCheckBox>();
            UcitajTurnire();
        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanAddOrganizatora()
        {
            return true;
        }

        public void DodajOrganizatora()
        {
             Validacija.Validate();
            if (Validacija.IsValid)
            {
                OrganizatorDAO odao = new OrganizatorDAO();


                List<long> turniri = new List<long>();

                foreach (var item in SviTurniri)
                {
                    if (item.IsSelected)
                    {
                        Turnir t = new Turnir();
                        turniri.Add(item.Id);
                    }
                }



                odao.Insert(Validacija.Organizator, turniri);


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
