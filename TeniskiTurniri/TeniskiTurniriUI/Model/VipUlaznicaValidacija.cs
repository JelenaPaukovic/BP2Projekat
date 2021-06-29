using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class VipUlaznicaValidacija : ValidationBase
    {
        VipUlaznica vipUlaznica;
        VipUlaznicaDAO ndao;
        // bool DaLiJeIzmena;

        public VipUlaznica VipUlaznica
        {
            get { return vipUlaznica; }
            set
            {
                vipUlaznica = value;
                OnPropertyChanged("Nagrada");
            }
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        public VipUlaznicaValidacija()
        {
            VipUlaznica = new VipUlaznica();
        }


        protected override void ValidateSelf()
        {


            if (this.VipUlaznica.idvu == 0)
            {
                this.ValidationErrors["idvu"] = "Unesite id!";
            }





            if (string.IsNullOrWhiteSpace(this.VipUlaznica.oznv))
            {
                this.ValidationErrors["oznv"] = "Unesite tip!";
            }


        }
    }
}
