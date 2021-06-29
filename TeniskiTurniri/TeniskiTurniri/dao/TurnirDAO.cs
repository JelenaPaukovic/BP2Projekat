using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class TurnirDAO : BaseRepo<Turnir>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Turnir turnir = db.TurnirSet.Where(c => c.idtur.Equals(id)).FirstOrDefault();

                if (turnir.Prodaje.Count > 0)   //prodajeset??
                    return false;

                if (turnir.Ucestvuje.Count > 0)   //prodajeset??
                    return false;

                if (turnir.Organizator.Count > 0)   //prodajeset??
                    return false;

                if (turnir.Odrzavanje.Count > 0)   //prodajeset??
                    return false;

                if (turnir.Kategorija != null)   //prodajeset??
                    return false;

                if (turnir.Gledalac.Count > 0)   //prodajeset??
                    return false;


            }

            return true;
        }


        public void Insert(Turnir turnir, List<long> organizatori)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                foreach (long item in organizatori)
                {
                    turnir.Organizator.Add(db.OrganizatorSet.Find(item));
                }

                db.TurnirSet.Add(turnir);
                db.SaveChanges();
            }
        }




        public List<Turnir> GetList()
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                

                List<Turnir> turniri = new List<Turnir>();

                db.TurnirSet.Include("Organizator");

                foreach (Turnir item in db.TurnirSet.Include("Organizator"))
                {

                    turniri.Add(item);
                }

                return turniri;
            }
        }
    }
}
