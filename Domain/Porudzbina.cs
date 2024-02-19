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
    public class Porudzbina: IEntity
    {
        private int porudzbinaID;
        private Zaposleni zaposleniID;
        private Sto stoID;
        private DateTime vremePorudzbine;
        private int cena;
        private List<StavkaPorudzbine> stavkaPorudzbine;
        private Racun r;



        public int PorudzbinaID { get => porudzbinaID; set => porudzbinaID = value; }
        public Zaposleni ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        [Browsable(false)]
        public Sto StoID { get => stoID; set => stoID = value; }
        [Browsable (false)]
        public DateTime VremePorudzbine { get => vremePorudzbine; set => vremePorudzbine = value; }
        public int Cena { get => cena; set => cena = value; }
        public List<StavkaPorudzbine> StavkaPorudzbine { get => stavkaPorudzbine; set => stavkaPorudzbine = value; }
        public Racun R { get => r; set => r = value; }

        public string nazivTabele => "Porudzbina";

        public string primarniKljuc => "PorudzbinaID";

        public string uslovPrimarni => null;

        public string uslovOstalo => null;

        public string izmena => null;

        public string unos => $"{PorudzbinaID},{zaposleniID.ZaposleniID},{StoID.StoID},'{vremePorudzbine.ToString("yyyy-MM-dd HH:mm:ss")}',{Cena},{R.RacunID}";

        public string selekcija => "*";
        public List<IEntity> GetEntites(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Porudzbina p = new Porudzbina();
                p.porudzbinaID = Convert.ToInt32(reader["PorudzbinaID"]);
                Zaposleni z = new Zaposleni();
                z.ZaposleniID = Convert.ToInt32(reader["ZaposleniID"]);
                p.ZaposleniID = z;
                Sto s = new Sto();
                s.StoID = Convert.ToInt32(reader["StoID"]);
                p.StoID = s;
                p.VremePorudzbine = Convert.ToDateTime(reader["Vreme"]);
                p.cena = Convert.ToInt32(reader["Cena"]);
                Racun R= new Racun();
                R.RacunID = Convert.ToInt32(reader["RacunID"]);
                p.R = R;
                result.Add(p);
            }
            return result;
        }
    }
}
