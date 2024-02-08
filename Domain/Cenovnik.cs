using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Cenovnik:IEntity
    {
        private int cenovnikID;
        private int stavkaCenovnika;

        public int CenovnikID { get => cenovnikID; set => cenovnikID = value; }
        public int StavkaCenovnika { get => stavkaCenovnika; set => stavkaCenovnika = value; }

        [Browsable(false)]
        public string nazivTabele => "Cenovnik";
        [Browsable(false)]
        public string primarniKljuc => "CenovikID";
        [Browsable(false)]
        public string uslovPrimarni => $"cenovnikID = {CenovnikID}";
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => $"{CenovnikID}, {StavkaCenovnika}";
        [Browsable(false)]
        public string selekcija => "*";

        public List<IEntity> GetEntites(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Cenovnik c = new Cenovnik();
                 c.CenovnikID = Convert.ToInt32(reader["CenovnikID"]);
                 c.StavkaCenovnika = Convert.ToInt32(reader["StavkaCenovnika"]);
                result.Add(c);
            }
            return result;
        }
    }
}
