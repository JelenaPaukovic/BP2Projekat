using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class OpremaDAO : BaseRepo<Oprema>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Oprema oprema = db.OpremaSet.Where(c => c.ido.Equals(id)).FirstOrDefault();

                if (oprema.Ucestvuje.Count > 0)   //prodajeset??
                    return false;
            }

            return true;
        }
    }
}
