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
    public partial class FrmBrisanjeRadnika : Form
    {
        EmployeController controller;
        public FrmBrisanjeRadnika(EmployeController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        private void FrmBrisanjeRadnika_Load(object sender, EventArgs e)
        {

        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            controller.proveriSifru(txtSifra,txtIme,txtPrivilegije);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            controller.Obrisi(txtSifra);
        }
    }
}
