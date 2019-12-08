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
    public partial class PhongHocDialog_ChiTiet : Form
    {
        private PhongHocDTO ph;
        public PhongHocDialog_ChiTiet(PhongHocDTO p)
        {
            ph = p;
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhongHocDialog_ChiTiet_Load(object sender, EventArgs e)
        {
            loadDataForTextBox();
            hienThiGrid();

        }

        private void loadDataForTextBox()
        {
            tb_created.Text = ph.Created.ToString();
            tb_updated.Text = ph.Updated.ToString();
            tb_maP.Text = ph.Id;
            tb_tp.Text = ph.Name;
            tb_sc.Text = ph.MaxSeat.ToString();
            tb_gc.Text = ph.Note;
        }

        private void hienThiGrid()
        {
            dgv_LH.Rows.Clear();
            List<LopHocDTO> classList = PhongHocBLL.Instance.getsClassUse(ph.Id);
            int stt = 0;
            foreach (LopHocDTO l in classList)
            {
                dgv_LH.Rows.Add();
                dgv_LH.Rows[stt].Cells["id_LH"].Value = l.id_LH;
                dgv_LH.Rows[stt].Cells["ten_LH"].Value = l.ten_LH;
                dgv_LH.Rows[stt].Cells["ten_KH"].Value = l.ten_KH;
                dgv_LH.Rows[stt].Cells["ten_GV"].Value = l.ten_GV;
                dgv_LH.Rows[stt].Cells["siso"].Value = l.siSo;
                dgv_LH.Rows[stt].Cells["ngaybatdau"].Value = l.ngayBatDau;
                dgv_LH.Rows[stt].Cells["ngayketthuc"].Value = l.ngayKetThuc;
                stt++;
            }
        }

    }
}
