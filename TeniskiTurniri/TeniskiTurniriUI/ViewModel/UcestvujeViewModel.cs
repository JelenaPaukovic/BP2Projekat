using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TeniskiTurniri;
using TeniskiTurniri.dao;
using TeniskiTurniriUI.Model;
using TeniskiTurniriUI.View;

namespace TeniskiTurniriUI.ViewModel
{
    public class UcestvujeViewModel : BindableBase

    {
        private UcestvujeView view;
        private string selektovaniTurnir;
        private List<string> sviTurniri;
        private string selektovaniIgrac;
        private List<string> sviIgraci;
        private string izabraniTurnirGreska;
        private string izabraniIgracGreska;
        private List<string> svaOprema;
        private string izabranaOprema;
        private string izabranaOpremaGreska;


        public ICommand AddCommand { get; set; }

        private TurnirDAO tdao = new TurnirDAO();
        private IgracDAO idao = new IgracDAO();
        private OpremaDAO odao = new OpremaDAO();

        public List<string> SviTurniri { get => sviTurniri; set { sviTurniri = value; OnPropertyChanged("SviTurniri"); } }
        public string SelektovaniTurnir { get => selektovaniTurnir; set { selektovaniTurnir = value; OnPropertyChanged("SelektovaniTurnir"); } }
        public List<string> SviIgraci { get => sviIgraci; set { sviIgraci = value; OnPropertyChanged("SviIgraci"); } }
        public string SelektovaniIgrac { get => selektovaniIgrac; set { selektovaniIgrac = value; OnPropertyChanged("SelektovaniIgrac"); } }

        public string IzabraniTurnirGreska { get => izabraniTurnirGreska; set { izabraniTurnirGreska = value; OnPropertyChanged("IzabraniTurnirGreska"); } }
        public string IzabraniIgracGreska { get => izabraniIgracGreska; set { izabraniIgracGreska = value; OnPropertyChanged("IzabraniIgracGreska"); } }
        public List<string> SvaOprema { get => svaOprema; set { svaOprema = value; OnPropertyChanged("SvaOprema"); } }

        public string IzabranaOprema { get => izabranaOprema; set { izabranaOprema = value; OnPropertyChanged("IzabranaOprema"); } }
        public string IzabranaOpremaGreska { get => izabranaOpremaGreska; set { izabranaOpremaGreska = value; OnPropertyChanged("IzabranaOpremaGreska"); } }
        
        
        
        
        public ICommand ExitCommand { get; set; }

        public UcestvujeViewModel(UcestvujeView view)
        {
            this.view = view;
            AddCommand = new MyICommand(this.Add, CanAdd);
            ExitCommand = new MyICommand(this.Exit);
            UcitajTurnire();
            UcitajIgrace();
            UcitajOpreme();
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


        public void UcitajOpreme()
        {
            SvaOprema = new List<string>();

            foreach (Oprema item in odao.GetList())
            {
                SvaOprema.Add("ID:" + item.ido.ToString() + " - Naziv:" + item.nazo);
            }
        }

        public void UcitajIgrace()
        {
            SviIgraci = new List<string>();

            foreach (Igrac item in idao.GetList())
            {
                SviIgraci.Add("ID:" + item.idig.ToString() + " - Drzava igraca:" + item.drzi + " - Ime igraca:" + item.imei + " - Prezime igraca:" + item.przi);
            }
        }

        public bool CanAdd()
        {
            return true;
        }

        public void Add()
        {
            if (!string.IsNullOrEmpty(SelektovaniTurnir) && !string.IsNullOrEmpty(SelektovaniIgrac) && !string.IsNullOrEmpty(IzabranaOprema))
            {

                UcestvujeDAO pdao = new UcestvujeDAO();
                Ucestvuje u = new Ucestvuje();

                int turnirId = OdrediTurnir();
                int IgracId = OdrediIgraca();
                int OpremaId = OdrediOpremu();

                u.Turnir_idtur = turnirId;
                u.Igrac_idig = IgracId;
                u.Oprema_ido = OpremaId;

                if (pdao.DaLiMozeDaUcestvuje(turnirId, IgracId, OpremaId))
                {
                    pdao.Insert(u, turnirId, IgracId, OpremaId);
                    MessageBox.Show("Odabranom igracu je uspesno dodeljeno da igra na odbranom turniru u odabranoj opremi!");
                    view.Close();
                }
                else
                {
                    MessageBox.Show("Odabrani igrac vec ucestvuje na odabranom turniru!");
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

                if (string.IsNullOrEmpty(SelektovaniIgrac))
                {
                    IzabraniIgracGreska = "Morate odabrati igraca!";
                }
                else
                {
                    IzabraniIgracGreska = "";
                }

                if (string.IsNullOrEmpty(IzabranaOprema))
                {
                    IzabranaOpremaGreska = "Morate odabrati opremu!";
                }
                else
                {
                    IzabranaOpremaGreska = "";
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

        public int OdrediIgraca()
        {
            string[] niz = SelektovaniIgrac.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            return broj;
        }

        public int OdrediOpremu()
        {
            string[] niz = IzabranaOprema.Split('-');
            string[] nizTemp = niz[0].Split(':');

            int broj = Int32.Parse(nizTemp[1]);
            return broj;
        }
    }
}
