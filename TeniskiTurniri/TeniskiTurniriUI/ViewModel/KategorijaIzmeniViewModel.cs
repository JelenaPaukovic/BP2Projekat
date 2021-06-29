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
    public class KategorijaIzmeniViewModel : BindableBase
    {
        public KategorijaIzmeniViewModel(KategorijaIzmeniView view, Kategorija Kategorija)
        {

            this.view = view;
            Validacija = new KategorijaValidacija();

            ExitCommand = new MyICommand(this.Exit);
            EditCommand = new MyICommand(this.IzmeniKategoriju);
            validacija.Kategorija = Kategorija;

        }
        private KategorijaIzmeniView view;
        private KategorijaValidacija validacija;


      



        public ICommand ExitCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public KategorijaValidacija Validacija
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

        public void IzmeniKategoriju()
        {
            Validacija.Validate();
            if (Validacija.IsValid)
            {

                KategorijaDAO kdao = new KategorijaDAO();

                kdao.Update(Validacija.Kategorija);


                view.Close();
            }
        }
    }
}
