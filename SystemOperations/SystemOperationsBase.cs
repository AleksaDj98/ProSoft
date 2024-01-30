using Domain;
using Library.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationsBase
    {
        protected GenericRepository repository;

        public SystemOperationsBase()
        {
            repository = new GenericRepository();
        }

        public void executeTemplate(IEntity entity)
        {
            try
            {
                repository.openConnection();
                repository.beginTransation();
                executeOperation(entity);
                repository.commitTransation();
            }
            catch (Exception)
            {
                repository.rollbackTransation();
                throw;
            }finally 
            {
                repository.closeConnection();
            }
        }

        protected abstract void executeOperation(IEntity entity);
    }
}
