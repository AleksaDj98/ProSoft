using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace View.Communication
{
    public class Communication
    {
        private static Communication instance;

        private Socket soket;
        private CommunicationClient klijent;

        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        private Communication()
        {

        }

        public  void Connection()
        {
            if (soket!=null && soket.Connected) return;
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Connect("127.0.0.1", 15000);
            klijent = new CommunicationClient(soket);
        }

        public void Disconnect()
        {
            soket.Close();
            soket=null;
        }

        public List<Zaposleni> Login(string text)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.Login,
                requestObject = new Zaposleni { SifraLogovanja = text }
            };
            klijent.SendRequest(zahtev);
            List<Zaposleni> zaposleni = (List<Zaposleni>)klijent.GetResponsResult();
            return zaposleni;
        }

        internal bool ProveriSifru(TextBox textSifra)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.ExistingEmploye,
                requestObject = new Zaposleni { SifraLogovanja = textSifra.Text }
            };
            klijent.SendRequest(zahtev);
            List<Zaposleni> zaposleni = (List<Zaposleni>)klijent.GetResponsResult();
            for (int i = 0; i < zaposleni.Count; i++)
            {
                if (zaposleni[i].SifraLogovanja == textSifra.Text) return true;
            }
            //if (zaposleni.Count > 0)
            //{
            //    MessageBox.Show("Korisnik sa ovom sifrom vec postoji");
            //    return true;
            //}
            return  false;
        }

        internal void SaveEmploye(Zaposleni zap)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.SaveEmploye,
                requestObject = zap
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal List<PDV> GetAllPDVVersion()
        {
            Request zahtev = new Request()
            {
                Operations = Operations.GetAllPDV
            };
            klijent.SendRequest(zahtev);
            List<PDV> pdv = (List<PDV>)klijent.GetResponsResult();
            return pdv;
        }

        internal List<VrstaProizvoda> GetAllProductVersion()
        {
            Request zahtev = new Request()
            {
                Operations = Operations.GetAllProductVersion
            };
            klijent.SendRequest(zahtev);
            List<VrstaProizvoda> vp = (List<VrstaProizvoda>)klijent.GetResponsResult();
            return vp;
        }

        internal void SaveProduct(Proizvod p)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.SaveProduct,
                requestObject = p
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal List<Zaposleni> PronadjiZaposlenog(string text)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.ExistingEmploye,
                requestObject = new Zaposleni { SifraLogovanja = text}
            };
            klijent.SendRequest(zahtev);
            List<Zaposleni> zaposleni = (List<Zaposleni>)klijent.GetResponsResult();
            return zaposleni;
        }

        internal void DeleteEmploye(Zaposleni zap)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.DeleteEmploye,
                requestObject = zap
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal List<Proizvod> CheckArticle(TextBox txtNaziv)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.ExistingArticle,
                requestObject = new Proizvod { NazivProizvoda = txtNaziv.Text }
            };
            klijent.SendRequest(zahtev);
            List<Proizvod> proizvod = (List<Proizvod>)klijent.GetResponsResult();
            //if (proizvod.Count > 0) return true;
            return proizvod;
        }

        internal List<Proizvod> GetAllAricles()
        {
            Request zahtev = new Request()
            {
                Operations = Operations.GetAllArticls
            };
            klijent.SendRequest(zahtev);
            List<Proizvod> vp = (List<Proizvod>)klijent.GetResponsResult();
            return vp;
        }

        internal int GetOrderID()
        {
            Request zahtev = new Request()
            {
                Operations = Operations.GetOrderID
            };
            klijent.SendRequest(zahtev);
            int ID = (int)klijent.GetResponsResult();
            return ID;
        }

        internal void SaveOrderItem(StavkaPorudzbine sp)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.SaveOrderItem,
                requestObject = sp
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal void SaveOrder(Porudzbina p)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.SaveOrder,
                requestObject = p
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal void SaveInvoiceID(Racun r)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.SaveInvoiceID,
                requestObject = r
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal int GetInvoiceID()
        {
            Request zahtev = new Request()
            {
                Operations = Operations.GetInvoicID
            };
            klijent.SendRequest(zahtev);
            int ID = (int)klijent.GetResponsResult();
            return ID;
        }

        internal void DeleteArtile(Proizvod p)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.DeleteArticle,
                requestObject = p
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal List<Porudzbina> GetAllOrders()
        {
            Request zahtev = new Request()
            {
                Operations = Operations.GetAllOrders
            };
            klijent.SendRequest(zahtev);
            List<Porudzbina> por = (List<Porudzbina>)klijent.GetResponsResult();
            return por;
        }

        internal void SaveInvoice(Racun r)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.SaveInvoice,
                requestObject = r
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal List<Racun> GetAllInvoices()
        {
            Request zahtev = new Request()
            {
                Operations = Operations.GetAllInvoices
            };
            klijent.SendRequest(zahtev);
            List<Racun> rac = (List<Racun>)klijent.GetResponsResult();
            return rac;
        }
    }
}
