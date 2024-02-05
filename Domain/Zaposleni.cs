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
    public class Zaposleni:IEntity
    {
        private int zaposleniID;
        private string imeZaposlenog;
        private string sifraLogovanja;
        private TipZaposlenog tip;

        public int ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        public string ImeZaposlenog { get => imeZaposlenog; set => imeZaposlenog = value; }
        public string SifraLogovanja { get => sifraLogovanja; set => sifraLogovanja = value; }
        public TipZaposlenog Tip { get => this.tip; set => this.tip = value; }

        public override string ToString()
        {
            return ImeZaposlenog.ToString(); 
        }
        [Browsable(false)]
        public string nazivTabele => "Zaposleni";
        [Browsable(false)]
        public string primarniKljuc => "ZaposleniID";
        [Browsable(false)]
        public string uslovPrimarni => $"SifraLogovanja = '{SifraLogovanja}'" ;
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos =>$"'{ImeZaposlenog}','{SifraLogovanja}',{Tip.TipID}";
        [Browsable(false)]
        public string selekcija => "*";
        [Browsable(false)]
        public List<IEntity> GetEntites(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Zaposleni z = new Zaposleni();
                z.ZaposleniID = Convert.ToInt32(reader["ZaposleniID"]);
                z.ImeZaposlenog = reader["ImeZaposlenog"].ToString();
                z.SifraLogovanja = reader["sifraLogovanja"].ToString();
                TipZaposlenog tip = new TipZaposlenog();
                tip.TipID = Convert.ToInt32(reader["tipID"]);
                z.Tip = tip;
                result.Add(z);
            }
            return result;
        }

    }
}
