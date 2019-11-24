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

namespace main_GUI
{
    public partial class GUI_KhoaHoc : Form
    {
        KhoaHocBLL khoaHocBLL;
        public GUI_KhoaHoc()
        {
            InitializeComponent();
            this.khoaHocBLL = new KhoaHocBLL();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new Font("Tahoma", 10);
            dataGridView1.DataSource = this.khoaHocBLL.getAllKhoaHoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            String ma = dataGridView1.Rows[index].Cells["id_KH"].Value.ToString();
            String ten = dataGridView1.Rows[index].Cells["ten_KH"].Value.ToString();
            String message = "xác nhận xóa khóa học " + ten + " có mã " + ma+" ?";
            DialogResult dr = MessageBox.Show(message, "xác nhận xóa khóa học", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int result = this.khoaHocBLL.deleteKhoaHoc(ma);
                    if (result != 0)
                    {
                        MessageBox.Show("Xóa khóa học thành công ");
                        dataGridView1.DataSource = this.khoaHocBLL.getAllKhoaHoc();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thể xóa khóa học: \n"+ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new Dialog_KhoaHOC(1, null).ShowDialog();
            this.dataGridView1.DataSource = this.khoaHocBLL.getAllKhoaHoc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            String ma = dataGridView1.Rows[index].Cells["id_KH"].Value.ToString();
            new Dialog_KhoaHOC(0, ma).ShowDialog();
            this.dataGridView1.DataSource = this.khoaHocBLL.getAllKhoaHoc();
        }

        private void cellClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            String ma = dataGridView1.Rows[index].Cells["id_KH"].Value.ToString();
            new Dialog_ThongTinKhoaHoc(ma).ShowDialog();
        }
    }
}
