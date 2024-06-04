using Domain;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using View.ButtonGenerator;
using View.PDFGenerator;

namespace View.Controller
{
    public class OrderControler
    {
        BindingList<StavkaPorudzbine> porudzbina = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> PorudzbineNaStolu = new BindingList<StavkaPorudzbine>();
        private List<StavkaPorudzbine> proizvodiZaRacun = new List<StavkaPorudzbine>();
        int ukupnoNaStolu = 0;
        Label lokalnilabel;
        BindingList<StavkaPorudzbine> proizvodi = new BindingList<StavkaPorudzbine>();
        List<Proizvod> proizvodiLista = Communication.Communication.Instance.GetAllAricles();
        private FrmMain frmMain;

        public OrderControler(FrmMain frmMain)
        {
            this.frmMain = frmMain;
        }
        internal void PostaviTabove(FlowLayoutPanel flp1, FlowLayoutPanel flp2, FlowLayoutPanel flp3, FlowLayoutPanel flp4, FlowLayoutPanel flp41, FlowLayoutPanel flp5, FlowLayoutPanel flp6, Label lblUC)
        {
            lokalnilabel = lblUC;
            foreach (Proizvod p in proizvodiLista)
            {
                if (p.Aktivan == true)
                {
                    switch (p.VrstaProizvoda.VrstaProizvodaID)
                    {
                        case 1: GenerisiDugmeZaProizvod(p, flp1); break;
                        case 2: GenerisiDugmeZaProizvod(p, flp2); break;
                        case 3: GenerisiDugmeZaProizvod(p, flp3); break;
                        case 4: GenerisiDugmeZaProizvod(p, flp4); break;
                        case 5: GenerisiDugmeZaProizvod(p, flp5); break;
                        case 6: GenerisiDugmeZaProizvod(p, flp6); break;
                        default: break;
                    }
                }
            }
        }

