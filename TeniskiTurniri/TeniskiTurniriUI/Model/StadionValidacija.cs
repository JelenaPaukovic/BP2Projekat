using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class StadionValidacija : ValidationBase
    {
        Stadion stadion;
        StadionDAO kdao;
        // bool DaLiJeIzmena;

        public Stadion Stadion
        {
            get { return stadion; }
            set
            {
                stadion = value;
                OnPropertyChanged("Stadion");
            }
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        public StadionValidacija()
        {
            Stadion = new Stadion();
        }

        protected override void ValidateSelf()
        {


            if (this.Stadion.idst == 0)
            {
                this.ValidationErrors["idst"] = "Unesite id!";
            }



            if (string.IsNullOrWhiteSpace(this.Stadion.nazst))
            {
                this.ValidationErrors["nazst"] = "Unesite naziv!";
            }


        }
    }
}
