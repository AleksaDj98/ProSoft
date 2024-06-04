using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ZaposlenogSO
{
    public class PromeniStatusZaposlenog : SystemOperationsBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Update(entity);
        }
    }
}
