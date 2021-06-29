using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class KoloValidacija : ValidationBase
    {
        Kolo kolo;
        KoloDAO kdao;
        // bool DaLiJeIzmena;

        public Kolo Kolo
        {
            get { return kolo; }
            set
            {
                kolo = value;
                OnPropertyChanged("Kolo");
            }
        }

        public KoloValidacija()
        {
            Kolo = new Kolo();
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        protected override void ValidateSelf()
        {


            if (this.Kolo.idk == 0)
            {
                this.ValidationErrors["idk"] = "Unesite id!";
            }

            /*if (this.Kolo.OdrzavanjeTurnir_idtur == 0)
            {
                this.ValidationErrors["idtur"] = "Unesite id turnira!";
            }

            if (this.Kolo.Odrzavanje_idod == 0)
            {
                this.ValidationErrors["idod"] = "Unesite id odrzavanja!";
            }*/
        }
    }
}
