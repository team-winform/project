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
using DTOs;

namespace main_GUI
{
    public partial class GiangVienGUI : Form
    {
        public GiangVienGUI()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("cell content click");
        }

        private void GiangVienGUI_Load(object sender, EventArgs e)
        {
            InitSortButton();
            
            hienThi();
            DisplayButton();
        }

        private class ComboBoxInfo
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public ComboBoxInfo(string k, string v)
            {
                Key = k;
                Value = v;
            }

            public ComboBoxInfo() { }
        }

        private void InitSortButton()
        {

            List<ComboBoxInfo> list = new List<ComboBoxInfo>();
            list.Add(new ComboBoxInfo("id_GV", "Mã giảng viên"));
            list.Add(new ComboBoxInfo("ten_GV", "Tên giảng viên"));
            list.Add(new ComboBoxInfo("ngaysinh_GV", "Ngày sinh"));
            list.Add(new ComboBoxInfo("sodt_GV", "Số điện thoại"));
            list.Add(new ComboBoxInfo("diachi_GV", "Địa chỉ"));
            list.Add(new ComboBoxInfo("ngaytao", "Ngày tạo"));
            list.Add(new ComboBoxInfo("ngaysua", "Ngày sửa"));
            list.Add(new ComboBoxInfo("ghichu_GV", "Ghi chú"));

            /*foreach(ComboBoxInfo c in list)
            {
                Console.WriteLine(c.Key + "; " + c.Value);
            }*/

            cb_sortBy.DataSource = list;
            cb_sortBy.DisplayMember = "Value";
            cb_sortBy.ValueMember = "Key";

            cb_sortType.Items.Add("ASC");
            cb_sortType.Items.Add("DESC");
            cb_sortType.SelectedIndex = 0;
        }

        private void DisplayButton()
        {
            
            if (dgv_GV.Rows.Count > 0 && dgv_GV.Rows[0].Cells[0].Value == null )
            {
                bt_sua.Enabled = false;
                bt_xoa.Enabled = false;
            }
            else
            {
                bt_sua.Enabled = true;
                bt_xoa.Enabled = true;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_them_Click(object sender, EventArgs e)
        {
            new GiangVienDialog_InsertUpdate(0, null).ShowDialog();
            hienThi();
            DisplayButton();
        }

        private void hienThi()
        {
            dgv_GV.DataSource = GiangVienBLL.Instance.getAll(getSortedByValue(), getSortTypeValue());
            
        }

        private string getSortedByValue()
        {
            //Console.WriteLine("da vao day" + cb_sortBy.SelectedValue.ToString());
            return cb_sortBy.SelectedValue.ToString();
        }

        private string getSortTypeValue()
        {
            //Console.WriteLine(cb_sortType.Text);
            return cb_sortType.Text;
        }

        private void Bt_xoa_Click(object sender, EventArgs e)
        {
            int index = dgv_GV.CurrentCell.RowIndex;
            String ma = dgv_GV.Rows[index].Cells["id_GV"].Value.ToString();
            string ten = dgv_GV.Rows[index].Cells["ten_GV"].Value.ToString();
            String message = "Xác nhận xóa Giảng viên: " + ten;

            DialogResult result = MessageBox.Show(message, "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (GiangVienBLL.Instance.delete(ma))
                {
                    MessageBox.Show("Xóa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienThi();
                    DisplayButton();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Bt_sua_Click(object sender, EventArgs e)
        {
            int index = dgv_GV.CurrentCell.RowIndex;
            String ma = dgv_GV.Rows[index].Cells["id_GV"].Value.ToString();
            new GiangVienDialog_InsertUpdate(1, ma).ShowDialog();
            hienThi();
            DisplayButton();
        }

        private void Bt_tim_Click(object sender, EventArgs e)
        {
            bt_tim.Enabled = false;
            new GiangVienDialog_search(this).Show();
        }

        public void enableButtonSearch()
        {
            bt_tim.Enabled = true;
        }

        private void Cb_sortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sortBy.Items.Count > 0 && cb_sortType.Items.Count > 0)
            {
                dgv_GV.DataSource = GiangVienBLL.Instance.getAll(getSortedByValue(), getSortTypeValue());
                //MessageBox.Show("count > 0");
            }
        }
  
        private void Cb_sortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sortBy.Items.Count > 0 && cb_sortType.Items.Count > 0)
            {
                dgv_GV.DataSource = GiangVienBLL.Instance.getAll(getSortedByValue(), getSortTypeValue());
            }
        }

        private void Dgv_GV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GiangVienDTO gv = new GiangVienDTO();
            int index = dgv_GV.CurrentCell.RowIndex;
            gv.Id = dgv_GV.Rows[index].Cells["id_GV"].Value.ToString();
            gv.Name = dgv_GV.Rows[index].Cells["ten_GV"].Value.ToString();
            gv.Note = dgv_GV.Rows[index].Cells["ghichu_GV"].Value.ToString();
            gv.Phone = dgv_GV.Rows[index].Cells["sodt_GV"].Value.ToString();
            gv.DayOfBirth = DateTime.Parse(dgv_GV.Rows[index].Cells["ngaysinh_GV"].Value.ToString());
            gv.Address = dgv_GV.Rows[index].Cells["diachi_GV"].Value.ToString();
            Console.WriteLine("giang vien db click");
            new GiangVienDialog_chiTiet(gv).ShowDialog();
        }
    }
}
