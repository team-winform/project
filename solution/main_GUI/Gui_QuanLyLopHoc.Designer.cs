namespace main_GUI
{
    partial class Gui_QuanLyLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTrangLopHoc = new System.Windows.Forms.TextBox();
            this.btTrangSauLopHoc = new System.Windows.Forms.Button();
            this.btTrangTruocLopHoc = new System.Windows.Forms.Button();
            this.grdLopHoc = new System.Windows.Forms.DataGridView();
            this.id_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGianVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbGiangVien = new System.Windows.Forms.ComboBox();
            this.txtTenLopHoc = new System.Windows.Forms.TextBox();
            this.btReloadLopHoc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSiSo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datePickerNgayKetThucHoc = new System.Windows.Forms.DateTimePicker();
            this.lbMaLop = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdLopHoc)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTrangLopHoc
            // 
            this.txtTrangLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangLopHoc.Location = new System.Drawing.Point(717, 221);
            this.txtTrangLopHoc.Name = "txtTrangLopHoc";
            this.txtTrangLopHoc.Size = new System.Drawing.Size(75, 22);
            this.txtTrangLopHoc.TabIndex = 37;
            this.txtTrangLopHoc.Text = "1";
            this.txtTrangLopHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTrangLopHoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrangLopHoc_KeyDown);
            this.txtTrangLopHoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrangLopHoc_KeyPress);
            // 
            // btTrangSauLopHoc
            // 
            this.btTrangSauLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrangSauLopHoc.Location = new System.Drawing.Point(798, 219);
            this.btTrangSauLopHoc.Name = "btTrangSauLopHoc";
            this.btTrangSauLopHoc.Size = new System.Drawing.Size(48, 23);
            this.btTrangSauLopHoc.TabIndex = 36;
            this.btTrangSauLopHoc.Text = ">>";
            this.btTrangSauLopHoc.UseVisualStyleBackColor = true;
            this.btTrangSauLopHoc.Click += new System.EventHandler(this.btTrangSauLopHoc_Click);
            // 
            // btTrangTruocLopHoc
            // 
            this.btTrangTruocLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrangTruocLopHoc.Location = new System.Drawing.Point(657, 219);
            this.btTrangTruocLopHoc.Name = "btTrangTruocLopHoc";
            this.btTrangTruocLopHoc.Size = new System.Drawing.Size(44, 23);
            this.btTrangTruocLopHoc.TabIndex = 35;
            this.btTrangTruocLopHoc.Text = "<<";
            this.btTrangTruocLopHoc.UseVisualStyleBackColor = true;
            this.btTrangTruocLopHoc.Click += new System.EventHandler(this.btTrangTruocLopHoc_Click);
            // 
            // grdLopHoc
            // 
            this.grdLopHoc.AllowUserToAddRows = false;
            this.grdLopHoc.AllowUserToDeleteRows = false;
            this.grdLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_LH,
            this.tenLop,
            this.tenKhoaHoc,
            this.tenGianVien,
            this.tenPhongHoc,
            this.ngaybatdau,
            this.ngayketthuc,
            this.siso});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLopHoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdLopHoc.Location = new System.Drawing.Point(24, 263);
            this.grdLopHoc.Name = "grdLopHoc";
            this.grdLopHoc.ReadOnly = true;
            this.grdLopHoc.Size = new System.Drawing.Size(822, 236);
            this.grdLopHoc.TabIndex = 34;
            this.grdLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLopHoc_CellClick);
            this.grdLopHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLopHoc_CellDoubleClick);
            // 
            // id_LH
            // 
            this.id_LH.HeaderText = "Mã lớp";
            this.id_LH.Name = "id_LH";
            this.id_LH.ReadOnly = true;
            this.id_LH.Width = 70;
            // 
            // tenLop
            // 
            this.tenLop.HeaderText = "Tên lớp";
            this.tenLop.Name = "tenLop";
            this.tenLop.ReadOnly = true;
            this.tenLop.Width = 150;
            // 
            // tenKhoaHoc
            // 
            this.tenKhoaHoc.HeaderText = "Khoá học";
            this.tenKhoaHoc.Name = "tenKhoaHoc";
            this.tenKhoaHoc.ReadOnly = true;
            this.tenKhoaHoc.Width = 90;
            // 
            // tenGianVien
            // 
            this.tenGianVien.HeaderText = "Giảng viên";
            this.tenGianVien.Name = "tenGianVien";
            this.tenGianVien.ReadOnly = true;
            this.tenGianVien.Width = 120;
            // 
            // tenPhongHoc
            // 
            this.tenPhongHoc.HeaderText = "Phòng Học";
            this.tenPhongHoc.Name = "tenPhongHoc";
            this.tenPhongHoc.ReadOnly = true;
            this.tenPhongHoc.Width = 90;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.ReadOnly = true;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.ReadOnly = true;
            // 
            // siso
            // 
            this.siso.HeaderText = "Sĩ số";
            this.siso.Name = "siso";
            this.siso.ReadOnly = true;
            this.siso.Width = 60;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbGiangVien);
            this.groupBox4.Controls.Add(this.txtTenLopHoc);
            this.groupBox4.Controls.Add(this.btReloadLopHoc);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lbSiSo);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.datePickerNgayKetThucHoc);
            this.groupBox4.Controls.Add(this.lbMaLop);
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
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(616, 215);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            // 
            // cbGiangVien
            // 
            this.cbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGiangVien.FormattingEnabled = true;
            this.cbGiangVien.Location = new System.Drawing.Point(443, 35);
            this.cbGiangVien.Name = "cbGiangVien";
            this.cbGiangVien.Size = new System.Drawing.Size(145, 24);
            this.cbGiangVien.TabIndex = 26;
            // 
            // txtTenLopHoc
            // 
            this.txtTenLopHoc.Location = new System.Drawing.Point(137, 70);
            this.txtTenLopHoc.Name = "txtTenLopHoc";
            this.txtTenLopHoc.Size = new System.Drawing.Size(157, 22);
            this.txtTenLopHoc.TabIndex = 17;
            // 
            // btReloadLopHoc
            // 
            this.btReloadLopHoc.Location = new System.Drawing.Point(6, 175);
            this.btReloadLopHoc.Name = "btReloadLopHoc";
            this.btReloadLopHoc.Size = new System.Drawing.Size(66, 28);
            this.btReloadLopHoc.TabIndex = 25;
            this.btReloadLopHoc.Text = "Load lại";
            this.btReloadLopHoc.UseVisualStyleBackColor = true;
            this.btReloadLopHoc.Click += new System.EventHandler(this.btReloadLopHoc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên lớp";
            // 
            // lbSiSo
            // 
            this.lbSiSo.AutoSize = true;
            this.lbSiSo.Location = new System.Drawing.Point(440, 133);
            this.lbSiSo.Name = "lbSiSo";
            this.lbSiSo.Size = new System.Drawing.Size(48, 16);
            this.lbSiSo.TabIndex = 23;
            this.lbSiSo.Text = "lbSiSo";
            this.lbSiSo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Khoá học";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // datePickerNgayKetThucHoc
            // 
            this.datePickerNgayKetThucHoc.Location = new System.Drawing.Point(443, 99);
            this.datePickerNgayKetThucHoc.Name = "datePickerNgayKetThucHoc";
            this.datePickerNgayKetThucHoc.Size = new System.Drawing.Size(145, 22);
            this.datePickerNgayKetThucHoc.TabIndex = 22;
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(134, 38);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(61, 16);
            this.lbMaLop.TabIndex = 5;
            this.lbMaLop.Text = "lbMaLop";
            this.lbMaLop.Visible = false;
            // 
            // datePickerNgayBatDauHoc
            // 
            this.datePickerNgayBatDauHoc.Location = new System.Drawing.Point(443, 67);
            this.datePickerNgayBatDauHoc.Name = "datePickerNgayBatDauHoc";
            this.datePickerNgayBatDauHoc.Size = new System.Drawing.Size(145, 22);
            this.datePickerNgayBatDauHoc.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(343, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "Ngày bắt đầu";
            // 
            // cbPhongHoc
            // 
            this.cbPhongHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongHoc.FormattingEnabled = true;
            this.cbPhongHoc.Location = new System.Drawing.Point(137, 133);
            this.cbPhongHoc.Name = "cbPhongHoc";
            this.cbPhongHoc.Size = new System.Drawing.Size(157, 24);
            this.cbPhongHoc.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(343, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Ngày kết thúc";
            // 
            // cbKhoaHoc
            // 
            this.cbKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaHoc.FormattingEnabled = true;
            this.cbKhoaHoc.Location = new System.Drawing.Point(137, 102);
            this.cbKhoaHoc.Name = "cbKhoaHoc";
            this.cbKhoaHoc.Size = new System.Drawing.Size(157, 24);
            this.cbKhoaHoc.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(343, 133);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "Sĩ số";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "Phòng học";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(343, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Giảng viên";
            // 
            // btXoaLopHoc
            // 
            this.btXoaLopHoc.Location = new System.Drawing.Point(437, 175);
            this.btXoaLopHoc.Name = "btXoaLopHoc";
            this.btXoaLopHoc.Size = new System.Drawing.Size(75, 28);
            this.btXoaLopHoc.TabIndex = 16;
            this.btXoaLopHoc.Text = "Xoá";
            this.btXoaLopHoc.UseVisualStyleBackColor = true;
            this.btXoaLopHoc.Click += new System.EventHandler(this.btXoaLopHoc_Click);
            // 
            // btThemLopHoc
            // 
            this.btThemLopHoc.Location = new System.Drawing.Point(179, 175);
            this.btThemLopHoc.Name = "btThemLopHoc";
            this.btThemLopHoc.Size = new System.Drawing.Size(75, 28);
            this.btThemLopHoc.TabIndex = 14;
            this.btThemLopHoc.Text = "Thêm";
            this.btThemLopHoc.UseVisualStyleBackColor = true;
            this.btThemLopHoc.Click += new System.EventHandler(this.btThemLopHoc_Click);
            // 
            // btSuaLopHoc
            // 
            this.btSuaLopHoc.Location = new System.Drawing.Point(308, 175);
            this.btSuaLopHoc.Name = "btSuaLopHoc";
            this.btSuaLopHoc.Size = new System.Drawing.Size(75, 28);
            this.btSuaLopHoc.TabIndex = 15;
            this.btSuaLopHoc.Text = "Sửa";
            this.btSuaLopHoc.UseVisualStyleBackColor = true;
            this.btSuaLopHoc.Click += new System.EventHandler(this.btSuaLopHoc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btTimKiemLop);
            this.groupBox3.Controls.Add(this.cbTieuChiTimKiemLop);
            this.groupBox3.Controls.Add(this.txtTimKiemLop);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(657, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 148);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btTimKiemLop
            // 
            this.btTimKiemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiemLop.Location = new System.Drawing.Point(60, 102);
            this.btTimKiemLop.Name = "btTimKiemLop";
            this.btTimKiemLop.Size = new System.Drawing.Size(75, 30);
            this.btTimKiemLop.TabIndex = 2;
            this.btTimKiemLop.Text = "Tìm kiếm";
            this.btTimKiemLop.UseVisualStyleBackColor = true;
            this.btTimKiemLop.Click += new System.EventHandler(this.btTimKiemLop_Click);
            // 
            // cbTieuChiTimKiemLop
            // 
            this.cbTieuChiTimKiemLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTieuChiTimKiemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTieuChiTimKiemLop.FormattingEnabled = true;
            this.cbTieuChiTimKiemLop.Items.AddRange(new object[] {
            "Theo mã lớp",
            "Theo tên lớp"});
            this.cbTieuChiTimKiemLop.Location = new System.Drawing.Point(37, 68);
            this.cbTieuChiTimKiemLop.Name = "cbTieuChiTimKiemLop";
            this.cbTieuChiTimKiemLop.Size = new System.Drawing.Size(121, 24);
            this.cbTieuChiTimKiemLop.TabIndex = 1;
            // 
            // txtTimKiemLop
            // 
            this.txtTimKiemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemLop.Location = new System.Drawing.Point(37, 33);
            this.txtTimKiemLop.Name = "txtTimKiemLop";
            this.txtTimKiemLop.Size = new System.Drawing.Size(121, 22);
            this.txtTimKiemLop.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // Gui_QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 514);
            this.Controls.Add(this.txtTrangLopHoc);
            this.Controls.Add(this.btTrangSauLopHoc);
            this.Controls.Add(this.btTrangTruocLopHoc);
            this.Controls.Add(this.grdLopHoc);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Name = "Gui_QuanLyLopHoc";
            this.Text = "Gui_QuanLyLopHoc";
            this.Load += new System.EventHandler(this.Gui_QuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLopHoc)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrangLopHoc;
        private System.Windows.Forms.Button btTrangSauLopHoc;
        private System.Windows.Forms.Button btTrangTruocLopHoc;
        private System.Windows.Forms.DataGridView grdLopHoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbGiangVien;
        private System.Windows.Forms.TextBox txtTenLopHoc;
        private System.Windows.Forms.Button btReloadLopHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSiSo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datePickerNgayKetThucHoc;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.DateTimePicker datePickerNgayBatDauHoc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbPhongHoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbKhoaHoc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btXoaLopHoc;
        private System.Windows.Forms.Button btThemLopHoc;
        private System.Windows.Forms.Button btSuaLopHoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btTimKiemLop;
        private System.Windows.Forms.ComboBox cbTieuChiTimKiemLop;
        private System.Windows.Forms.TextBox txtTimKiemLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGianVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
    }
}