        private void GenerisiDugmeZaProizvod(Proizvod p, FlowLayoutPanel flp)
        {
            var button = new CustomButton();
            button.Width = 230;
            button.Height = 52;
            button.Tag = p;
            button.p = p;
            button.Click += Button_Click;
            button.Text = p.NazivProizvoda;

            flp.Controls.Add(button);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as CustomButton;
            Proizvod p = button.p;
            StavkaPorudzbine sr = new StavkaPorudzbine();
            sr.Naziv = button.Text;
            sr.Proizvod = p;
            sr.Cena = p.ProdajnaCena;
            sr.Kolicina = 1;
            DodajArtikal(sr, lokalnilabel);
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

        internal void PonistiPorudzbinu(Label labelUkupnaCena)
        {
            proizvodi.Clear();
            labelUkupnaCena.Text = "0";
        }

        internal void SetDGV(DataGridView dataGridView1)
        {
            dataGridView1.DataSource = proizvodi;
        }

        internal void OtvoriUCRasporedStolova()
        {
            if (proizvodi.Count == 0)
            {
                MessageBox.Show("Unesite proizvod kako biste mogli da kreirate poruzbinu ");
                return;
            }

            OtvoriUCRasporedStolovaZaStampuRacuna();

        }

        internal void OtvoriUCRasporedStolovaZaStampuRacuna() => frmMain.RasporedStolova(this);

        internal void OtvoriUCUnosPorudzbine() => frmMain.OtvoriUnosPorudzbine();

        internal bool ProveriListu()
        {
            if (proizvodi.Count > 0)
            {
                return true;
            }
            return false;
        }
        internal BindingList<StavkaPorudzbine> PostaviPorudzbinu(BindingList<StavkaPorudzbine> sto, Sto Sto)
        {
            try
            {
                Porudzbina p = new Porudzbina();
                p.PorudzbinaID = Communication.Communication.Instance.GetOrderID();
                p.ZaposleniID = MainCoordinator.Instance.zaposleni;
                p.StoID = Sto;
                p.VremePorudzbine = DateTime.Now;
                p.StavkaPorudzbine = proizvodi.ToList();

                foreach (StavkaPorudzbine stavkaPorudzbine in proizvodi)
                {
                    p.Cena = p.Cena + stavkaPorudzbine.Cena;
                    stavkaPorudzbine.Porudzbina = p;
                    sto.Add(stavkaPorudzbine);
                }

                ukupnoNaStolu += p.Cena;

                Communication.Communication.Instance.SaveOrder(p);

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
        internal void SetDGVInRasporedStolova(BindingList<StavkaPorudzbine> sto, DataGridView dgvPregledPorudzbina, Button btnStampaj, Label label1)
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
            ukupnoNaStolu = 0;
            foreach (StavkaPorudzbine sp in sto)
            {
                ukupnoNaStolu = ukupnoNaStolu + sp.Cena;
            }


            label1.Text = $"Ukupno: {ukupnoNaStolu}";
            dgvPregledPorudzbina.DataSource = sto;
        }
        internal void ObrisiArtikalIzPorudzbine(DataGridView dgwPorudzbina, Label labelUkupnaCena)
        {
            //int smanjenaCena;
            int cenaNaLabelu;
            int.TryParse(labelUkupnaCena.Text, out cenaNaLabelu);
            StavkaPorudzbine sp = dgwPorudzbina.SelectedRows[0].DataBoundItem as StavkaPorudzbine;
            cenaNaLabelu = cenaNaLabelu - sp.Cena;
            labelUkupnaCena.Text = cenaNaLabelu.ToString();
            
            proizvodi.Remove(sp);
        }
        internal void StamampajRacun(DataGridView dgvPregledPorudzbina, Label label1)
        {
            List<Porudzbina> zaIzmenu = new List<Porudzbina>();
            foreach (DataGridViewRow dgv in dgvPregledPorudzbina.Rows)
            {
                StavkaPorudzbine s = dgv.DataBoundItem as StavkaPorudzbine;
                DodajUlistu(s, proizvodiZaRacun);
                ListaPorudzbina(s, zaIzmenu);
            }

            Racun r  = new Racun();
            r.RacunID = Communication.Communication.Instance.GetInvoiceID();
            r.Stavke = zaIzmenu;
            r.VremeIzdavanja = DateTime.Now;


            for (int i = 0; i < proizvodiZaRacun.Count; i++)
            {
                r.CenaRacuna = r.CenaRacuna + proizvodiZaRacun[i].Cena;
            }

            try
            {
                Communication.Communication.Instance.SaveInvoice(r);
                StampanjeRacuna(r, proizvodiZaRacun);
                MessageBox.Show($"Ukupan racun za naplatu je: {r.CenaRacuna}");
                label1.Text = "Ukupno: ";
                ukupnoNaStolu = 0;
                proizvodiZaRacun.Clear();
                PorudzbineNaStolu.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Greska prilikom stampanja racuna");
                throw;
            }
        }

        private void ListaPorudzbina(StavkaPorudzbine s, List<Porudzbina> zaIzmenu)
        {
            if (zaIzmenu.Count == 0)
            {
                Porudzbina po = new Porudzbina();
                po.PorudzbinaID = s.Porudzbina.PorudzbinaID;
                po.StavkaPorudzbine.Add(s);
                zaIzmenu.Add(po);
                return;
            }
            bool postoji = false;
            foreach (Porudzbina porudzbina in zaIzmenu)
            {
                if(porudzbina.PorudzbinaID == s.Porudzbina.PorudzbinaID)
                {
                    porudzbina.StavkaPorudzbine.Add(s);
                    postoji = true;
                    break;
                }
            }
            if(!postoji)
            {
                Porudzbina p = new Porudzbina();
                p.PorudzbinaID = s.Porudzbina.PorudzbinaID;
                zaIzmenu.Add(p);
            }
        }

        private void DodajUlistu(StavkaPorudzbine s, List<StavkaPorudzbine> proizvodiZaRacun)
        {

            if (proizvodiZaRacun.Count == 0)
            {
                proizvodiZaRacun.Add(s);
                return;
            }

            bool postojiProizvod = false;
            for (int i = 0; i < proizvodiZaRacun.Count; i++)
            {
                if (proizvodiZaRacun[i].Proizvod == s.Proizvod)
                {
                    proizvodiZaRacun[i].Kolicina += s.Kolicina;
                    proizvodiZaRacun[i].Cena += s.Cena;
                    postojiProizvod = true;
                    break;
                }
            }
            if (!postojiProizvod)
            {
                proizvodiZaRacun.Add(s);
            }
        }

        private void StampanjeRacuna(Racun r, List<StavkaPorudzbine> pzr)
        {
            try
            {
                string solutionFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string putanja = Path.Combine(solutionFolder, "Racuni", $"Racun_br.{r.RacunID}.pdf");
                GeneratePDF pdf = new GeneratePDF(putanja, true);

                pdf.AddText($"Racun id. {r.RacunID}", new DPoint(0, 0.45), 20);
                pdf.AddText("___________________________________________________________________", new DPoint(0, 1.0), 12);
                pdf.DrawTable(0, 2.0, 15.7, 15, null, pzr, proizvodiLista);
                double visinaTabele = pdf.getTableHight() + 3.0;
                pdf.AddText("___________________________________________________________________", new DPoint(0, visinaTabele), 12);
                visinaTabele += 1.0;
                pdf.AddText($"Ukupno za naplatu: {r.CenaRacuna} ", new DPoint(0, visinaTabele), 12);
                visinaTabele += 0.5;
                pdf.AddQRCode($"Platili ste račun u vrednosti od {r.CenaRacuna} u prodajnom mestu Kafe bar Čitaonica 'Braća Bluz' na adresi Beogradska 10 u Ugrinovcima(Zemun) postanski broj: 11277.\nIznos PDV: {r.CenaRacuna*0.2}", 5,visinaTabele);

                pdf.SaveAndShow();
            }
            catch (Exception)
            {
                MessageBox.Show("Greska prilikom stampanja racuna");
            }
        }
    }
}
