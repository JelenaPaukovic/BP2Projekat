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
    public class NagradaIzmeniViewModel : BindableBase
    {
        public NagradaIzmeniViewModel(NagradaIzmeniView view, Nagrada Nagrada)
        {

            this.view = view;
            Validacija = new NagradaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniNagradu);
            validacija.Nagrada = Nagrada;

        }
        private NagradaIzmeniView view;
        private NagradaValidacija validacija;





        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public NagradaValidacija Validacija
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

        public void IzmeniNagradu()
        {
            Validacija.Validate();
            if (Validacija.IsValid)
            {
                NagradaDAO ndao = new NagradaDAO();






                ndao.Update(Validacija.Nagrada);


                view.Close();
            }
        }
    }
}
