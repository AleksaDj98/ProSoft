using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PorudzbinaSO
{
    public  class VratiIDPorudzbine : SystemOperationsBase
    {
        public  Porudzbina p = new Porudzbina();
        protected override void executeOperation(IEntity entity)
        {
            p.PorudzbinaID = repository.GetNewID(entity);
        }
    }
}
