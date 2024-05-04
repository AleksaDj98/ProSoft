using System;
using System.Windows.Forms;
using View.Controller;

namespace View.UserControls
{
    public delegate void DugmeKliknutoHandler(object sender, EventArgs e);
    public partial class UCUnosPorudzbine : UserControl
    {
        private OrderControler orderControler;
        public event DugmeKliknutoHandler DugmeKliknuto;

        public UCUnosPorudzbine()
        {
            
        }

        public UCUnosPorudzbine(OrderControler orderControler)
        {
            this.orderControler = orderControler;
            InitializeComponent();
            orderControler.postaviTabove(flp1,flp2,flp3,flp4,flp4,flp5,flp6,labelUkupnaCena);
            orderControler.setDGV(dgwPorudzbina);
        }

        private void UCUnosPorudzbine_Load(object sender, EventArgs e)
        {
            
        }
        private void btnPonistiPorudzbinu_Click(object sender, EventArgs e)
        {
            if (dgwPorudzbina.Rows.Count != 0)
            {
                orderControler.ponistiPorudzbin();
            }
        }

        private void btnObrisiArtikal_Click(object sender, EventArgs e)
        {
            if(dgwPorudzbina.Rows.Count != 0)
            {
                orderControler.obrisiArtikalIzPorudzbine(dgwPorudzbina);
            }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            orderControler.OtvoriUCRasporedStolovaZaStampuRacuna();
        }

        private void btnStampanje_Click(object sender, EventArgs e)
        {
            orderControler.OtvoriUCRasporedStolovaZaStampuRacuna();
        }
    }
}
