using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class IgracDAO : BaseRepo<Igrac>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Igrac igrac = db.IgracSet.Where(c => c.idig.Equals(id)).FirstOrDefault();

                if (igrac.Ucestvuje.Count > 0)   //prodajeset??
                    return false;

                
            }

            return true;
        }
    }
}
