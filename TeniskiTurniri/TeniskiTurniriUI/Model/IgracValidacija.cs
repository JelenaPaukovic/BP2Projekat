using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class IgracValidacija : ValidationBase
    {
        Igrac igrac;
        IgracDAO Idao;
        // bool DaLiJeIzmena;

        public Igrac Igrac
        {
            get { return igrac; }
            set
            {
                igrac = value;
                OnPropertyChanged("Igrac");
            }
        }

        public IgracValidacija()
        {
            Igrac = new Igrac();
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        protected override void ValidateSelf()
        {


            if (this.Igrac.idig == 0)
            {
                this.ValidationErrors["idig"] = "Unesite id!";
            }



            if (string.IsNullOrWhiteSpace(this.Igrac.imei))
            {
                this.ValidationErrors["imei"] = "Unesite ime!";
            }

            if (string.IsNullOrWhiteSpace(this.Igrac.przi))
            {
                this.ValidationErrors["przi"] = "Unesite prezime!";
            }

            if (string.IsNullOrWhiteSpace(this.Igrac.drzi))
            {
                this.ValidationErrors["drzi"] = "Unesite drzavu!";
            }


        }
    }
}
