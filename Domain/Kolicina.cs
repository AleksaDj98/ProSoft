using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Kolicina
    {
        private int porudzbinaID;
        private int proizvodID;
        private int stanjeLagera;

        public int PorudzbinaID { get => porudzbinaID; set => porudzbinaID = value; }
        public int ProizvodID { get => proizvodID; set => proizvodID = value; }
        public int StanjeLagera { get => stanjeLagera; set => stanjeLagera = value; }
    }
}
