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
    public class Proizvod: IEntity
    {
        private int proizvodID;
        private string nazivProizvoda;
        private int prodajnaCena;
        private float cenaBezPDV;
        private float vrednostPDV;
        private int stanjeLagera;
        private PDV PDV;
        private VrstaProizvoda vrstaProizvoda;
        private bool aktivan;

        public override string ToString()
        {
            return NazivProizvoda;
        }

        [Browsable(false)]
        public int ProizvodID { get => proizvodID; set => proizvodID = value; }
        public string NazivProizvoda { get => nazivProizvoda; set => nazivProizvoda = value; }
        public int ProdajnaCena { get => prodajnaCena; set => prodajnaCena = value; }
        [Browsable(false)]
        public float CenaBezPDV { get => cenaBezPDV; set => cenaBezPDV = value; }
        [Browsable(false)]
        public float VrednostPDV { get => vrednostPDV; set => vrednostPDV = value; }
        [Browsable(false)]
        public int StanjeLagera { get => stanjeLagera; set => stanjeLagera = value; }
        [Browsable(false)]
        public PDV pdv { get => PDV; set => PDV = value; }
        [Browsable(false)]
        public VrstaProizvoda VrstaProizvoda { get => vrstaProizvoda; set => vrstaProizvoda = value; }
        public bool Aktivan { get => aktivan; set => aktivan = value; }
        [Browsable(false)]
        public string nazivTabele => "Proizvod";
        [Browsable(false)]
        public string primarniKljuc => "ProizvodID";
        [Browsable(false)]
        public string uslovPrimarni => $"where LOWER(nazivProizvoda) = LOWER('{NazivProizvoda}')";
        [Browsable(false)]
        public string uslovOstalo => null;
        [Browsable(false)]
        public string izmena => $"set Aktivan = CASE WHEN Aktivan = 1 THEN 0 WHEN Aktivan = 0 THEN 1 END";
        [Browsable(false)]
        public string unos => $"'{NazivProizvoda}',{ProdajnaCena},{CenaBezPDV},{VrednostPDV},{StanjeLagera},{pdv.PDVID1},{VrstaProizvoda.VrstaProizvodaID}"; 
        [Browsable(false)]
        public string selekcija => "*";

   

        public List<IEntity> GetEntites(SqlDataReader reader)
        {
            List<IEntity> result = new List<IEntity>();
            while (reader.Read())
            {
                Proizvod p = new Proizvod();
                p.ProizvodID = Convert.ToInt32(reader["ProizvodID"]);
                p.NazivProizvoda = reader["nazivProizvoda"].ToString();
                p.prodajnaCena = Convert.ToInt32(reader["prodajnaCena"]);
                p.cenaBezPDV = Convert.ToInt32(reader["cenaBezPDV"]);
                p.VrednostPDV = Convert.ToInt32(reader["vrednostPDV"]);
                p.StanjeLagera = Convert.ToInt32(reader["stanjeLagera"]);
                PDV pdv = new PDV();
                pdv.PDVID1 = Convert.ToInt32(reader["PDVID"]);
                p.PDV = pdv;
                VrstaProizvoda vp = new VrstaProizvoda();
                vp.VrstaProizvodaID = Convert.ToInt32(reader["vrstaProizvoda"]);
                p.VrstaProizvoda = vp;
                p.Aktivan = Convert.ToBoolean(reader["Aktivan"]);
                result.Add(p);
            }
            return result;
        }

        public IEntity GetEntity(SqlDataReader reader)
        {
            Proizvod p = new Proizvod();
            while (reader.Read())
            {
                //Proizvod p = new Proizvod();
                p.ProizvodID = Convert.ToInt32(reader["ProizvodID"]);
                p.NazivProizvoda = reader["nazivProizvoda"].ToString();
                p.prodajnaCena = Convert.ToInt32(reader["prodajnaCena"]);
                p.cenaBezPDV = Convert.ToInt32(reader["cenaBezPDV"]);
                p.VrednostPDV = Convert.ToInt32(reader["vrednostPDV"]);
                p.StanjeLagera = Convert.ToInt32(reader["stanjeLagera"]);
                PDV pdv = new PDV();
                pdv.PDVID1 = Convert.ToInt32(reader["PDVID"]);
                p.PDV = pdv;
                VrstaProizvoda vp = new VrstaProizvoda();
                vp.VrstaProizvodaID = Convert.ToInt32(reader["vrstaProizvoda"]);
                p.VrstaProizvoda = vp;
                p.Aktivan = Convert.ToBoolean(reader["Aktivan"]);
            }
            return p;
        }
    }
 }

