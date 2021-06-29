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
    public class IgracIzmeniViewModel : BindableBase
    {
        private IgracIzmeniView view;
        private IgracValidacija validacija;




        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public IgracValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public IgracIzmeniViewModel(IgracIzmeniView view, Igrac igrac)
        {
            this.view = view;
            Validacija = new IgracValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniIgraca);
            validacija.Igrac = igrac;


        }

        public void Exit()
        {
            view.Close();
        }

        public void IzmeniIgraca()
        {
            Validacija.Validate();
            if (Validacija.IsValid)
            {
                IgracDAO idao = new IgracDAO();






                idao.Update(Validacija.Igrac);


                view.Close();
            }
        }
    }
}
