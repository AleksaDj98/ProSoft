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
    public class SaveEmployeController
    {
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
