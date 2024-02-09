using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodiSO
{
    public  class ProveriProizvod : SystemOperationsBase
    {
        public List<Proizvod> pro;
        protected override void executeOperation(IEntity entity)
        {
            pro = repository.GetAll(entity).Cast<Proizvod>().ToList();
        }
    }
}
