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
    public partial class HocPhiGui : Form
    {
        public HocPhiGui()
        {
            InitializeComponent();
        }

        private void HocPhiGui_Load(object sender, EventArgs e)
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
            cb_listClass.DisplayMember = "ten_LH";
            cb_listClass.ValueMember = "id_LH";
            if (cb_listClass.Items.Count > 0)
            {
                return true;
            }

            else
                return false;
        }

        private void Bt_selectLop_Click(object sender, EventArgs e)
        {
            cb_lanNop.Enabled = true;
            bt_ChonLanNop.Enabled = true;
            cb_lanNop.SelectedIndex = -1;
            bt_Huy.Visible = false;
            bt_xacNhanHP.Visible = false;
            hienThiGrid();
        }

        private void hienThiGrid()
        {
            string classId = cb_listClass.SelectedValue.ToString();
            List<HocPhiDTO> hps = HocPhiBLL.Instance.getsByClassId(classId);
            MessageBox.Show(hps.Count.ToString());
        }
    }
}
