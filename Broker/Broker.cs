using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
       
        public Broker() 
        { 
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProSoftProjekat;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }
        
        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }

        public void BeginTransacton()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void Delete(IEntity entity)
        {
            SqlCommand command = new SqlCommand("",connection,transaction);
            command.CommandText = $"DELETE FROM {entity.nazivTabele} {entity.uslovPrimarni}";
            if(command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error");
            }
        } 

        public void Save(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.nazivTabele} values ({entity.unos})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public IEntity getOne(IEntity entity)
        {
            IEntity rezultat;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT {entity.selekcija} from {entity.nazivTabele} {entity.uslovPrimarni}";
            SqlDataReader reader = command.ExecuteReader();
            rezultat = entity.GetEntity(reader);
            reader.Close();
            return rezultat;
        }

        public List<IEntity> getAll(IEntity entity)
        {
            List<IEntity> rezultat;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT {entity.selekcija} from {entity.nazivTabele}  {entity.uslovOstalo}";
            SqlDataReader reader = command.ExecuteReader();
            rezultat = entity.GetEntites(reader);
            reader.Close();
            return rezultat;
        }


        public int GetNewId(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select max({entity.primarniKljuc}) from {entity.nazivTabele}";
            object result = command.ExecuteScalar();
            if (result is DBNull)
            {
                return 1;
            }
            else
            {
                return (int)result + 1;
            }
        }

        public void Update(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"UPDATE {entity.nazivTabele} {entity.izmena} {entity.uslovPrimarni}";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }
    }
}
