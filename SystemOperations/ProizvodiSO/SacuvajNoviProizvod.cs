using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SystemOperations.ProizvodiSO
{
    public class SacuvajNoviProizvod : SystemOperationsBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            repository.Save(entity);
        }
    }
}
