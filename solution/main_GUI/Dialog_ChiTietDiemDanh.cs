using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLs;

namespace main_GUI
{
    public partial class Dialog_ChiTietDiemDanh : Form
    {
        private String maHV;
        private String maLH;
        public Dialog_ChiTietDiemDanh(String maHV,String maLH)
        {
            InitializeComponent();
            this.maHV = maHV;
            this.maLH = maLH;
        }

        private void Dialog_ChiTietDiemDanh_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Tahoma", 10);
            dataGridView1.DataSource = new DiemDanhBLL().getDayOF(maHV, maLH);
        }
    }
}
