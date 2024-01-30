using System;
using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.IO;
using System.Windows.Forms;
using View.Exeptions;
using System.Net.Sockets;
using View.Exceptions;

namespace View.Communication
{
    public class CommunicationClient
    {
        private Receiver reciver;
        private Sender sender;
        

        public CommunicationClient(Socket soket)
        {
            reciver = new Receiver(soket);
            sender = new Sender(soket);
        }

        public void SendRequest(Request request)
        {
            try
            {
                sender.Send(request);
            }
            catch (IOException ex)
            {
                throw new ServerException(ex.Message);
            }catch (SocketException ex) 
            {
                throw new ServerException(ex.Message);
            }
        }

        public object GetResponsResult()
        {
            Response response = (Response)reciver.Receive();
            if(response.isSuccessful)
            {
                return response.Result;
            }
            else
            {
                throw new SystemOperationException(response.Error);
            }
        }
    }
}
