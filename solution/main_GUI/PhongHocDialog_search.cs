using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using BLLs;

namespace main_GUI
{
    public partial class PhongHocDialog_search : Form
    {
        public PhongHocDialog_search()
        {
            InitializeComponent();
        }

        private void Bt_tim_Click(object sender, EventArgs e)
        {
            searchPH();
            showButton();
        }

        private void searchPH()
        {
            if (cb_loai.Text == "Theo mã")
            {

                string ma = tb_ph.Text;
                List<PhongHocDTO> phs = new List<PhongHocDTO>();
                phs.Add(PhongHocBLL.Instance.findById(ma));
                dgv_ph.DataSource = phs;

            }
            else
            {
                string ten = tb_ph.Text;
                dgv_ph.DataSource = PhongHocBLL.Instance.findByName(ten);
            }
        }

        private void PhongHocDialog_search_Load(object sender, EventArgs e)
        {
            cb_loai.Text = "Theo mã";
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
        }

        private void Bt_sua_Click(object sender, EventArgs e)
        {
            int index = dgv_ph.CurrentCell.RowIndex;
            String ma = dgv_ph.Rows[index].Cells["id_PH"].Value.ToString();
            new PhongHocDialog_insertupdate(ma, false).ShowDialog();
            dgv_ph.DataSource = PhongHocBLL.Instance.getAll();
        }

        private void Bt_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_ph.CurrentCell.RowIndex;
            String ma = dgv_ph.Rows[index].Cells["id_PH"].Value.ToString();
            string ten = dgv_ph.Rows[index].Cells["ten_PH"].Value.ToString();
            String message = "Xác nhận xóa phòng học: " + ten;

            DialogResult result = MessageBox.Show(message, "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (PhongHocBLL.Instance.delete(ma))
                {
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_ph.DataSource = PhongHocBLL.Instance.getAll();
                    showButton();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_ph_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showButton();
        }

        private void showButton()
        {
            if (dgv_ph.Rows.Count > 0 && dgv_ph.Rows[0].Cells[0].Value != null)
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
    }
}
