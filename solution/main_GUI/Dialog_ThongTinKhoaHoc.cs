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
    public partial class Dialog_ThongTinKhoaHoc : Form
    {
        private KhoaHocBLL khoaHocBLL;
        private String ma;
        public Dialog_ThongTinKhoaHoc(String ma)
        {
            InitializeComponent();
            this.khoaHocBLL = new KhoaHocBLL();
            this.ma = ma;
        }

        private void Dialog_ThongTinKhoaHoc_Load(object sender, EventArgs e)
        {
            Dictionary<String, String> dic = khoaHocBLL.findKhoaHoc(ma);
            label1.Text += dic["ten_KH"].ToString();
            dataGridView1.Font = new Font("Tahoma", 10);
            DataTable tb = khoaHocBLL.getLopHocOfKhoaHoc(ma);
            this.dataGridView1.DataSource = tb;
        }
    }
}
