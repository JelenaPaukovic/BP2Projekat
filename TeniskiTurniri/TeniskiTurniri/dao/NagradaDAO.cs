using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeniskiTurniri.dao
{
    public class NagradaDAO : BaseRepo<Nagrada>
    {
        public bool DaLiMozeDaSeObrise(int id)
        {
            using (var db = new ModelTeniskiTurniriContainer())
            {
                Nagrada nagrada = db.NagradaSet.Where(c => c.idn.Equals(id)).FirstOrDefault();

                if (nagrada.Ucestvuje.Count > 0)   //prodajeset??
                    return false;
            }

            return true;
        }
    }
}
