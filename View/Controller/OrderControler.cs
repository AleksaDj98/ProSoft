using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.UserControls;

namespace View.Controller
{
    public class OrderControler
    {
        BindingList<StavkaPorudzbine> porudzbina = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> PorudzbineNaStolu = new BindingList<StavkaPorudzbine>();
        Racun LokalniRacun;



        BindingList<StavkaPorudzbine> proizvodi = new BindingList<StavkaPorudzbine>();
        List<Proizvod> proizvodiLista;
        private FrmMain frmMain;

        public OrderControler(FrmMain frmMain)
        {
            this.frmMain = frmMain;
        }

        internal void addArticle(Button button, Label labelUkupnaCena)
        {
            foreach (Proizvod  pro in proizvodiLista) 
            { 
                if(pro.NazivProizvoda == button.Text)
                {
                    Proizvod p = pro;
                    StavkaPorudzbine sr = new StavkaPorudzbine();
                    sr.Naziv = button.Text;
                    sr.Proizvod = p;
                    sr.Cena = p.ProdajnaCena;
                    sr.Kolicina = 1;
                    DodajArtikal(sr,labelUkupnaCena);
                }
            }
        }
        private void DodajArtikal(StavkaPorudzbine sr, Label labelUkupnaCena)
        {
            var postojecaStavka = proizvodi.FirstOrDefault(c => c.Naziv == sr.Naziv);
            if (postojecaStavka != null)
            {
                postojecaStavka.Kolicina = postojecaStavka.Kolicina + 1;
                postojecaStavka.Cena = sr.Proizvod.ProdajnaCena * postojecaStavka.Kolicina;
                proizvodi.Remove(postojecaStavka);
                proizvodi.Add(postojecaStavka);
            }
            else
            {
                proizvodi.Add(sr);
            }
            int ukupnaCena = 0;
            foreach (StavkaPorudzbine srr in proizvodi)
            {
                ukupnaCena = ukupnaCena + srr.Cena;
            }

            labelUkupnaCena.Text = ukupnaCena.ToString();
        }

        internal void ponistiPorudzbin()
        {
            proizvodi.Clear();
        }

        internal void SetButtonsInGroupBox(GroupBox gpProizvodi)
        {
            foreach (Button btn in gpProizvodi.Controls)
            {
                btn.Visible = false;
            }

           proizvodiLista = Communication.Communication.Instance.GetAllAricles();
            

            for (int i = 0; i < Math.Min(proizvodiLista.Count,gpProizvodi.Controls.Count); i++)
            {
                gpProizvodi.Controls[i].Text = proizvodiLista[i].NazivProizvoda;
                gpProizvodi.Controls[i].Visible = true;
            }
        }

        internal void setDGV(DataGridView dataGridView1)
        {
            dataGridView1.DataSource = proizvodi;
        }

        internal void OtvoriUCRasporedStolova()
        {
            if(proizvodi.Count == 0)
            {
                MessageBox.Show("Unesite proizvod kako biste mogli da kreirate poruzbinu ");
                return;
            }

            OtvoriUCRasporedStolovaZaStampuRacuna();

        }

        internal void OtvoriUCRasporedStolovaZaStampuRacuna() => frmMain.RasporedStolova(this);

        internal void OtvoriUCUnosPorudzbine() => frmMain.OtvoriUnosPorudzbine();

        internal bool proveriListu()
        {
            if(proizvodi.Count > 0)
            {
                return true;
            }
            return false;
        }

        internal BindingList<StavkaPorudzbine> postaviPorudzbinu(BindingList<StavkaPorudzbine> sto, Sto Sto,Racun r)
        {
            try
            {
                Porudzbina p = new Porudzbina();
                p.PorudzbinaID = Communication.Communication.Instance.GetOrderID();
                p.ZaposleniID = MainCoordinator.Instance.zaposleni;
                p.StoID = Sto;
                p.VremePorudzbine = DateTime.Now;
                p.StavkaPorudzbine = sto.ToList();
                p.Cena = 0;
                if (r == null)
                {
                    r = new Racun();
                    r.RacunID = Communication.Communication.Instance.GetInvoiceID();
                    r.VremeIzdavanja = DateTime.Now;
                    Communication.Communication.Instance.SaveInvoiceID(r);
                }
                p.R = r;

                foreach (StavkaPorudzbine stavkaPorudzbine in proizvodi)
                {
                    stavkaPorudzbine.PorudzbinaID = p.PorudzbinaID;
                    p.Cena = p.Cena + stavkaPorudzbine.Cena;
                    stavkaPorudzbine.Porudzbina = p;
                    sto.Add(stavkaPorudzbine);
                }

                Communication.Communication.Instance.SaveOrder(p);

                foreach (StavkaPorudzbine sp in sto)
                {
                    Communication.Communication.Instance.SaveOrderItem(sp);
                }
                MessageBox.Show($"Porudzbina je uspesno postavljena na sto {Sto.StoID}");
                proizvodi.Clear();
                OtvoriUCUnosPorudzbine();
                return sto;
            }
            catch (Exception)
            {
                MessageBox.Show("Greska prilikom postavljanja porudzbine");
                throw;
            }
        }
        internal void setDGVInRasporedStolova(BindingList<StavkaPorudzbine> sto, DataGridView dgvPregledPorudzbina, Button btnStampaj, Racun r)
        {
            if (sto.Count > 0)
            {
                btnStampaj.Enabled = true;
            }
            else
            {
                btnStampaj.Enabled = false;
            }
            PorudzbineNaStolu = sto;
            LokalniRacun = r;
            dgvPregledPorudzbina.DataSource = sto;
        }

        internal void obrisiArtikalIzPorudzbine(DataGridView dgwPorudzbina)
        {
            StavkaPorudzbine sp =  dgwPorudzbina.SelectedRows[0].DataBoundItem as StavkaPorudzbine;
            proizvodi.Remove(sp);
        }

        internal void stamampajRacun(DataGridView dgvPregledPorudzbina)
        {
            List<StavkaPorudzbine> proizvodiZaRacun = new List<StavkaPorudzbine>();

            foreach (DataGridViewRow dgv in dgvPregledPorudzbina.Rows)
            {
                StavkaPorudzbine s = dgv.DataBoundItem as StavkaPorudzbine;
                proizvodiZaRacun.Add(s);
            }
            Porudzbina por = new Porudzbina();
            por.PorudzbinaID = proizvodiZaRacun[0].Porudzbina.PorudzbinaID;
            List<Porudzbina> p = Communication.Communication.Instance.GetAllOrders();

            for (int i = 0; i < p.Count; i++)
            {
                if(por.PorudzbinaID == p[i].PorudzbinaID)
                {
                    por = p[i];
                    break;
                }
            }
            Racun r = por.R;
            r.VremeIzdavanja = DateTime.Now;
            r.CenaRacuna = 0;

            for (int i = 0; i < proizvodiZaRacun.Count; i++)
            {
                r.CenaRacuna = r.CenaRacuna + proizvodiZaRacun[i].Cena;
            }

            try
            {
                Communication.Communication.Instance.SaveInvoice(r);
                MessageBox.Show($"Ukupan racun za naplatu je: {r.CenaRacuna}");
                LokalniRacun = null;
                PorudzbineNaStolu.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Greska prilikom stampanja racuna");
                throw;
            }



        }
    }
}
