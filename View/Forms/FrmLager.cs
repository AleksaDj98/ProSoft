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
    public partial class FrmLager : Form
    {
        LagerController lagerCotnroller;

        public FrmLager()
        {
            InitializeComponent();
            lagerCotnroller = new LagerController();
            lagerCotnroller.SetDGV(dgvProizvodi);
            dgvProizvodi.ClearSelection();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rbNabavka_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            lagerCotnroller.Pretrazi(txtPretraga, dgvProizvodi);
        }

        private void txtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPromenaStanja_Click(object sender, EventArgs e)
        {
            if (lagerCotnroller.ProveriPolja(dgvProizvodi, rbNabavka, rbRashod, txtKolicina))
            {
                lagerCotnroller.PromeniStanjeLagera(dgvProizvodi, rbNabavka, rbRashod, txtKolicina);
            }

        }

        private void FrmLager_Load(object sender, EventArgs e)
        {

        }
    }
}
