using Domain;
using Org.BouncyCastle.Asn1.Pkcs;
using PdfSharp.Charting;
using PdfSharp.Drawing;
using PdfSharp.Internal;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Annotations;
using QRCoder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Markup.Localizer;
using View.ButtonGenerator;
using View.UserControls;

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
        internal void postaviTabove(FlowLayoutPanel flp1, FlowLayoutPanel flp2, FlowLayoutPanel flp3, FlowLayoutPanel flp4, FlowLayoutPanel flp41, FlowLayoutPanel flp5, FlowLayoutPanel flp6, Label lblUC)
        {
            lokalnilabel = lblUC;
            foreach (Proizvod p in proizvodiLista)
            {
                if (p.Aktivan == true)
                {
                    switch (p.VrstaProizvoda.VrstaProizvodaID)
                    {
                        case 1: generisiDugmeZaProizvod(p, flp1); break;
                        case 2: generisiDugmeZaProizvod(p, flp2); break;
                        case 3: generisiDugmeZaProizvod(p, flp3); break;
                        case 4: generisiDugmeZaProizvod(p, flp4); break;
                        case 5: generisiDugmeZaProizvod(p, flp5); break;
                        case 6: generisiDugmeZaProizvod(p, flp6); break;
                        default: break;
                    }
                }
            }
        }

        private void generisiDugmeZaProizvod(Proizvod p, FlowLayoutPanel flp)
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

        internal void ponistiPorudzbin(Label labelUkupnaCena)
        {
            proizvodi.Clear();
            labelUkupnaCena.Text = "0";
        }

        internal void setDGV(DataGridView dataGridView1)
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

        internal bool proveriListu()
        {
            if (proizvodi.Count > 0)
            {
                return true;
            }
            return false;
        }
        internal BindingList<StavkaPorudzbine> postaviPorudzbinu(BindingList<StavkaPorudzbine> sto, Sto Sto)
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
        internal void setDGVInRasporedStolova(BindingList<StavkaPorudzbine> sto, DataGridView dgvPregledPorudzbina, Button btnStampaj, Label label1)
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
        internal void obrisiArtikalIzPorudzbine(DataGridView dgwPorudzbina, Label labelUkupnaCena)
        {
            //int smanjenaCena;
            int cenaNaLabelu;
            int.TryParse(labelUkupnaCena.Text, out cenaNaLabelu);
            StavkaPorudzbine sp = dgwPorudzbina.SelectedRows[0].DataBoundItem as StavkaPorudzbine;
            cenaNaLabelu = cenaNaLabelu - sp.Cena;
            labelUkupnaCena.Text = cenaNaLabelu.ToString();
            
            proizvodi.Remove(sp);
        }
        internal void stamampajRacun(DataGridView dgvPregledPorudzbina, Label label1)
        {
            List<Porudzbina> zaIzmenu = new List<Porudzbina>();
            foreach (DataGridViewRow dgv in dgvPregledPorudzbina.Rows)
            {
                StavkaPorudzbine s = dgv.DataBoundItem as StavkaPorudzbine;
                dodajUlistu(s, proizvodiZaRacun);
                listaPorudzbina(s, zaIzmenu);
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
                stampanjeRacuna(r, proizvodiZaRacun);
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

        private void listaPorudzbina(StavkaPorudzbine s, List<Porudzbina> zaIzmenu)
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
                //p.StavkaPorudzbine.Add(s);
                zaIzmenu.Add(p);
            }
        }

        private void dodajUlistu(StavkaPorudzbine s, List<StavkaPorudzbine> proizvodiZaRacun)
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

        private void stampanjeRacuna(Racun r, List<StavkaPorudzbine> pzr)
        {
            //string[] podaciZaDnevni;

            string tekstZaRacun = $"Racun br. {r.RacunID}\n";
            tekstZaRacun += $"---------------------------------------------------------------------------------------------------------------------------------------\n" +
                $"Naziv proizvoda                 Jedinicna cena                       Kolicina                     Cena\n";

            for (int i = 0; i < pzr.Count; i++)
            {
                for (int y = 0; y < proizvodiLista.Count; y++)
                {
                    if (pzr[i].Proizvod.ProizvodID == proizvodiLista[y].ProizvodID)
                    {
                        //tekstZaRacun += $"{proizvodiLista[y].NazivProizvoda}                            {proizvodiLista[y].ProdajnaCena}                                   {pzr[i].Kolicina}                                     {pzr[i].Cena} \n"; break;


                        tekstZaRacun += string.Format("{0,25}{1,25}{2,25}{3,25}\n", proizvodiLista[y].NazivProizvoda, proizvodiLista[y].ProdajnaCena, pzr[i].Kolicina, pzr[i].Cena); break;
                        //tekstZaRacun += $"{proizvodiLista[y].NazivProizvoda}                            {proizvodiLista[y].ProdajnaCena}                                   {pzr[i].Kolicina}                                     {pzr[i].Cena} \n"; break;
                    }
                }
            }

            tekstZaRacun += $"---------------------------------------------------------------------------------------------------------------------------------------\nUkupno za naplatu: {r.CenaRacuna} \n";
            Bitmap QRKodSlika = generisiQRCode(tekstZaRacun);
            stampajUPDF(tekstZaRacun, r, QRKodSlika);
            System.Windows.Forms.MessageBox.Show($"Racun br. {r.RacunID} je uspesno istampan");
        }

        private Bitmap generisiQRCode(string tekstZaRacun)
        {
            string textZaQRkod = "Fiskalni racun je validan i prosao je kroz proces fiskalizacije.\n Platili ste sledece stavke:\n\n" + tekstZaRacun;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(textZaQRkod, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrcodeimage = qrCode.GetGraphic(20);
            Bitmap QRCodeResize = new Bitmap(qrcodeimage, new Size(400, 400));
            return QRCodeResize;
        }

        private void stampajUPDF(string tekstZaRacun, Racun r, Bitmap qRKodSlika)
        {
            PdfDocument stampaRacuna = new PdfDocument();
            PdfPage page = stampaRacuna.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12);



            string[] linije = tekstZaRacun.Split('\n');
            int y = 50;

            foreach (string linija in linije)
            {
                gfx.DrawString(linija, font, XBrushes.Black, new XPoint(50, y));
                y += 20;
            }
            using (MemoryStream ms = new MemoryStream())
            {
                qRKodSlika.Save(ms, ImageFormat.Png);
                ms.Seek(0, SeekOrigin.Begin);

                XImage qrImage = XImage.FromStream(ms);
                gfx.DrawImage(qrImage, new XRect(50, y + 20, qRKodSlika.Width, qRKodSlika.Height));
            }



            string solutionFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string putanja = Path.Combine(solutionFolder, "Racuni", $"Racun_br.{r.RacunID}.pdf");
            stampaRacuna.Save(putanja);
            stampaRacuna.Close();
            Process.Start(putanja);
        }

        
    }
}
