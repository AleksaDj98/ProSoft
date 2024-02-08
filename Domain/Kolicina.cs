using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Kolicina
    {
        private Porudzbina porudzbinaID;
        private Proizvod proizvodID;
        private int stanjeLagera;

        public Porudzbina  PorudzbinaID { get => porudzbinaID; set => porudzbinaID = value; }
        public Proizvod ProizvodID { get => proizvodID; set => proizvodID = value; }
        public int StanjeLagera { get => stanjeLagera; set => stanjeLagera = value; }


    }
}
