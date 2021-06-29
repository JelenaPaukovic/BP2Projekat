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
    public class StadionDodajViewModel : BindableBase
    {
        private StadionDodajView view;
        private StadionValidacija validacija;




        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public StadionValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public StadionDodajViewModel(StadionDodajView view)
        {
            this.view = view;
            Validacija = new StadionValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajStadion);


        }

        public void Exit()
        {
            view.Close();
        }

        public void DodajStadion()
        {
            // Validacija.Validate();
            // if (Validacija.IsValid)
            {
                StadionDAO sdao = new StadionDAO();






                sdao.Insert(Validacija.Stadion);


                view.Close();
            }
        }
    }
}
