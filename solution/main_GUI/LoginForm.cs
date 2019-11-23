using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using BLLs;

namespace main_GUI
{
    public partial class LoginForm : Form
    {
        LoginBLL loginBLL = new LoginBLL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lbLoginErr.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = Utils.MD5Hash(txtPassword.Text);

            GlobalInfo.accountGlobal = loginBLL.login(username, password);
            if (GlobalInfo.accountGlobal == null)
            {
                lbLoginErr.Show();
            }
            else
            {
                clearTextBox();
                this.Hide();
                new MainForm().Show();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void clearTextBox()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}
