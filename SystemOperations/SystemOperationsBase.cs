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

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransation();
                ExecuteOperation(entity);
                repository.CommitTransation();
            }
            catch (Exception)
            {
                repository.RollbackTransation();
                throw;
            }finally 
            {
                repository.CloseConnection();
            }
        }

        protected abstract void ExecuteOperation(IEntity entity);
    }
}
