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

        private List<LopHocDTO> lhs;
        private List<HocPhiDTO> hps;
        private void HocPhiGui_Load(object sender, EventArgs e)
        {
            loadDataForComboBox();
            if (cb_listClass.Items.Count > 0)
            {
                bt_selectLop.Enabled = true;
            }
            unableThongKe();
        }

        private bool loadDataForComboBox()
        {
            
            try
            {
                QuanLyLopHocBLL lhBBLL = new QuanLyLopHocBLL();
                lhs = lhBBLL.getsIdAndName();

                cb_listClass.DataSource = lhs;
                cb_listClass.DisplayMember = "ten_LH";
                cb_listClass.ValueMember = "id_LH";
                return true;
            }
            catch
            {
                return false;
            }
            
            
        }

        private void Bt_selectLop_Click(object sender, EventArgs e)
        {
            cb_lanNop.Enabled = true;
            bt_ChonLanNop.Enabled = false;
            cb_lanNop.SelectedIndex = -1;
            bt_Huy.Visible = false;
            bt_xacNhanHP.Visible = false;
            loadTextBoxHocPhi();
            hienThiGrid();
            dgv_HocPhi.ReadOnly = true;
            loadTextBoxThongKe();
        }

        private void unableThongKe()
        {
            tb_soHV.Visible = false;
            tb_tongPhi.Visible = false;
            tb_tongThu.Visible = false;
            tb_Tongno.Visible = false;
            lb_sohv.Visible = false;
            lb_tongno.Visible = false;
            lb_tongphi.Visible = false;
            lb_tongthu.Visible = false;
        }

        private void enableThongKe()
        {
            tb_soHV.Visible = true;
            tb_tongPhi.Visible = true;
            tb_tongThu.Visible = true;
            tb_Tongno.Visible = true;
            lb_sohv.Visible = true;
            lb_tongno.Visible = true;
            lb_tongphi.Visible = true;
            lb_tongthu.Visible = true;
        }

        private void loadTextBoxThongKe()
        {
            enableThongKe();

            getTongSoHV();
            getTongThu();
            getTongNo();
            getTongHocPhi();
        }

        private double getTongNo()
        {
            double tong = getTongHocPhi() - getTongThu();
            tb_Tongno.Text = string.Format("{0:#,##}", tong);
            return tong;
        }

        private double getTongThu()
        {
            double tong = 0;
            foreach(HocPhiDTO hp in hps)
            {
                tong += hp.Complete;
            }
            tb_tongThu.Text = string.Format("{0:#,##}", tong);
            return tong;
        }

        private double getTongHocPhi()
        {
            double tong = double.Parse(tb_hocphi.Text) * hps.Count;
            tb_tongPhi.Text = string.Format("{0:#,##}", tong);
            return tong;
        }

        private void getTongSoHV()
        {
            tb_soHV.Text = hps.Count.ToString();
        }

        private void loadTextBoxHocPhi()
        {
            string classId = cb_listClass.SelectedValue.ToString();
            foreach (LopHocDTO lh in lhs)
            {
                if (lh.id_LH == classId)
                {
                    tb_hocphi.Text = string.Format("{0:#,##}", lh.hocPhi);
                    return;
                }
            }
        }

        private void hienThiGrid()
        {
            string classId = cb_listClass.SelectedValue.ToString();
            hps = HocPhiBLL.Instance.getsByClassId(classId);
            dgv_HocPhi.Rows.Clear();
            int i = 0;
            foreach (HocPhiDTO hp in hps)
            {
                dgv_HocPhi.Rows.Add();
                dgv_HocPhi.Rows[i].Cells["id_HV"].Value = hp.StudentId;
                dgv_HocPhi.Rows[i].Cells["ten_HV"].Value = hp.StudentName;
                dgv_HocPhi.Rows[i].Cells["nop1"].Value = string.Format("{0:#,##}", hp.Pay1);
                dgv_HocPhi.Rows[i].Cells["date1"].Value = hp.Date1;
                dgv_HocPhi.Rows[i].Cells["nop2"].Value = string.Format("{0:#,##}", hp.Pay2);
                dgv_HocPhi.Rows[i].Cells["date2"].Value = hp.Date2;

                //set hoan thanh
                if (hp.Complete == 0)
                {
                    dgv_HocPhi.Rows[i].Cells["complete"].Style.ForeColor = Color.Red;
                    dgv_HocPhi.Rows[i].Cells["complete"].Value = 0;
                }
                else if (hp.getOwed() > 0)
                {
                    dgv_HocPhi.Rows[i].Cells["complete"].Style.ForeColor = Color.Orange;
                    dgv_HocPhi.Rows[i].Cells["complete"].Value = string.Format("{0:#,##}", hp.Complete);
                }
                else
                {
                    dgv_HocPhi.Rows[i].Cells["complete"].Style.ForeColor = Color.Green;
                    dgv_HocPhi.Rows[i].Cells["complete"].Value = string.Format("{0:#,##}", hp.Complete);
                }

                // set con no
                if (hp.getOwed() == 0)
                {
                    dgv_HocPhi.Rows[i].Cells["conno"].Style.ForeColor = Color.Green;
                    dgv_HocPhi.Rows[i].Cells["conno"].Value = 0;
                }
                else if (hp.getOwed() < hp.Tuition)
                {
                    dgv_HocPhi.Rows[i].Cells["conno"].Style.ForeColor = Color.Orange;
                    dgv_HocPhi.Rows[i].Cells["conno"].Value = string.Format("{0:#,##}", hp.getOwed());
                }
                else
                {
                    dgv_HocPhi.Rows[i].Cells["conno"].Style.ForeColor = Color.Red;
                    dgv_HocPhi.Rows[i].Cells["conno"].Value = string.Format("{0:#,##}", hp.getOwed());
                }
                i++;
            }
        }

        private void reloadButton()
        {
            bt_selectLop.Enabled = true;
            bt_xacNhanHP.Visible = false;
            bt_Huy.Visible = false;
            
            cb_lanNop.SelectedIndex = -1;
            cb_lanNop.Enabled = true;
            bt_ChonLanNop.Enabled = false;
        }

        private void Bt_ChonLanNop_Click(object sender, EventArgs e)
        {
            if (bt_Huy.Visible == false)
            {
                cb_lanNop.Enabled = false;
                bt_ChonLanNop.Enabled = false;
            }
            bt_Huy.Visible = true;
            bt_xacNhanHP.Visible = true;
            bt_selectLop.Enabled = false;
            ChangeCollumnColorActive();
            cellVisiable();
        }

        private void cellVisiable()
        {
            dgv_HocPhi.ReadOnly = false;
            dgv_HocPhi.Columns["id_HV"].ReadOnly = true;
            dgv_HocPhi.Columns["ten_HV"].ReadOnly = true;
            dgv_HocPhi.Columns["date1"].ReadOnly = true;
            dgv_HocPhi.Columns["date2"].ReadOnly = true;
            dgv_HocPhi.Columns["complete"].ReadOnly = true;
            dgv_HocPhi.Columns["conno"].ReadOnly = true;

            string chonLanNop = cb_lanNop.Text;
            foreach (DataGridViewRow r in dgv_HocPhi.Rows)
            {
                if (chonLanNop == "Lần 1")
                {

                    r.Cells["nop1"].ReadOnly = false;
                    r.Cells["nop2"].ReadOnly = true;
                }

                else if (chonLanNop == "Lần 2")
                {
                    r.Cells["nop1"].ReadOnly = true;
                    r.Cells["nop2"].ReadOnly = false;

                }
                else
                {
                    dgv_HocPhi.Columns["nop1"].ReadOnly = true;
                    dgv_HocPhi.Columns["nop2"].ReadOnly = true;
                }
            }
        }

        private void ChangeCollumnColorActive()
        {
            string chonLanNop = cb_lanNop.Text;
            if (chonLanNop == "Lần 1")
            {
                dgv_HocPhi.Columns["nop1"].DefaultCellStyle.BackColor = Color.Yellow;
                dgv_HocPhi.Columns["nop2"].DefaultCellStyle.BackColor = Color.White;
                
            }
            else if (chonLanNop == "Lần 2")
            {
                dgv_HocPhi.Columns["nop1"].DefaultCellStyle.BackColor = Color.White;
                dgv_HocPhi.Columns["nop2"].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                dgv_HocPhi.Columns["nop1"].DefaultCellStyle.BackColor = Color.White;
                dgv_HocPhi.Columns["nop2"].DefaultCellStyle.BackColor = Color.White;
            }

        }

        private void Bt_Huy_Click(object sender, EventArgs e)
        {
            reloadButton();
            hienThiGrid();
            ChangeCollumnColorActive();
            cellVisiable();
            loadTextBoxThongKe();
        }

        private void Cb_lanNop_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_ChonLanNop.Enabled = true;
        }

        // This method handling việc nhập học phí cho tất cả học viên cùng lúc
        private void Bt_xacNhanHP_Click(object sender, EventArgs e)
        {
            string lanNop = cb_lanNop.Text;
            int PayTime;

            if (lanNop == "Lần 1")
                PayTime = 1;
            else if (lanNop == "Lần 2")
                PayTime = 2;
            else
                PayTime = 0;

            int i = 0;
            foreach(DataGridViewRow r in dgv_HocPhi.Rows)
            {
                if(PayTime == 1)
                {
                    // this code used to ngăn không cho xóa lần nộp 1 khi lần nộp 2 đã có dữ liệu.
                    // Vì phải có lần 1 mới có lần 2 chứ. -))
                    if (r.Cells["nop1"].Value.ToString() == "" && r.Cells["nop2"].Value.ToString() != "")
                        continue;
                }

                // Chỉ thay đổi các row có điều chỉnh ở cột nộp 1 || cột nộp 2
                if(r.Cells["nop1"].Value != null && r.Cells["nop1"].Value.ToString() != string.Empty || r.Cells["nop2"].Value != null && r.Cells["nop2"].Value.ToString() != string.Empty)
                {
                    HocPhiDTO hp = getHPfromGridRowIndex(i);
                    HocPhiBLL.Instance.payTuition(hp, PayTime);
                }
                ++i;
            }

            // Sau khi nhập xong. Reset lại sự hiển thị của các button, hiện thị lại grid, thống kê,..
            reloadButton();
            hienThiGrid();
            ChangeCollumnColorActive();
            cellVisiable();
            loadTextBoxThongKe();
        }

        //This method return HocPhiDTO object in active row
        private HocPhiDTO getHPfromGridRowIndex(int index)
        {
            HocPhiDTO hp = new HocPhiDTO();
            hp.StudentId = dgv_HocPhi.Rows[index].Cells["id_HV"].Value.ToString();
            hp.StudentName = dgv_HocPhi.Rows[index].Cells["ten_HV"].Value.ToString();
            hp.ClassId = cb_listClass.SelectedValue.ToString();
            hp.ClassName = cb_listClass.Text;
            hp.Tuition = double.Parse(tb_hocphi.Text);
            try
            {
                hp.Pay1 = double.Parse(dgv_HocPhi.Rows[index].Cells["nop1"].Value.ToString());
                
            }
            catch { }
            try
            {
                hp.Pay2 = double.Parse(dgv_HocPhi.Rows[index].Cells["nop2"].Value.ToString());
            }
            catch { }

            try
            {
                hp.Complete = double.Parse(dgv_HocPhi.Rows[index].Cells["complete"].Value.ToString());
            }
            catch { }

            try
            {
                hp.Date1 = DateTime.Parse(dgv_HocPhi.Rows[index].Cells["date1"].Value.ToString());
            }
            catch { }
            try
            {
                hp.Date2 = DateTime.Parse(dgv_HocPhi.Rows[index].Cells["date2"].Value.ToString());
            }
            catch { }
            return hp;
        }

        // Xu ly khi nhap cell: chỉ cho nhập số
        private void Dgv_HocPhi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tbx = e.Control as TextBox;
            bool notNumber = false;

            tbx.KeyDown += (S, E) =>
            {
                if (E.KeyCode < Keys.D0 || E.KeyCode > Keys.D9)
                {
                    Console.WriteLine("Khac k0-9");
                    if (E.KeyCode < Keys.NumPad0 || E.KeyCode > Keys.NumPad9)
                    {
                        Console.WriteLine("khac n0-9");
                        if (E.KeyCode != Keys.Back)
                        {
                            Console.WriteLine("Khac back");
                            if (E.KeyCode != Keys.Up && E.KeyCode != Keys.Right && E.KeyCode != Keys.Down && E.KeyCode != Keys.Left)
                            {
                                Console.WriteLine("Khac muiten");
                                Console.WriteLine(E.KeyData);
                                notNumber = true;
                            }
                        }
                    }
                }
                else if (Control.ModifierKeys == Keys.Shift)
                {
                    Console.WriteLine("La shift");
                    notNumber = true;
                }
                else
                {
                    Console.WriteLine("la so");
                    notNumber = false;
                }
            };

            tbx.KeyPress += (S, E) =>
            {
                if (notNumber)
                {
                    E.Handled = true;
                }
            };

            tbx.KeyUp += (S, E) =>
            {
                try
                {
                    tbx.Text = string.Format("{0:#,##}", double.Parse(tbx.Text));
                    tbx.SelectionStart = tbx.Text.Length;
                    tbx.SelectionLength = 0;
                }
                catch { }
            };
        }

        private void Cb_listClass_Click(object sender, EventArgs e)
        {
            if(cb_listClass.Items.Count == 0)
            {
                MessageBox.Show("Hiện chưa có lớp nào hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
