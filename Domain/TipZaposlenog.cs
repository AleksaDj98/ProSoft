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
    public class TipZaposlenog:IEntity
    {
        private int tipID;
        private string nazivTipa;
        private bool ovlascenje;

        public int TipID { get => tipID; set => tipID = value; }
        public string NazivTipa { get => nazivTipa; set => nazivTipa = value; }
        public bool Ovlascenje { get => ovlascenje; set => ovlascenje = value; }

        public override string ToString()
        {
            return NazivTipa;
        }

        [Browsable(false)]
        public string nazivTabele => "TipZaposlenog";
        [Browsable(false)]
        public string primarniKljuc => "TipID";
        [Browsable(false)]
        public string uslovPrimarni => $"TipID = {TipID}";
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;
        [Browsable(false)]
        public string selekcija => "*";
        [Browsable(false)]
        public List<IEntity> GetEntites(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                TipZaposlenog t = new TipZaposlenog();
                t.tipID = Convert.ToInt32(reader["TipID"]);
                t.NazivTipa = reader["NazivTipa"].ToString();
                t.Ovlascenje = Convert.ToBoolean(reader["ovlacenja"]);
                result.Add(t);
            }
            return result;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
