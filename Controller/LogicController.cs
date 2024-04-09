using Domain;
using Library.Database;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.LoginSO;
using SystemOperations.ZaposlenogSO;
using SystemOperations.ProizvodiSO;
using SystemOperations.PorudzbinaSO;
using SystemOperations.ReportsSO;

namespace Controller
{
    public class LogicController
    {
        private IGenericRepository repository;
        public Zaposleni zaposleni { get; set; }

        private static LogicController instance;

        public static LogicController Instance
        {
            get
            {
                if(instance == null) instance = new LogicController();
                return instance;
            }
        }
        private LogicController()
        {
            repository = new GenericRepository();
        }

        public object Login(Zaposleni requestObject)
        {
            prijavaRadnika pr = new prijavaRadnika();
            pr.executeTemplate(requestObject);
            return pr.zap;
        }

        public object ExistingEmp(Zaposleni requestObject)
        {
            PronadjiZaposlenog pz = new PronadjiZaposlenog();
            pz.executeTemplate(requestObject);
            return pz.zap;
        }

        public void SaveEmploye(Zaposleni requestObject)
        {
            KreirajRadnika kr = new KreirajRadnika();
            kr.executeTemplate(requestObject);
        }

        public object GetAllPDV()
        {
            VratiSvePDV vspdv = new VratiSvePDV();
            vspdv.executeTemplate(new PDV());
            return vspdv.pdv;
        }

        public object GetAllProductVersion()
        {
            VratiSveVrsteProizvoda vs = new VratiSveVrsteProizvoda();
            vs.executeTemplate(new VrstaProizvoda());
            return vs.vp;
        }

        public void SaveProduct(Proizvod requestObject)
        {
            SacuvajNoviProizvod np = new SacuvajNoviProizvod();
            np.executeTemplate(requestObject);
        }

        public void DeleteEmploye(Zaposleni requestObject)
        {
            PromeniStatusZaposlenog or = new PromeniStatusZaposlenog();
            or.executeTemplate(requestObject);
        }

        public object ExistingArticle(Proizvod requestObject)
        {
            ProveriProizvod pp = new ProveriProizvod();
            pp.executeTemplate(requestObject);
            return pp.pro;
        }

        public object GetAllArticles()
        {
            ProveriProizvod pp = new ProveriProizvod();
            pp.executeTemplate(new Proizvod());
            return pp.pro;
        }

        public object GetOrderID()
        {
            VratiIDPorudzbine idp = new VratiIDPorudzbine();
            idp.executeTemplate(new Porudzbina());
            return idp.p.PorudzbinaID;
        }

        public void SaveOrderItem(StavkaPorudzbine requestObject)
        {
            SacuvajStavkuPorudzbine sp = new SacuvajStavkuPorudzbine();
            sp.executeTemplate(requestObject);
        }

        public void SaveOrder(Porudzbina requestObject)
        {
            SacuvajPorudzbinu p = new SacuvajPorudzbinu();
            p.executeTemplate(requestObject);   
        }

        public void SaveinvoiceID(Racun requestObject)
        {
            SacuvajRacunID rid = new  SacuvajRacunID();
            rid.executeTemplate(requestObject);
        }

        public object GetInvoicID()
        {
            VratiIDRacuna idr = new VratiIDRacuna();
            idr.executeTemplate(new Racun());
            return idr.r.RacunID;
        }

        public void DeleteArticle(Proizvod requestObject)
        {
            PromeniStatusProizvoda a = new PromeniStatusProizvoda();
            a.executeTemplate(requestObject);
        }

        public object GetAllOrders()
        {
            VratiSvePorudzbine sp = new VratiSvePorudzbine();
            sp.executeTemplate(new Porudzbina());
            return sp.poruzbina;
        }

        public void UpdateInvoice(Racun requestObject)
        {
            SacuvajRacun sr = new SacuvajRacun();
            sr.executeTemplate(requestObject);
        }

        public object GetAllInvoices()
        {
            VratiSveRacune sr = new VratiSveRacune();
            sr.executeTemplate (new Porudzbina());
            return sr.racun;
        }
    }
}
