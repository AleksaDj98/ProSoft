using Domain;
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

namespace View.Forms
{
    public partial class FrmUnosArtikla : Form
    {
        ArticleController controller;
        Timer timer;
        public FrmUnosArtikla(ArticleController controller)
        {
            InitializeComponent();
            this.controller = controller;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
            txtLager.KeyPress += TextBox_KeyPress;
            txtProdajnaCena.KeyPress += TextBox_KeyPress;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            controller.CaluculateReadOnlyTexBox(cbPDV, txtProdajnaCena, txtVrednostBezPDV, txtVrednostPDV);
        }

        private void txtProdajnaCena_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmUnosArtikla_Load(object sender, EventArgs e)
        {
            controller.PopuniComboBox(this,cbPDV,cbVrstaProizvoda);
            cbVrstaProizvoda.SelectedItem = null;
            cbPDV.SelectedItem = null ;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (controller.CheckFild(txtNaziv, txtLager, txtProdajnaCena, cbPDV, cbVrstaProizvoda))
            {
                controller.Save(txtNaziv, txtLager, txtProdajnaCena, txtVrednostBezPDV, txtVrednostPDV, cbPDV, cbVrstaProizvoda);
            }
            
        }
    }
}
