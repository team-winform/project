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
    public partial class GiangVienDialog_chiTiet : Form
    {
        private GiangVienDTO gv;
        public GiangVienDialog_chiTiet(GiangVienDTO g)
        {
            gv = g;
            InitializeComponent();
        }

        private void GiangVienDialog_chiTiet_Load(object sender, EventArgs e)
        {
            hienThiGrid();
            loadDataForTextBox();
        }

        private void loadDataForTextBox()
        {
            tb_address.Text = gv.Address;
            tb_date.Text = gv.DayOfBirth.ToString();
            tb_ma.Text = gv.Id;
            tb_note.Text = gv.Note;
            tb_sdt.Text = gv.Phone;
            tb_ten.Text = gv.Name;
        }

        private void hienThiGrid()
        {
            dgv_classList.Rows.Clear();
            List<LopHocDTO> classList = GiangVienBLL.Instance.getClassList(gv);
            int stt = 0;
            foreach (LopHocDTO l in classList)
            {
                dgv_classList.Rows.Add();
                dgv_classList.Rows[stt].Cells["id_LH"].Value = l.id_LH;
                dgv_classList.Rows[stt].Cells["ten_LH"].Value = l.ten_LH;
                dgv_classList.Rows[stt].Cells["ten_KH"].Value = l.ten_KH;
                dgv_classList.Rows[stt].Cells["ten_PH"].Value = l.ten_PH;
                dgv_classList.Rows[stt].Cells["siso"].Value = l.siSo;
                dgv_classList.Rows[stt].Cells["ngaybatdau"].Value = l.ngayBatDau;
                dgv_classList.Rows[stt].Cells["ngayketthuc"].Value = l.ngayKetThuc;
                stt++;
            }
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            new GiangVienGUI().enableButtonSearch();
            this.Close();
        }

        private void GiangVienDialog_chiTiet_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
