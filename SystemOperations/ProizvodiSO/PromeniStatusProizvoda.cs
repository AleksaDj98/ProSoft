using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodiSO
{
    public class PromeniStatusProizvoda : SystemOperationsBase
    {
        protected override void executeOperation(IEntity entity)
        {
            Proizvod p = entity as Proizvod;
            p.Uslov = $"set Aktivan = CASE WHEN Aktivan = 1 THEN 0 WHEN Aktivan = 0 THEN 1 END";
            repository.Update(entity);
        }
    }
}
