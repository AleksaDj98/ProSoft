using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class VrstaProizvoda
    {
        private int vrstaProizvodaID;
        private string nazivVrsteProizvoda;

        public int VrstaProizvodaID { get => vrstaProizvodaID; set => vrstaProizvodaID = value; }
        public string NazivVrsteProizvoda { get => nazivVrsteProizvoda; set => nazivVrsteProizvoda = value; }
    }
}
