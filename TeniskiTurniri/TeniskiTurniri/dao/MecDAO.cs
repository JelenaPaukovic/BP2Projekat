using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class MecDAO : BaseRepo<Mec>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Mec mec = db.MecSet.Where(c => c.idm.Equals(id)).FirstOrDefault();

                if (mec.Kolo != null)   //ako je jedan onda razlicito od null
                    return false;

                if (mec.Stadion != null)
                    return false;

                if (mec.Ucestvuje.Count > 0) //ako je lista onda ide .count
                    return false;
            }

            return true;
        }
    }
}
