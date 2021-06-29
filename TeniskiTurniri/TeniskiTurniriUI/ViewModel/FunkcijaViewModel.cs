using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeniskiTurniriUI.Model;
using TeniskiTurniriUI.View;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.ViewModel
{
    public class FunkcijaViewModel : BindableBase
    {

        private FunkcijaView view;
        private string izabranoMesto;
        private List<FunkcijaKlasa> listaRezultata;

        public ICommand ExitCommand { get; set; }
        public ICommand PronadjiCommand { get; set; }
        public string IzabranoMesto { get => izabranoMesto; set { izabranoMesto = value; OnPropertyChanged("IzabranoMesto"); } }

        public List<FunkcijaKlasa> ListaRezultata { get => listaRezultata; set { listaRezultata = value; OnPropertyChanged("ListaRezultata"); } }
        public FunkcijaViewModel(FunkcijaView view)
        {
            this.view = view;
            ExitCommand = new MyICommand(this.Exit);
            PronadjiCommand = new MyICommand(this.Pronadji, CanPronadji);
            listaRezultata = new List<FunkcijaKlasa>();
        }

        public void Exit()
        {
            view.Close();
        }

        public bool CanPronadji()
        {
            return !string.IsNullOrEmpty(IzabranoMesto);
        }

        public void Pronadji()
        {
            ListaRezultata.Clear();
            

            Funkcija dao = new Funkcija();
            string s = IzabranoMesto;
            s = s.Trim();
            List<string> rezultat = dao.PozoviFunkciju(s);

            foreach (string item in rezultat)
            {
                FunkcijaKlasa f = new FunkcijaKlasa(item, item.Length);
                ListaRezultata.Add(f);
                    
            }
        }

    }
}
