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
        UCUnosPorudzbine unosPorudzbine;

        public FrmMain(MainController controller)
        {
            InitializeComponent();
            this.controller = controller;
           
        }
        public void SetPanel(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Parent = pnlMain;
            userControl.Dock= DockStyle.Fill;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

    }
}
