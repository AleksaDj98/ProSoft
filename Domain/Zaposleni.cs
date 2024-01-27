using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Zaposleni
    {
        private int zaposleniID;
        private string imeZaposlenog;
        private int sifraLogovanja;
        private int tipID;

        public int ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        public string ImeZaposlenog { get => imeZaposlenog; set => imeZaposlenog = value; }
        public int SifraLogovanja { get => sifraLogovanja; set => sifraLogovanja = value; }
        public int TipID { get => tipID; set => tipID = value; }
    }
}
