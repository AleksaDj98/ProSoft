using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Proizvod
    {
        private int proizvodID;
        private string nazivProizvoda;
        private int prodajnaCena;
        private float cenaBezPDV;
        private float vrednostPDV;
        private int stanjeLagera;
        private int pDVID;
        private int vrstaProizvoda;
        private int cenovnikID;

        public int ProizvodID { get => proizvodID; set => proizvodID = value; }
        public string NazivProizvoda { get => nazivProizvoda; set => nazivProizvoda = value; }
        public int ProdajnaCena { get => prodajnaCena; set => prodajnaCena = value; }
        public float CenaBezPDV { get => cenaBezPDV; set => cenaBezPDV = value; }
        public float VrednostPDV { get => vrednostPDV; set => vrednostPDV = value; }
        public int StanjeLagera { get => stanjeLagera; set => stanjeLagera = value; }
        public int PDVID { get => pDVID; set => pDVID = value; }
        public int VrstaProizvoda { get => vrstaProizvoda; set => vrstaProizvoda = value; }
        public int CenovnikID { get => cenovnikID; set => cenovnikID = value; }
    }
}
