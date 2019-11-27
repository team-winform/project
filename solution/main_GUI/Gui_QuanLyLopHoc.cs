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
    public partial class Gui_QuanLyLopHoc : Form
    {
        QuanLyLopHocBLL quanLyLopHocBLL = new QuanLyLopHocBLL();
        KhoaHocBLL khoaHocBLL = new KhoaHocBLL();
        PhongHocBLL phongHocBLL = new PhongHocBLL();
        GiangVienBLL giangVienBLL = new GiangVienBLL();

        List<LopHocDTO> currentListLopHoc;

        public Gui_QuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void Gui_QuanLyLopHoc_Load(object sender, EventArgs e)
        {
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
            try
            {
                int page = int.Parse(txtTrangLopHoc.Text);
                hienThiGrdLopHoc(page);
            }
            catch (Exception ee)
            {

            }
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
            DialogResult result = hienThongBao("Bạn có muốn xoá lớp?");
            if (result == DialogResult.OK)
            {
                quanLyLopHocBLL.deleteLopHoc(lbMaLop.Text);
                hienThiGrdLopHoc();
            }
        }

        private void grdLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grdLopHoc.SelectedCells[0].RowIndex;
            DataGridViewRow row = grdLopHoc.Rows[index];
            string maLopHoc = row.Cells[0].Value.ToString();
            LopHocDTO currentLopHoc = quanLyLopHocBLL.findLopHocInList(maLopHoc, currentListLopHoc);

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
