using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ZaposlenogSO
{
    public class obrisiRadnika : SystemOperationsBase
    {
        protected override void executeOperation(IEntity entity)
        {
            repository.Delete(entity);
        }
    }
}
