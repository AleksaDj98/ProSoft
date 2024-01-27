using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private Socket soket;
        

        public Server() 
        { 
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 99999);
            soket.Bind(ep);
            soket.Listen(5);
        }

        public void Listen()
        {
            Socket klijent = soket.Accept();

        }

        public void Stop()
        {
            soket?.Close();
        }

    }
}
