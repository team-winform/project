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
using DTOs;

namespace main_GUI
{
    public partial class GiangVienDialog_search : Form
    {
        public GiangVienDialog_search()
        {
            InitializeComponent();
        }

        private void Bt_tim_Click(object sender, EventArgs e)
        {
            
        }

        private void Bt_them_Click(object sender, EventArgs e)
        {

        }

        private void Bt_sua_Click(object sender, EventArgs e)
        {
            int index = dgv_GV.CurrentCell.RowIndex;
            String ma = dgv_GV.Rows[index].Cells["id_GV"].Value.ToString();
            new GiangVienDialog_InsertUpdate(1, ma).ShowDialog();
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
                    dgv_GV.DataSource = GiangVienBLL.Instance.getAll();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Bt_tim_Click_1(object sender, EventArgs e)
        {
            if (cb_loaitk.Text == "Theo mã")
            {
                
                string ma = tb_gv.Text;
                List<GiangVienDTO> gvs = new List<GiangVienDTO>();
                gvs.Add(GiangVienBLL.Instance.findById(ma));
                dgv_GV.DataSource = gvs;

            }
            else
            {
                string ten = tb_gv.Text;
                dgv_GV.DataSource = GiangVienBLL.Instance.findByName(ten);
            }
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GiangVienDialog_search_Load(object sender, EventArgs e)
        {
            cb_loaitk.Text = "Theo mã";
        }
    }
}
