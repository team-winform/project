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
    public partial class GiangVienGUI : Form
    {
        public GiangVienGUI()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GiangVienGUI_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_them_Click(object sender, EventArgs e)
        {
            new GiangVienDialog_InsertUpdate(0, null).ShowDialog();
            hienThi();
        }

        private void hienThi()
        {
            dgv_GV.DataSource = GiangVienBLL.Instance.getAll();
        }

        private void Bt_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_GV.CurrentCell.RowIndex;
            String ma = dgv_GV.Rows[index].Cells["id_GV"].Value.ToString();
            string ten = dgv_GV.Rows[index].Cells["ten_GV"].Value.ToString();
            String message = "Xác nhận xóa Giảng viên: " + ten;

            DialogResult result = MessageBox.Show(message, "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (GiangVienBLL.Instance.delete(ma))
                {
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Bt_sua_Click(object sender, EventArgs e)
        {
            int index = dgv_GV.CurrentCell.RowIndex;
            String ma = dgv_GV.Rows[index].Cells["id_GV"].Value.ToString();
            new GiangVienDialog_InsertUpdate(1, ma).ShowDialog();
            hienThi();
        }

        private void Bt_tim_Click(object sender, EventArgs e)
        {
            new GiangVienDialog_search().Show();
        }
    }
}
