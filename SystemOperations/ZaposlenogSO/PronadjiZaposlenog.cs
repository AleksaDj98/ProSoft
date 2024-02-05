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
        public List<Zaposleni> zap;

        protected override void executeOperation(IEntity entity)
        {
            zap = repository.GetAll(entity).Cast<Zaposleni>().ToList();
        }
    }
 }
