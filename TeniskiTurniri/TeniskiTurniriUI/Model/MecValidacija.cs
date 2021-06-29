using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeniskiTurniri;
using TeniskiTurniri.dao;

namespace TeniskiTurniriUI.Model
{
    public class MecValidacija : ValidationBase
    {
        Mec mec;
        MecDAO ndao;


        public Mec Mec
        {
            get { return mec; }

            set
            {
                mec = value;
                OnPropertyChanged("Mec");
            }
        }


        public MecValidacija()
        {
            Mec = new Mec();
        }

        protected override void ValidateSelf()
        {
            if (this.Mec.idm == 0)
            {
                this.ValidationErrors["idn"] = "Unesite id!";
            }


            if (this.Mec.brg == 0)
            {
                this.ValidationErrors["brg"] = "Unesite broj gledalaca!";
            }


         

            if (string.IsNullOrWhiteSpace(this.Mec.imeig))
            {
                this.ValidationErrors["imeig"] = "Unesite ime igraca!";
            }

            if (string.IsNullOrWhiteSpace(this.Mec.przig))
            {
                this.ValidationErrors["przig"] = "Unesite prezime igraca!";
            }


        }

    }
}
