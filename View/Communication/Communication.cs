using Common;
using Domain;
using System;
using System.Collections.Generic;
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

        public Zaposleni Login(string text)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.Login,
                requestObject = new Zaposleni { SifraLogovanja = text }
            };
            klijent.SendRequest(zahtev);
            List<Zaposleni> zaposleni = (List<Zaposleni>)klijent.GetResponsResult();
            return zaposleni.FirstOrDefault();
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
            if (zaposleni.Count > 0)
            {
                MessageBox.Show("Korisnik sa ovom sifrom vec postoji");
                return true;
            }
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

        internal Zaposleni PronadjiZaposlenog(string text)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.ExistingEmploye,
                requestObject = new Zaposleni { SifraLogovanja = text}
            };
            klijent.SendRequest(zahtev);
            List<Zaposleni> zaposleni = (List<Zaposleni>)klijent.GetResponsResult();
            return zaposleni.FirstOrDefault();
        }

        internal void Delete(Zaposleni zap)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.DeleteEmploye,
                requestObject = zap
            };
            klijent.SendRequest(zahtev);
            klijent.GetResponsResult();
        }

        internal bool CheckDevice(TextBox txtNaziv)
        {
            Request zahtev = new Request()
            {
                Operations = Operations.ExistingArticle,
                requestObject = new Proizvod { NazivProizvoda = txtNaziv.Text }
            };
            klijent.SendRequest(zahtev);
            List<Proizvod> proizvod = (List<Proizvod>)klijent.GetResponsResult();
            if (proizvod.Count > 0) return true;
            return false;
        }
    }
}
