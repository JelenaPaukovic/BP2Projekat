using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class OdrzavanjeDAO : BaseRepo<Odrzavanje>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Odrzavanje odrzavanje = db.OdrzavanjeSet.Where(c => c.idod.Equals(id)).FirstOrDefault();

                if (odrzavanje.Kolo.Count > 0)   //prodajeset??
                    return false;

                if (odrzavanje.Turnir != null)   //prodajeset??
                    return false;

            }

            return true;
        }
    }
}
