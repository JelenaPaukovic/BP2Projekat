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
    public class ObicnaUlaznicaIzmeniViewModel : BindableBase
    {
        public ObicnaUlaznicaIzmeniViewModel(ObicnaUlaznicaIzmeniView view, ObicnaUlaznica ObicnaUlaznica)
        {

            this.view = view;
            Validacija = new ObicnaUlaznicaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniUlaznicu);
            validacija.ObicnaUlaznica = ObicnaUlaznica;
            UcitajUlaznice();
            IzabranaUlaznica = "";

        }
        private ObicnaUlaznicaIzmeniView view;
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
        public ICommand EditCommand { get; set; }

        public ObicnaUlaznicaValidacija Validacija
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
                ObicnaUlaznicaDAO u = new ObicnaUlaznicaDAO();

                //if (daLiJeEdit)
                {
                    u.Update(Validacija.ObicnaUlaznica);
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

                
                    if (item.idu == Validacija.ObicnaUlaznica.idou)
                        IzabranaUlaznica = "ID:" + item.idu.ToString() + " - Tip ulaznice:" + item.tipu;
                
            }
        }

        public void OdrediUlaznicu()
        {
            string[] niz = IzabranaUlaznica.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            //Validacija.Turnir.idtur = broj; //sta ovde 
            Validacija.ObicnaUlaznica.idou = broj;
        }



    }
}
