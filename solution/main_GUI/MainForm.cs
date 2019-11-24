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
    public partial class MainForm : Form
    {
        AccountDTO accountGlobal = GlobalInfo.accountGlobal;
        TaiKhoanCuaToiBLL taiKhoanCuaToiBLL = new TaiKhoanCuaToiBLL();
        QuanLyLopHocBLL quanLyLopHocBLL = new QuanLyLopHocBLL();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();

            loadTabQuanLyLopHoc();
            loadTabTaiKhoanCuaToi();




        }

        public void hienThongBaoLoi(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void hienThongBao(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        ////////////////////////////////////////////////
        ///
        ///         Trang quan ly tai khoan cua toi
        ///
        /////////////////////////////////////////////////


        private void loadTabTaiKhoanCuaToi()
        {
            tabControl.TabPages.Add(tabPageTaiKhoanCuaToi);

            lbTaiKhoanCuaToi.Text = accountGlobal.username;
            txtHoTen.Text = accountGlobal.fullname;
            txtSoDienThoai.Text = accountGlobal.phone;
        }

        private void btnDoiThongTinCaNhan_Click(object sender, EventArgs e)
        {
            taiKhoanCuaToiBLL.doiThongTinCaNhan(accountGlobal, txtHoTen.Text, txtSoDienThoai.Text);
            hienThongBao("Đổi thông tin thành công");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            taiKhoanCuaToiBLL.dangXuat();
            new LoginForm().Show();
            this.Dispose();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                taiKhoanCuaToiBLL.doiMatKhau(txtMatKhauCu.Text, txtMatKhauMoi.Text, txtMatKhauMoi2.Text);
                hienThongBao("Đổi mật khẩu thành công");
            }
            catch (Exception ee)
            {
                hienThongBaoLoi(ee.Message);
            }
        }

        private void clearPasswordText()
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtMatKhauMoi2.Text = "";
        }

        ////////////////////////////////////////////////
        ///
        ///         Trang quan ly lop hoc
        ///
        /////////////////////////////////////////////////

        private void loadTabQuanLyLopHoc()
        {
            tabControl.TabPages.Add(tabQuanLyLopHoc);

            cbTieuChiTimKiemLop.SelectedIndex = 0;
        }

        // Cho nhập số dương only
        private void txtTrangLopHoc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void txtTrangLopHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { }
                //hienThiGrdLopHoc();
        }

        private void hienThiGrdLopHoc(List<LopHocDTO> lstLopHocs)
        {
            grdLopHoc.Rows.Clear();
            int index = 0;
            foreach (LopHocDTO dto in lstLopHocs)
            {
                grdLopHoc.Rows.Add();
                grdLopHoc.Rows[index].Cells[0].Value = "";
                index++;
            }
        }



        private void btTrangTruocLopHoc_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txtTrangLopHoc.Text);
            if (page > 1)
            {
                txtTrangLopHoc.Text = (page - 1).ToString();
                //hienThiGrdLopHoc();
            }
        }

        private void btTrangSauLopHoc_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txtTrangLopHoc.Text);
            txtTrangLopHoc.Text = (page + 1).ToString();
            //hienThiGrdLopHoc();
        }


        private void btTimKiemLop_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemLop.Text;
            
        }
    }
}
