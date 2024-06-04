using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ZaposlenogSO
{
    public class KreirajRadnika : SystemOperationsBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Save(entity);
        }
    }
}
