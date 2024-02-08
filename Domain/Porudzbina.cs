using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Porudzbina
    {
        private int porudzbinaID;
        private Proizvod proizvodID;
        private Zaposleni zaposleniID;
        private Sto stoID;
        private DateTime vremePorudzbine;

        public int PorudzbinaID { get => porudzbinaID; set => porudzbinaID = value; }
        public Proizvod ProizvodID { get => proizvodID; set => proizvodID = value; }
        public Zaposleni ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        public Sto StoID { get => stoID; set => stoID = value; }
        public DateTime VremePorudzbine { get => vremePorudzbine; set => vremePorudzbine = value; }
    }
}
