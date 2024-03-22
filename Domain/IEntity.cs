using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntity
    {
        string nazivTabele{ get; }
        string primarniKljuc { get; }
         string uslovPrimarni { get; }
        string uslovOstalo { get; }
        string izmena { get; }
        string unos { get; }
        string selekcija { get; }
        IEntity GetEntity(SqlDataReader reader); 
        List<IEntity> GetEntites(SqlDataReader reader);
    }
}
