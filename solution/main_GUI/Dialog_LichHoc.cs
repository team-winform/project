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
    public partial class Dialog_LichHoc : Form
    {
        QuanLyLopHocBLL quanLyLopHocBLL = new QuanLyLopHocBLL();
        LichHocBLL lichHocBLL = new LichHocBLL();
        LopHocDTO currentLopHoc;
        List<LichHocDTO> currentLstLichHocs;
        List<int> lstThuForbidden;

        string path_folderExport = "C://exportpdf/";

        public Dialog_LichHoc(string maLop)
        {
            InitializeComponent();
            currentLopHoc = quanLyLopHocBLL.getLopHocExtraInfo(maLop);
        }

        private void Dialog_LichHoc_Load(object sender, EventArgs e)
        {
            loadForm();
            hienThiLich();
            updateThuForbidden();
        }

        private void updateThuForbidden()
        {
            lstThuForbidden = lichHocBLL.getThuForbidden(currentLopHoc.id_PH, currentLopHoc.id_LH, cbThoiGian.SelectedIndex, currentLopHoc.ngayBatDau, currentLopHoc.ngayKetThuc);
        }

        private void updateLstLichHocs()
        {
            currentLstLichHocs = lichHocBLL.getLichHoc(currentLopHoc.id_LH);
        }

        private void updateLopHoc()
        {
            currentLopHoc = quanLyLopHocBLL.getLopHocExtraInfo(currentLopHoc.id_LH);
        }

        private void loadForm()
        {
            initcbThoiGian();
            lbTenLop.Text = currentLopHoc.ten_LH;
            lbTenPH.Text = currentLopHoc.ten_PH;
            lbTenGV.Text = currentLopHoc.ten_GV;
            lbFrom.Text = formatDate(currentLopHoc.ngayBatDau);
            lbTo.Text = formatDate(currentLopHoc.ngayKetThuc);
            lbMaLop.Text = currentLopHoc.id_LH;
            string thu = "";
            foreach (int t in lichHocBLL.getThuUsingMaLop(currentLopHoc.id_LH))
            {
                thu += t + ", ";
            }
            if (thu.Length != 0)
            {
                thu = thu.Substring(0, thu.Length - 2);
            }
            lbThu.Text = thu;
            lbThoiGian.Text = mapThoiGian(currentLopHoc.thoiGian);
            if (currentLopHoc.thoiGian != -1)
                cbThoiGian.SelectedIndex = currentLopHoc.thoiGian;
        }

        private void initcbThoiGian()
        {
            List<ThoiGian> thoiGians = new List<ThoiGian>();
            thoiGians.Add(new ThoiGian(0, "8h - 11h"));
            thoiGians.Add(new ThoiGian(1, "13h - 16h"));
            thoiGians.Add(new ThoiGian(2, "18h - 21h"));
            cbThoiGian.DataSource = thoiGians;
            cbThoiGian.DisplayMember = "ten";
            cbThoiGian.ValueMember = "id";
        }
        private string mapThoiGian(int thoiGian)
        {
            switch (thoiGian)
            {
                case 0:
                    // Sang
                    return "8h - 11h";
                case 1:
                    // Chieu
                    return "13 - 16h";
                case 2:
                    // Toi
                    return "18h - 21h";
                default:
                    return "unknown";
            }
        }
        private void hienThiLich()
        {
            updateLstLichHocs();
            updateThuForbidden();
            int rowIndex = 0;
            grdLichHoc.Rows.Clear();
            // 3 cot w, from, to
            grdLichHoc.Columns[0].ReadOnly = true;
            grdLichHoc.Columns[1].ReadOnly = true;
            grdLichHoc.Columns[2].ReadOnly = true;
            for (int i = 3; i < grdLichHoc.ColumnCount; i++)
            {
                grdLichHoc.Columns[i].ReadOnly = false;
            }
            foreach (int thu in lstThuForbidden)
            {
                grdLichHoc.Columns[thu + 1].ReadOnly = true;
                grdLichHoc.Columns[thu + 1].DefaultCellStyle.BackColor = Color.Red;

            }

            DateTime timeNow = currentLopHoc.ngayBatDau;
            while (timeNow < currentLopHoc.ngayKetThuc)
            {
                grdLichHoc.Rows.Add();
                DataGridViewRow row = grdLichHoc.Rows[rowIndex];

                // Tuan
                row.Cells[0].Value = rowIndex + 1;
                // from
                row.Cells[1].Value = formatDate(timeNow);
                // to
                row.Cells[2].Value = formatDate(timeNow.AddDays(6));

                foreach (LichHocDTO dto in currentLstLichHocs)
                {
                    if (dto.tuan == rowIndex + 1)
                    {
                        bool isForbidden = false;
                        foreach (int thu in lstThuForbidden)
                        {
                            if (thu == dto.thu)
                                isForbidden = true;
                        }
                        if (!isForbidden)
                            row.Cells[dto.thu + 1].Value = dto.noiDung;
                    }
                }

                timeNow = timeNow.AddDays(7);
                rowIndex++;
            }
        }

        private List<LichHocDTO> getLichHocsFromGrd()
        {
            List<LichHocDTO> lstLichHocs = new List<LichHocDTO>();
            foreach (DataGridViewRow row in grdLichHoc.Rows)
            {
                bool hasLichHoc = false;
                LichHocDTO dto = new LichHocDTO();
                // run from thu 2 (cot 3)
                for (int i = 3; i < grdLichHoc.ColumnCount; i++)
                {
                    if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Trim() != "")
                    {
                        dto.id_LH = currentLopHoc.id_LH;
                        dto.tuan = row.Index + 1;
                        dto.thu = i - 1;
                        dto.noiDung = row.Cells[i].Value.ToString().Trim();
                        hasLichHoc = true;
                    }
                }
                if (hasLichHoc)
                    lstLichHocs.Add(dto);
            }
            return lstLichHocs;
        }

        private string formatDate(DateTime date)
        {
            return date.Day + "/" + date.Month + "/" + date.Year;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            quanLyLopHocBLL.updateThoiGianHoc(currentLopHoc.id_LH, cbThoiGian.SelectedIndex);
            lichHocBLL.addLichHocs(currentLopHoc.id_LH, getLichHocsFromGrd());
            hienThongBao("Cập nhật thành công");
            updateLopHoc();
            hienThiLich();
            loadForm();
        }

        private void hienThongBao(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            hienThiLich();
        }

        private class ThoiGian
        {
            public int id { get; set; }
            public string ten { get; set; }

            public ThoiGian(int id, string ten)
            {
                this.id = id;
                this.ten = ten;
            }
        }

        private void btExport_Click(object sender, EventArgs e)
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

            String fileName = "Lich_Hoc_" + currentLopHoc.id_LH + "_" + currentLopHoc.ten_LH + ".pdf";
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

            Paragraph p1 = new Paragraph("Mã lớp: " + currentLopHoc.id_LH, f2);
            p1.Alignment = Element.ALIGN_LEFT;
            Paragraph p2 = new Paragraph("Thời khoá biểu\n" + currentLopHoc.ten_LH + "\n\n", fTitle);
            p2.Alignment = Element.ALIGN_CENTER;

            string thu = "";
            foreach (int t in lichHocBLL.getThuUsingMaLop(currentLopHoc.id_LH))
                thu += t + ", ";
            if (thu.Length != 0)
                thu = thu.Substring(0, thu.Length - 2);
            string s3 = string.Format("  {0, -15} {3, -30} {1, -15} {4, -20} {2, -15} {5, -20}",
                "Phòng học:", "Thứ:", "Từ ngày:", currentLopHoc.ten_PH, thu, formatDate(currentLopHoc.ngayBatDau));
            Paragraph p3 = new Paragraph(s3, f2);
            p3.Alignment = Element.ALIGN_LEFT;

            string s4 = string.Format("  {0, -15} {3, -30} {1, -15} {4, -20} {2, -15} {5, -20}",
                "Giảng viên:", "Thời gian:", "Đến ngày:", currentLopHoc.ten_GV, lbThoiGian.Text, formatDate(currentLopHoc.ngayKetThuc));
            Paragraph p4 = new Paragraph(s4, f2);
            p4.Alignment = Element.ALIGN_LEFT;

            PdfPTable table = new PdfPTable(this.grdLichHoc.Columns.Count);
            foreach (DataGridViewColumn cl in grdLichHoc.Columns)
            {
                table.AddCell(new Paragraph(cl.HeaderText, f2));
            }

            foreach (DataGridViewRow row in grdLichHoc.Rows)
            {
                for (int i = 0; i < grdLichHoc.Columns.Count; i++)
                {
                    String text = "";
                    if (row.Cells[i].Value != null)
                        text = row.Cells[i].Value.ToString();
                    PdfPCell cell = new PdfPCell(new Paragraph(text, f2));
                    table.AddCell(cell);
                }
            }
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(new Paragraph("\n\n"));
            doc.Add(table);
            doc.Close();
        }
    }
}
