using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class ProdajeDAO : BaseRepo<Prodaje>
    {
        public void Insert(Prodaje prodaje, int turnir, int ulaznica)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                


                prodaje.Turnir = db.TurnirSet.Find(turnir); //da li je to turnirset?
                prodaje.Ulaznica = db.UlaznicaSet.Find(ulaznica);


                db.ProdajeSet.Add(prodaje);
                db.SaveChanges();
            }
        }

        public bool DaLiMozeDaSeProda(int turnir, int ulaznica)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                List<Prodaje> prodaje = db.ProdajeSet.ToList();

                foreach (Prodaje item in prodaje)
                {
                    if (item.Ulaznica_idu == ulaznica && item.Turnir_idtur == turnir)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
