using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class VipUlaznicaDAO : BaseRepo<VipUlaznica>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                VipUlaznica vipUlaznica = db.VipUlaznicaSet.Where(c => c.idvu.Equals(id)).FirstOrDefault();

                if (vipUlaznica.Ulaznica != null)   //prodajeset??
                    return false;
            }

            return true;
        }
    }
}
