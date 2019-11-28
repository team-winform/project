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
        KhoaHocBLL khoaHocBLL = new KhoaHocBLL();
        PhongHocBLL phongHocBLL = new PhongHocBLL();
        GiangVienBLL giangVienBLL = new GiangVienBLL();
        QuanLyTaiKhoanBLL quanLyTaiKhoanBLL = new QuanLyTaiKhoanBLL();

        List<LopHocDTO> currentListLopHoc;
        List<AccountDTO> currentListAccount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Clear();

            loadTabQuanLyLopHoc();
            loadTabTaiKhoanCuaToi();

            if (accountGlobal != null && accountGlobal.level == 0)
            {
                loadTabQuanLyTaiKhoan();
            }

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
            if (accountGlobal != null)
            {
                lbTaiKhoanCuaToi.Text = accountGlobal.username;
                txtHoTen.Text = accountGlobal.fullname;
                txtSoDienThoai.Text = accountGlobal.phone;
            }
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

            lbMaLop.Text = "";
            lbSiSo.Text = "";
            lbMaLop.Show();
            lbSiSo.Show();

            cbTieuChiTimKiemLop.SelectedIndex = 0;

            cbKhoaHoc.DataSource = khoaHocBLL.getAllKhoaHoc();
            cbKhoaHoc.DisplayMember = "ten_KH";
            cbKhoaHoc.ValueMember = "id_KH";

            cbPhongHoc.DataSource = phongHocBLL.getAll();
            cbPhongHoc.DisplayMember = "name";
            cbPhongHoc.ValueMember = "id";

            cbGiangVien.DataSource = giangVienBLL.getAll();
            cbGiangVien.DisplayMember = "name";
            cbGiangVien.ValueMember = "id";

            datePickerNgayBatDauHoc.Format = DateTimePickerFormat.Custom;
            datePickerNgayBatDauHoc.CustomFormat = "dd-MM-yyyy";

            datePickerNgayKetThucHoc.Format = DateTimePickerFormat.Custom;
            datePickerNgayKetThucHoc.CustomFormat = "dd-MM-yyyy";

            hienThiGrdLopHoc();
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
            hienThiGrdLopHoc();
        }

        private void hienThiGrdLopHoc(List<LopHocDTO> lstLopHocs)
        {
            currentListLopHoc = lstLopHocs;
            grdLopHoc.Rows.Clear();
            int index = 0;
            foreach (LopHocDTO dto in lstLopHocs)
            {
                grdLopHoc.Rows.Add();
                grdLopHoc.Rows[index].Cells["id_lh"].Value = dto.id_LH;
                grdLopHoc.Rows[index].Cells[1].Value = dto.ten_LH;
                grdLopHoc.Rows[index].Cells[2].Value = dto.tenKhoaHoc;
                grdLopHoc.Rows[index].Cells[3].Value = dto.tenGiangVien;
                grdLopHoc.Rows[index].Cells[4].Value = dto.tenPhongHoc;
                grdLopHoc.Rows[index].Cells[5].Value = dto.ngayBatDau.Day + "/" + dto.ngayBatDau.Month + "/" + dto.ngayBatDau.Year;
                grdLopHoc.Rows[index].Cells[6].Value = dto.ngayKetThuc.Day + "/" + dto.ngayKetThuc.Month + "/" + dto.ngayKetThuc.Year; ;
                //grdLopHoc.Rows[index].Cells[5].Value = dto.ngayBatDau.ToShortDateString();
                //grdLopHoc.Rows[index].Cells[6].Value = dto.ngayKetThuc.ToShortDateString();
                grdLopHoc.Rows[index].Cells[7].Value = dto.siSo;
                index++;
            }
        }

        private void hienThiGrdLopHoc(int page)
        {
            hienThiGrdLopHoc(quanLyLopHocBLL.getLopHoc(page));
        }

        private void hienThiGrdLopHoc()
        {
            hienThiGrdLopHoc(int.Parse(txtTrangLopHoc.Text));
        }

        private void btTrangTruocLopHoc_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txtTrangLopHoc.Text);
            if (page > 1)
            {
                txtTrangLopHoc.Text = (page - 1).ToString();
                hienThiGrdLopHoc();
            }
        }

        private void btTrangSauLopHoc_Click(object sender, EventArgs e)
        {
            int page = int.Parse(txtTrangLopHoc.Text);
            txtTrangLopHoc.Text = (page + 1).ToString();
            hienThiGrdLopHoc();
        }

        private void btTimKiemLop_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemLop.Text;
            int tieuChi = int.Parse(cbTieuChiTimKiemLop.SelectedIndex.ToString());
            List<LopHocDTO> lstLopHocTimDc = quanLyLopHocBLL.searchLopHoc(tuKhoa, tieuChi);
            hienThiGrdLopHoc(lstLopHocTimDc);

        }

        private void btReloadLopHoc_Click(object sender, EventArgs e)
        {
            hienThiGrdLopHoc();
            ClearFormLopHoc();
        }

        private void btThemLopHoc_Click(object sender, EventArgs e)
        {
            LopHocDTO lopHocDTO = getLopHocOnForm();
            quanLyLopHocBLL.insertLopHoc(lopHocDTO);
            hienThiGrdLopHoc();
        }

        private LopHocDTO getLopHocOnForm()
        {
            LopHocDTO dto = new LopHocDTO();
            if (txtTenLopHoc.Text.Trim() == "")
            {
                hienThongBaoLoi("Tên lớp học không được để trống");
                return null;
            }

            dto.id_LH = lbMaLop.Text;
            dto.ten_LH = txtTenLopHoc.Text.Trim();
            dto.id_GV = cbGiangVien.SelectedValue.ToString();
            dto.id_PH = cbPhongHoc.SelectedValue.ToString();
            dto.id_KH = cbKhoaHoc.SelectedValue.ToString();
            dto.ngayBatDau = datePickerNgayBatDauHoc.Value;
            dto.ngayKetThuc = datePickerNgayKetThucHoc.Value;

            return dto;
        }

        private void btXoaLopHoc_Click(object sender, EventArgs e)
        {
            quanLyLopHocBLL.deleteLopHoc(lbMaLop.Text);
            hienThiGrdLopHoc();
        }

        private void grdLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grdLopHoc.SelectedCells[0].RowIndex;

            LopHocDTO currentLopHoc = currentListLopHoc.ElementAt(index);

            cbGiangVien.SelectedValue = currentLopHoc.id_GV;
            cbKhoaHoc.SelectedValue = currentLopHoc.id_KH;
            cbPhongHoc.SelectedValue = currentLopHoc.id_PH;
            datePickerNgayBatDauHoc.Value = currentLopHoc.ngayBatDau;
            datePickerNgayKetThucHoc.Value = currentLopHoc.ngayKetThuc;

            lbMaLop.Text = currentLopHoc.id_LH;
            txtTenLopHoc.Text = currentLopHoc.ten_LH;
            lbSiSo.Text = currentLopHoc.siSo.ToString();

            //DataGridViewRow row = grdLopHoc.Rows[index];
            //datePickerNgayBatDauHoc.Value = DateTime.Parse(row.Cells[5].Value.ToString().Trim());
            //datePickerNgayKetThucHoc.Value = DateTime.Parse(row.Cells[6].Value.ToString().Trim());
        }

        private void grdLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearFormLopHoc()
        {
            lbMaLop.Text = "";
            txtTenLopHoc.Text = "";
            cbKhoaHoc.SelectedIndex = 0;
            cbPhongHoc.SelectedIndex = 0;
            cbGiangVien.SelectedIndex = 0;
            datePickerNgayBatDauHoc.Value = DateTime.Now;
            datePickerNgayKetThucHoc.Value = DateTime.Now;
            lbSiSo.Text = "";
            txtTenLopHoc.Focus();
        }

        private void btSuaLopHoc_Click(object sender, EventArgs e)
        {
            LopHocDTO lopHocDTO = getLopHocOnForm();
            quanLyLopHocBLL.updateLopHoc(lopHocDTO);
            hienThiGrdLopHoc();
        }

        private void btLichHoc_Click(object sender, EventArgs e)
        {
            string maLop = lbMaLop.Text;
            if (maLop.Trim() != "")
                new Dialog_QuanLyLichHocLopHoc(maLop).ShowDialog();
        }

        ////////////////////////////////////////////////
        ///
        ///         Quan ly tai khoan
        ///
        /////////////////////////////////////////////////

        private void loadTabQuanLyTaiKhoan()
        {
            tabControl.TabPages.Add(tabQuanLyTaiKhoan);
            cbLevel.SelectedIndex = 2;

            hienThiGrdAccount();
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
            quanLyTaiKhoanBLL.deleteAccount(txtTaiKhoan.Text);
            hienThiGrdAccount();
            clearFormQLTaiKhoan();
        }

        private void grdTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grdTaiKhoan.SelectedCells[0].RowIndex;
            AccountDTO currentAccount = currentListAccount.ElementAt(index);

            txtTaiKhoan.Text = currentAccount.username;
            cbLevel.SelectedIndex = currentAccount.level;
        }

        
    }
}
