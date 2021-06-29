using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class OpremaValidacija : ValidationBase
    {
        Oprema oprema;
        OpremaDAO odao;
        // bool DaLiJeIzmena;

        public Oprema Oprema
        {
            get { return oprema; }
            set
            {
                oprema = value;
                OnPropertyChanged("Oprema");
            }
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/


        public OpremaValidacija()
        {
            Oprema = new Oprema();
        }
        protected override void ValidateSelf()
        {


            if (this.Oprema.ido == 0)
            {
                this.ValidationErrors["ido"] = "Unesite id!";
            }



            if (string.IsNullOrWhiteSpace(this.Oprema.nazo))
            {
                this.ValidationErrors["nazo"] = "Unesite naziv!";
            }


        }
    }
}
