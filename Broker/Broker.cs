using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
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


        

        public void Save(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.nazivTabele} values ({entity.unos})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public List<IEntity> getAll(IEntity entity)
        {
            List<IEntity> rezultat;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT {entity.selekcija} from {entity.nazivTabele} where {entity.uslovPrimarni}{entity.uslovOstalo}";
            SqlDataReader reader = command.ExecuteReader();
            rezultat = entity.GetEntites(reader);
            reader.Close();
            return rezultat;
        }

    }
}
