using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.Controller
{
    public class MainController
    {

        internal void otvoriUCUnosPorudzbine(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCUnosPorudzbine(new OrderControler()));
        }


    }
}
