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
    public class StavkaPorudzbine:IEntity
    {
        private string naziv;
        private int kolicina;
        private int cena;
        private Proizvod proizvod;
        private Porudzbina porudzbina;

        public string Naziv { get => naziv; set => naziv = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public int Cena { get => cena; set => cena = value; }
        [Browsable(false)]
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }
        [Browsable(false)]
        public Porudzbina Porudzbina { get => porudzbina; set => porudzbina = value; }

        [Browsable(false)]
        public string nazivTabele => "StavkaPorudzbine";
        [Browsable(false)]
        public string primarniKljuc => null;
        [Browsable(false)]
        public string uslovPrimarni => $"where PorudzbinaID = {Porudzbina.PorudzbinaID}";
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => null;
        [Browsable(false)]
        public string unos => $"{Proizvod.ProizvodID},{Porudzbina.PorudzbinaID},{Kolicina},{Cena}";
        [Browsable(false)]
        public string selekcija => "*";

  

        [Browsable(false)]
        public List<IEntity> GetEntites(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                StavkaPorudzbine sp = new StavkaPorudzbine();
                Porudzbina p = new Porudzbina();
                p.PorudzbinaID = Convert.ToInt32(reader["PorudzbinaID"]);
                sp.Porudzbina = p;
                Proizvod pr = new Proizvod();
                pr.ProizvodID = Convert.ToInt32(reader["ProizvodID"]);
                sp.Proizvod = pr;
                kolicina = Convert.ToInt32(reader["Kolicina"]);
                cena = (int)Convert.ToDouble(reader["Cena"]);
                result.Add(sp);
            }
            return result;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {;
            StavkaPorudzbine sp = new StavkaPorudzbine();
            while (reader.Read())
            {
                Porudzbina p = new Porudzbina();
                p.PorudzbinaID = Convert.ToInt32(reader["PorudzbinaID"]);
                sp.Porudzbina = p;
                Proizvod pr = new Proizvod();
                pr.ProizvodID = Convert.ToInt32(reader["ProizvodID"]);
                sp.Proizvod = pr;
                kolicina = Convert.ToInt32(reader["Kolicina"]);
                cena = (int)Convert.ToDouble(reader["Cena"]);
            }
            return sp;
        }
    }
}
