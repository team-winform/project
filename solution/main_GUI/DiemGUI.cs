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
        private List<HocVienLopHocDTO> hvlhs;
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
            dgv_Diem.ReadOnly = true;
            unableThongKe();
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
            
            hienThiGrid();
            cb_chonDiem.Enabled = true;
            cb_chonDiem.SelectedIndex = -1;
            bt_nhapDiem.Enabled = false;
            bt_Huy.Visible = false;
            bt_xacNhanDiem.Visible = false;
            thongKe();
        }

        private void unableThongKe()
        {
            lb_dat.Visible = false;
            lb_khongdat.Visible = false;
            lb_totng.Visible = false;
            lb_truot.Visible = false;
            lb_gioi.Visible = false;
            lb_kha.Visible = false;
            lb_tb.Visible = false;

            tb_dat.Visible = false;
            tb_kdat.Visible = false;
            tb_tn.Visible = false;
            tb_truot.Visible = false;
            tb_gioi.Visible = false;
            tb_kha.Visible = false;
            tb_tb.Visible = false;

        }

        private void visibleThongKe()
        {
            lb_dat.Visible = true;
            lb_khongdat.Visible = true;
            lb_totng.Visible = true;
            lb_truot.Visible = true;
            lb_gioi.Visible = true;
            lb_kha.Visible = true;
            lb_tb.Visible = true;

            tb_dat.Visible = true;
            tb_kdat.Visible = true;
            tb_tn.Visible = true;
            tb_truot.Visible = true;
            tb_gioi.Visible = true;
            tb_kha.Visible = true;
            tb_tb.Visible = true;
        }

        private void thongKe()
        {
            visibleThongKe();

            int tongDat = 0;
            int tongKDat = 0;
            int tongTN = 0;
            int tongTruot = 0;
            int tongGioi = 0;
            int tongKha = 0;
            int tongTB = 0;

            foreach (HocVienLopHocDTO hl in hvlhs)
            {
                if (hl.Rate == true)
                    ++tongDat;
                if (hl.Graduating == true)
                    ++tongTN;
                if (hl.Rank == "Giỏi")
                    ++tongGioi;
                if (hl.Rank == "Khá")
                    ++tongKha;
                if (hl.Rank == "Trung bình")
                    ++tongTB;
                if (hl.Rate == false && (hl.Point1 != -1 && hl.Point2 != -1))
                    ++tongKDat;
                if ((hl.Rate == true && hl.PointFinal != -1 && hl.Point1 != -1 && hl.Point2 != -1 && hl.Graduating == false))
                    ++tongTruot;
            }

            tb_dat.Text = tongDat.ToString();
            tb_kdat.Text = tongKDat.ToString();
            tb_tn.Text = tongTN.ToString();
            tb_truot.Text =(tongKDat + tongTruot).ToString();
            tb_gioi.Text = tongGioi.ToString();
            tb_kha.Text = tongKha.ToString();
            tb_tb.Text = tongTB.ToString();

        }

        

        private void hienThiGrid()
        {
            string className = cb_listClass.Text;
            hvlhs = HocVienLopHocBLL.Instance.getsByClassName(className);

            dgv_Diem.Rows.Clear();
            int i = 0;
            
            foreach(HocVienLopHocDTO hvlh in hvlhs)
            {
                dgv_Diem.Rows.Add();
                dgv_Diem.Rows[i].Cells["id_HV"].Value = hvlh.StudentId;
                dgv_Diem.Rows[i].Cells["ten_HV"].Value = hvlh.StudentName;
                dgv_Diem.Rows[i].Cells["diem_1"].Value = (hvlh.Point1 == -1) ? "" : hvlh.Point1.ToString();
                dgv_Diem.Rows[i].Cells["diem_2"].Value = (hvlh.Point2 == -1) ? "" : hvlh.Point2.ToString();

                // set danh gia
                if(dgv_Diem.Rows[i].Cells["diem_1"].Value.ToString() == string.Empty || dgv_Diem.Rows[i].Cells["diem_2"].Value.ToString() == string.Empty)
                {
                    dgv_Diem.Rows[i].Cells["danhgia"].Value = "Chưa đánh giá";
                }
                else if(hvlh.Rate == false)
                {
                    dgv_Diem.Rows[i].Cells["danhgia"].Style.ForeColor = Color.Red;
                    dgv_Diem.Rows[i].Cells["danhgia"].Value = "Không đạt";
                } else if(hvlh.Rate == true)
                {
                    dgv_Diem.Rows[i].Cells["danhgia"].Style.ForeColor = Color.Green;
                    dgv_Diem.Rows[i].Cells["danhgia"].Value = "Đạt";
                }

                // set diem do an
                if(dgv_Diem.Rows[i].Cells["danhgia"].Value.ToString() == "Không đạt")
                {
                    dgv_Diem.Rows[i].Cells["diem_do_an"].Style.ForeColor = Color.Red;
                    dgv_Diem.Rows[i].Cells["diem_do_an"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_Diem.Rows[i].Cells["diem_do_an"].Value = "------";
                }
                else
                {
                    dgv_Diem.Rows[i].Cells["diem_do_an"].Value = (hvlh.PointFinal == -1) ? "" : hvlh.PointFinal.ToString();
                }

                //set diem tb
                if (hvlh.getDTB() == "-1" && dgv_Diem.Rows[i].Cells["danhgia"].Value.ToString() == "Không đạt")
                {
                    dgv_Diem.Rows[i].Cells["dtb"].Style.ForeColor = Color.Red;
                    dgv_Diem.Rows[i].Cells["dtb"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_Diem.Rows[i].Cells["dtb"].Value = "------";
                }
                else if(hvlh.getDTB() == "-1")
                {
                    dgv_Diem.Rows[i].Cells["dtb"].Value = "Chưa đủ điểm";
                }
                else
                {
                    dgv_Diem.Rows[i].Cells["dtb"].Style.ForeColor = Color.Blue;
                    dgv_Diem.Rows[i].Cells["dtb"].Value = hvlh.getDTB().ToString();
                }

                //set xet tot nghiep
                if (dgv_Diem.Rows[i].Cells["danhgia"].Value.ToString() == "Không đạt")
                {
                    dgv_Diem.Rows[i].Cells["xet_tot_nghiep"].Style.ForeColor = Color.Red;
                    dgv_Diem.Rows[i].Cells["xet_tot_nghiep"].Value = "Học lại";
                }
                else if (dgv_Diem.Rows[i].Cells["diem_do_an"].Value.ToString() == string.Empty)
                {
                    dgv_Diem.Rows[i].Cells["xet_tot_nghiep"].Value = "Chưa đủ điểm";
                } 
                else if(hvlh.Graduating == true)
                {
                    dgv_Diem.Rows[i].Cells["xet_tot_nghiep"].Style.ForeColor = Color.Green;
                    dgv_Diem.Rows[i].Cells["xet_tot_nghiep"].Value = "Tốt nghiệp";
                }
                else
                {
                    dgv_Diem.Rows[i].Cells["xet_tot_nghiep"].Style.ForeColor = Color.Red;
                    dgv_Diem.Rows[i].Cells["xet_tot_nghiep"].Value = "Học lại";
                }

                // set xep loai
                if(hvlh.Rank != "Không xếp loại")
                {
                    dgv_Diem.Rows[i].Cells["xeploai"].Style.ForeColor = Color.Green;
                    dgv_Diem.Rows[i].Cells["xeploai"].Value = hvlh.Rank;
                }
                else
                {
                    dgv_Diem.Rows[i].Cells["xeploai"].Value = hvlh.Rank;
                }
                
                dgv_Diem.Rows[i].Cells["ghichu_HVLH"].Value = hvlh.Note;

                i++;
            }
        }

        private void Bt_nhapDiem_Click(object sender, EventArgs e)
        {
            if (bt_Huy.Visible == false)
            {
                cb_chonDiem.Enabled = false;
                bt_nhapDiem.Enabled = false;
            }
                
            bt_Huy.Visible = true;
            bt_xacNhanDiem.Visible = true;
            bt_selectLop.Enabled = false;
            ChangeCollumnColorActive();
            cellVisiable();
        }

        private HocVienLopHocDTO getHVLHfromGrid()
        {
            int index = dgv_Diem.SelectedCells[0].OwningRow.Index;
            return getHVLHfromGridRowIndex(index);
        }

        private HocVienLopHocDTO getHVLHfromGridRowIndex(int index)
        {
            HocVienLopHocDTO hl = new HocVienLopHocDTO();
            hl.StudentId = dgv_Diem.Rows[index].Cells["id_HV"].Value.ToString();
            hl.StudentName = dgv_Diem.Rows[index].Cells["ten_HV"].Value.ToString();
            hl.ClassId = cb_listClass.SelectedValue.ToString();
            hl.ClassName = cb_listClass.Text;
            try{
                hl.Point1 = double.Parse(dgv_Diem.Rows[index].Cells["diem_1"].Value.ToString());
            }catch
            {
                hl.Point1 = -1;
            }

            try
            {
                hl.Point2 = double.Parse(dgv_Diem.Rows[index].Cells["diem_2"].Value.ToString());
            }
            catch
            {
                hl.Point2 = -1;
            }


            if (dgv_Diem.Rows[index].Cells["danhgia"].Value.ToString() == "Đạt" && dgv_Diem.Rows[index].Cells["diem_do_an"].Value != null && dgv_Diem.Rows[index].Cells["diem_do_an"].Value.ToString() != "")
            {
                try
                {
                    hl.PointFinal = double.Parse(dgv_Diem.Rows[index].Cells["diem_do_an"].Value.ToString());
                } catch(Exception e)
                {
                    hl.PointFinal = -1;
                }
            }
            else
                hl.PointFinal = -1;
            return hl;
        }
        private void Cb_chonDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_nhapDiem.Enabled = true;
        }

        private void cellVisiable()
        {
            dgv_Diem.ReadOnly = false;
            dgv_Diem.Columns["id_HV"].ReadOnly = true;
            dgv_Diem.Columns["ten_HV"].ReadOnly = true;
            dgv_Diem.Columns["danhgia"].ReadOnly = true;
            dgv_Diem.Columns["xeploai"].ReadOnly = true;
            dgv_Diem.Columns["xet_tot_nghiep"].ReadOnly = true;
            dgv_Diem.Columns["ghichu_HVLH"].ReadOnly = true;
            dgv_Diem.Columns["dtb"].ReadOnly = true;

            string chonDiem = cb_chonDiem.Text;
            foreach (DataGridViewRow r in dgv_Diem.Rows)
            {
                if (chonDiem == "Điểm 1")
                {
                    try
                    {
                        double.Parse(r.Cells["diem_do_an"].Value.ToString());
                        r.Cells["diem_1"].ReadOnly = true;
                        r.Cells["diem_2"].ReadOnly = true;
                        r.Cells["diem_do_an"].ReadOnly = true;
                    }
                    catch (Exception e)
                    {
                        r.Cells["diem_1"].ReadOnly = false;
                        r.Cells["diem_2"].ReadOnly = true;
                        r.Cells["diem_do_an"].ReadOnly = true;
                    }
                }
                        
                else if(chonDiem == "Điểm 2")
                {
                    try
                    {
                        double.Parse(r.Cells["diem_do_an"].Value.ToString());
                        r.Cells["diem_1"].ReadOnly = true;
                        r.Cells["diem_2"].ReadOnly = true;
                        r.Cells["diem_do_an"].ReadOnly = true;
                    }
                    catch (Exception e)
                    {
                        r.Cells["diem_1"].ReadOnly = true;
                        r.Cells["diem_2"].ReadOnly = false;
                        r.Cells["diem_do_an"].ReadOnly = true;
                    }
                    
                }
                else if(chonDiem == "Điểm đồ án")
                {
                    if (r.Cells["danhgia"].Value.ToString() == "Đạt")
                    {
                        r.Cells["diem_1"].ReadOnly = true;
                        r.Cells["diem_2"].ReadOnly = true;
                        r.Cells["diem_do_an"].ReadOnly = false;
                    }
                    else
                    {
                        r.Cells["diem_1"].ReadOnly = true;
                        r.Cells["diem_2"].ReadOnly = true;
                        r.Cells["diem_do_an"].ReadOnly = true;
                        r.Cells["diem_do_an"].Style.BackColor = Color.Gray;
                        r.Cells["diem_do_an"].Style.ForeColor = Color.Red;
                        r.Cells["diem_do_an"].Value = "Không thể nhập";
                    }
                }
                else
                {
                    dgv_Diem.Columns["diem_1"].ReadOnly = true;
                    dgv_Diem.Columns["diem_2"].ReadOnly = true;
                    dgv_Diem.Columns["diem_do_an"].ReadOnly = true;
                }
            }
        }

        private void ChangeCollumnColorActive()
        {
            string chonDiem = cb_chonDiem.Text;
            if (chonDiem == "Điểm 1")
            {
                dgv_Diem.Columns["diem_1"].DefaultCellStyle.BackColor = Color.Yellow;
                dgv_Diem.Columns["diem_2"].DefaultCellStyle.BackColor = Color.White;
                dgv_Diem.Columns["diem_do_an"].DefaultCellStyle.BackColor = Color.White;

            }
            else if(chonDiem == "Điểm 2")
            {
                dgv_Diem.Columns["diem_1"].DefaultCellStyle.BackColor = Color.White;
                dgv_Diem.Columns["diem_2"].DefaultCellStyle.BackColor = Color.Yellow;
                dgv_Diem.Columns["diem_do_an"].DefaultCellStyle.BackColor = Color.White;

            }
            else if(chonDiem == "Điểm đồ án")
            {
                dgv_Diem.Columns["diem_1"].DefaultCellStyle.BackColor = Color.White;
                dgv_Diem.Columns["diem_2"].DefaultCellStyle.BackColor = Color.White;
                dgv_Diem.Columns["diem_do_an"].DefaultCellStyle.BackColor = Color.Yellow;

            }
            else
            {
                dgv_Diem.Columns["diem_1"].DefaultCellStyle.BackColor = Color.White;
                dgv_Diem.Columns["diem_2"].DefaultCellStyle.BackColor = Color.White;
                dgv_Diem.Columns["diem_do_an"].DefaultCellStyle.BackColor = Color.White;

            }

        }

        private void Bt_Huy_Click(object sender, EventArgs e)
        {
            reloadControl();
            ChangeCollumnColorActive();
            hienThiGrid();
            cellVisiable();
        }

        private void reloadControl()
        {
            cb_chonDiem.Enabled = true;
            cb_chonDiem.SelectedIndex = -1;
            bt_Huy.Visible = false;
            bt_xacNhanDiem.Visible = false;
            bt_selectLop.Enabled = true;
            bt_nhapDiem.Enabled = false;
        }

        private void Bt_xacNhanDiem_Click(object sender, EventArgs e)
        {
            string point = cb_chonDiem.Text;
            int pointType = 0;
            if (point == "Điểm 1")
                pointType = 1;
            else if (point == "Điểm 2")
                pointType = 2;
            else if(point == "Điểm đồ án")
                pointType = 3;

            int i = 0;
            foreach(DataGridViewRow r in dgv_Diem.Rows)
            {
                HocVienLopHocDTO hl = getHVLHfromGridRowIndex(i);
                if (pointType == 1 && (r.Cells["diem_do_an"].Value.ToString() == "" || r.Cells["diem_do_an"].Value.ToString() == "------") || pointType == 2 && (r.Cells["diem_do_an"].Value.ToString() == "" || r.Cells["diem_do_an"].Value.ToString() == "------") || pointType == 3 && r.Cells["danhgia"].Value.ToString() == "Đạt")
                {                    
                    if (HocVienLopHocBLL.Instance.setPoint(hl, pointType))
                    {
                        if (pointType == 1 || pointType == 2)
                        {
                            if (r.Cells["diem_1"].Value != null && r.Cells["diem_2"].Value != null && r.Cells["diem_1"].Value.ToString() != "" && r.Cells["diem_2"].Value.ToString() != "")
                            {
                                setRate(hl);
                            } 
                            else if((r.Cells["diem_1"].Value == null || r.Cells["diem_2"].Value == null) && r.Cells["danhgia"].Value.ToString() != "Chưa đánh giá")
                            {
                                Console.WriteLine("d1d2 rong. rate khac chuadanhgia");
                                setRate(hl);
                            }
                        }
                        else if (pointType == 3)
                            setTotNghiepAndXepLoai(hl);
                    }
                }
                i++;
            }

            reloadControl();
            ChangeCollumnColorActive();
            hienThiGrid();
            cellVisiable();
            thongKe();
        }

        private bool setRate(HocVienLopHocDTO hl)
        {
            Console.WriteLine("trong ham rate: " + hl.Point1 + ";" + hl.Point2);
            bool rate = false;
            if (hl.Point1 >= 5 && hl.Point2 >= 5)
                rate = true;
            hl.Rate = rate;
            return HocVienLopHocBLL.Instance.setRate(hl);
        }

        private bool setTotNghiepAndXepLoai(HocVienLopHocDTO hl)
        {
            bool totNghiep = false;
            string xepLoai = "Không xếp loại";
            if (hl.PointFinal >= 5)
                totNghiep = true;

            if(totNghiep == true)
            {
                double diemTB = double.Parse(hl.getDTB());
                if (diemTB >= 5 && diemTB <= 7)
                    xepLoai = "Trung bình";
                else if (diemTB < 8.5)
                    xepLoai = "Khá";
                else
                    xepLoai = "Giỏi";
                
            }

            hl.Rank = xepLoai;
            hl.Graduating = totNghiep;

            return HocVienLopHocBLL.Instance.setGraduatAndRank(hl);
        }

        private void Dgv_Diem_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("key up");
        }

        private void Dgv_Diem_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        // Xu ly input nhap diem. 
        private void Dgv_Diem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tbx = e.Control as TextBox;
            bool notNumber = false;

            // Kiem tra phim nhap vao co phai la so
            tbx.KeyDown += (S, E) =>
            {
                if (E.KeyCode < Keys.D0 || E.KeyCode > Keys.D9)
                {
                    Console.WriteLine("Khac k0-9");
                    if (E.KeyCode < Keys.NumPad0 || E.KeyCode > Keys.NumPad9)
                    {
                        Console.WriteLine("khac n0-9");
                        if (E.KeyCode != Keys.Back && E.KeyCode != Keys.OemPeriod)
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
                //Neu khong la so. Khong nhap.
                if (notNumber)
                {
                    E.Handled = true;
                }
            };

            tbx.KeyUp += (S, E) =>
            {
                // Nếu điểm > 10 thì điểm = 10;
                try
                {
                    double diem = double.Parse(tbx.Text);
                    if (diem > 10)
                    {
                        tbx.Text = "10";
                        //Đặt con trỏ về cuối dòng text mỗi khi có thay đổi text
                        tbx.SelectionStart = tbx.Text.Length;
                        tbx.SelectionLength = 0;
                    }
                }
                catch { }
            };
        }
    }
}
