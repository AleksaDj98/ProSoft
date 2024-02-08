using DatabaseBroker;
using Domain;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Database
{
    public class GenericRepository : IGenericRepository
    {
        private Broker broker = new Broker();
        public void beginTransation() => broker.BeginTransacton();
        public void closeConnection() => broker.CloseConnection();
        public void commitTransation() => broker.Commit();
        public List<IEntity> GetAll(IEntity e) => broker.getAll(e);
        public void openConnection() => broker.OpenConnection();
        public void rollbackTransation() => broker.Rollback();
        public void Save(IEntity entity) => broker.Save(entity);
        public void Delete(IEntity entity) => broker.Delete(entity);
    }
}
