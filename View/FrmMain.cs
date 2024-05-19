using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;
using View.UserControls;

namespace View
{
    public partial class FrmMain : Form
    {
        private readonly MainController controller;
        private MainCoordinator instance;
        private UserControl uc;

        public FrmMain(MainController controller, MainCoordinator instance)
        {
            InitializeComponent();
            this.controller = controller;
            this.instance = instance;
            this.Text = $"Konobar: {instance.zaposleni.ImeZaposlenog}";
            this.Load += FrmMain_Load;
           
        }
        public void SetPanel(UserControl userControl)
        {
            uc = userControl;
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock= DockStyle.Fill;
            //userControl.Dispose();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            controller.proveriKorisnika(cenovnikToolStripMenuItem,ZaposleniToolStripMenuItem,instance,this);
            controller.otvoriUCUnosPorudzbine(this);
        }

        private void unosNovogZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.otvoriFormuUnosZaposlenog();
        }

        private void unosNovogArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.otvoriFormuUnosArtikla();
        }

        private void brisanjeZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.otvoriFormuBrisanjeRadnika();
        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {

        }

        internal void RasporedStolova(OrderControler orderControler)
        {
            controller.otvoriUCRasporedStolova(this,orderControler);
        }

        internal void OtvoriUnosPorudzbine()
        {
            controller.otvoriUCUnosPorudzbine(this);
        }

        private void pregledArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.otvoriFrmBrisanjeArtikla();
        }

        private void dnevniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.otvoriDnevniIzvestaj();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        { 
            MainController.CloseMainForm();
        }

        private void lagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainController.otvoriFrmLager();
        }
    }
}
