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
    public partial class FrmBrisanjeArtikla : Form
    {
        ArticleController controller = new ArticleController();
        public FrmBrisanjeArtikla()
        {
            InitializeComponent();
        }
        private void FrmBrisanjeArtikla_Load(object sender, EventArgs e)
        {
            controller.SetDGV(dgvProizvodi);
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            controller.ProveriDaLiJeSelektovanoIObrisi(dgvProizvodi,txtNazivProizvoda);
        }

        private void txtNazivProizvoda_TextChanged(object sender, EventArgs e)
        {
            controller.ProveriPoiljeIPretrazi(txtNazivProizvoda,dgvProizvodi);
        }
    }
}
