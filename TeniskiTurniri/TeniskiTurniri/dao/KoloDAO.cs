using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class KoloDAO : BaseRepo<Kolo>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Kolo kolo = db.KoloSet.Where(c => c.idk.Equals(id)).FirstOrDefault();

                if (kolo.Odrzavanje != null)   
                    return false;

                if (kolo.Mec.Count > 0)   
                    return false;
                

            }

            return true;
        }
    }
}
