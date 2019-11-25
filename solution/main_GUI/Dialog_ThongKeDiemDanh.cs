using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using BLLs;

namespace main_GUI
{
    public partial class Dialog_ThongKeDiemDanh : Form
    {
        private String maLop;
        private String tenLop;
        public Dialog_ThongKeDiemDanh(String maLop,String tenLop)
        {
            InitializeComponent();
            this.maLop = maLop;
            this.tenLop = tenLop;
        }

        private void Dialog_ThongKeDiemDanh_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Font = new System.Drawing.Font("Tahoma", 10);
            labelTitle.Text = "Tổng kết điểm danh lớp\n" + tenLop;
            try
            {
                this.dataGridView1.DataSource = new DiemDanhBLL().thongKeDiemDanh(maLop);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                export();
                MessageBox.Show("đã export");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
        }

        private void export()
        {
            String fileName = "diemdanh_" + maLop + ".pdf";
            Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 20, 20);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("C://exportpdf/"+fileName, FileMode.Create));
            doc.Open();

            BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\Tahoma.TTF", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font f2 = new iTextSharp.text.Font(bf,12,iTextSharp.text.Font.NORMAL,BaseColor.BLACK);
            iTextSharp.text.Font fTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.NORMAL, BaseColor.BLUE);

            Paragraph paragraph = new Paragraph("Tổng kết điểm danh \n" + tenLop,fTitle);
            paragraph.Alignment = Element.ALIGN_CENTER;
            PdfPTable table = new PdfPTable(this.dataGridView1.Columns.Count);

            foreach (DataGridViewColumn cl in dataGridView1.Columns)
            {
                table.AddCell(new Paragraph(cl.HeaderText,f2));
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    String text = row.Cells[i].Value.ToString();
                    PdfPCell cell = new PdfPCell(new Paragraph(text,f2));
                    table.AddCell(cell);
                }
            }
            doc.Add(paragraph);
            doc.Add(new Paragraph("\n\n"));
            doc.Add(table);
            doc.Close();
        }
    }
}
