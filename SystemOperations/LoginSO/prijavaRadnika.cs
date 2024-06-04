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
        public Zaposleni zap;
        protected override void ExecuteOperation(IEntity entity)
        {
                zap  = repository.GetOne(entity) as Zaposleni;
        }
    }
}
