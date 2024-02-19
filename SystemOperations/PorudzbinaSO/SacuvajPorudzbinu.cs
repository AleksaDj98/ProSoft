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
        protected override void executeOperation(IEntity entity)
        {
            repository.Save(entity);
        }
    }
}
