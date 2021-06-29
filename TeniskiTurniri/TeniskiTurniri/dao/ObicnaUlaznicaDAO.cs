using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class ObicnaUlaznicaDAO : BaseRepo<ObicnaUlaznica>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                ObicnaUlaznica obicnaUlaznica = db.ObicnaUlaznicaSet.Where(c => c.idou.Equals(id)).FirstOrDefault();

                if (obicnaUlaznica.Ulaznica != null)   //prodajeset??
                    return false;
            }

            return true;
        }
    }
}
