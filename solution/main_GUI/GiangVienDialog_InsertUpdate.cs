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

        private bool CheckEmptyInput()
        {
            bool error = false;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
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

            return error;
        }


        private bool Them(bool error)
        {
            if (type == 0 && !error)
            {
                GiangVienDTO gv = new GiangVienDTO();
                gv.Name = tb_ten.Text.Trim();
                gv.Username = cb_username.Text;
                gv.Note = tb_ghichu.Text;
                gv.Phone = tb_sdt.Text;
                gv.Address = tb_diachi.Text;
                gv.DayOfBirth = dateTimePicker1.Value;

                if (GiangVienBLL.Instance.insert(gv))
                {
                    return true;
                }
            }
            else if (type == 1 && !error)
            {
                GiangVienDTO gv = new GiangVienDTO();
                gv.Id = ma;
                gv.Name = tb_ten.Text.Trim();
                gv.Username = cb_username.Text;
                gv.Note = tb_ghichu.Text;
                gv.Phone = tb_sdt.Text;
                gv.Address = tb_diachi.Text;
                gv.DayOfBirth = dateTimePicker1.Value;

                if (GiangVienBLL.Instance.update(gv))
                {
                    return true;
                }
            }
            return false;
        }

        private void CheckThem()
        {
            bool error = CheckEmptyInput();
            bool KQ = Them(error);
            if (type == 0 && KQ)
            {
                MessageBox.Show("Thêm giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (type == 0 && !KQ)
            {
                MessageBox.Show("Thêm giảng viên thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (type == 1 && KQ)
            {
                MessageBox.Show("Sửa giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa giảng viên thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bt_them_Click(object sender, EventArgs e)
        {
            CheckThem();
        }

        private void GiangVienDialog_InsertUpdate_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            List<string> freeUsername = GiangVienBLL.Instance.getFreeUsername();

            if (type == 0)
            {
                this.lb_title.Text = "Thêm giảng viên";
                bt_ok.Text = "Thêm";
                if (freeUsername.Count == 0)
                {
                    MessageBox.Show("Hiện tại chưa thể thêm giảng viên mới. Vui lòng thêm mới Username trước!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    foreach (string un in freeUsername)
                    {
                        cb_username.Items.Add(un);
                    }
                    cb_username.SelectedIndex = 0;
                }
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

                cb_username.Items.Add(gv.Username);
                cb_username.SelectedIndex = 0;
                
                foreach (string un in freeUsername)
                {
                    cb_username.Items.Add(un);
                }
            }

            
           
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tb_ten_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            } else if(e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if(tb_ten.Text.Length > 30)
                {
                    tb_ten.Text = tb_ten.Text.Remove(tb_ten.Text.Length - 1);
                }
            }
        }

        private void DateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_sdt.Focus();
            }
        }

        private void Tb_sdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_diachi.Focus();
            }
            else if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (tb_sdt.Text.Length > 10)
                {
                    tb_sdt.Text = tb_sdt.Text.Remove(tb_sdt.Text.Length - 1);
                }
            }
        }

        private void Tb_diachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_ghichu.Focus();
            }
            else if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (tb_diachi.Text.Length > 100)
                {
                    tb_diachi.Text = tb_diachi.Text.Remove(tb_diachi.Text.Length - 1);
                }
            }
        }

       

        private void Tb_ghichu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckThem();
            }
        }
    }
}
