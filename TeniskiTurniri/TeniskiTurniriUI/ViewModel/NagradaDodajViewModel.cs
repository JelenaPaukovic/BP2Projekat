using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeniskiTurniri;
using TeniskiTurniri.dao;
using TeniskiTurniriUI.Model;
using TeniskiTurniriUI.View;

namespace TeniskiTurniriUI.ViewModel
{
    public class NagradaDodajViewModel : BindableBase
    {

        private NagradaDodajView view;
        private NagradaValidacija validacija;




        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public NagradaValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public NagradaDodajViewModel(NagradaDodajView view)
        {
            this.view = view;
            Validacija = new NagradaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajNagradu);


        }

        public void Exit()
        {
            view.Close();
        }

        public void DodajNagradu()
        {
            // Validacija.Validate();
            // if (Validacija.IsValid)
            {
                NagradaDAO ndao = new NagradaDAO();






                ndao.Insert(Validacija.Nagrada);


                view.Close();
            }
        }
    }
}
