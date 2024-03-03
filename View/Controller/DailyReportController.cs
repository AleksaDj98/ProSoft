using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            StampajUNotepade(tekstZaDnevni);
            System.Windows.Forms.MessageBox.Show("Dnevni izvestaj je uspesno istampan");
        }

        private void StampajUNotepade(string tekstZaDnevni)
        {
            Process notepadProcess = new Process();
            notepadProcess.StartInfo.FileName = "notepad.exe";
            string nazivFajla = $"Dnevni izvestaj_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";

            notepadProcess.Start();
            System.IO.File.WriteAllText(nazivFajla, tekstZaDnevni);
            Process.Start("notepad.exe", nazivFajla);
            notepadProcess.WaitForExit();
        }
    }
}
