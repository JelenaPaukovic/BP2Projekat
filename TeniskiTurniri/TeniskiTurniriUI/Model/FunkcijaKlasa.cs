using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniriUI.Model
{
    public class FunkcijaKlasa
    {

        //private string tekst;


        public FunkcijaKlasa(string tekst, int brojSlova)
        {
            Tekst = tekst;
            BrojSlova = brojSlova;
        }

        

        public string Tekst { get; set; }

        public int BrojSlova { get; set; }
    }
}
