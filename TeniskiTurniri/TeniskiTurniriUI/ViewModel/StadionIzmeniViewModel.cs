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
    public class StadionIzmeniViewModel : BindableBase
    {
        public StadionIzmeniViewModel(StadionIzmeniView view, Stadion Stadion)
        {

            this.view = view;
            Validacija = new StadionValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniStadion);
            validacija.Stadion = Stadion;

        }
        private StadionIzmeniView view;
        private StadionValidacija validacija;






        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public StadionValidacija Validacija
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

        public void IzmeniStadion()
        {
            Validacija.Validate();
            if (Validacija.IsValid)
            {
                StadionDAO sdao = new StadionDAO();






                sdao.Update(Validacija.Stadion);


                view.Close();
            }
        }
    }
}
