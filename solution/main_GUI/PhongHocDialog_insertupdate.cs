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
    public partial class PhongHocDialog_insertupdate : Form
    {
        private bool isInsert;
        private string id;

        public PhongHocDialog_insertupdate(string ma, bool type)
        {
            isInsert = type;
            id = ma;
            InitializeComponent();
        }

        private void Bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkEmptyInput()
        {
            bool error = false;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    
                    if (control.Text == String.Empty)
                    {
                        error = true;
                        errorProvider1.SetError(control, "Vui lòng nhập trường này!");
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
            if (isInsert && !error)
            {
                PhongHocDTO ph = new PhongHocDTO();
                ph.Name = tb_ten.Text.Trim();
                ph.Note = tb_ghichu.Text.Trim();
                ph.MaxSeat = int.Parse(tb_succhua.Text.Trim());
                ph.Created = DateTime.Now;
                ph.Updated = ph.Created;
                ph.Id = "PH_" + TimingDTO.getTimeString("dd", "MM", "yy", "HH", "mm", "ss");

                if (PhongHocBLL.Instance.insert(ph))
                {
                    MessageBox.Show("Thêm phòng học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return true;
                }
            }
            else if (!error)
            {
                PhongHocDTO ph = new PhongHocDTO();
                ph.Id = id;
                ph.Name = tb_ten.Text;
                ph.MaxSeat = int.Parse(tb_succhua.Text);
                ph.Note = tb_ghichu.Text;

                ph.Updated = DateTime.Now;

                if (PhongHocBLL.Instance.update(ph))
                {
                    return true;
                }
            }

            return false;
        }

        private void checkThem()
        {
            bool error = checkEmptyInput();
            bool KQ = Them(error);
            if(isInsert && KQ)
            {
                MessageBox.Show("Thêm phòng học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if(isInsert && !KQ)
            {
                MessageBox.Show("Thêm phòng học thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(!isInsert && KQ)
            {
                MessageBox.Show("Sửa phòng học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa phòng học thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Bt_ok_Click(object sender, EventArgs e)
        {
            checkThem();
        }

        private void PhongHocDialog_insertupdate_Load(object sender, EventArgs e)
        {
            if (isInsert)
            {
                lb_title.Text = "Thêm phòng học";
                bt_ok.Text = "Thêm";
            }
            else
            {
                lb_title.Text = "Sửa phòng học";
                bt_ok.Text = "Sửa";

                PhongHocDTO ph = PhongHocBLL.Instance.findById(id);
                
                tb_succhua.Text = ph.MaxSeat.ToString();
                tb_ghichu.Text = ph.Note;
                tb_ten.Text = ph.Name;
                
            }
        }

        private void Tb_ten_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tb_succhua.Focus();
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                if (tb_ten.Text.Length > 30)
                {
                    tb_ten.Text = tb_ten.Text.Remove(tb_ten.Text.Length - 1);
                }
            }
        }

        private void Tb_succhua_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_ghichu.Focus();
            }else if(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if(tb_succhua.Text.Length > 4)
                {
                    tb_succhua.Text = tb_succhua.Text.Remove(tb_succhua.Text.Length - 1);
                }
            }
            else if(e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                tb_succhua.Text = tb_succhua.Text.Remove(tb_succhua.Text.Length - 1);
            }
        }

        private void Tb_ghichu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkThem();
            }
        }
    }
}
