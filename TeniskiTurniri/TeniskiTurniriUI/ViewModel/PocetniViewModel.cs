using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeniskiTurniriUI.Model;
using TeniskiTurniriUI.View;

namespace TeniskiTurniriUI.ViewModel
{
    public class PocetniViewModel : BindableBase
    {
        public ICommand TurnirCommand { get; set; }
        public ICommand UlaznicaCommand { get; set; }
        public ICommand NagradaCommand { get; set; }
        public ICommand GledalacCommand { get; set; }
        public ICommand IgracCommand { get; set; }
        public ICommand KategorijaCommand { get; set; }
        public ICommand KoloCommand { get; set; }
        public ICommand MecCommand { get; set; }
        public ICommand OdrzavanjeCommand { get; set; }
        public ICommand OpremaCommand { get; set; }
        public ICommand OrganizatorCommand { get; set; }
        public ICommand StadionCommand { get; set; }
        public ICommand VipUlaznicaCommand { get; set; }
        public ICommand ObicnaUlaznicaCommand { get; set; }
        public ICommand UcestvujeCommand { get; set; }
        public ICommand ProdajeCommand { get; set; }

        public ICommand FunkcijaCommand { get; set; }

        public PocetniViewModel()
        {
            TurnirCommand = new MyICommand(OtvoriTurnir, CanTurnir);
            UlaznicaCommand = new MyICommand(OtvoriUlaznicu, CanUlaznica);
            NagradaCommand = new MyICommand(OtvoriNagradu, CanNagrada);
            GledalacCommand = new MyICommand(OtvoriGledaoca, CanGledalac);
            IgracCommand = new MyICommand(OtvoriIgraca, CanIgrac);
            KategorijaCommand = new MyICommand(OtvoriKategoriju, CanKategorija);
            KoloCommand = new MyICommand(OtvoriKolo, CanKolo);
            MecCommand = new MyICommand(OtvoriMec, CanMec);
            OdrzavanjeCommand = new MyICommand(OtvoriOdrzavanje, CanOdrzavanje);
            OpremaCommand = new MyICommand(OtvoriOpremu, CanOprema);
            OrganizatorCommand = new MyICommand(OtvoriOrganizatora, CanOrganizator);
            StadionCommand = new MyICommand(OtvoriStadion, CanStadion);
            VipUlaznicaCommand = new MyICommand(OtvoriVipUlaznicu, CanVipUlaznica);
            ObicnaUlaznicaCommand = new MyICommand(OtvoriObicnuUlaznicu, CanObicnaUlaznica);
            UcestvujeCommand = new MyICommand(OtvoriUcestvuje, CanProdaje);
            ProdajeCommand = new MyICommand(OtvoriProdaje, CanProdaje);
            FunkcijaCommand = new MyICommand(OtvoriFunkciju, CanFunkcija);

        }


        public bool CanTurnir()
        {
            return true;
        }

        public void OtvoriTurnir()
        {
            TurnirView newView = new TurnirView();
            newView.DataContext = new TurnirViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanUlaznica()
        {
            return true;
        }

        public void OtvoriUlaznicu()
        {
            UlaznicaView newView = new UlaznicaView();
            newView.DataContext = new UlaznicaViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanNagrada()
        {
            return true;
        }

        public void OtvoriNagradu()
        {
            NagradaView newView = new NagradaView();
            newView.DataContext = new NagradaViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanGledalac()
        {
            return true;
        }

        public void OtvoriGledaoca()
        {
            GledalacView newView = new GledalacView();
            newView.DataContext = new GledalacViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanIgrac()
        {
            return true;
        }

        public void OtvoriIgraca()
        {
            IgracView newView = new IgracView();
            newView.DataContext = new IgracViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanKategorija()
        {
            return true;
        }

        public void OtvoriKategoriju()
        {
            KategorijaView newView = new KategorijaView();
            newView.DataContext = new KategorijaViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanKolo()
        {
            return true;
        }

        public void OtvoriKolo()
        {
            KoloView newView = new KoloView();
            newView.DataContext = new KoloViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanMec()
        {
            return true;
        }

        public void OtvoriMec()
        {
            MecView newView = new MecView();
            newView.DataContext = new MecViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanOdrzavanje()
        {
            return true;
        }

        public void OtvoriOdrzavanje()
        {
            OdrzavanjeView newView = new OdrzavanjeView();
            newView.DataContext = new OdrzavanjeViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanOprema()
        {
            return true;
        }

        public void OtvoriOpremu()
        {
            OpremaView newView = new OpremaView();
            newView.DataContext = new OpremaViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanOrganizator()
        {
            return true;
        }

        public void OtvoriOrganizatora()
        {
            OrganizatorView newView = new OrganizatorView();
            newView.DataContext = new OrganizatorViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanStadion()
        {
            return true;
        }

        public void OtvoriStadion()
        {
            StadionView newView = new StadionView();
            newView.DataContext = new StadionViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanVipUlaznica()
        {
            return true;
        }

        public void OtvoriVipUlaznicu()
        {
            VipUlaznicaView newView = new VipUlaznicaView();
            newView.DataContext = new VipUlaznicaViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanObicnaUlaznica()
        {
            return true;
        }

        public void OtvoriObicnuUlaznicu()
        {
            ObicnaUlaznicaView newView = new ObicnaUlaznicaView();
            newView.DataContext = new ObicnaUlaznicaViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanUcestvuje()
        {
            return true;
        }

        public void OtvoriUcestvuje()
        {
            UcestvujeView newView = new UcestvujeView();
            newView.DataContext = new UcestvujeViewModel(newView);
            newView.ShowDialog();
        }

        public bool CanProdaje()
        {
            return true;
        }

        public void OtvoriProdaje()
        {
            ProdajeView newView = new ProdajeView();
            newView.DataContext = new ProdajeViewModel(newView);
            newView.ShowDialog();
        }


        public bool CanFunkcija()
        {
            return true;
        }

        public void OtvoriFunkciju()
        {
            FunkcijaView newView = new FunkcijaView();
            newView.DataContext = new FunkcijaViewModel(newView);
            newView.ShowDialog();
        }
    }
}
