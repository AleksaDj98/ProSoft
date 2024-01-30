using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

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
            List<Zaposleni> x = (List<Zaposleni>)klijent.GetResponsResult();
            return x.FirstOrDefault();
        }
    }
}
