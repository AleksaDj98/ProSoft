using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Racun:IEntity
    {
        private int racunID;
        private DateTime vremeIzdavanja;
        private int cenaRacuna;
        private List<Porudzbina> porudzbina;

        public int RacunID { get => racunID; set => racunID = value; }
        public DateTime VremeIzdavanja { get => vremeIzdavanja; set => vremeIzdavanja = value; }
        public int CenaRacuna { get => cenaRacuna; set => cenaRacuna = value; }
        public List<Porudzbina> Stavke { get => porudzbina; set => porudzbina = value; }

        public string nazivTabele => "Racun";

        public string primarniKljuc => "RacunID";

        public string uslovPrimarni => $" WHERE Racunid = {RacunID}";

        public string uslovOstalo => null;

        public string izmena => $" SET VremeIzdavanja = '{VremeIzdavanja.ToString("yyyy-MM-dd HH:mm:ss")}', Cena = {cenaRacuna}";

        public string unos => $"{RacunID},'{vremeIzdavanja.ToString("yyyy-MM-dd HH:mm:ss")}',{CenaRacuna}";

        public string selekcija => "*";


        public List<IEntity> GetEntites(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Racun r = new Racun();
                r.racunID = Convert.ToInt32(reader["RacunID"]);
                r.VremeIzdavanja = Convert.ToDateTime(reader["VremeIzdavanja"]);
                r.cenaRacuna = Convert.ToInt32(reader["Cena"]);
                result.Add(r);
            }
            return result;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            Racun r = new Racun();
            while (reader.Read())
            {
                r.racunID = Convert.ToInt32(reader["RacunID"]);
                r.VremeIzdavanja = Convert.ToDateTime(reader["VremeIzdavanja"]);
                r.cenaRacuna = Convert.ToInt32(reader["Cena"]);
            }
            return r;
        }
    }
}
