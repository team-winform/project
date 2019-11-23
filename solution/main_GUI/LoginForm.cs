using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = dateTimePicker1.Value.ToString();
            dateTimePicker2.Value = DateTime.Parse( txtUsername.Text);
        }
    }
}
