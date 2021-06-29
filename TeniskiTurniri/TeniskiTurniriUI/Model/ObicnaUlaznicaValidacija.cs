using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class ObicnaUlaznicaValidacija : ValidationBase
    {
        ObicnaUlaznica obicnaUlaznica;
        ObicnaUlaznicaDAO ndao;
        // bool DaLiJeIzmena;

        public ObicnaUlaznica ObicnaUlaznica
        {
            get { return obicnaUlaznica; }
            set
            {
                obicnaUlaznica = value;
                OnPropertyChanged("Nagrada");
            }
        }


        public ObicnaUlaznicaValidacija()
        {
            ObicnaUlaznica = new ObicnaUlaznica();
        }
        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        protected override void ValidateSelf()
        {


            if (this.ObicnaUlaznica.idou == 0)
            {
                this.ValidationErrors["idou"] = "Unesite id!";
            }





          /*  if (string.IsNullOrWhiteSpace(this.ObicnaUlaznica.ozno))
            {
                this.ValidationErrors["ozno"] = "Unesite tip!";
            }*/


        }
    }
}
