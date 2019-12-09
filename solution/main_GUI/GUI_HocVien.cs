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
    public partial class GUI_HocVien : Form
    {
        private HocVienBLL hocVienBll;
        private DiemDanhBLL diemDanhBLL;
        public GUI_HocVien()
        {
            InitializeComponent();
            this.hocVienBll = new HocVienBLL();
            this.diemDanhBLL = new DiemDanhBLL();
        }

        private void GUI_HocVien_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Tahoma", 10);
            try
            {
                comboBox1.DataSource = diemDanhBLL.getAllLopHoc();
                comboBox1.DisplayMember = "ten_LH";
                comboBox1.ValueMember = "id_LH";

                String maLop = comboBox1.SelectedValue.ToString();
                dataGridView1.DataSource = hocVienBll.getListHocVien(maLop);
            }
            catch (Exception ex)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maLop = comboBox1.SelectedValue.ToString();
            dataGridView1.DataSource = hocVienBll.getListHocVien(maLop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String maLop = comboBox1.SelectedValue.ToString();
                new Dialog_HocVien(true, null, maLop).ShowDialog();
                dataGridView1.DataSource = hocVienBll.getListHocVien(maLop);
            }
            catch
            {
                MessageBox.Show("Hãy chọn lớp");
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                String maLop = comboBox1.SelectedValue.ToString();
                String maHV = dataGridView1.Rows[index].Cells["id_HV"].Value.ToString();
                new Dialog_HocVien(false, maHV, null).ShowDialog();
                dataGridView1.DataSource = hocVienBll.getListHocVien(maLop);
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String maLop = comboBox1.SelectedValue.ToString();
                int index = dataGridView1.CurrentCell.RowIndex;
                String ma = dataGridView1.Rows[index].Cells["id_HV"].Value.ToString();
                DialogResult result = MessageBox.Show("bạn có muốn xóa", "xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int rowUpdate = hocVienBll.delete(ma,maLop);
                    if (rowUpdate != 0) MessageBox.Show("Xóa học viên thành công");                 
                }
                dataGridView1.DataSource = hocVienBll.getListHocVien(maLop);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa học viên thất bại");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
