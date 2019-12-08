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
    public partial class DiemDialog_nhapDiem : Form
    {
        private bool diem1;
        private bool diem2;
        private bool diemfinal;
        private HocVienLopHocDTO hl;

        public DiemDialog_nhapDiem(bool d1, bool d2, bool dfinal, HocVienLopHocDTO h)
        {
            InitializeComponent();
            diem1 = d1;
            diem2 = d2;
            diemfinal = dfinal;
            hl = h;
        }

        private void DiemDialog_nhapDiem_Load(object sender, EventArgs e)
        {
            lb_diem1.Visible = diem1;
            tb_diem1.Visible = diem1;
            lb_diem2.Visible = diem2;
            tb_diem2.Visible = diem2;
            lb_diemDoAn.Visible = diemfinal;
            tb_diemfinal.Visible = diemfinal;

            tb_hv_id.Text = hl.StudentId;
            tb_hv_name.Text = hl.StudentName;
            tb_class_id.Text = hl.ClassId;
            tb_class_name.Text = hl.ClassName;
        }

        private void Bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_nhap_Click(object sender, EventArgs e)
        {
            
            HocVienLopHocDTO hl = new HocVienLopHocDTO();
            

            //Loại điểm = 0 - nhập điểm thường xuyên
            //Loại điểm = 1 - nhập điểm đồ án
            int pointType = 0;
            if(tb_diemfinal.Visible == false)
            {
                if (tb_diem1.Text == "")
                {
                    errorProvider1.SetError(tb_diem1, "Điểm không được để trống");
                    return;
                }
                if (tb_diem2.Text == "")
                {
                    errorProvider1.SetError(tb_diem2, "Điểm không được để trống");
                    return;
                }
                    hl.Point1 = double.Parse(tb_diem1.Text);
                hl.Point2 = double.Parse(tb_diem2.Text);
            }
            else
            {
                if (tb_diemfinal.Text == "")
                {
                    errorProvider1.SetError(tb_diemfinal, "Điểm không được để trống");
                    return;
                }
                hl.PointFinal = double.Parse(tb_diemfinal.Text);
                pointType = 1;
            }
            hl.StudentId = tb_hv_id.Text;
            hl.StudentName = tb_hv_name.Text;
            hl.ClassId = tb_class_id.Text;
            hl.ClassName = tb_class_name.Text;

            // save point
            if (HocVienLopHocBLL.Instance.setPoint(hl, pointType))
            {
                MessageBox.Show("Nhập điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // code auto change rate value after set point
                if (pointType == 0)
                    setRate(hl);
                else
                    setTotNghiepAndXepLoai(hl);

                // Đóng form
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập điểm thất bại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool setRate(HocVienLopHocDTO hl)
        {
            bool rate = false;
            if (hl.Point1 >= 5 && hl.Point2 >= 5)
                rate = true;
            hl.Rate = rate;
             return HocVienLopHocBLL.Instance.setRate(hl);
        }

        private bool setTotNghiepAndXepLoai(HocVienLopHocDTO hl)
        {
            bool totNghiep = false;
            string xepLoai = "Không xếp loại";
            if (hl.PointFinal >= 7)
                totNghiep = true;
            double diemTB = (((hl.Point1 + hl.Point2) / 2) + hl.PointFinal) / 3;
            if (diemTB >= 5 && diemTB <= 7)
                xepLoai = "Trung bình";
            else if (diemTB < 8.5)
                xepLoai = "Khá";
            else
                xepLoai = "Giỏi";

            hl.Graduating = totNghiep;
            hl.Rank = xepLoai;

            return HocVienLopHocBLL.Instance.setGraduatAndRank(hl);
        }
    }
}
