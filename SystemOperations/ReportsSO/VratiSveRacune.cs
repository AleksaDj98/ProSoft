using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ReportsSO
{
    public class VratiSveRacune : SystemOperationsBase
    {
        public List<Racun> racun;
        protected override void ExecuteOperation(IEntity entity)
        {
           racun = repository.GetAll(new Racun()).Cast<Racun>().ToList();
        }
    }
}
