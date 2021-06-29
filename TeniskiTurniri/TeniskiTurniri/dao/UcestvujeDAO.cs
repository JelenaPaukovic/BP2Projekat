using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class UcestvujeDAO : BaseRepo<Ucestvuje>
    {
        public void Insert(Ucestvuje ucestvuje, int turnir, int igrac, int oprema)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {



                ucestvuje.Turnir = db.TurnirSet.Find(turnir); //da li je to turnirset?
                ucestvuje.Igrac = db.IgracSet.Find(igrac);
                ucestvuje.Oprema = db.OpremaSet.Find(oprema);


                db.UcestvujeSet.Add(ucestvuje);
                db.SaveChanges();
            }
        }

        public bool DaLiMozeDaUcestvuje(int turnir, int igrac, int oprema)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                List<Ucestvuje> ucestvuje = db.UcestvujeSet.ToList();

                foreach (Ucestvuje item in ucestvuje)
                {
                    if (item.Igrac_idig == igrac && item.Turnir_idtur == turnir && item.Oprema_ido == oprema)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
