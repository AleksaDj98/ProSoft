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
using SystemOperations.LagerSO;

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
            pr.ExecuteTemplate(requestObject);
            return pr.zap;
        }

        public object ExistingEmp(Zaposleni requestObject)
        {
            PronadjiZaposlenog pz = new PronadjiZaposlenog();
            pz.ExecuteTemplate(requestObject);
            return pz.zap;
        }

        public void SaveEmploye(Zaposleni requestObject)
        {
            KreirajRadnika kr = new KreirajRadnika();
            kr.ExecuteTemplate(requestObject);
        }

        public object GetAllPDV()
        {
            VratiSvePDV vspdv = new VratiSvePDV();
            vspdv.ExecuteTemplate(new PDV());
            return vspdv.pdv;
        }

        public object GetAllProductVersion()
        {
            VratiSveVrsteProizvoda vs = new VratiSveVrsteProizvoda();
            vs.ExecuteTemplate(new VrstaProizvoda());
            return vs.vp;
        }

        public void SaveProduct(Proizvod requestObject)
        {
            SacuvajNoviProizvod np = new SacuvajNoviProizvod();
            np.ExecuteTemplate(requestObject);
        }

        public void DeleteEmploye(Zaposleni requestObject)
        {
            PromeniStatusZaposlenog or = new PromeniStatusZaposlenog();
            or.ExecuteTemplate(requestObject);
        }

        public object ExistingArticle(Proizvod requestObject)
        {
            ProveriProizvod pp = new ProveriProizvod();
            pp.ExecuteTemplate(requestObject);
            return pp.pro;
        }

        public object GetAllArticles()
        {
            ProveriProizvod pp = new ProveriProizvod();
            pp.ExecuteTemplate(new Proizvod());
            return pp.pro;
        }

        public object GetOrderID()
        {
            VratiIDPorudzbine idp = new VratiIDPorudzbine();
            idp.ExecuteTemplate(new Porudzbina());
            return idp.p.PorudzbinaID;
        }
        public void SaveOrder(Porudzbina requestObject)
        {
            SacuvajPorudzbinu p = new SacuvajPorudzbinu();
            p.ExecuteTemplate(requestObject);   
        }
        public object GetInvoicID()
        {
            VratiIDRacuna idr = new VratiIDRacuna();
            idr.ExecuteTemplate(new Racun());
            return idr.r.RacunID;
        }

        public void DeleteArticle(Proizvod requestObject)
        {
            PromeniStatusProizvoda a = new PromeniStatusProizvoda();
            a.ExecuteTemplate(requestObject);
        }

        public object GetAllOrders()
        {
            VratiSvePorudzbine sp = new VratiSvePorudzbine();
            sp.ExecuteTemplate(new Porudzbina());
            return sp.poruzbina;
        }

        public void UpdateInvoice(Racun requestObject)
        {
            SacuvajRacun sr = new SacuvajRacun();
            sr.ExecuteTemplate(requestObject);
        }

        public object GetAllInvoices()
        {
            VratiSveRacune sr = new VratiSveRacune();
            sr.ExecuteTemplate(new Racun());
            return sr.racun;
        }

        public void UpdateStorage(Proizvod requestObject)
        {
            PromeniStanjeLagera psl = new PromeniStanjeLagera();
            psl.ExecuteTemplate(requestObject);
        }
    }
}
