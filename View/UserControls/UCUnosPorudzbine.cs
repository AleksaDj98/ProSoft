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
            orderControler.SetButtonsInGroupBox(gpProizvodi);
            DodajEventHendlerZaDugmice();
            DugmeKliknuto += UC_DugmeKliknuto;
            orderControler.setDGV(dgwPorudzbina);
        }

        private void UC_DugmeKliknuto(object sender, EventArgs e)
        {
            if(sender is Button b)
            {
                orderControler.addArticle(b,labelUkupnaCena);
            }
        }

        private void DodajEventHendlerZaDugmice()
        {
            foreach(Control control in gpProizvodi.Controls)
            {
                if(control is Button button)
                {
                    button.Click += DugmeUnutarGroupBoxa_Click;
                }
            }
        }

        private void DugmeUnutarGroupBoxa_Click(object sender, EventArgs e)
        {
            if(DugmeKliknuto != null) DugmeKliknuto(sender, e);
        }

        private void UCUnosPorudzbine_Load(object sender, EventArgs e)
        {
            
        }
        private void btnPonistiPorudzbinu_Click(object sender, EventArgs e)
        {
            orderControler.ponistiPorudzbin();
        }

        private void btnObrisiArtikal_Click(object sender, EventArgs e)
        {
            orderControler.obrisiArtikalIzPorudzbine(dgwPorudzbina);
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
