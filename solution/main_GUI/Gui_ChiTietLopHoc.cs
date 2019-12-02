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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace main_GUI
{
    public partial class Gui_ChiTietLopHoc : Form
    {
        ChiTietLopHocBLL chiTietLopHocBLL = new ChiTietLopHocBLL();
        HocVienBLL hocVienBLL = new HocVienBLL();
        LopHocDTO currentLopHoc;
        List<HocVienLopHocDTO> currentLstDSHV;
        string currentHV_maHV;
        string path_folderExport = "C://exportpdf/";

        public Gui_ChiTietLopHoc(string maLop)
        {
            InitializeComponent();
            currentLopHoc = chiTietLopHocBLL.getLopHocBasicInfo(maLop);
        }

        private void Gui_ChiTietLopHoc_Load(object sender, EventArgs e)
        {
            clearForm();
            loadLopInfo();
            hienThiGrdDSHV();
            loadTabLichHoc();
        }

        private void loadTabLichHoc()
        {
            TabPage tabPage = new TabPage();
            string tabName = "Quản lý lịch học";
            Dialog_LichHoc gui = new Dialog_LichHoc(currentLopHoc.id_LH);

            gui.TopLevel = false;
            gui.FormBorderStyle = FormBorderStyle.None;
            gui.Visible = true;
            tabPage.Controls.Add(gui);
            gui.Dock = DockStyle.Fill;
            tabPage.Text = tabName;
            tabControl1.TabPages.Add(tabPage);
        }

        private void loadLopInfo()
        {
            currentLopHoc = chiTietLopHocBLL.getLopHocBasicInfo(currentLopHoc.id_LH);
            lbTenLop.Text = currentLopHoc.ten_LH;
            lbSiSo.Text = "Sĩ số: " + currentLopHoc.siSo + "/" + currentLopHoc.sucChua;
            lbMaLop.Text = currentLopHoc.id_LH;
        }

        private void clearForm()
        {
            lbMaHocVien.Text = "";
            lbTenHocVien.Text = "";
            txtTimKiem.Text = "";
            cbTieuChiTimKiem.SelectedIndex = 0;
        }

        private void hienThiGrdDSHV()
        {
            List<HocVienLopHocDTO> lstHocVienLopHoc = chiTietLopHocBLL.readDSHV(currentLopHoc.id_LH);
            currentLstDSHV = lstHocVienLopHoc;
            grdDssv.Rows.Clear();
            int index = 0;
            foreach (HocVienLopHocDTO hvlh in lstHocVienLopHoc)
            {
                grdDssv.Rows.Add();
                grdDssv.Rows[index].Cells[0].Value = hvlh.id_HV;
                grdDssv.Rows[index].Cells[1].Value = hvlh.ten_HV;
                if (hvlh.diem1 != -1)
                    grdDssv.Rows[index].Cells[2].Value = hvlh.diem1;
                else
                    grdDssv.Rows[index].Cells[2].Value = "";
                if (hvlh.diem2 != -1)
                    grdDssv.Rows[index].Cells[3].Value = hvlh.diem2;
                else
                    grdDssv.Rows[index].Cells[3].Value = "";
                if (hvlh.diem3 != -1)
                    grdDssv.Rows[index].Cells[4].Value = hvlh.diem3;
                else
                    grdDssv.Rows[index].Cells[4].Value = "";
                if (hvlh.diem4 != -1)
                    grdDssv.Rows[index].Cells[5].Value = hvlh.diem4;
                else
                    grdDssv.Rows[index].Cells[5].Value = "";

                grdDssv.Rows[index].Cells[6].Value = hvlh.ghiChu_HVLH;
                index++;
            }
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            clearForm();
            loadLopInfo();
            hienThiGrdDSHV();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            int tieuChi = cbTieuChiTimKiem.SelectedIndex;
            string keyWord = txtTimKiem.Text;
            switch (tieuChi)
            {
                case 0:
                    // Tìm theo mã
                    grdTimKiem.DataSource = hocVienBLL.findHocVienById(keyWord);
                    break;
                case 1:
                    // Tìm theo tên
                    grdTimKiem.DataSource = hocVienBLL.findHocVienByTen(keyWord);
                    break;
                case 2:
                    // Tìm theo SDT
                    grdTimKiem.DataSource = hocVienBLL.findHocVienBySDT(keyWord);
                    break;
                default:
                    break;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            chiTietLopHocBLL.addHV_LH(currentLstDSHV, currentLopHoc, currentHV_maHV);
            hienThiGrdDSHV();
            loadLopInfo();
        }

        private void grdDssv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grdDssv.SelectedCells[0].RowIndex;
            DataGridViewRow row = grdDssv.Rows[index];
            currentHV_maHV = row.Cells[0].Value.ToString();
            HocVienLopHocDTO hvlh;
            hvlh = chiTietLopHocBLL.findHocVienInDSHV(currentLstDSHV, currentHV_maHV);
            lbMaHocVien.Text = hvlh.id_HV;
            lbTenHocVien.Text = hvlh.ten_HV;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = hienCanhBao("Xác nhận xoá học viên khỏi lớp?");
            if (result == DialogResult.OK)
            {
                chiTietLopHocBLL.removeHocVienLopHoc(currentLstDSHV, currentLopHoc.id_LH, currentHV_maHV);
                hienThiGrdDSHV();
                loadLopInfo();
            }
        }

        private void btExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                exportPDF();
                String fileName = "DSHV_" + currentLopHoc.id_LH + "_" + currentLopHoc.ten_LH + ".pdf";
                string path_fileExport = Path.Combine(path_folderExport, fileName);
                MessageBox.Show("Export thành công!\n" + path_fileExport);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }

        private void exportPDF()
        {
            Directory.CreateDirectory(path_folderExport);

            String fileName = "DSHV_" + currentLopHoc.id_LH + "_" + currentLopHoc.ten_LH + ".pdf";
            string path_fileExport = Path.Combine(path_folderExport, fileName);
            if (File.Exists(path_fileExport))
            {
                File.Delete(path_fileExport);
            }
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 20, 20);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path_fileExport, FileMode.Create));
            doc.Open();

            BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\Tahoma.TTF", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            Paragraph paragraph = new Paragraph("Danh sách học viên \n" + currentLopHoc.ten_LH, fTitle);
            paragraph.Alignment = Element.ALIGN_CENTER;

            Paragraph p_maLop = new Paragraph("Mã lớp: " + currentLopHoc.id_LH, f2);
            p_maLop.Alignment = Element.ALIGN_LEFT;
            Paragraph p_siSo = new Paragraph("Sĩ số: " + currentLopHoc.siSo, f2);
            p_maLop.Alignment = Element.ALIGN_LEFT;


            PdfPTable table = new PdfPTable(this.grdDssv.Columns.Count + 1);
            table.AddCell(new Paragraph("STT", f2));
            foreach (DataGridViewColumn cl in grdDssv.Columns)
            {
                table.AddCell(new Paragraph(cl.HeaderText, f2));
            }
            int stt = 1;
            foreach (DataGridViewRow row in grdDssv.Rows)
            {
                table.AddCell(new Paragraph(stt + "", f2));
                for (int i = 0; i < grdDssv.Columns.Count; i++)
                {
                    String text = row.Cells[i].Value.ToString();
                    PdfPCell cell = new PdfPCell(new Paragraph(text, f2));
                    table.AddCell(cell);
                }
                stt++;
            }
            doc.Add(paragraph);
            doc.Add(p_maLop);
            doc.Add(p_siSo);
            doc.Add(new Paragraph("\n\n"));
            doc.Add(table);
            doc.Close();
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTimKiem_Click(this, new EventArgs());
            }
        }

        private void grdTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grdTimKiem.SelectedCells[0].RowIndex;
            DataGridViewRow row = grdTimKiem.Rows[index];
            currentHV_maHV = row.Cells[0].Value.ToString();
            lbMaHocVien.Text = row.Cells[0].Value.ToString();
            lbTenHocVien.Text = row.Cells[1].Value.ToString();
        }

        private DialogResult hienCanhBao(String message)
        {
            return MessageBox.Show(message, "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
