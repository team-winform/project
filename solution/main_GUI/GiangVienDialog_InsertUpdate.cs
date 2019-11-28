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
    public partial class GiangVienDialog_InsertUpdate : Form
    {
        int type;
        string ma;
        public GiangVienDialog_InsertUpdate(int type, string ma)
        {
            InitializeComponent();
            this.type = type;
            this.ma = ma;
        }

        private void Bt_them_Click(object sender, EventArgs e)
        {
            bool error = false;
            
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    if (control.Text == String.Empty)
                    {
                        error = true;
                        errorProvider1.SetError(control, "truong");
                    }
                    else
                    {
                        errorProvider1.SetError(control, "");
                    }
                }
            }

            if(type == 0 && !error)
            {
                GiangVienDTO gv = new GiangVienDTO();
                gv.Name = tb_ten.Text.Trim();
                gv.Note = tb_ghichu.Text;
                gv.Phone = tb_sdt.Text;
                gv.Address = tb_diachi.Text;
                gv.DayOfBirth = dateTimePicker1.Value;

                if (GiangVienBLL.Instance.insert(gv))
                {
                    MessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if(type == 1 && !error)
            {
                GiangVienDTO gv = new GiangVienDTO();
                gv.Id = ma;
                gv.Name = tb_ten.Text.Trim();
                gv.Note = tb_ghichu.Text;
                gv.Phone = tb_sdt.Text;
                gv.Address = tb_diachi.Text;
                gv.DayOfBirth = dateTimePicker1.Value;

                if (GiangVienBLL.Instance.update(gv))
                {
                    MessageBox.Show("Sửa giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa giảng viên thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void GiangVienDialog_InsertUpdate_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            
            if (type == 0)
            {
                this.lb_title.Text = "Thêm giảng viên";
                bt_ok.Text = "Thêm";
            }
            else
            {
                this.lb_title.Text = "Sửa giảng viên";
                bt_ok.Text = "Sửa";

                GiangVienDTO gv = GiangVienBLL.Instance.findById(ma);
                tb_ten.Text = gv.Name;
                tb_sdt.Text = gv.Phone;
                dateTimePicker1.Value = gv.DayOfBirth;
                tb_ghichu.Text = gv.Note;
                tb_diachi.Text = gv.Address;


            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
