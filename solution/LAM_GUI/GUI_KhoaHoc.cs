using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAM_BLL;

namespace LAM_GUI
{
    public partial class GUI_KhoaHoc : Form
    {
        public GUI_KhoaHoc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BLL().getAllKhoaHoc();
        }
    }
}
