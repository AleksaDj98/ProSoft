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
                case Operations.ExistingEmploye:
                    response.Result = LogicController.Instance.ExistingEmp((Zaposleni)request.requestObject); break;
                case Operations.SaveEmploye:
                    LogicController.Instance.SaveEmploye((Zaposleni)request.requestObject);break;
                case Operations.GetAllPDV:
                    response.Result = LogicController.Instance.GetAllPDV();break;
                case Operations.GetAllProductVersion:
                    response.Result = LogicController.Instance.GetAllProductVersion();break;
                case Operations.SaveProduct:
                    LogicController.Instance.SaveProduct((Proizvod)request.requestObject);break;
                case Operations.DeleteEmploye:
                    LogicController.Instance.DeleteEmploye((Zaposleni)request.requestObject); break;
                case Operations.ExistingArticle:
                    response.Result = LogicController.Instance.ExistingArticle((Proizvod)request.requestObject);break;
                case Operations.GetAllArticls:
                    response.Result = LogicController.Instance.GetAllArticles(); break;
                case Operations.GetOrderID:
                    response.Result = LogicController.Instance.GetOrderID();break;
                case Operations.SaveOrderItem:
                    LogicController.Instance.SaveOrderItem((StavkaPorudzbine)request.requestObject); break;
                case Operations.SaveOrder:
                    LogicController.Instance.SaveOrder((Porudzbina)request.requestObject); break;
                case Operations.SaveInvoiceID:
                    LogicController.Instance.SaveinvoiceID((Racun)request.requestObject); break;
                case Operations.GetInvoicID:
                    response.Result = LogicController.Instance.GetInvoicID(); break;
                case Operations.DeleteArticle:
                    LogicController.Instance.DeleteArticle((Proizvod)request.requestObject); break;
                case Operations.GetAllOrders:
                    response.Result = LogicController.Instance.GetAllOrders(); break;
                case Operations.SaveInvoice:
                    LogicController.Instance.UpdateInvoice((Racun)request.requestObject);break;

            }
            return response;
        }

        internal void Stop()
        {
            klijent.Close();
        }
    }
}
