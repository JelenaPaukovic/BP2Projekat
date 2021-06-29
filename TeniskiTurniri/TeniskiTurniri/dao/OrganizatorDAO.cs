using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class OrganizatorDAO : BaseRepo<Organizator>
    {
         public bool DaLiMozeDaSeObrise(int id)
         {
             using (var db = new ModelTeniskiTurniriContainer())
             {
                 Organizator organizator = db.OrganizatorSet.Where(c => c.idor.Equals(id)).FirstOrDefault();

                 if (organizator.Turnir.Count > 0)   //prodajeset??
                     return false;
             }

             return true;
         }
        public List<Organizator> GetList()
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {


                List<Organizator> organizatori = new List<Organizator>();

                db.OrganizatorSet.Include("Turnir");

                foreach (Organizator item in db.OrganizatorSet.Include("Turnir"))
                {

                    organizatori.Add(item);
                }

                return organizatori;
            }
        }


        public void Insert(Organizator organizator, List<long> turniri)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                foreach (long item in turniri)
                {
                    organizator.Turnir.Add(db.TurnirSet.Find(item));
                }

                db.OrganizatorSet.Add(organizator);
                db.SaveChanges();
            }
        }


        public void Update(Organizator organizator, List<int> turniri)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                foreach (int item in turniri)
                {
                    organizator.Turnir.Add(db.TurnirSet.Find(item));
                }
            }
                //db.OrganizatorSet.Add(organizator);
                //db.Set<Organizator>().Attach(organizator);
                //db.Entry(organizator).State = System.Data.Entity.EntityState.Modified;
                base.Update(organizator);
                //db.SaveChanges();
            
        }
    }
}
