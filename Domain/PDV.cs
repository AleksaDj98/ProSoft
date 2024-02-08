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
    public class PDV:IEntity
    {
        private int PDVID;
        private int procenatPDV;

        public int PDVID1 { get => PDVID; set => PDVID = value; }
        public int ProcenatPDV { get => procenatPDV; set => procenatPDV = value; }

        public override string ToString() => PDVID1.ToString();

        [Browsable(false)]
        public string nazivTabele => "PDV";
        [Browsable(false)]
        public string primarniKljuc => "PDVID";
        [Browsable(false)]
        public string uslovPrimarni => null;
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => null;
        [Browsable(false)]
        public string selekcija => "*";

        public List<IEntity> GetEntites(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                PDV pdv = new PDV();
                pdv.PDVID =     Convert.ToInt32(reader["PDVID"]);
                pdv.procenatPDV = Convert.ToInt32(reader["ProcenatPDV"]);
                result.Add(pdv);
            }
            return result;
        }
    }
}
