using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ZaposlenogSO
{
    public class PronadjiZaposlenog:SystemOperationsBase
    {
        public Zaposleni zap;

        protected override void ExecuteOperation(IEntity entity)
        {
            zap = repository.GetOne(entity) as Zaposleni;
        }
    }
 }
