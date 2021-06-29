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
    public class UlaznicaDodajViewModel : BindableBase
    {
        private UlaznicaDodajView view;
        private UlaznicaValidacija validacija;




        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public UlaznicaValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public UlaznicaDodajViewModel(UlaznicaDodajView view)
        {
            this.view = view;
            Validacija = new UlaznicaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajUlaznicu);


        }

        public void Exit()
        {
            view.Close();
        }

        public void DodajUlaznicu()
        {
            // Validacija.Validate();
            // if (Validacija.IsValid)
            
                UlaznicaDAO udao = new UlaznicaDAO();






                udao.Insert(Validacija.Ulaznica);


                view.Close();
            
        }
    }
}
