using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PorudzbinaSO
{
    public class SacuvajRacun : SystemOperationsBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Save(entity);
            Racun r = entity as Racun;
            List<Porudzbina> por = r.Stavke;
            foreach  (Porudzbina p in por)
            {
                List<StavkaPorudzbine> sp = p.StavkaPorudzbine;
                foreach (StavkaPorudzbine stavkaP in sp)
                {
                    Proizvod proizvod = stavkaP.Proizvod;
                    proizvod.Uslov = $"SET stanjeLagera = stanjeLagera - {stavkaP.Kolicina}";
                    repository.Update(proizvod);
                }
                p.R.RacunID = r.RacunID;
                repository.Update(p);
            }
        }
    }
}
