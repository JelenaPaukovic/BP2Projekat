using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class TurnirValidacija : ValidationBase
    {
        public TurnirValidacija()
        {
            Turnir = new Turnir();
        }

        Turnir turnir;
        TurnirDAO tdao;
        // bool DaLiJeIzmena;

        public Turnir Turnir
        {
            get { return turnir; }
            set
            {
                turnir = value;
                OnPropertyChanged("Turnir");
            }
        }



        protected override void ValidateSelf()
        {


            if (this.Turnir.idtur == 0)
            {
                this.ValidationErrors["idtur"] = "Morate uneti id!";
            }

            if (string.IsNullOrWhiteSpace(this.Turnir.naztur))
            {
                this.ValidationErrors["naztur"] = "Unesite naziv!";
            }

            if (string.IsNullOrWhiteSpace(this.Turnir.mestotur))
            {
                this.ValidationErrors["mestotur"] = "Unesite mesto!";
            }
        }
    }
}
