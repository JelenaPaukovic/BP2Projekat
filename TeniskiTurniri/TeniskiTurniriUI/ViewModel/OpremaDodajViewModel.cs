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
    public class OpremaDodajViewModel : BindableBase
    {
        private OpremaDodajView view;
        private OpremaValidacija validacija;




        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public OpremaValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public OpremaDodajViewModel(OpremaDodajView view)
        {
            this.view = view;
            Validacija = new OpremaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajOpremu);


        }

        public void Exit()
        {
            view.Close();
        }

        public void DodajOpremu()
        {
            // Validacija.Validate();
            // if (Validacija.IsValid)
            {
                OpremaDAO odao = new OpremaDAO();






                odao.Insert(Validacija.Oprema);


                view.Close();
            }
        }
    }
}
