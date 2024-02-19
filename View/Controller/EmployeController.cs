using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Controller
{
    public class EmployeController
    {
        public List<Zaposleni> sviZaposleni = new List<Zaposleni>();
        public Zaposleni zap;

        internal void Obrisi(TextBox txtSifra)
        {

            if (string.IsNullOrEmpty(txtSifra.Text))
            {
                txtSifra.BackColor = Color.Salmon;
                txtSifra.Focus();
                return;
            }
            txtSifra.BackColor= Color.White;

            try
            {
                if (MessageBox.Show($"Da li ste sigurni da zelide da izbrisete zaposlenog : {this.zap.ImeZaposlenog}", "Potvrda o brisanju radnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Communication.Communication.Instance.DeleteEmploye(zap);
                    MessageBox.Show("Radnik je uspesno obrisan");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ne mozemo da izbrisemo radnika");
            }
        }


        internal void  proveriSifru(TextBox txtSifra, TextBox txtIme, TextBox txtPrivilegije)
        {
            if (string.IsNullOrEmpty(txtSifra.Text))
            {
                txtSifra.BackColor = Color.Salmon;
                txtSifra.Focus();
                return;
            }

            if (MainCoordinator.Instance.zaposleni.SifraLogovanja == txtSifra.Text)
            {
                MessageBox.Show("Ne mozete da obrisete sami svoj nalog!");
                return;
            }

            sviZaposleni = Communication.Communication.Instance.PronadjiZaposlenog(txtSifra.Text);

      

            foreach (Zaposleni z in sviZaposleni)
            {
                if (z.SifraLogovanja.Equals(txtSifra.Text))
                {
                    zap = z;
                    break;
                }
            }

            if (zap ==  null)
            {
                MessageBox.Show("Zaposleni za ovom sifrom ne postoji!");
                return;
            }

            txtIme.Text = zap.ImeZaposlenog;
            if (zap.Tip.Ovlascenje)
            {
                txtPrivilegije.Text = "Admin";
            }
            else
            {
                txtPrivilegije.Text = "Zaposleni";
            }
        }

        internal void sacuvajZaposlenog(TextBox textIme, TextBox textSifra, CheckBox chbAdmin)
        {
            if (string.IsNullOrEmpty(textIme.Text))
            {
                textIme.BackColor = Color.Salmon;
                textIme.Focus();
                return;
            }

            if (string.IsNullOrEmpty(textSifra.Text) || Communication.Communication.Instance.ProveriSifru(textSifra))
            {
                textSifra.BackColor = Color.Salmon;
                textSifra.Focus();
                return;
            }

            try
            {
                Zaposleni zap = new Zaposleni();
                zap.ImeZaposlenog = textIme.Text;
                zap.SifraLogovanja = textSifra.Text;
                zap.Tip = new TipZaposlenog();
                if(chbAdmin.Checked)
                {
                    zap.Tip.TipID = 1;
                }
                else
                {
                    zap.Tip.TipID = 0;
                }

                Communication.Communication.Instance.SaveEmploye(zap);
                MessageBox.Show("Novi zaposleni je kreiran");
            }
            catch (Exception)
            {
                MessageBox.Show("Trenutno nije moguce kreirati novog zaposlenog");
            }
        }


    }
}
