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
        List<LopHocDTO> currentListLopHoc;

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

            lbMaLop.Show();
            lbSiSo.Show();

            cbTieuChiTimKiemLop.SelectedIndex = 0;

            cbKhoaHoc.DataSource = khoaHocBLL.getAllKhoaHoc();
            cbKhoaHoc.DisplayMember = "ten_KH";
            cbKhoaHoc.ValueMember = "id_KH";

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
                grdLopHoc.Rows[index].Cells[0].Value = dto.id_LH;
                grdLopHoc.Rows[index].Cells[1].Value = dto.tenLopHoc;
                grdLopHoc.Rows[index].Cells[2].Value = dto.tenKhoaHoc;
                grdLopHoc.Rows[index].Cells[3].Value = dto.tenGiangVien;
                grdLopHoc.Rows[index].Cells[4].Value = dto.tenPhongHoc;
                //grdLopHoc.Rows[index].Cells[5].Value = dto.ngayBatDau.Day + "/" +(dto.ngayBatDau.Month+1)+"/" + dto.ngayBatDau.Year;
                //grdLopHoc.Rows[index].Cells[6].Value = dto.ngayKetThuc.Day + "/" + (dto.ngayKetThuc.Month + 1) + "/" + dto.ngayKetThuc.Year; ;
                grdLopHoc.Rows[index].Cells[5].Value = dto.ngayBatDau.ToShortDateString();
                grdLopHoc.Rows[index].Cells[6].Value = dto.ngayKetThuc.ToShortDateString();
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
            clearForm();
        }

        private void btThemLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void btXoaLopHoc_Click(object sender, EventArgs e)
        {
            quanLyLopHocBLL.deleteLopHoc(lbMaLop.Text);

        }

        private void grdLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grdLopHoc.SelectedCells[0].RowIndex;
            txtChonGiangVien.Text = currentListLopHoc.ElementAt(index).id_GV +"-";

            DataGridViewRow row = grdLopHoc.Rows[index];
            lbMaLop.Text = Convert.ToString(row.Cells[0].Value).Trim();
            txtTenLopHoc.Text = row.Cells[1].Value.ToString();
            cbKhoaHoc.SelectedText = Convert.ToString(row.Cells[2].Value).Trim();
            txtChonGiangVien.Text += Convert.ToString(row.Cells[3].Value).Trim();
            cbPhongHoc.SelectedText = Convert.ToString(row.Cells[4].Value).Trim();
            datePickerNgayBatDauHoc.Value = DateTime.Parse(row.Cells[5].Value.ToString().Trim());
            datePickerNgayKetThucHoc.Value = DateTime.Parse(row.Cells[6].Value.ToString().Trim());
            lbSiSo.Text = row.Cells[7].Value.ToString();
        }

        private void grdLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearForm()
        {
            lbMaLop.Text = "";
            txtTenLopHoc.Text = "";
            cbKhoaHoc.SelectedIndex = 0;
            cbPhongHoc.SelectedIndex = 0;
            txtChonGiangVien.Text = "";
            datePickerNgayBatDauHoc.Value = DateTime.Now;
            datePickerNgayKetThucHoc.Value = DateTime.Now;
            lbSiSo.Text = "";
            txtTenLopHoc.Focus();
        }


    }
}
