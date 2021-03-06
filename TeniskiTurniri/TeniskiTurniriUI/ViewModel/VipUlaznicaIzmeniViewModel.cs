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
    public class VipUlaznicaIzmeniViewModel : BindableBase
    {
        public VipUlaznicaIzmeniViewModel(VipUlaznicaIzmeniView view, VipUlaznica vipUlaznica)
        {

            this.view = view;
            Validacija = new VipUlaznicaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniUlaznicu);
            validacija.VipUlaznica = vipUlaznica;
            UcitajUlaznice();
            IzabranaUlaznica = "";

        }
        private VipUlaznicaIzmeniView view;
        private VipUlaznicaValidacija validacija;
        private List<string> spisakUlaznica;
        private string izabranaUlaznica;
        private string izabranaUlaznicaGreska;
        private bool daLiJeEdit = false;
        private UlaznicaDAO udao = new UlaznicaDAO();

        public List<string> SpisakUlaznica { get => spisakUlaznica; set { spisakUlaznica = value; OnPropertyChanged("SpisakUlaznica"); } }
        public string IzabranaUlaznica { get => izabranaUlaznica; set { izabranaUlaznica = value; OnPropertyChanged("IzabranaUlaznica"); } }
        public string IzabranaUlaznicaGreska { get => izabranaUlaznicaGreska; set { izabranaUlaznicaGreska = value; OnPropertyChanged("IzabranaUlaznicaGreska"); } }





        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public VipUlaznicaValidacija Validacija
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

        public void IzmeniUlaznicu()
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
                VipUlaznicaDAO u = new VipUlaznicaDAO();

                //if (daLiJeEdit)
                {
                    u.Update(Validacija.VipUlaznica);
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


                if (item.idu == Validacija.VipUlaznica.idvu)
                    IzabranaUlaznica = "ID:" + item.idu.ToString() + " - Tip ulaznice:" + item.tipu;

            }
        }

        public void OdrediUlaznicu()
        {
            string[] niz = IzabranaUlaznica.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.VipUlaznica.idvu = broj;
        }

    }
}
