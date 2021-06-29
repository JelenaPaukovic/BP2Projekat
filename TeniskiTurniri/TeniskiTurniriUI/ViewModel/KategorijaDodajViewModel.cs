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
    public class KategorijaDodajViewModel  : BindableBase
    {

        private KategorijaDodajView view;
        private KategorijaValidacija validacija;




        public ICommand ExitCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public KategorijaValidacija Validacija
        {
            get { return validacija; }
            set
            {
                validacija = value;
                OnPropertyChanged("Validacija");
            }
        }


        public KategorijaDodajViewModel(KategorijaDodajView view)
        {
            this.view = view;
            Validacija = new KategorijaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            AddCommand = new MyICommand(this.DodajKategoriju);


        }

        public void Exit()
        {
            view.Close();
        }

        public void DodajKategoriju()
        {
             Validacija.Validate();
            if (Validacija.IsValid)
            {
                KategorijaDAO kdao = new KategorijaDAO();
                

                kdao.Insert(Validacija.Kategorija);


                view.Close();
            }
        }

    }
}
