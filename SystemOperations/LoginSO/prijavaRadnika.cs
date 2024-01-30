using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.LoginSO
{
    public class prijavaRadnika : SystemOperationsBase
    {
        public List<Zaposleni> zap;
        protected override void executeOperation(IEntity entity)
        {
                zap  = repository.GetAll(entity).Cast<Zaposleni>().ToList();
        }
    }
}
