using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class KategorijaDAO : BaseRepo<Kategorija>
    {
        public void Insert(Kategorija kategorija)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                db.Procedure1(kategorija.idkat, kategorija.nazkat);
                //db.Set<TEntity>().Add(entity);
                db.SaveChanges();
            }
        }


        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Kategorija kategorija = db.KategorijaSet.Where(c => c.idkat.Equals(id)).FirstOrDefault();

                if (kategorija.Turnir.Count > 0)   //prodajeset??
                    return false;
            }

            return true;
        }
    }
}
