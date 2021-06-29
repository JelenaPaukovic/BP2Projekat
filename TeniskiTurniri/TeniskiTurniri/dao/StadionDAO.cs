using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class StadionDAO : BaseRepo<Stadion>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Stadion stadion = db.StadionSet.Where(c => c.idst.Equals(id)).FirstOrDefault();

                if (stadion.Mec.Count > 0)   //prodajeset??
                    return false;
            }

            return true;
        }
    }
}
