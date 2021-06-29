using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class Funkcija
    {
        public List<string> PozoviFunkciju(string mesto)
        {
            List<string> lista = new List<string>();

            using (var db = new ModelTeniskiTurniriContainer())
            {
                try
                {
                    //Poziv funkcije
                    lista = db.Funkcija1(mesto).ToList();
                }
                catch
                {
                    lista = new List<string>();
                }
            }

            return lista;
        }
    }
}



