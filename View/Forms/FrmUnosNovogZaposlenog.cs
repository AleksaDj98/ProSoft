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
    public partial class FrmUnosNovogZaposlenog : Form
    {
        public EmployeController sacuvajZaposlenog;
        public TextBox TextIme { get => txtIme; }
        public TextBox TextSifra { get => txtSifra; }
        public CheckBox ChbAdmin { get=>chbAdmin; }

        public FrmUnosNovogZaposlenog()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            sacuvajZaposlenog = new EmployeController();
            sacuvajZaposlenog.SacuvajZaposlenog(TextIme, TextSifra,ChbAdmin);
        }

        private void FrmUnosNovogZaposlenog_Load(object sender, EventArgs e)
        {

        }

        private void txtSifra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
