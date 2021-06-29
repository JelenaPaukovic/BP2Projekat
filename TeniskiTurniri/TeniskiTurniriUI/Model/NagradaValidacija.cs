using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class NagradaValidacija : ValidationBase
    {
        Nagrada nagrada;
        NagradaDAO ndao;
        // bool DaLiJeIzmena;

        public Nagrada Nagrada
        {
            get { return nagrada; }
            set
            {
                nagrada = value;
                OnPropertyChanged("Nagrada");
            }
        }

        public NagradaValidacija()
        {
            Nagrada = new Nagrada();
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        protected override void ValidateSelf()
        {


            if (this.Nagrada.idn == 0)
            {
                this.ValidationErrors["idn"] = "Unesite id!";
            }



            if (string.IsNullOrWhiteSpace(this.Nagrada.nazn))
            {
                this.ValidationErrors["nazn"] = "Unesite naziv!";
            }


        }
    }
}
