using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sto
    {
        private int stoID;
        private int brojStola;

        public int StoID { get => stoID; set => stoID = value; }
        public int BrojStola { get => brojStola; set => brojStola = value; }
    }
}
