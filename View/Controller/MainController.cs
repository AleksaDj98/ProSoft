using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Forms;
using View.UserControls;

namespace View.Controller
{
    public class MainController
    {
        static UCUnosPorudzbine UnosPorudzbine;
        USRasporedStolova RasporedStolova;


        internal void otvoriUCUnosPorudzbine(FrmMain frmMain)
        {
            if(UnosPorudzbine == null)
            {
                UnosPorudzbine = new UCUnosPorudzbine(new OrderControler(frmMain));
                frmMain.SetPanel(UnosPorudzbine);
            }
            else
            {
                frmMain.SetPanel(UnosPorudzbine);
            }
        }

        internal void otvoriFormuUnosZaposlenog()
        {
            FrmUnosNovogZaposlenog zaposleni = new FrmUnosNovogZaposlenog();
            zaposleni.ShowDialog();
        }

        internal void proveriKorisnika(ToolStripMenuItem cenovnikToolStripMenuItem, ToolStripMenuItem zaposleniToolStripMenuItem, MainCoordinator instance, FrmMain frmMain)
        {
            if(instance.zaposleni.Tip.TipID != 1)
            {
                frmMain.Text = $"Radnik: {MainCoordinator.Instance.zaposleni.ImeZaposlenog}";
                cenovnikToolStripMenuItem.Visible = false;
                zaposleniToolStripMenuItem.Visible = false;
            }
            else
            {
                frmMain.Text = $"Admin: {MainCoordinator.Instance.zaposleni.ImeZaposlenog}";
                cenovnikToolStripMenuItem.Visible = true;
                zaposleniToolStripMenuItem.Visible = true;
            }
        }

        internal void otvoriFormuUnosArtikla()
        {
            FrmUnosArtikla artikal = new FrmUnosArtikla(new ArticleController());
            artikal.ShowDialog();
        }

        internal void otvoriFormuBrisanjeRadnika()
        {
            FrmPromenaStatusaRadnika radnik = new FrmPromenaStatusaRadnika(new EmployeController());
            radnik.ShowDialog();
        }

        internal void otvoriUCRasporedStolova(FrmMain frmMain,OrderControler orderController)
        {
            if(RasporedStolova == null)
            {
                RasporedStolova = new USRasporedStolova(orderController);
                frmMain.SetPanel(RasporedStolova);
            }
            else
            {
                frmMain.SetPanel(RasporedStolova);
            }
        }

        internal void otvoriFrmBrisanjeArtikla()
        {
            FrmBrisanjeArtikla ba = new FrmBrisanjeArtikla();
            ba.ShowDialog();
        }

        internal void otvoriDnevniIzvestaj()
        {
            FrmDnevniIzvestaj di = new FrmDnevniIzvestaj();
            di.ShowDialog();
        }

        internal static void CloseMainForm()
        {
            UnosPorudzbine = null;
            Communication.Communication.Instance.Disconnect();
            MainCoordinator.Instance.OpenLoginForm();
        }
    }
}
