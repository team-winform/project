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
    public partial class GUI_TaiKhoanCuaToi : Form
    {
        TaiKhoanCuaToiBLL taiKhoanCuaToiBLL = new TaiKhoanCuaToiBLL();
        AccountDTO accountGlobal = GlobalInfo.accountGlobal;

        public GUI_TaiKhoanCuaToi()
        {
            InitializeComponent();
        }


        private void GUI_TaiKhoanCuaToi_Load(object sender, EventArgs e)
        {
            if (accountGlobal != null)
            {
                lbTaiKhoanCuaToi.Text = accountGlobal.username;
                txtHoTen.Text = accountGlobal.fullname;
                txtSoDienThoai.Text = accountGlobal.phone;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            taiKhoanCuaToiBLL.dangXuat();
            Application.Restart();
            //new LoginForm().Show();
            //this.Dispose();
        }

        private void btnDoiThongTinCaNhan_Click(object sender, EventArgs e)
        {
            taiKhoanCuaToiBLL.doiThongTinCaNhan(accountGlobal, txtHoTen.Text, txtSoDienThoai.Text);
            hienThongBao("Đổi thông tin thành công");
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                taiKhoanCuaToiBLL.doiMatKhau(txtMatKhauCu.Text, txtMatKhauMoi.Text, txtMatKhauMoi2.Text);
                hienThongBao("Đổi mật khẩu thành công");
                clearPasswordText();
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



        public void hienThongBaoLoi(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult hienThongBao(string message)
        {
            return MessageBox.Show(message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

    }
}
