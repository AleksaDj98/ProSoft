using Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Controller
{
    public class LoginController
    {
		

        internal bool Connect()
        {
			try
			{
				Communication.Communication.Instance.Connection();
				return true;
			}
			catch (Exception)
			{
				System.Windows.Forms.MessageBox.Show("Greska prilikom povezivanja sa Serverom");
				return false;
			}
        }

        internal void Login(TextBox text, FrmLogin frmLogin)
        {
            if(string.IsNullOrEmpty(text.Text))
			{
				text.BackColor = Color.Salmon;
				text.Focus();
				return;
			}

			try
			{
				Zaposleni z = Communication.Communication.Instance.Login(text.Text);


				//for (int i = 0; i < z.Count; i++)
				//{
				//	if (z[i].SifraLogovanja == text.Text)
				//	{
				//                    MainCoordinator.Instance.zaposleni = z[i];
				//                    MessageBox.Show($"{z[i].ImeZaposlenog} dobrodosao/la");
				//		MainCoordinator.Instance.OpenMainForm();
				//		frmLogin.Dispose();
				//		return;
				//	}
				//}
				//MessageBox.Show("Korisnik sa ovom sifrom nije pronadjen"); return;

				if (z == null)
				{
					MessageBox.Show("korisnik sa ovim podacima nije pronadjen"); return;
				}
				MessageBox.Show($"{z.ImeZaposlenog} dobrodosao/la");
				MainCoordinator.Instance.zaposleni = z;
				MainCoordinator.Instance.OpenMainForm();
				frmLogin.Dispose();
			}
			catch (Exception)
			{
				MessageBox.Show("greska");
				return;
			}


        }
    }
}
