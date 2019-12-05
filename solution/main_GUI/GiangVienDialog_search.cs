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
        GiangVienGUI gvGui;
        public GiangVienDialog_search(GiangVienGUI gvg)
        {
            gvGui = gvg;
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
            hienThiGrid();

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
                    hienThiGrid();
                    showButton();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Bt_tim_Click_1(object sender, EventArgs e)
        {
            hienThiGrid();
            showButton();
        }

        private void hienThiGrid()
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
            gvGui.enableButtonSearch();
            this.Close();
        }

        private void GiangVienDialog_search_Load(object sender, EventArgs e)
        {
            cb_loaitk.Text = "Theo mã";
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
        }

        private void GiangVienDialog_search_Leave(object sender, EventArgs e)
        {
            
        }

        private void GiangVienDialog_search_FormClosed(object sender, FormClosedEventArgs e)
        {
            gvGui.enableButtonSearch();
        }

        private void Dgv_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showButton();
        }

        private void showButton()
        {
            if (dgv_GV.Rows.Count > 0 && dgv_GV.Rows[0].Cells[0].Value != null)
            {
                Console.WriteLine("true");
                bt_xoa.Enabled = true;
                bt_sua.Enabled = true;
            }
            else
            {
                Console.WriteLine("false");
                bt_xoa.Enabled = false;
                bt_sua.Enabled = false;
            }
        }

        private void Dgv_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GiangVienDTO gv = new GiangVienDTO();
            int index = dgv_GV.CurrentCell.RowIndex;
            gv.Id = dgv_GV.Rows[index].Cells["id_GV"].Value.ToString();
            gv.Name = dgv_GV.Rows[index].Cells["ten_GV"].Value.ToString();
            gv.Note = dgv_GV.Rows[index].Cells["ghichu_GV"].Value.ToString();
            gv.Phone = dgv_GV.Rows[index].Cells["sodt_GV"].Value.ToString();
            gv.DayOfBirth = DateTime.Parse(dgv_GV.Rows[index].Cells["ngaysinh_GV"].Value.ToString());
            gv.Address = dgv_GV.Rows[index].Cells["diachi_GV"].Value.ToString();

            new GiangVienDialog_chiTiet(gv).ShowDialog();
        }
    }
}
