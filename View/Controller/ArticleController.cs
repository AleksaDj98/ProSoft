﻿using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Forms;

namespace View.Controller
{
    public class ArticleController
    {
        static List<Proizvod> PomocnaLista;
        static BindingList<Proizvod> sviProizvodi;
        BindingList<Proizvod> istaLista = sviProizvodi;
        internal void CaluculateReadOnlyTexBox(ComboBox cbPDV, TextBox txtProdajnaCena, TextBox txtVrednostBezPDV, TextBox txtVrednostPDV)
        {
            if(!string.IsNullOrEmpty(txtProdajnaCena.Text) && cbPDV.SelectedItem != null)
            {
                PDV vrPDV = cbPDV.SelectedItem as PDV;
                int procPDV = vrPDV.ProcenatPDV;
                double prodajnaCena = int.Parse(txtProdajnaCena.Text);
                double vrednostPDV = prodajnaCena / 100 * procPDV;
                double vrednostBezPDV = prodajnaCena - vrednostPDV;

                txtVrednostPDV.Text = vrednostPDV.ToString();
                txtVrednostBezPDV.Text = vrednostBezPDV.ToString();
            }
        }

        internal bool CheckFild(TextBox txtNaziv, TextBox txtLager, TextBox txtProdajnaCena, ComboBox cbPDV, ComboBox cbVrstaProizvoda)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                txtNaziv.BackColor = Color.Salmon;
                txtNaziv.Focus();
                return false;
            }
            else
            {
                txtNaziv.BackColor = Color.White;
            }

            if (cbVrstaProizvoda.SelectedItem == null)
            {
                cbVrstaProizvoda.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                cbVrstaProizvoda.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(txtProdajnaCena.Text))
            {
                txtProdajnaCena.BackColor = Color.Salmon;
                txtLager.Focus();
                return false;
            }
            else
            {
                txtProdajnaCena.BackColor = Color.White;
            }

            if (cbPDV.SelectedItem == null)
            {
                cbPDV.BackColor = Color.Salmon;
                return false;
            }
            else
            {
                cbPDV.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(txtLager.Text))
            {
                txtLager.BackColor = Color.Salmon;
                txtLager.Focus();
                return false;
            }
            else
            {
                txtLager.BackColor = Color.White;
            }

            List<Proizvod> postojeciProizvodi = Communication.Communication.Instance.CheckArticle(txtNaziv);

            foreach(Proizvod p in postojeciProizvodi)
            {
                if (p.NazivProizvoda.ToLower().Equals( txtNaziv.Text.ToLower()))
                {
                    MessageBox.Show("Proizvod sa ovim imenom postoji");
                    return false;
                }
            }

           
            
            return true; 
        }

        internal void PopuniComboBox(FrmUnosArtikla frmUnosArtikla, ComboBox cbPDV, ComboBox cbVrsteProizvoda)
        {
            cbVrsteProizvoda.DataSource = Communication.Communication.Instance.GetAllProductVersion();
            cbPDV.DataSource =  Communication.Communication.Instance.GetAllPDVVersion();
        }

        internal void ProveriDaLiJeSelektovanoIObrisi(DataGridView dgvProizvodi, TextBox txtNazivProizvoda)
        {
            if (dgvProizvodi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molim vas selektujte zeljeni artikal");
                return;
            }

            Proizvod P = dgvProizvodi.SelectedRows[0].DataBoundItem as Proizvod;

            try
            {
                if (MessageBox.Show($"Da li ste sigurni da zelide da promenite status proizvoda : {P.NazivProizvoda}", "Potvrda o proeni statusa porizvoda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Communication.Communication.Instance.DeleteArtile(P);
                    MessageBox.Show($"Proizvodu {P.NazivProizvoda} je uspesno promenjen status");
                    txtNazivProizvoda.Text = "";
                    SetDGV(dgvProizvodi);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ne mozemo da promenimo status ovog proizvoda");
            }

        }

        internal void ProveriPoiljeIPretrazi(TextBox txtNazivProizvoda, DataGridView dgvProizvodi)
        {
            if (string.IsNullOrEmpty(txtNazivProizvoda.Text))
            {
                dgvProizvodi.DataSource = sviProizvodi;
                dgvProizvodi.ClearSelection();
                return;
            }
            dgvProizvodi.DataSource = sviProizvodi;
            List<Proizvod> pomocnaLista = PretraziProizvode(sviProizvodi,txtNazivProizvoda);
            dgvProizvodi.DataSource = pomocnaLista;
            dgvProizvodi.ClearSelection();
        }

        private List<Proizvod> PretraziProizvode(BindingList<Proizvod> sviProizvodi, TextBox txtNazivProizvoda)
        {
            return sviProizvodi.Where(p => p.NazivProizvoda.IndexOf(txtNazivProizvoda.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        internal void Save(TextBox txtNaziv, TextBox txtLager, TextBox txtProdajnaCena, TextBox txtVrednostBezPDV, TextBox txtVrednostPDV, ComboBox cbPDV, ComboBox cbVrstaProizvoda)
        { 
            try
            {
                Proizvod p = new Proizvod();
                p.NazivProizvoda = txtNaziv.Text;
                p.ProdajnaCena = int.Parse(txtProdajnaCena.Text);
                p.CenaBezPDV = float.Parse(txtVrednostBezPDV.Text);
                p.VrednostPDV = float.Parse(txtVrednostPDV.Text);
                PDV pdv = new PDV();
                pdv = cbPDV.SelectedItem as PDV;
                p.pdv = pdv;
                VrstaProizvoda vp = new VrstaProizvoda();
                vp = cbVrstaProizvoda.SelectedItem as VrstaProizvoda;
                p.VrstaProizvoda = vp;
                p.Aktivan = true;
                p.StanjeLagera = int.Parse(txtLager.Text);


                Communication.Communication.Instance.SaveProduct(p);
                MessageBox.Show("Proizvod je uspesno sacuvan!");
            }
            catch (Exception)
            {
                MessageBox.Show("Nije uspelo cuvanje novog proizvoda");
            }
        }

        internal void SetDGV(DataGridView dgvProizvodi)
        {
            if(dgvProizvodi.ColumnCount == 0)
            {
                dgvProizvodi.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn nazivProizvodaColumn = new DataGridViewTextBoxColumn();
                nazivProizvodaColumn.DataPropertyName = "NazivProizvoda";
                nazivProizvodaColumn.HeaderText = "Naziv proizvoda";
                dgvProizvodi.Columns.Add(nazivProizvodaColumn);

                DataGridViewTextBoxColumn ProdajnaCenaColumn = new DataGridViewTextBoxColumn();
                ProdajnaCenaColumn.DataPropertyName = "ProdajnaCena";
                ProdajnaCenaColumn.HeaderText = "Cena";
                dgvProizvodi.Columns.Add(ProdajnaCenaColumn);

                DataGridViewCheckBoxColumn aktivanColumn = new DataGridViewCheckBoxColumn();
                aktivanColumn.DataPropertyName = "Aktivan";
                aktivanColumn.HeaderText = "Akrivan";
                dgvProizvodi.Columns.Add(aktivanColumn);

                PomocnaLista = Communication.Communication.Instance.GetAllAricles();
                sviProizvodi = new BindingList<Proizvod>(PomocnaLista);
                dgvProizvodi.DataSource = sviProizvodi;
                dgvProizvodi.ClearSelection();
            }
            else
            {
                dgvProizvodi.DataSource = Communication.Communication.Instance.GetAllAricles();
                dgvProizvodi.ClearSelection();
            }
        }
    }
}
