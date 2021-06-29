using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class GledalacValidacija : ValidationBase
    {
        Gledalac gledalac;
        GledalacDAO gdao;
        // bool DaLiJeIzmena;

        public Gledalac Gledalac
        {
            get { return gledalac; }
            set
            {
                gledalac = value;
                OnPropertyChanged("Gledalac");
            }
        }


        public GledalacValidacija()
        {
            Gledalac = new Gledalac();
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        protected override void ValidateSelf()
        {


            if (this.Gledalac.idg == 0)
            {
                this.ValidationErrors["idg"] = "Morate uneti id!";
            }

           /* if (gdao.FindById(this.Gledalac.idg) != null)
            {
                this.ValidationErrors["idg"] = "Postoji gledalac sa istim id-em!";
            }*/
        }
    }
}
