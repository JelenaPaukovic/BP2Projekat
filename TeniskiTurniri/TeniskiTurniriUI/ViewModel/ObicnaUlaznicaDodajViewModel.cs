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
    public class ObicnaUlaznicaDodajViewModel : BindableBase
    {
        
        private ObicnaUlaznicaDodajView view;
        private ObicnaUlaznicaValidacija validacija;
        private List<string> spisakUlaznica;
        private string izabranaUlaznica;
        private string izabranaUlaznicaGreska;
        private bool daLiJeEdit = false;
        private UlaznicaDAO udao = new UlaznicaDAO();

        public List<string> SpisakUlaznica { get => spisakUlaznica; set { spisakUlaznica = value; OnPropertyChanged("SpisakUlaznica"); } }
        public string IzabranaUlaznica { get => izabranaUlaznica; set { izabranaUlaznica = value; OnPropertyChanged("IzabranaUlaznica"); } }
        public string IzabranaUlaznicaGreska { get => izabranaUlaznicaGreska; set { izabranaUlaznicaGreska = value; OnPropertyChanged("IzabranaUlaznicaGreska"); } }



        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public ObicnaUlaznicaValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public ObicnaUlaznicaDodajViewModel(ObicnaUlaznicaDodajView view)
        {
            this.view = view;
            Validacija = new ObicnaUlaznicaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajObicnuUlaznicu, this.CanAddUlaznicu);
            UcitajUlaznice();
            IzabranaUlaznica = "";

        }

        public bool CanAddUlaznicu()
        {
            return true;
        }

        public void Exit()
        {
            view.Close();
        }

        public void DodajObicnuUlaznicu()
        {
             Validacija.Validate();
            if (izabranaUlaznica == "")
            {
                izabranaUlaznicaGreska = "Morate izabrati ulaznicu!";
            }
            else
            {
                izabranaUlaznicaGreska = "";
            }

            if (Validacija.IsValid && IzabranaUlaznica != "")
            {
                OdrediUlaznicu();
                ObicnaUlaznicaDAO u = new ObicnaUlaznicaDAO();

                if (daLiJeEdit)
                {
                    u.Update(Validacija.ObicnaUlaznica);
                }
                else
                {
                    u.Insert(Validacija.ObicnaUlaznica);
                }

                view.Close();
            }
        }


        public void UcitajUlaznice()
        {
            SpisakUlaznica = new List<string>();

            foreach (Ulaznica item in udao.GetList())
            {
                spisakUlaznica.Add("ID:" + item.idu.ToString() + " - Tip ulaznice:" + item.tipu);

                /*if (DaLiJeIzmena)
                {
                    if (item.idkat == Validacija.Turnir.OdeljenjeOdeljenjeId)
                        IzabranaKategorija = "ID:" + item.idkat.ToString() + " - Naziv:" + item.nazkat;
                }*/
            }
        }

        public void OdrediUlaznicu()
        {
            string[] niz = IzabranaUlaznica.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.ObicnaUlaznica.Ulaznica = udao.FindById(broj);
        }
    }
}
