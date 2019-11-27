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
                        loadTabQuanLyLopHoc();
                        loadTabQuanLyTaiKhoan();
                        break;
                    // Quản lý
                    case 1:
                        loadTabQuanLyKhoaHoc();
                        loadTabQuanLyLopHoc();
                        break;
                    // Giảng viên
                    case 2:
                        loadTabGuiDiemDanh();
                        break;
                    // Nhân viên
                    case 3:
                        break;
                }
            }
            loadTabTaiKhoanCuaToi();
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
