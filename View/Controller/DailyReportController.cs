using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using View.PDFGenerator;

namespace View.Controller
{
    public class DailyReportController
    {
        private void StampajUPDF(string tekstZaDnevni)
        {
            PdfDocument dnevniIZvestaj = new PdfDocument();
            PdfPage page = dnevniIZvestaj.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12);
            string[] linije = tekstZaDnevni.Split('\n');
            int y = 50;
            foreach(string linija in linije)
            {
                gfx.DrawString(linija, font, XBrushes.Black, new XPoint(50, y));
                y += 20;
            }
            string solutionFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string putanja = Path.Combine(solutionFolder, "Dnevni izvestaji", $"Dnevni_izestaj_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf");
            dnevniIZvestaj.Save(putanja);
            dnevniIZvestaj.Close();
        }

        internal void CheckDateAndGenerateDailyReport(System.Windows.Forms.DateTimePicker dtpDnevniIzvestaj)
        {
            try
            {
                DateTime now = DateTime.Now;

                if (dtpDnevniIzvestaj.Value.Date > now.Date)
                {
                    System.Windows.Forms.MessageBox.Show("Ne mozete da izvucete dnevni izvestaj za datum u buducnosti!");
                    return;
                }
                List<Racun> r = Communication.Communication.Instance.GetAllInvoices();
                List<Racun> racuniZaDnevni = new List<Racun>();
                int pazar = 0;
                double pozicija = 2.0;

                string solutionFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string putanja = Path.Combine(solutionFolder, "Dnevni izvestaji", $"Dnevni_izestaj_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf");
                GeneratePDF pdf = new GeneratePDF(putanja, true);

                pdf.AddText($"Dnevni izvestaj na dan {dtpDnevniIzvestaj.Value.ToString("dd.MM.yyyy.")}", new DPoint(0, 0.45), 20);
                pdf.AddText("___________________________________________________________________", new DPoint(0, 1.0), 12);
                for (int i = 0; i < r.Count; i++)
                {
                    if (r[i].VremeIzdavanja.Date == dtpDnevniIzvestaj.Value.Date)
                    {
                        //racuniZaDnevni.Add(r[i]);
                        pdf.AddText($"Racun: {r[i].RacunID}, Vreme izdavanja racuna: {r[i].VremeIzdavanja}, Iznos racuna: {r[i].CenaRacuna}", new DPoint(0, pozicija), 12);
                        pozicija += 1.0;
                        pazar = pazar + r[i].CenaRacuna;
                    }
                }
                pdf.AddText("___________________________________________________________________", new DPoint(0, pozicija), 12);
                pozicija += 1.0;
                pdf.AddText($"Pazar: {pazar}", new DPoint(0, pozicija+0.5), 12);

                pdf.SaveAndShow();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da istampa dnevni izvestaj, proverite da li imate dovoljno trake u kasi");
            }
        }
    }
}
