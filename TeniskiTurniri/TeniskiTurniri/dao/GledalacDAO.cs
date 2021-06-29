using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class GledalacDAO : BaseRepo<Gledalac>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Gledalac gledalac = db.GledalacSet.Where(c => c.idg.Equals(id)).FirstOrDefault();

                if (gledalac.Prodaje.Count > 0)   //prodajeset??
                    return false;

                if (gledalac.Turnir.Count > 0)   //prodajeset??
                    return false;
            }

            return true;
        }

        public List<Gledalac> GetList()
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {


                List<Gledalac> gledaoci = new List<Gledalac>();

                db.GledalacSet.Include("Turnir");

                foreach (Gledalac item in db.GledalacSet.Include("Turnir"))
                {

                    gledaoci.Add(item);
                }

                return gledaoci;
            }
        }


        public void Insert(Gledalac gledalac, List<long> turniri)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                foreach (long item in turniri)
                {
                    gledalac.Turnir.Add(db.TurnirSet.Find(item));
                }

                db.GledalacSet.Add(gledalac);
                db.SaveChanges();
            }
        }


        public void Update(Gledalac gledalac, List<int> turniri)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                foreach (int item in turniri)
                {
                    gledalac.Turnir.Add(db.TurnirSet.Find(item));
                }
            }
            //db.gledalacSet.Add(gledalac);
            //db.Set<gledalac>().Attach(gledalac);
            //db.Entry(gledalac).State = System.Data.Entity.EntityState.Modified;
            base.Update(gledalac);
            //db.SaveChanges();

        }
    }
}
