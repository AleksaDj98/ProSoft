using Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Drawing.Printing;
using Controller;

namespace Server
{
    public class ClientHandler
    {
        private Zaposleni ulogovanZaposleni;
        private Socket klijent;

        public ClientHandler(Socket klijent)
        {
            this.klijent = klijent;
        }

        internal void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(klijent);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = processRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.isSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze!");
            }
            catch (SerializationException )
            {
                Console.WriteLine("Doslo je fo prekida veze");
            }
        }

        private Response processRequest(Request request)
        {
            Response response = new Response();
            response.isSuccessful = true;
            switch(request.Operations)
            {
                case Operations.Login:
                        response.Result = LogicController.Instance.Login((Zaposleni)request.requestObject); break;
            }
            return response;
        }

        internal void Stop()
        {
            klijent.Close();
        }
    }
}
