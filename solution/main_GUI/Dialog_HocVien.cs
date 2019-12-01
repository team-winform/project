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

namespace main_GUI
{
    public partial class Dialog_HocVien : Form
    {
        private String ma;
        private Boolean isThem;
        private String maLop;
        private HocVienBLL hocVienBLL;
        public Dialog_HocVien(Boolean isThem,String ma,String maLop)
        {
            InitializeComponent();
            this.hocVienBLL = new HocVienBLL();
            this.isThem = isThem;
            this.ma = ma;
            this.maLop = maLop;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dialog_HocVien_Load(object sender, EventArgs e)
        {
            this.dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            if (isThem) labelTitle.Text = "Thêm Học Viên";
            else
            {
                labelTitle.Text = "Sửa Học Viên";
                Dictionary<String, String> result = hocVienBLL.getHocVien(ma);
                if (result != null)
                {
                    txtTen.Text = result["ten_HV"];
                    txtSdt.Text = result["sodt_HV"];
                    txtDiaChi.Text = result["diachi_HV"];
                    dtpNgaySinh.Value = DateTime.Parse(result["ngaysinh_HV"]);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                String ten = txtTen.Text.Trim();
                String sdt = txtSdt.Text.Trim();
                DateTime ngaySinh = dtpNgaySinh.Value;
                String diaChi = txtDiaChi.Text.Trim();
                int rowUpdate=0;
                if (isThem)
                {
                    rowUpdate=hocVienBLL.add(ten, sdt, ngaySinh, diaChi, maLop);
                }
                else
                {
                    rowUpdate = hocVienBLL.update(ma, ten, sdt, ngaySinh, diaChi);
                }
                if (rowUpdate != 0)
                {
                    MessageBox.Show("Thực hiện thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Thêm học viên thất bại");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
