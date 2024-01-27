using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cenovnik
    {
        private int cenovnikID;
        private int stavkaCenovnika;

        public int CenovnikID { get => cenovnikID; set => cenovnikID = value; }
        public int StavkaCenovnika { get => stavkaCenovnika; set => stavkaCenovnika = value; }
    }
}
