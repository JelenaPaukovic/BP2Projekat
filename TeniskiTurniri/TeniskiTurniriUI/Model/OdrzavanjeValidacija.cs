using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class OdrzavanjeValidacija : ValidationBase
    {
        Odrzavanje odrzavanje;
        OdrzavanjeDAO ndao;
        // bool DaLiJeIzmena;

        public Odrzavanje Odrzavanje
        {
            get { return odrzavanje; }
            set
            {
                odrzavanje = value;
                OnPropertyChanged("Odrzavanje");
            }
        }


        public OdrzavanjeValidacija()
        {
            Odrzavanje = new Odrzavanje();
        }

        protected override void ValidateSelf()
        {
            if (this.Odrzavanje.idod == 0)
            {
                this.ValidationErrors["idod"] = "Unesite id!";
            }
        }
    }
}
