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
    public partial class MainForm : Form
    {
        AccountDTO accountGlobal = GlobalInfo.accountGlobal;
        TaiKhoanCuaToiBLL taiKhoanCuaToiBLL = new TaiKhoanCuaToiBLL();
        QuanLyLopHocBLL quanLyLopHocBLL = new QuanLyLopHocBLL();
        KhoaHocBLL khoaHocBLL = new KhoaHocBLL();
        PhongHocBLL phongHocBLL = new PhongHocBLL();
        GiangVienBLL giangVienBLL = new GiangVienBLL();
        QuanLyTaiKhoanBLL quanLyTaiKhoanBLL = new QuanLyTaiKhoanBLL();

        List<LopHocDTO> currentListLopHoc;
        List<AccountDTO> currentListAccount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl.Dock = DockStyle.Fill;
            tabControl.TabPages.Clear();

            if (accountGlobal != null)
            {
                switch (accountGlobal.level)
                {
                    // Admin
                    case 0:
                        loadTabQuanLyKhoaHoc();
                        loadTabQuanLyPhongHoc();
                        loadTabQuanLyGiangVien();
                        loadTabQuanLyHocVien();
                        loadTabQuanLyLopHoc();
                        loadTabQuanLyTaiKhoan();
                        break;
                    // Quản lý
                    case 1:
                        loadTabQuanLyKhoaHoc();
                        loadTabQuanLyPhongHoc();
                        loadTabQuanLyGiangVien();
                        loadTabQuanLyHocVien();
                        loadTabQuanLyLopHoc();
                        break;
                    // Giảng viên
                    case 2:
                        loadTabGuiDiemDanh();
                        loadTabQuanLyDiem();
                        break;
                    // Nhân viên thu ngân
                    case 3:
                        loadTabQuanLyHocPhi();
                        break;
                }
            }
            loadTabTaiKhoanCuaToi();
        }

        private void loadTabQuanLyHocVien()
        {
            TabPage tabQLHV = new TabPage();
            GUI_HocVien guiHV = new GUI_HocVien();
            guiHV.TopLevel = false;
            guiHV.FormBorderStyle = FormBorderStyle.None;
            guiHV.Visible = true;
            tabQLHV.Controls.Add(guiHV);
            guiHV.Dock = DockStyle.Fill;
            tabQLHV.Text = "Quản lý học viên";
            tabControl.TabPages.Add(tabQLHV);
        }

        private void loadTabQuanLyPhongHoc()
        {
            TabPage tabQLPH = new TabPage();
            PhongHocGUI phGui = new PhongHocGUI();
            phGui.TopLevel = false;
            phGui.FormBorderStyle = FormBorderStyle.None;
            phGui.Visible = true;
            tabQLPH.Controls.Add(phGui);
            phGui.Dock = DockStyle.Fill;
            tabQLPH.Text = "Quản lý phòng học";
            tabControl.TabPages.Add(tabQLPH);
        }

        private void loadTabQuanLyHocPhi()
        {
            TabPage tabQLHP = new TabPage();
            HocPhiGui hpGui = new HocPhiGui();
            hpGui.TopLevel = false;
            hpGui.FormBorderStyle = FormBorderStyle.None;
            hpGui.Visible = true;
            tabQLHP.Controls.Add(hpGui);
            hpGui.Dock = DockStyle.Fill;
            tabQLHP.Text = "Quản lý học phí";
            tabControl.TabPages.Add(tabQLHP);
        }

        private void loadTabQuanLyGiangVien()
        {
            TabPage tabQLGV = new TabPage();
            GiangVienGUI gvGui = new GiangVienGUI();
            gvGui.TopLevel = false;
            gvGui.FormBorderStyle = FormBorderStyle.None;
            gvGui.Visible = true;
            tabQLGV.Controls.Add(gvGui);
            gvGui.Dock = DockStyle.Fill;
            tabQLGV.Text = "Quản lý giảng viên";
            tabControl.TabPages.Add(tabQLGV);
        }

        private void loadTabQuanLyDiem()
        {
            TabPage tabQLDiem = new TabPage();
            DiemGUI diemGui = new DiemGUI();
            diemGui.TopLevel = false;
            diemGui.FormBorderStyle = FormBorderStyle.None;
            diemGui.Visible = true;
            tabQLDiem.Controls.Add(diemGui);
            diemGui.Dock = DockStyle.Fill;
            tabQLDiem.Text = "Quản lý điểm";
            tabControl.TabPages.Add(tabQLDiem);
        }

        private void loadTabQuanLyKhoaHoc()
        {
            TabPage tabQLKhoaHoc = new TabPage();
            GUI_KhoaHoc guiKH = new GUI_KhoaHoc();
            guiKH.TopLevel = false;
            guiKH.FormBorderStyle = FormBorderStyle.None;
            guiKH.Visible = true;
            tabQLKhoaHoc.Controls.Add(guiKH);
            guiKH.Dock = DockStyle.Fill;
            tabQLKhoaHoc.Text = "Quản lý khoá học";
            tabControl.TabPages.Add(tabQLKhoaHoc);
        }

        private void loadTabGuiDiemDanh()
        {
            TabPage diemDanh = new TabPage();
            GUI_DiemDanh dd = new GUI_DiemDanh();
            dd.TopLevel = false;
            dd.FormBorderStyle = FormBorderStyle.None;
            dd.Visible = true;
            diemDanh.Controls.Add(dd);
            dd.Dock = DockStyle.Fill;
            diemDanh.Text = "Điểm danh";
            tabControl.TabPages.Add(diemDanh);
        }

        /// <summary>
        /// Quản lý tài khoản cá nhân
        /// </summary>

        private void loadTabTaiKhoanCuaToi()
        {
            TabPage tabPage = new TabPage();
            string tabName = "Tài khoản của tôi";
            GUI_TaiKhoanCuaToi gui = new GUI_TaiKhoanCuaToi();

            gui.TopLevel = false;
            gui.FormBorderStyle = FormBorderStyle.None;
            gui.Visible = true;
            tabPage.Controls.Add(gui);
            gui.Dock = DockStyle.Fill;
            tabPage.Text = tabName;
            tabControl.TabPages.Add(tabPage);

        }
        

        /// <summary>
        /// Quản lý lớp học
        /// </summary>
        private void loadTabQuanLyLopHoc()
        {

            TabPage tabPage = new TabPage();
            string tabName = "Quản lý Lớp học";
            Gui_QuanLyLopHoc gui = new Gui_QuanLyLopHoc();

            gui.TopLevel = false;
            gui.FormBorderStyle = FormBorderStyle.None;
            gui.Visible = true;
            tabPage.Controls.Add(gui);
            gui.Dock = DockStyle.Fill;
            tabPage.Text = tabName;
            tabControl.TabPages.Add(tabPage);
        }
        

        /// <summary>
        /// Quản lý tài khoản
        /// </summary>
        private void loadTabQuanLyTaiKhoan()
        {
            TabPage tabPage = new TabPage();
            string tabName = "Quản lý tài khoản";
            Gui_QuanLyTaiKhoan gui = new Gui_QuanLyTaiKhoan();

            gui.TopLevel = false;
            gui.FormBorderStyle = FormBorderStyle.None;
            gui.Visible = true;
            tabPage.Controls.Add(gui);
            gui.Dock = DockStyle.Fill;
            tabPage.Text = tabName;
            tabControl.TabPages.Add(tabPage);

        }


        public void hienThongBaoLoi(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult hienThongBao(string message)
        {
            return MessageBox.Show(message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

    }
}
