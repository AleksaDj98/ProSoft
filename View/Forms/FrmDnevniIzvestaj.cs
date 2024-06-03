using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View.Forms
{
    public partial class FrmDnevniIzvestaj : Form
    {
        DailyReportController controller;
        public FrmDnevniIzvestaj()
        {
            InitializeComponent();
            controller = new DailyReportController();
        }

        private void FrmDnevniIzvestaj_Load(object sender, EventArgs e)
        {

        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            controller.CheckDateAndGenerateDailyReport2(dtpDnevniIzvestaj);
        }
    }
}
