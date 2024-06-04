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
        public void BeginTransation() => broker.BeginTransacton();
        public void CloseConnection() => broker.CloseConnection();
        public void CommitTransation() => broker.Commit();
        public List<IEntity> GetAll(IEntity e) => broker.GetAll(e);
        public void OpenConnection() => broker.OpenConnection();
        public void RollbackTransation() => broker.Rollback();
        public void Save(IEntity entity) => broker.Save(entity);
        public void Delete(IEntity entity) => broker.Delete(entity);
        public int GetNewID(IEntity entity) => broker.GetNewId(entity);
        public void Update(IEntity entity) => broker.Update(entity);
        public IEntity GetOne(IEntity entity) => broker.GetOne(entity);
    }
}
