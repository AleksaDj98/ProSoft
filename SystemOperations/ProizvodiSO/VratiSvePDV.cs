using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodiSO
{
    public class VratiSvePDV : SystemOperationsBase
    {
        public List<PDV> pdv;
        protected override void executeOperation(IEntity entity)
        {
            pdv = repository.GetAll(new PDV()).Cast<PDV>().ToList();
        }
    }
}
