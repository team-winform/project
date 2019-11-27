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
    public partial class Dialog_QuanLyLichHocLopHoc : Form
    {
        LichHocBLL lichHocBLL = new LichHocBLL();
        QuanLyLopHocBLL quanLyLopHocBLL = new QuanLyLopHocBLL();
        LopHocDTO currentlopHoc;

        List<LichHocDTO> currentListLichHoc;
        LichHocDTO currentLichHoc;

        public Dialog_QuanLyLichHocLopHoc(string maLop)
        {
            InitializeComponent();
            this.currentlopHoc = quanLyLopHocBLL.searchLopHoc(maLop, 0).ElementAt(0);
            hienThiGrdLichHoc();
        }

        private void Dialog_QuanLyLichHocLopHoc_Load(object sender, EventArgs e)
        {
            hienThiGrdLichHoc();
            lbMaLopHoc.Text = currentlopHoc.id_LH;
            lbTenLopHoc.Text = currentlopHoc.ten_LH;
            lbNgayBatDau.Text = currentlopHoc.ngayBatDau.Day + "/" + (currentlopHoc.ngayBatDau.Month + 1) + "/" + currentlopHoc.ngayBatDau.Year;
            lbNgayKetThuc.Text = currentlopHoc.ngayKetThuc.Day + "/" + (currentlopHoc.ngayKetThuc.Month + 1) + "/" + currentlopHoc.ngayKetThuc.Year;
        }

        private void hienThiGrdLichHoc()
        {
            List<LichHocDTO> lstLichHocs = lichHocBLL.getLichHoc(currentlopHoc.id_LH);
            currentListLichHoc = lstLichHocs;

            grdLichHoc.Rows.Clear();

            int index = 0;
            foreach (LichHocDTO dto in lstLichHocs)
            {
                grdLichHoc.Rows.Add();
                grdLichHoc.Rows[index].Cells[0].Value = currentlopHoc.ngayBatDau.Day + "/" + currentlopHoc.ngayBatDau.Month + "/" + currentlopHoc.ngayBatDau.Year;
                grdLichHoc.Rows[index].Cells[1].Value = currentlopHoc.ngayKetThuc.Day + "/" + currentlopHoc.ngayKetThuc.Month + "/" + currentlopHoc.ngayKetThuc.Year;
                grdLichHoc.Rows[index].Cells[2].Value = dto.thu.ToString();
                grdLichHoc.Rows[index].Cells[3].Value = dto.tiet.Split(',')[0] + " -> " + dto.tiet.Split(',')[1];
                index++;
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (currentLichHoc != null)
            {
                DialogResult result = hienThongBao("Xác nhận xoá lịch học?");
                if (result == DialogResult.OK)
                {
                    lichHocBLL.deleteLichHoc(currentLichHoc.id_LIH);
                    hienThiGrdLichHoc();
                }
            }
        }

        private void grdLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grdLichHoc.SelectedCells[0].RowIndex;
            currentLichHoc = new LichHocDTO();
            currentLichHoc = currentListLichHoc.ElementAt(index);
        }

        private string castThu(int thu)
        {
            switch (thu)
            {
                case 0:
                    return "Hai";
                case 1:
                    return "Ba";
                case 2:
                    return "Tư";
                case 3:
                    return "Năm";
                case 4:
                    return "Sáu";
                case 5:
                    return "Bảy";
                case 6:
                    return "Chủ Nhật";
                default:
                    return "Unknown";
            }
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
