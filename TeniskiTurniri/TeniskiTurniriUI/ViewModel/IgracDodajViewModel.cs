using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeniskiTurniri.dao;
using TeniskiTurniriUI.Model;
using TeniskiTurniriUI.View;

namespace TeniskiTurniriUI.ViewModel
{
    public class IgracDodajViewModel : BindableBase
    {
        private IgracDodajView view;
        private IgracValidacija validacija;




        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public IgracValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public IgracDodajViewModel(IgracDodajView view)
        {
            this.view = view;
            Validacija = new IgracValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajIgraca);


        }

        public void Exit()
        {
            view.Close();
        }

        public void DodajIgraca()
        {
            // Validacija.Validate();
            // if (Validacija.IsValid)
            {
                IgracDAO idao = new IgracDAO();






                idao.Insert(Validacija.Igrac);


                view.Close();
            }
        }
    }
}
