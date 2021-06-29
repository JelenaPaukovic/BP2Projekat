using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class UlaznicaDAO : BaseRepo<Ulaznica>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Ulaznica ulaznica = db.UlaznicaSet.Where(c => c.idu.Equals(id)).FirstOrDefault();

                if (ulaznica.Prodaje.Count > 0)   //prodajeset??
                    return false;

                if (ulaznica.VipUlaznica != null)   //prodajeset??
                    return false;

                if (ulaznica.ObicnaUlaznica != null)   //prodajeset??
                    return false;

            }

            return true;
        }

    }
}
