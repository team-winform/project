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
    public partial class GUI_DiemDanh : Form
    {
        BLL bll;
        public GUI_DiemDanh()
        {
            InitializeComponent();
            this.bll = new BLL();
        }

        private void GUI_DiemDanh_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Tahoma", 10);
            comboBox1.DataSource = bll.getAllLopHoc();
            comboBox1.DisplayMember = "ten_LH";
            comboBox1.ValueMember = "id_LH";

            String ma = comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = bll.getDiemDanh(ma);
        }

        private void change(object sender, EventArgs e)
        {
            String ma = comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = bll.getDiemDanh(ma);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maLop = comboBox1.SelectedValue.ToString();
            if (bll.checkLopHocDaDiemDanh(maLop))
            {
                MessageBox.Show("Lớp học này đã điểm danh");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["vang"].Value != null && int.Parse(row.Cells["vang"].Value.ToString()) == 1)
                    {
                        String maHV = row.Cells["id_HV"].Value.ToString();
                        String maLH = comboBox1.SelectedValue.ToString();
                        bll.diemDanh(maHV, maLH);
                    }
                }
                MessageBox.Show("Đã điểm danh");
                String ma = comboBox1.SelectedValue.ToString();
                dataGridView1.DataSource = bll.getDiemDanh(ma);
            }
            
        }
    }
}
