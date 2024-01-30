using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 15000);
            //IPEndPoint ep = new IPEndPoint(IPAddress.Any, 10000);
            soket.Bind(ep);
            soket.Listen(5);
        }

        public void Listen()
        {
            soket.Listen(5);
            bool kraj = false;

            while(!kraj)
            {
                try
                {
                    Socket klijent = soket.Accept();
                    ClientHandler handler = new ClientHandler(klijent);
                    Thread nit = new Thread(handler.StartHandler);
                    nit.IsBackground = true;
                    nit.Start();
                }
                catch (SocketException)
                {
                    Console.WriteLine("Kraj rada");
                    kraj = true;
                }
            }

        }

        public void Stop()
        {
            soket?.Close();
        }

    }
}
