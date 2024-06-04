using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PorudzbinaSO
{
    public class SacuvajPorudzbinu : SystemOperationsBase
    {
        List<StavkaPorudzbine> zaCuvanje = new List<StavkaPorudzbine>();
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Save(entity);
            Porudzbina p = entity as Porudzbina;
            zaCuvanje = p.StavkaPorudzbine;
            foreach (StavkaPorudzbine sp in zaCuvanje)
            {
                repository.Save(sp);
            }
        }
    }
}
