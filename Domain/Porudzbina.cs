using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Porudzbina
    {
        private int porudzbinaID;
        private int proizvodID;
        private int zaposleniID;
        private int stoID;
        private DateTime vremePorudzbine;

        public int PorudzbinaID { get => porudzbinaID; set => porudzbinaID = value; }
        public int ProizvodID { get => proizvodID; set => proizvodID = value; }
        public int ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        public int StoID { get => stoID; set => stoID = value; }
        public DateTime VremePorudzbine { get => vremePorudzbine; set => vremePorudzbine = value; }
    }
}
