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
    }
}
