using Domain;
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
    public partial class USRasporedStolova : UserControl
    {
        OrderControler controller;
        BindingList<StavkaPorudzbine> porudzbina = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto1 = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto2 = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto3 = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto4 = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto5 = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto6 = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto7 = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto8 = new BindingList<StavkaPorudzbine>();
        BindingList<StavkaPorudzbine> sto9 = new BindingList<StavkaPorudzbine>();
        Sto Sto1;
        Sto Sto2;
        Sto Sto3;
        Sto Sto4;
        Sto Sto5;
        Sto Sto6;
        Sto Sto7;
        Sto Sto8;
        Sto Sto9;


        public USRasporedStolova(Controller.OrderControler orderControler)
        {
            InitializeComponent();
            this.controller = orderControler;
            dgvPregledPorudzbina.DataSource = porudzbina;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Sto3 == null)
            {
                Sto3 = new Sto()
                {
                    StoID = 3,
                    BrojStola = 3,
                };
            }
                if (controller.ProveriListu())
                {
                    sto3 = controller.PostaviPorudzbinu(sto3,Sto3);
                }
                else
                {
                    controller.SetDGVInRasporedStolova(sto3, dgvPregledPorudzbina, btnStampaj, label1);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sto1 == null)
            {
                Sto1 = new Sto()
                {
                    StoID = 1,
                    BrojStola = 1,
                };
            }
            if (controller.ProveriListu())
            {
                sto1 = controller.PostaviPorudzbinu(sto1, Sto1);
            }
            else
            {
                controller.SetDGVInRasporedStolova(sto1, dgvPregledPorudzbina, btnStampaj,label1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Sto2 == null)
            {
                Sto2 = new Sto()
                {
                    StoID = 2,
                    BrojStola = 2,
                };
            }
            if (controller.ProveriListu())
            {
                sto2 = controller.PostaviPorudzbinu(sto2, Sto2);
            }
            else
            {
                controller.SetDGVInRasporedStolova(sto2, dgvPregledPorudzbina, btnStampaj, label1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Sto4 == null)
            {
                Sto4 = new Sto()
                {
                    StoID = 4,
                    BrojStola = 4,
                };
            }
            if (controller.ProveriListu())
            {
                sto4 = controller.PostaviPorudzbinu(sto4, Sto4);
            }
            else
            {
                controller.SetDGVInRasporedStolova(sto4, dgvPregledPorudzbina, btnStampaj, label1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Sto5 == null)
            {
                Sto5 = new Sto()
                {
                    StoID = 5,
                    BrojStola = 5,
                };
            }
            if (controller.ProveriListu())
            {
                sto5 = controller.PostaviPorudzbinu(sto5, Sto5);
            }
            else
            {
                controller.SetDGVInRasporedStolova(sto5, dgvPregledPorudzbina, btnStampaj, label1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Sto6 == null)
            {
                Sto6 = new Sto()
                {
                    StoID = 6,
                    BrojStola = 6,
                };
            }
            if (controller.ProveriListu())
            {
                sto6 = controller.PostaviPorudzbinu(sto6, Sto6);
            }
            else
            {
                controller.SetDGVInRasporedStolova(sto6, dgvPregledPorudzbina, btnStampaj, label1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Sto7 == null)
            {
                Sto7 = new Sto()
                {
                    StoID = 7,
                    BrojStola = 7,
                };
            }
            if (controller.ProveriListu())
            {
                sto7 = controller.PostaviPorudzbinu(sto7, Sto7);
            }
            else
            {
                controller.SetDGVInRasporedStolova(sto7, dgvPregledPorudzbina, btnStampaj,label1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Sto8 == null)
            {
                Sto8 = new Sto()
                {
                    StoID = 8,
                    BrojStola = 8,
                };
            }
            if (controller.ProveriListu())
            {
                sto8 = controller.PostaviPorudzbinu(sto8, Sto8);
            }
            else
            {
                controller.SetDGVInRasporedStolova(sto8, dgvPregledPorudzbina, btnStampaj,label1);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Sto9 == null)
            {
                Sto9 = new Sto()
                {
                    StoID = 9,
                    BrojStola = 9,
                };
            }
            if (controller.ProveriListu())
            {
                sto9 = controller.PostaviPorudzbinu(sto9, Sto9);
            }
            else
            {
                controller.SetDGVInRasporedStolova(sto9, dgvPregledPorudzbina, btnStampaj,label1);
            }
        }

        private void USRasporedStolova_Load(object sender, EventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            controller.OtvoriUCUnosPorudzbine();
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            controller.StamampajRacun(dgvPregledPorudzbina,label1);
        }
    }
}
