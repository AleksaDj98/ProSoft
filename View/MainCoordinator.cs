using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Controller;

namespace View
{
    public class MainCoordinator
    {
        private MainController controller = new MainController();
        private LoginController loginController = new LoginController();
        private FrmLogin frmLogin;
        private FrmMain frmMain;
        
        public Zaposleni zaposleni { get; set; }

        private static MainCoordinator instance;
        private MainCoordinator() { }

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null) instance = new MainCoordinator();
                return instance;
            }
        }

        public void OpenLoginForm()
        {
            frmLogin = new FrmLogin(loginController);
            frmLogin.Show();
        }

        public void OpenMainForm()
        {
            frmMain = new FrmMain(controller,instance);
            frmMain.Show();
        }

    }
}
