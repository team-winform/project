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
    public partial class Gui_QuanLyTaiKhoan : Form
    {

        QuanLyTaiKhoanBLL quanLyTaiKhoanBLL = new QuanLyTaiKhoanBLL();
        List<AccountDTO> currentListAccount;

        public Gui_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void Gui_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

            cbLevel.SelectedIndex = cbLevel.Items.Count - 1;
            hienThiGrdAccount();
        }

        public void hienThongBaoLoi(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult hienThongBao(string message)
        {
            return MessageBox.Show(message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }


        private string castLevel(int level)
        {
            switch (level)
            {
                case 0:
                    return "Quản trị viên";
                case 1:
                    return "Quản lý";
                case 2:
                    return "Giảng viên";
                default:
                    return "Nhân viên";
            }
        }

        private void hienThiGrdAccount()
        {
            List<AccountDTO> lstAccounts = quanLyTaiKhoanBLL.getAccountTable();
            currentListAccount = lstAccounts;

            grdTaiKhoan.Rows.Clear();
            int index = 0;
            foreach (AccountDTO dto in lstAccounts)
            {
                grdTaiKhoan.Rows.Add();
                grdTaiKhoan.Rows[index].Cells[0].Value = dto.username;
                grdTaiKhoan.Rows[index].Cells[1].Value = "********";
                grdTaiKhoan.Rows[index].Cells[2].Value = castLevel(dto.level);
                grdTaiKhoan.Rows[index].Cells[3].Value = dto.fullname;
                grdTaiKhoan.Rows[index].Cells[4].Value = dto.phone;

                index++;
            }
        }

        private AccountDTO getTaiKhoanOnForm()
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                hienThongBaoLoi("Tài khoản, mật khẩu không được để trống");
                return null;
            }
            else
            {
                AccountDTO acc = new AccountDTO();
                acc.username = txtTaiKhoan.Text;
                acc.password = txtMatKhau.Text;
                acc.level = cbLevel.SelectedIndex;
                return acc;
            }
        }

        private void clearFormQLTaiKhoan()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbLevel.SelectedIndex = 2;
        }

        private void btnClearAccount_Click(object sender, EventArgs e)
        {
            clearFormQLTaiKhoan();
        }

        private void btnReloadGrdAccount_Click(object sender, EventArgs e)
        {
            hienThiGrdAccount();
        }

        private void btThemTaiKhoan_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoanBLL.addAccount(getTaiKhoanOnForm());
            hienThiGrdAccount();
            clearFormQLTaiKhoan();
        }

        private void btCapNhatTaiKhoan_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoanBLL.updateAccount(getTaiKhoanOnForm());
            hienThiGrdAccount();
            clearFormQLTaiKhoan();
        }

        private void btXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            DialogResult result = hienThongBao("Xác nhận xoá tài khoản");
            if (result == DialogResult.OK)
            {
                quanLyTaiKhoanBLL.deleteAccount(txtTaiKhoan.Text);
                hienThiGrdAccount();
                clearFormQLTaiKhoan();
            }
        }

        private void grdTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grdTaiKhoan.SelectedCells[0].RowIndex;
            if (index < currentListAccount.Count)
            {
                AccountDTO currentAccount = currentListAccount.ElementAt(index);

                txtTaiKhoan.Text = currentAccount.username;
                cbLevel.SelectedIndex = currentAccount.level;
            }
        }


    }
}
