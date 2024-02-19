using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodiSO
{
    public class ObrisiArtikal : SystemOperationsBase
    {
        protected override void executeOperation(IEntity entity)
        {
           repository.Delete(entity);
        }
    }
}
