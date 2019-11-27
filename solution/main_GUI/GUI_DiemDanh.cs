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
    public partial class GUI_DiemDanh : Form
    {
        DiemDanhBLL diemDanhBLL;
        public GUI_DiemDanh()
        {
            InitializeComponent();
            this.diemDanhBLL = new DiemDanhBLL();
        }

        private void GUI_DiemDanh_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text += " ngày " + now.ToString("MM/dd/yyyy");

            dataGridView1.Font = new Font("Tahoma", 10);
            comboBox1.DataSource = this.diemDanhBLL.getAllLopHoc();
            comboBox1.DisplayMember = "ten_LH";
            comboBox1.ValueMember = "id_LH";

            try
            {
                String ma = comboBox1.SelectedValue.ToString();
                dataGridView1.DataSource = this.diemDanhBLL.getDiemDanh(ma);
            }
            catch
            {

            }
        }

        private void change(object sender, EventArgs e)
        {
            try
            {
                String ma = comboBox1.SelectedValue.ToString();
                dataGridView1.DataSource = this.diemDanhBLL.getDiemDanh(ma);
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maLop = comboBox1.SelectedValue.ToString();
            if (this.diemDanhBLL.checkLopHocDaDiemDanh(maLop))
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
                        this.diemDanhBLL.diemDanh(maHV, maLH);
                    }
                }
                MessageBox.Show("Đã điểm danh");
                String ma = comboBox1.SelectedValue.ToString();
                dataGridView1.DataSource = this.diemDanhBLL.getDiemDanh(ma);
            }
            
        }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            String maHV = dataGridView1.Rows[index].Cells["id_HV"].Value.ToString();
            String maLop = comboBox1.SelectedValue.ToString();
            new Dialog_ChiTietDiemDanh(maHV,maLop).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String maLop = comboBox1.SelectedValue.ToString();
            String tenLop = comboBox1.Text;
            new Dialog_ThongKeDiemDanh(maLop,tenLop).ShowDialog();
        }
    }
}
