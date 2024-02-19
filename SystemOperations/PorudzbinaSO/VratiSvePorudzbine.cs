using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.PorudzbinaSO
{
    public class VratiSvePorudzbine : SystemOperationsBase
    {
        public  List<Porudzbina> poruzbina;
        protected override void executeOperation(IEntity entity)
        {
            poruzbina = repository.GetAll(new Porudzbina()).Cast<Porudzbina>().ToList();
        }
    }
}
