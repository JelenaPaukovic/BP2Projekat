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
    public class OpremaIzmeniViewModel : BindableBase
    {
        public OpremaIzmeniViewModel(OpremaIzmeniView view, Oprema Oprema)
        {

            this.view = view;
            Validacija = new OpremaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniOpremu);
            validacija.Oprema = Oprema;

        }
        private OpremaIzmeniView view;
        private OpremaValidacija validacija;






        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public OpremaValidacija Validacija
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

        public void IzmeniOpremu()
        {
            Validacija.Validate();
            if (Validacija.IsValid)
            {
                OpremaDAO odao = new OpremaDAO();






                odao.Update(Validacija.Oprema);


                view.Close();
            }
        }
    }
}
