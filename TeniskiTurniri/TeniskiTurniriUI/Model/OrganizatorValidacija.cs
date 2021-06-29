using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class OrganizatorValidacija : ValidationBase
    {
        Organizator organizator;
        OrganizatorDAO odao;
        // bool DaLiJeIzmena;

        public Organizator Organizator
        {
            get { return organizator; }
            set
            {
                organizator = value;
                OnPropertyChanged("Organizator");
            }
        }

        /*  public GledalacValidacija(bool daLiJeIzmena)
          {
              Kategorija = new Kategorija();
              dao = new KategorijaDao();
              DaLiJeIzmena = daLiJeIzmena;
          }*/



        public OrganizatorValidacija()
        {
            Organizator = new Organizator();
        }
        protected override void ValidateSelf()
        {


            if (this.Organizator.idor == 0)
            {
                this.ValidationErrors["idor"] = "Unesite id!";
            }



            if (string.IsNullOrWhiteSpace(this.Organizator.nazor))
            {
                this.ValidationErrors["nazor"] = "Unesite naziv!";
            }


        }
    }
}
