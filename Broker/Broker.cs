using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker() 
        { 
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProSoftProjekat;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
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
        


    }
}
