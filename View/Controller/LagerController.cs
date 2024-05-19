using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Controller
{
    internal class LagerController
    {
        List<Proizvod> sviProizvodi = Communication.Communication.Instance.GetAllAricles();
        internal void Pretrazi(TextBox txtPretraga, DataGridView dgvProizvodi)
        {
            if (string.IsNullOrEmpty(txtPretraga.Text))
            {
                dgvProizvodi.DataSource =sviProizvodi;
                dgvProizvodi.ClearSelection();
                return;
            }
            dgvProizvodi.DataSource = sviProizvodi;
            List<Proizvod> pomocnaLista = PretraziProizvode(sviProizvodi, txtPretraga);
            
            dgvProizvodi.DataSource = pomocnaLista;
            dgvProizvodi.ClearSelection();
        }

        private List<Proizvod> PretraziProizvode(List<Proizvod> sviProizvodi, TextBox txtPretraga)
        {
            return sviProizvodi.Where(p => p.NazivProizvoda.IndexOf(txtPretraga.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        internal void setDGV(DataGridView dgvProizvodi)
        {
            if(dgvProizvodi.ColumnCount == 0)
            {
                dgvProizvodi.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn nazivProizvodaColumn = new DataGridViewTextBoxColumn();
                nazivProizvodaColumn.DataPropertyName = "NazivProizvoda";
                nazivProizvodaColumn.HeaderText = "Naziv proizvoda";
                dgvProizvodi.Columns.Add(nazivProizvodaColumn);

                DataGridViewTextBoxColumn stanjeLageraColumn = new DataGridViewTextBoxColumn();
                stanjeLageraColumn.DataPropertyName = "StanjeLagera";
                stanjeLageraColumn.HeaderText = "Stanje lagera";
                dgvProizvodi.Columns.Add(stanjeLageraColumn);

                dgvProizvodi.DataSource = Communication.Communication.Instance.GetAllAricles();
                dgvProizvodi.ClearSelection();
            }
            else
            {
                dgvProizvodi.DataSource = Communication.Communication.Instance.GetAllAricles();
                dgvProizvodi.ClearSelection();
            }
        }

        internal void PromeniStanjeLagera(DataGridView dgvProizvodi, RadioButton rbNabavka, RadioButton rbRashod, TextBox txtKolicina)
        {
            try
            {
                int kolicina = Convert.ToInt32(txtKolicina.Text);
                Proizvod p = new Proizvod();
                p = dgvProizvodi.SelectedRows[0].DataBoundItem as Proizvod;

                if (rbNabavka.Checked)
                {
                    p.Uslov = $"set stanjeLagera = stanjeLagera +{kolicina}";
                    Communication.Communication.Instance.ChangeLager(p);
                    MessageBox.Show($"Uspesno ste uneli nabavku od {kolicina} komada za proizvod: {p.NazivProizvoda}\n\nTrenutno stanje lagera: {p.StanjeLagera+kolicina}");
                    setDGV(dgvProizvodi);
                }
                else
                {
                    p.Uslov = $"set stanjeLagera = stanjeLagera - {kolicina}";
                    Communication.Communication.Instance.ChangeLager(p);
                    MessageBox.Show($"Uspesno ste rashodovali kolicunu od {kolicina} komada za proizvod: {p.NazivProizvoda}\n\nTrenutno stanje lagera: {p.StanjeLagera - kolicina}");
                    setDGV(dgvProizvodi);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greska prilikom promene stanja lagera");
            }
        }

        internal bool proveriPolja(DataGridView dgvProizvodi, RadioButton rbNabavka, RadioButton rbRashod, TextBox txtKolicina)
        {
            if (dgvProizvodi.SelectedRows.Count == 0)
            {
                dgvProizvodi.GridColor = Color.Salmon;
                MessageBox.Show("Molim vas selektujte proizvod za koji hocete da promenite stanje!");
                return false;
            }
            else
            {
                dgvProizvodi.GridColor = SystemColors.ControlDark;
            }
            if (rbNabavka.Checked == true || rbRashod.Checked == true)
            {
                rbNabavka.ForeColor = Color.Black;
                rbRashod.ForeColor = Color.Black;
            }
            else
            {
                rbRashod.ForeColor = Color.Salmon;
                rbNabavka.ForeColor = Color.Salmon;
                MessageBox.Show("Molim vas izaberite koji tip promene stanja lagera zelite da primenite");
                return false;
            }
            if (string.IsNullOrEmpty(txtKolicina.Text))
            {
                txtKolicina.BackColor = Color.Salmon;
                MessageBox.Show("Molim vas unesite kolicinu");
                return false;
            }
            else
            {
                txtKolicina.BackColor = Color.White;
            }
            return true;
        }
    }
}
