using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class UlaznicaValidacija : ValidationBase
    {
        Ulaznica ulaznica;
        UlaznicaDAO udao;   //Ulaznica
        // bool DaLiJeIzmena;

        public Ulaznica Ulaznica
        {
            get { return ulaznica; }
            set
            {
                ulaznica = value;
                OnPropertyChanged("Ulaznica");
            }
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/

        public UlaznicaValidacija()
        {
            Ulaznica = new Ulaznica();
        }

        protected override void ValidateSelf()
        {


            if (this.Ulaznica.idu == 0)
            {
                this.ValidationErrors["idu"] = "Morate uneti id!";
            }


        }
    }
}
