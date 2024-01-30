using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class TipZaposlenog
    {
        private int tipID;
        private string nazivTipa;
        private bool ovlascenje;

        public int TipID { get => tipID; set => tipID = value; }
        public string NazivTipa { get => nazivTipa; set => nazivTipa = value; }
        public bool Ovlascenje { get => ovlascenje; set => ovlascenje = value; }
    }
}
