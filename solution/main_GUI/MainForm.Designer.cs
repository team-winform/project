namespace main_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageTaiKhoanCuaToi = new System.Windows.Forms.TabPage();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMatKhauMoi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoiThongTinCaNhan = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lbTaiKhoanCuaToi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabQuanLyLopHoc = new System.Windows.Forms.TabPage();
            this.txtTrangLopHoc = new System.Windows.Forms.TextBox();
            this.btTrangSauLopHoc = new System.Windows.Forms.Button();
            this.btTrangTruocLopHoc = new System.Windows.Forms.Button();
            this.grdLopHoc = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtChonGiangVien = new System.Windows.Forms.TextBox();
            this.txtTenLopHoc = new System.Windows.Forms.TextBox();
            this.btReloadLopHoc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSiSo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datePickerNgayKetThucHoc = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.datePickerNgayBatDauHoc = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.cbPhongHoc = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btXoaLopHoc = new System.Windows.Forms.Button();
            this.btThemLopHoc = new System.Windows.Forms.Button();
            this.btSuaLopHoc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btTimKiemLop = new System.Windows.Forms.Button();
            this.cbTieuChiTimKiemLop = new System.Windows.Forms.ComboBox();
            this.txtTimKiemLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.id_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGianVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageTaiKhoanCuaToi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabQuanLyLopHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLopHoc)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageTaiKhoanCuaToi
            // 
            this.tabPageTaiKhoanCuaToi.Controls.Add(this.btnDangXuat);
            this.tabPageTaiKhoanCuaToi.Controls.Add(this.groupBox2);
            this.tabPageTaiKhoanCuaToi.Controls.Add(this.groupBox1);
            this.tabPageTaiKhoanCuaToi.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaiKhoanCuaToi.Name = "tabPageTaiKhoanCuaToi";
            this.tabPageTaiKhoanCuaToi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaiKhoanCuaToi.Size = new System.Drawing.Size(855, 498);
            this.tabPageTaiKhoanCuaToi.TabIndex = 1;
            this.tabPageTaiKhoanCuaToi.Text = "Tài khoản của tôi";
            this.tabPageTaiKhoanCuaToi.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Red;
            this.btnDangXuat.Location = new System.Drawing.Point(684, 383);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(98, 32);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMatKhauMoi2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDoiMatKhau);
            this.groupBox2.Controls.Add(this.txtMatKhauCu);
            this.groupBox2.Controls.Add(this.txtMatKhauMoi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(126, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 183);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đổi mật khẩu";
            // 
            // txtMatKhauMoi2
            // 
            this.txtMatKhauMoi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi2.Location = new System.Drawing.Point(219, 96);
            this.txtMatKhauMoi2.Name = "txtMatKhauMoi2";
            this.txtMatKhauMoi2.Size = new System.Drawing.Size(157, 22);
            this.txtMatKhauMoi2.TabIndex = 9;
            this.txtMatKhauMoi2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(204, 135);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(107, 32);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(219, 21);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(157, 22);
            this.txtMatKhauCu.TabIndex = 5;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(219, 61);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(157, 22);
            this.txtMatKhauMoi.TabIndex = 6;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu cũ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mật khẩu mới";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoiThongTinCaNhan);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.lbTaiKhoanCuaToi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(126, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // btnDoiThongTinCaNhan
            // 
            this.btnDoiThongTinCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiThongTinCaNhan.Location = new System.Drawing.Point(204, 149);
            this.btnDoiThongTinCaNhan.Name = "btnDoiThongTinCaNhan";
            this.btnDoiThongTinCaNhan.Size = new System.Drawing.Size(107, 32);
            this.btnDoiThongTinCaNhan.TabIndex = 7;
            this.btnDoiThongTinCaNhan.Text = "Lưu thay đổi";
            this.btnDoiThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnDoiThongTinCaNhan.Click += new System.EventHandler(this.btnDoiThongTinCaNhan_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(219, 64);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(157, 22);
            this.txtHoTen.TabIndex = 5;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(219, 104);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(157, 22);
            this.txtSoDienThoai.TabIndex = 6;
            // 
            // lbTaiKhoanCuaToi
            // 
            this.lbTaiKhoanCuaToi.AutoSize = true;
            this.lbTaiKhoanCuaToi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiKhoanCuaToi.Location = new System.Drawing.Point(216, 26);
            this.lbTaiKhoanCuaToi.Name = "lbTaiKhoanCuaToi";
            this.lbTaiKhoanCuaToi.Size = new System.Drawing.Size(121, 16);
            this.lbTaiKhoanCuaToi.TabIndex = 4;
            this.lbTaiKhoanCuaToi.Text = "lbTaiKhoanCuaToi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // tabQuanLyLopHoc
            // 
            this.tabQuanLyLopHoc.Controls.Add(this.txtTrangLopHoc);
            this.tabQuanLyLopHoc.Controls.Add(this.btTrangSauLopHoc);
            this.tabQuanLyLopHoc.Controls.Add(this.btTrangTruocLopHoc);
            this.tabQuanLyLopHoc.Controls.Add(this.grdLopHoc);
            this.tabQuanLyLopHoc.Controls.Add(this.groupBox4);
            this.tabQuanLyLopHoc.Controls.Add(this.groupBox3);
            this.tabQuanLyLopHoc.Controls.Add(this.label5);
            this.tabQuanLyLopHoc.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyLopHoc.Name = "tabQuanLyLopHoc";
            this.tabQuanLyLopHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyLopHoc.Size = new System.Drawing.Size(855, 498);
            this.tabQuanLyLopHoc.TabIndex = 0;
            this.tabQuanLyLopHoc.Text = "Quản lý lớp học";
            this.tabQuanLyLopHoc.UseVisualStyleBackColor = true;
            // 
            // txtTrangLopHoc
            // 
            this.txtTrangLopHoc.Location = new System.Drawing.Point(711, 229);
            this.txtTrangLopHoc.Name = "txtTrangLopHoc";
            this.txtTrangLopHoc.Size = new System.Drawing.Size(75, 20);
            this.txtTrangLopHoc.TabIndex = 30;
            this.txtTrangLopHoc.Text = "1";
            this.txtTrangLopHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTrangLopHoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrangLopHoc_KeyDown);
            this.txtTrangLopHoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrangLopHoc_KeyPress);
            // 
            // btTrangSauLopHoc
            // 
            this.btTrangSauLopHoc.Location = new System.Drawing.Point(792, 227);
            this.btTrangSauLopHoc.Name = "btTrangSauLopHoc";
            this.btTrangSauLopHoc.Size = new System.Drawing.Size(48, 23);
            this.btTrangSauLopHoc.TabIndex = 29;
            this.btTrangSauLopHoc.Text = ">>";
            this.btTrangSauLopHoc.UseVisualStyleBackColor = true;
            this.btTrangSauLopHoc.Click += new System.EventHandler(this.btTrangSauLopHoc_Click);
            // 
            // btTrangTruocLopHoc
            // 
            this.btTrangTruocLopHoc.Location = new System.Drawing.Point(651, 227);
            this.btTrangTruocLopHoc.Name = "btTrangTruocLopHoc";
            this.btTrangTruocLopHoc.Size = new System.Drawing.Size(44, 23);
            this.btTrangTruocLopHoc.TabIndex = 28;
            this.btTrangTruocLopHoc.Text = "<<";
            this.btTrangTruocLopHoc.UseVisualStyleBackColor = true;
            this.btTrangTruocLopHoc.Click += new System.EventHandler(this.btTrangTruocLopHoc_Click);
            // 
            // grdLopHoc
            // 
            this.grdLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_LH,
            this.tenKhoaHoc,
            this.tenGianVien,
            this.tenPhongHoc,
            this.ngaybatdau,
            this.ngayketthuc,
            this.siso,
            this.ghichu});
            this.grdLopHoc.Location = new System.Drawing.Point(18, 256);
            this.grdLopHoc.Name = "grdLopHoc";
            this.grdLopHoc.Size = new System.Drawing.Size(822, 236);
            this.grdLopHoc.TabIndex = 27;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtChonGiangVien);
            this.groupBox4.Controls.Add(this.txtTenLopHoc);
            this.groupBox4.Controls.Add(this.btReloadLopHoc);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lbSiSo);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.datePickerNgayKetThucHoc);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.datePickerNgayBatDauHoc);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.cbPhongHoc);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.cbKhoaHoc);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btXoaLopHoc);
            this.groupBox4.Controls.Add(this.btThemLopHoc);
            this.groupBox4.Controls.Add(this.btSuaLopHoc);
            this.groupBox4.Location = new System.Drawing.Point(18, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(616, 215);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quản lý";
            // 
            // txtChonGiangVien
            // 
            this.txtChonGiangVien.Location = new System.Drawing.Point(443, 35);
            this.txtChonGiangVien.Name = "txtChonGiangVien";
            this.txtChonGiangVien.Size = new System.Drawing.Size(133, 20);
            this.txtChonGiangVien.TabIndex = 27;
            // 
            // txtTenLopHoc
            // 
            this.txtTenLopHoc.Location = new System.Drawing.Point(148, 70);
            this.txtTenLopHoc.Name = "txtTenLopHoc";
            this.txtTenLopHoc.Size = new System.Drawing.Size(121, 20);
            this.txtTenLopHoc.TabIndex = 17;
            // 
            // btReloadLopHoc
            // 
            this.btReloadLopHoc.Location = new System.Drawing.Point(72, 177);
            this.btReloadLopHoc.Name = "btReloadLopHoc";
            this.btReloadLopHoc.Size = new System.Drawing.Size(75, 23);
            this.btReloadLopHoc.TabIndex = 25;
            this.btReloadLopHoc.Text = "Load lại";
            this.btReloadLopHoc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(55, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên lớp";
            // 
            // lbSiSo
            // 
            this.lbSiSo.AutoSize = true;
            this.lbSiSo.Location = new System.Drawing.Point(440, 133);
            this.lbSiSo.Name = "lbSiSo";
            this.lbSiSo.Size = new System.Drawing.Size(37, 13);
            this.lbSiSo.TabIndex = 23;
            this.lbSiSo.Text = "lbSiSo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Khoá học";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // datePickerNgayKetThucHoc
            // 
            this.datePickerNgayKetThucHoc.Location = new System.Drawing.Point(443, 99);
            this.datePickerNgayKetThucHoc.Name = "datePickerNgayKetThucHoc";
            this.datePickerNgayKetThucHoc.Size = new System.Drawing.Size(133, 20);
            this.datePickerNgayKetThucHoc.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "lbMaLop";
            // 
            // datePickerNgayBatDauHoc
            // 
            this.datePickerNgayBatDauHoc.Location = new System.Drawing.Point(443, 67);
            this.datePickerNgayBatDauHoc.Name = "datePickerNgayBatDauHoc";
            this.datePickerNgayBatDauHoc.Size = new System.Drawing.Size(133, 20);
            this.datePickerNgayBatDauHoc.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(356, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Ngày bắt đầu";
            // 
            // cbPhongHoc
            // 
            this.cbPhongHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongHoc.FormattingEnabled = true;
            this.cbPhongHoc.Location = new System.Drawing.Point(148, 133);
            this.cbPhongHoc.Name = "cbPhongHoc";
            this.cbPhongHoc.Size = new System.Drawing.Size(121, 21);
            this.cbPhongHoc.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(356, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Ngày kết thúc";
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(148, 102);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(121, 21);
            this.cbKhoaHoc.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(356, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Sĩ số";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Phòng học";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Giảng viên";
            // 
            // btXoaLopHoc
            // 
            this.btXoaLopHoc.Location = new System.Drawing.Point(459, 177);
            this.btXoaLopHoc.Name = "btXoaLopHoc";
            this.btXoaLopHoc.Size = new System.Drawing.Size(75, 23);
            this.btXoaLopHoc.TabIndex = 16;
            this.btXoaLopHoc.Text = "Xoá";
            this.btXoaLopHoc.UseVisualStyleBackColor = true;
            // 
            // btThemLopHoc
            // 
            this.btThemLopHoc.Location = new System.Drawing.Point(201, 177);
            this.btThemLopHoc.Name = "btThemLopHoc";
            this.btThemLopHoc.Size = new System.Drawing.Size(75, 23);
            this.btThemLopHoc.TabIndex = 14;
            this.btThemLopHoc.Text = "Thêm";
            this.btThemLopHoc.UseVisualStyleBackColor = true;
            // 
            // btSuaLopHoc
            // 
            this.btSuaLopHoc.Location = new System.Drawing.Point(330, 177);
            this.btSuaLopHoc.Name = "btSuaLopHoc";
            this.btSuaLopHoc.Size = new System.Drawing.Size(75, 23);
            this.btSuaLopHoc.TabIndex = 15;
            this.btSuaLopHoc.Text = "Sửa";
            this.btSuaLopHoc.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btTimKiemLop);
            this.groupBox3.Controls.Add(this.cbTieuChiTimKiemLop);
            this.groupBox3.Controls.Add(this.txtTimKiemLop);
            this.groupBox3.Location = new System.Drawing.Point(651, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 148);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btTimKiemLop
            // 
            this.btTimKiemLop.Location = new System.Drawing.Point(60, 108);
            this.btTimKiemLop.Name = "btTimKiemLop";
            this.btTimKiemLop.Size = new System.Drawing.Size(75, 23);
            this.btTimKiemLop.TabIndex = 2;
            this.btTimKiemLop.Text = "Tìm kiếm";
            this.btTimKiemLop.UseVisualStyleBackColor = true;
            this.btTimKiemLop.Click += new System.EventHandler(this.btTimKiemLop_Click);
            // 
            // cbTieuChiTimKiemLop
            // 
            this.cbTieuChiTimKiemLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTieuChiTimKiemLop.FormattingEnabled = true;
            this.cbTieuChiTimKiemLop.Items.AddRange(new object[] {
            "Theo mã lớp",
            "Theo tên lớp"});
            this.cbTieuChiTimKiemLop.Location = new System.Drawing.Point(37, 68);
            this.cbTieuChiTimKiemLop.Name = "cbTieuChiTimKiemLop";
            this.cbTieuChiTimKiemLop.Size = new System.Drawing.Size(121, 21);
            this.cbTieuChiTimKiemLop.TabIndex = 1;
            // 
            // txtTimKiemLop
            // 
            this.txtTimKiemLop.Location = new System.Drawing.Point(37, 33);
            this.txtTimKiemLop.Name = "txtTimKiemLop";
            this.txtTimKiemLop.Size = new System.Drawing.Size(121, 20);
            this.txtTimKiemLop.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabQuanLyLopHoc);
            this.tabControl.Controls.Add(this.tabPageTaiKhoanCuaToi);
            this.tabControl.Location = new System.Drawing.Point(12, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(863, 524);
            this.tabControl.TabIndex = 0;
            // 
            // id_LH
            // 
            this.id_LH.HeaderText = "Mã lớp";
            this.id_LH.Name = "id_LH";
            // 
            // tenKhoaHoc
            // 
            this.tenKhoaHoc.HeaderText = "Khoá học";
            this.tenKhoaHoc.Name = "tenKhoaHoc";
            // 
            // tenGianVien
            // 
            this.tenGianVien.HeaderText = "Giảng viên";
            this.tenGianVien.Name = "tenGianVien";
            // 
            // tenPhongHoc
            // 
            this.tenPhongHoc.HeaderText = "Phòng Học";
            this.tenPhongHoc.Name = "tenPhongHoc";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.Name = "ngaybatdau";
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.Name = "ngayketthuc";
            // 
            // siso
            // 
            this.siso.HeaderText = "Sĩ số";
            this.siso.Name = "siso";
            this.siso.Width = 60;
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 537);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trung tâm lập trình  69";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageTaiKhoanCuaToi.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabQuanLyLopHoc.ResumeLayout(false);
            this.tabQuanLyLopHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLopHoc)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageTaiKhoanCuaToi;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMatKhauMoi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoiThongTinCaNhan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lbTaiKhoanCuaToi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabQuanLyLopHoc;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbSiSo;
        private System.Windows.Forms.DateTimePicker datePickerNgayKetThucHoc;
        private System.Windows.Forms.DateTimePicker datePickerNgayBatDauHoc;
        private System.Windows.Forms.ComboBox cbPhongHoc;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.TextBox txtTenLopHoc;
        private System.Windows.Forms.Button btXoaLopHoc;
        private System.Windows.Forms.Button btSuaLopHoc;
        private System.Windows.Forms.Button btThemLopHoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btReloadLopHoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btTimKiemLop;
        private System.Windows.Forms.ComboBox cbTieuChiTimKiemLop;
        private System.Windows.Forms.TextBox txtTimKiemLop;
        private System.Windows.Forms.DataGridView grdLopHoc;
        private System.Windows.Forms.TextBox txtChonGiangVien;
        private System.Windows.Forms.Button btTrangTruocLopHoc;
        private System.Windows.Forms.TextBox txtTrangLopHoc;
        private System.Windows.Forms.Button btTrangSauLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGianVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}

