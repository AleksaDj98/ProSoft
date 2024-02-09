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

        internal void otvoriUCUnosPorudzbine(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUnosPorudzbine(new OrderControler()));
        }

        internal void otvoriFormuUnosZaposlenog()
        {
            FrmUnosNovogZaposlenog zaposleni = new FrmUnosNovogZaposlenog();
            zaposleni.ShowDialog();
        }

        internal void proveriKorisnika(ToolStripMenuItem cenovnikToolStripMenuItem, ToolStripMenuItem zaposleniToolStripMenuItem, MainCoordinator instance)
        {
            if(instance.zaposleni.Tip.TipID != 1)
            {
                cenovnikToolStripMenuItem.Visible = false;
                zaposleniToolStripMenuItem.Visible = false;
            }
            else
            {
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
            FrmBrisanjeRadnika radnik = new FrmBrisanjeRadnika(new EmployeController());
            radnik.ShowDialog();
        }
    }
}
