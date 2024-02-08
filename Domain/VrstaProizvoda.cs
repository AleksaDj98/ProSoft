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
    public class VrstaProizvoda: IEntity
    {
        private int vrstaProizvodaID;
        private string nazivVrsteProizvoda;

        public int VrstaProizvodaID { get => vrstaProizvodaID; set => vrstaProizvodaID = value; }
        public string NazivVrsteProizvoda { get => nazivVrsteProizvoda; set => nazivVrsteProizvoda = value; }

        public override string ToString()
        {
            return NazivVrsteProizvoda;
        }
        [Browsable(false)]
        public string nazivTabele => "VrstaProizvoda";
        [Browsable(false)]
        public string primarniKljuc => "VrstaProizvodaID";
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
                VrstaProizvoda vp = new VrstaProizvoda();
                vp.vrstaProizvodaID = Convert.ToInt32(reader["vrstaProizvodaID"]);
                vp.nazivVrsteProizvoda = reader["NazivVrsteProizvoda"].ToString();
                result.Add(vp);
            }
            return result;
        }
    }
}
