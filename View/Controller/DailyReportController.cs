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

namespace View.Controller
{
    public class DailyReportController
    {
        internal void CheckDateAndGenerateDailyReport(System.Windows.Forms.DateTimePicker dtpDnevniIzvestaj)
        {
            DateTime now = DateTime.Now;

            if (dtpDnevniIzvestaj.Value.Date > now.Date)
            {
                System.Windows.Forms.MessageBox.Show("Ne mozete da izvucete dnevni izvestaj za datum u buducnosti!");
                return;
            }
            string[] podaciZaDnevni;
            List<Racun> r = Communication.Communication.Instance.GetAllInvoices();
            List<Racun> racuniZaDnevni = new List<Racun>();
            int pazar = 0;

            string tekstZaDnevni = $"Dnevni izvestaj na dan {dtpDnevniIzvestaj.Value.ToString("dd.MM.yyyy.")}\n\n\n";
            
            for (int i = 0; i < r.Count; i++)
            {
                if (r[i].VremeIzdavanja.Date == dtpDnevniIzvestaj.Value.Date && r[i].CenaRacuna > 0)
                {
                    racuniZaDnevni.Add(r[i]);
                    tekstZaDnevni += $"Racun: {r[i].RacunID}, Vreme izdavanja racuna: {r[i].VremeIzdavanja}, Iznos racuna: {r[i].CenaRacuna}\n";
                    pazar = pazar + r[i].CenaRacuna;
                }
            }

            tekstZaDnevni += $"---------------------------------------------------------------------------------------------------------------------------------------\nPazar: {pazar} ";

            //StampajUNotepade(tekstZaDnevni);
            stampajUPDF(tekstZaDnevni);
            System.Windows.Forms.MessageBox.Show("Dnevni izvestaj je uspesno istampan");
        }

        private void stampajUPDF(string tekstZaDnevni)
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

        private void StampajUNotepade(string tekstZaDnevni)
        {
            Process notepadProcess = new Process();
            notepadProcess.StartInfo.FileName = "notepad.exe";
            string nazivFajla = $"Dnevni_izvestaj_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";
         

            notepadProcess.Start();
            System.IO.File.WriteAllText(nazivFajla, tekstZaDnevni);
            Process.Start("notepad.exe", nazivFajla);
            notepadProcess.WaitForExit();
        }
    }
}
