using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TeniskiTurniri.dao;
using TeniskiTurniriUI.Model;
using TeniskiTurniriUI.View;
using TeniskiTurniri;


namespace TeniskiTurniriUI.ViewModel
{
    public class ProdajeViewModel : BindableBase
    {
        
        private ProdajeView view;
        private string selektovaniTurnir;
        private List<string> sviTurniri;
        private string selektovanaUlaznica;
        private List<string> sveUlaznice;
        private string izabraniTurnirGreska;
        private string izabranaUlaznicaGreska;



        public ICommand AddCommand { get; set; }

        private TurnirDAO tdao = new TurnirDAO();
        private UlaznicaDAO udao = new UlaznicaDAO();

        public List<string> SviTurniri { get => sviTurniri; set { sviTurniri = value; OnPropertyChanged("SviTurniri"); } }
        public string SelektovaniTurnir { get => selektovaniTurnir; set { selektovaniTurnir = value; OnPropertyChanged("SelektovaniTurnir"); } }
        public List<string> SveUlaznice { get => sveUlaznice; set { sveUlaznice = value; OnPropertyChanged("SveUlaznice"); } }
        public string SelektovanaUlaznica { get => selektovanaUlaznica; set { selektovanaUlaznica = value; OnPropertyChanged("SelektovanaUlaznica"); } }

        public string IzabraniTurnirGreska { get => izabraniTurnirGreska; set { izabraniTurnirGreska = value; OnPropertyChanged("IzabraniTurnirGreska"); } }
        public string IzabranaUlaznicaGreska { get => izabranaUlaznicaGreska; set { izabranaUlaznicaGreska = value; OnPropertyChanged("IzabranaUlaznicaGreska"); } }
        public ICommand ExitCommand { get; set; }

        public ProdajeViewModel(ProdajeView view)
        {
            this.view = view;
            AddCommand = new MyICommand(this.Add, CanAdd);
            ExitCommand = new MyICommand(this.Exit);
            UcitajTurnire();
            UcitajUlaznice();
        }

        public void Exit()
        {
            view.Close();
        }

        public void UcitajTurnire()
        {
            SviTurniri = new List<string>();

            foreach (Turnir item in tdao.GetList())
            {
                SviTurniri.Add("ID:" + item.idtur.ToString() + " - Naziv:" + item.naztur);
            }
        }

        public void UcitajUlaznice()
        {
            SveUlaznice = new List<string>();

            foreach (Ulaznica item in udao.GetList())
            {
                SveUlaznice.Add("ID:" + item.idu.ToString() + " - Tip ulaznice:" + item.tipu);
            }
        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            if (!string.IsNullOrEmpty(SelektovaniTurnir) && !string.IsNullOrEmpty(SelektovanaUlaznica))
            {

                ProdajeDAO pdao = new ProdajeDAO();
                Prodaje p = new Prodaje();  

                int turnirId = OdrediTurnir();
                int ulaznicaId = OdrediUlaznicu();

                p.Turnir_idtur = turnirId;
                p.Ulaznica_idu = ulaznicaId;

                if (pdao.DaLiMozeDaSeProda(turnirId, ulaznicaId))
                {
                    pdao.Insert(p, turnirId, ulaznicaId);
                    MessageBox.Show("Odabrana ulaznica je uspesno prodata za izabrani turnir!");
                    view.Close();
                }
                else
                {
                    MessageBox.Show("Odabrana ulaznica je vec prodata!");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(SelektovaniTurnir))
                {
                    IzabraniTurnirGreska = "Morate odabrati turnir!";
                }
                else
                {
                    IzabraniTurnirGreska = "";
                }

                if (string.IsNullOrEmpty(SelektovanaUlaznica))
                {
                    IzabranaUlaznicaGreska = "Morate odabrati ulaznicu!";
                }
                else
                {
                    IzabranaUlaznicaGreska = "";
                }

            }
        }

        public int OdrediTurnir()
        {
            string[] niz = SelektovaniTurnir.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            return broj;
        }

        public int OdrediUlaznicu()
        {
            string[] niz = SelektovanaUlaznica.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            return broj;
        }
    }
}

