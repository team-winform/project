using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAM_BLL;
using System.Data.SqlClient;

namespace LAM_GUI
{
    
    public partial class Dialog_KhoaHOC : Form
    {
        int type;
        String ma;
        BLL bll;
        public Dialog_KhoaHOC(int type,String ma)
        {
            InitializeComponent();
            this.bll = new BLL();
            this.type = type;
            this.ma = ma;
            this.CenterToParent();
        }

        private void Dialog_KhoaHOC_Load(object sender, EventArgs e)
        {
            if (this.type == 1) labelTitle.Text = "Thêm khóa học";
            else
            {
                labelTitle.Text = "Sửa khóa học";
                Dictionary<String, String> kh = bll.findKhoaHoc(ma);
                txtTen.Text = kh["ten_KH"].ToString();
                txtGia.Text = kh["gia_KH"].ToString();
                txtGhiChu.Text = kh["ghichu_KH"].ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text == "")
                {
                    errorProvider1.SetError(txtTen, "Tên không được để trống");
                    throw new Exception();
                }
                if (txtGia.Text == "") errorProvider1.SetError(txtGia, "giá không được để trống");
                int gia = int.Parse(txtGia.Text.Trim());

                try
                {
                    int result;
                    if (type == 1) result = bll.addKhoaHoc(txtTen.Text.Trim(), txtGia.Text.Trim(), txtGhiChu.Text.Trim());
                    else result = bll.updateKhoaHoc(ma, txtTen.Text.Trim(), txtGia.Text.Trim(), txtGhiChu.Text.Trim());
                    if (result != 0)
                    {
                        if(type==1) MessageBox.Show("Thêm khóa học thành công");
                        else MessageBox.Show("sửa khóa học thành công");
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    if(type==1) MessageBox.Show("Không thể thêm khóa học: \n" + ex.Message);
                    else MessageBox.Show("Không thể sửa khóa học: \n" + ex.Message);
                }
            }
            catch(FormatException ex)
            {
                errorProvider1.SetError(txtGia, "giá phải là số");
            }catch(Exception ex)
            {

            }

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
