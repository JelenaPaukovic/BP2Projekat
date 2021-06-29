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
    public class UlaznicaIzmeniViewModel : BindableBase
    {
        public UlaznicaIzmeniViewModel(UlaznicaIzmeniView view, Ulaznica Ulaznica)
        {

            this.view = view;
            Validacija = new UlaznicaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniUlaznicu);
            validacija.Ulaznica = Ulaznica;

        }
        private UlaznicaIzmeniView view;
        private UlaznicaValidacija validacija;






        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public UlaznicaValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }




        public void Exit()
        {
            view.Close();
        }

        public void IzmeniUlaznicu()
        {
            Validacija.Validate();
            if (Validacija.IsValid)
            {
                UlaznicaDAO udao = new UlaznicaDAO();






                udao.Update(Validacija.Ulaznica);


                view.Close();
            }
        }
    }
}
