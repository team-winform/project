﻿using System;
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
    public partial class PhongHocGUI : Form
    {
        public PhongHocGUI()
        {
            InitializeComponent();
        }

        private void PhongHocGUI_Load(object sender, EventArgs e)
        {
            hienThi();
        }

        private void hienThi()
        {
            dgv_ph.DataSource = PhongHocBLL.Instance.getAll();
        }

        private void Bt_them_Click(object sender, EventArgs e)
        {
            new PhongHocDialog_insertupdate(null, true).ShowDialog();

            hienThi();
        }

        private void Bt_sua_Click(object sender, EventArgs e)
        {
            int index = dgv_ph.CurrentCell.RowIndex;
            String ma = dgv_ph.Rows[index].Cells["id_PH"].Value.ToString();
            new PhongHocDialog_insertupdate(ma, false).ShowDialog();

            hienThi();
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
                    hienThi();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Bt_tim_Click(object sender, EventArgs e)
        {
            new PhongHocDialog_search().Show();
            hienThi();
        }

        private void Dgv_ph_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PhongHocDTO ph = new PhongHocDTO();
            int index = dgv_ph.CurrentCell.RowIndex;
            ph.Id = dgv_ph.Rows[index].Cells["id_PH"].Value.ToString();
            ph.Name = dgv_ph.Rows[index].Cells["ten_PH"].Value.ToString();
            ph.Note = dgv_ph.Rows[index].Cells["ghichu_PH"].Value.ToString();
            ph.Created = DateTime.Parse(dgv_ph.Rows[index].Cells["ngaytao"].Value.ToString());
            ph.Updated = DateTime.Parse(dgv_ph.Rows[index].Cells["ngaysua"].Value.ToString());
            ph.MaxSeat = int.Parse(dgv_ph.Rows[index].Cells["succhua_PH"].Value.ToString());
            new PhongHocDialog_ChiTiet(ph).ShowDialog();
        }
    }
}
