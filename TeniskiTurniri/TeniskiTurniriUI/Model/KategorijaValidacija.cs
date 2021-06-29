using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class KategorijaValidacija : ValidationBase
    {
        Kategorija kategorija;
        KategorijaDAO kdao;
        // bool DaLiJeIzmena;

        public Kategorija Kategorija
        {
            get { return kategorija; }
            set
            {
                kategorija = value;
                OnPropertyChanged("Kategorija");
            }
        }


        public KategorijaValidacija()
        {
            Kategorija = new Kategorija();
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        protected override void ValidateSelf()
        {


            if (this.Kategorija.idkat == 0)
            {
                this.ValidationErrors["idkat"] = "Unesite id!";
            }



            if (string.IsNullOrWhiteSpace(this.Kategorija.nazkat))
            {
                this.ValidationErrors["nazkat"] = "Unesite naziv!";
            }


        }
    }
}
