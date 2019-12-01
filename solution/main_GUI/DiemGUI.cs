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
    public partial class DiemGUI : Form
    {
        public DiemGUI()
        {
            InitializeComponent();
        }

        private void DiemGUI_Load(object sender, EventArgs e)
        {
            if (loadDataForComboBox())
            {
                bt_selectLop.Enabled = true;
            }
            
                

        }

        private bool loadDataForComboBox()
        {
            QuanLyLopHocBLL lhBBLL = new QuanLyLopHocBLL();
            cb_listClass.DataSource = lhBBLL.getsIdAndName();
            cb_listClass.DisplayMember = "tenLopHoc";
            cb_listClass.ValueMember = "id_LH";
            Console.WriteLine(cb_listClass.Items.Count);
            if (cb_listClass.Items.Count > 0)
            {
                return true;
            }
               
            else
                return false;
        }

        private void Bt_selectLop_Click(object sender, EventArgs e)
        {
            string className = cb_listClass.Text;
            hienThiGrid(className);
        }

        private void hienThiGrid(string className)
        {
            dgv_Diem.DataSource = HocVienLopHocBLL.Instance.getsByClassName(className);
            if (dgv_Diem.Rows.Count > 0)
                bt_nhapDiem.Enabled = true;
        }

        private void Bt_nhapDiem_Click(object sender, EventArgs e)
        {
            HocVienLopHocDTO hl = getHVLHfromGrid();
            bool diem1 =false;
            bool diem2 = false;
            bool diemFinal = false;
            if(hl.Point1 == -1 && hl.Point2 == -1)
            {
                diem1 = true;
                diem2 = true;
                diemFinal = false;
            }
            else if(hl.Rate)
            {
                diem1 = false;
                diem2 = false;
                diemFinal = true;
            }
            else
            {
                MessageBox.Show("Không thể nhập điểm cho học viên này!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            new DiemDialog_nhapDiem(diem1, diem2, diemFinal, hl).ShowDialog();
            string className = cb_listClass.Text;
            hienThiGrid(className);
        }

        private HocVienLopHocDTO getHVLHfromGrid()
        {
            int index = dgv_Diem.SelectedCells[0].OwningRow.Index;
            HocVienLopHocDTO hl = new HocVienLopHocDTO();
            hl.StudentId = dgv_Diem.Rows[index].Cells["id_HV"].Value.ToString();
            hl.StudentName = dgv_Diem.Rows[index].Cells["ten_HV"].Value.ToString();
            hl.ClassId = dgv_Diem.Rows[index].Cells["id_LH"].Value.ToString();
            hl.ClassName = dgv_Diem.Rows[index].Cells["ten_LH"].Value.ToString();
            hl.Point1 = double.Parse(dgv_Diem.Rows[index].Cells["diem_1"].Value.ToString());
            hl.Point2 = double.Parse(dgv_Diem.Rows[index].Cells["diem_2"].Value.ToString());
            hl.Rate = bool.Parse(dgv_Diem.Rows[index].Cells["danhgia"].Value.ToString());
            return hl;
        }
    }
}
