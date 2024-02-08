using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ProizvodiSO
{
    public class VratiSveVrsteProizvoda : SystemOperationsBase
    {
        public List<VrstaProizvoda> vp;
        protected override void executeOperation(IEntity entity)
        {
            vp = repository.GetAll(new VrstaProizvoda()).Cast<VrstaProizvoda>().ToList();
        }
    }
}
