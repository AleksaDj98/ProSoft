using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Receiver
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter;
        
        public  Receiver(Socket soket)
        {
            this.socket = soket;
            this.stream = new NetworkStream(soket);
            this.formatter = new BinaryFormatter();
        }

        public object Receive()
        {
            return formatter.Deserialize(stream);
        }
    }
}
