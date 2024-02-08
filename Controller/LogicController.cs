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
    }
}
