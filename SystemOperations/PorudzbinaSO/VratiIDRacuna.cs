using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PorudzbinaSO
{

    public class VratiIDRacuna : SystemOperationsBase
    {
        public Racun r = new Racun();
        protected override void ExecuteOperation(IEntity entity)
        {
            r.RacunID = repository.GetNewID(entity);
        }
    }
}
