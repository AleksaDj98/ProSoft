using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View
{
    public partial class FrmLogin : Form
    {
        LoginController loginController;
        public FrmLogin(Controller.LoginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
            txtPass.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPass.Text  += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPass.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPass.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPass.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPass.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPass.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPass.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPass.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPass.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtPass.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (loginController.Connect())
            {
                loginController.Login(txtPass, this);
            }
        }

        private void btnObrisiBr_Click(object sender, EventArgs e)
        {
            if(txtPass.Text.Length > 0)
            {
                txtPass.Text = txtPass.Text.Substring(0, txtPass.Text.Length - 1);
            }
        }
    }
}
