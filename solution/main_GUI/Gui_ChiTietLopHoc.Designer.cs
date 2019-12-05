namespace main_GUI
{
    partial class Gui_ChiTietLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbSiSo = new System.Windows.Forms.Label();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTenHocVien = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMaHocVien = new System.Windows.Forms.Label();
            this.btExportPDF = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.grdTimKiem = new System.Windows.Forms.DataGridView();
            this.id_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.grdDssv = new System.Windows.Forms.DataGridView();
            this.maHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_do_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xet_tot_nghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_dtb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDssv)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 701);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btExportPDF);
            this.tabPage1.Controls.Add(this.btReload);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grdDssv);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1159, 672);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý học viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbMaLop);
            this.groupBox3.Controls.Add(this.lbSiSo);
            this.groupBox3.Controls.Add(this.lbTenLop);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(339, 242);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp học";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(8, 92);
            this.lbMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(72, 20);
            this.lbMaLop.TabIndex = 8;
            this.lbMaLop.Text = "lbMã lớp";
            // 
            // lbSiSo
            // 
            this.lbSiSo.AutoSize = true;
            this.lbSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiSo.Location = new System.Drawing.Point(8, 134);
            this.lbSiSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSiSo.Name = "lbSiSo";
            this.lbSiSo.Size = new System.Drawing.Size(60, 20);
            this.lbSiSo.TabIndex = 9;
            this.lbSiSo.Text = "lbSi so";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(25, 41);
            this.lbTenLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(66, 24);
            this.lbTenLop.TabIndex = 7;
            this.lbTenLop.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTenHocVien);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbMaHocVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(367, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(311, 219);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Học viên đang chọn";
            // 
            // lbTenHocVien
            // 
            this.lbTenHocVien.AutoSize = true;
            this.lbTenHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHocVien.Location = new System.Drawing.Point(135, 111);
            this.lbTenHocVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenHocVien.Name = "lbTenHocVien";
            this.lbTenHocVien.Size = new System.Drawing.Size(59, 20);
            this.lbTenHocVien.TabIndex = 10;
            this.lbTenHocVien.Text = "label7";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(35, 166);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 38);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(183, 166);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 38);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên học viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã học viên";
            // 
            // lbMaHocVien
            // 
            this.lbMaHocVien.AutoSize = true;
            this.lbMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHocVien.Location = new System.Drawing.Point(135, 64);
            this.lbMaHocVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaHocVien.Name = "lbMaHocVien";
            this.lbMaHocVien.Size = new System.Drawing.Size(59, 20);
            this.lbMaHocVien.TabIndex = 8;
            this.lbMaHocVien.Text = "label5";
            // 
            // btExportPDF
            // 
            this.btExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportPDF.Location = new System.Drawing.Point(101, 268);
            this.btExportPDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExportPDF.Name = "btExportPDF";
            this.btExportPDF.Size = new System.Drawing.Size(108, 34);
            this.btExportPDF.TabIndex = 12;
            this.btExportPDF.Text = "Xuất PDF";
            this.btExportPDF.UseVisualStyleBackColor = true;
            this.btExportPDF.Click += new System.EventHandler(this.btExportPDF_Click);
            // 
            // btReload
            // 
            this.btReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReload.Location = new System.Drawing.Point(8, 268);
            this.btReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(85, 34);
            this.btReload.TabIndex = 11;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTieuChiTimKiem);
            this.groupBox1.Controls.Add(this.grdTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(685, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(457, 293);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbTieuChiTimKiem
            // 
            this.cbTieuChiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTieuChiTimKiem.FormattingEnabled = true;
            this.cbTieuChiTimKiem.Items.AddRange(new object[] {
            "Mã",
            "Họ tên",
            "Số điện thoại"});
            this.cbTieuChiTimKiem.Location = new System.Drawing.Point(253, 215);
            this.cbTieuChiTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTieuChiTimKiem.Name = "cbTieuChiTimKiem";
            this.cbTieuChiTimKiem.Size = new System.Drawing.Size(133, 28);
            this.cbTieuChiTimKiem.TabIndex = 3;
            // 
            // grdTimKiem
            // 
            this.grdTimKiem.AllowUserToAddRows = false;
            this.grdTimKiem.AllowUserToDeleteRows = false;
            this.grdTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_HV,
            this.ten_HV,
            this.ngaysinh_HV,
            this.sodt_HV});
            this.grdTimKiem.Location = new System.Drawing.Point(15, 26);
            this.grdTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTimKiem.Name = "grdTimKiem";
            this.grdTimKiem.ReadOnly = true;
            this.grdTimKiem.RowHeadersVisible = false;
            this.grdTimKiem.RowHeadersWidth = 51;
            this.grdTimKiem.Size = new System.Drawing.Size(431, 182);
            this.grdTimKiem.TabIndex = 12;
            this.grdTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTimKiem_CellClick);
            // 
            // id_HV
            // 
            this.id_HV.DataPropertyName = "id_HV";
            this.id_HV.HeaderText = "Mã HV";
            this.id_HV.MinimumWidth = 6;
            this.id_HV.Name = "id_HV";
            this.id_HV.ReadOnly = true;
            this.id_HV.Width = 65;
            // 
            // ten_HV
            // 
            this.ten_HV.DataPropertyName = "ten_HV";
            this.ten_HV.HeaderText = "Tên học viên";
            this.ten_HV.MinimumWidth = 6;
            this.ten_HV.Name = "ten_HV";
            this.ten_HV.ReadOnly = true;
            this.ten_HV.Width = 125;
            // 
            // ngaysinh_HV
            // 
            this.ngaysinh_HV.DataPropertyName = "ngaysinh_HV";
            this.ngaysinh_HV.HeaderText = "Ngày sinh";
            this.ngaysinh_HV.MinimumWidth = 6;
            this.ngaysinh_HV.Name = "ngaysinh_HV";
            this.ngaysinh_HV.ReadOnly = true;
            this.ngaysinh_HV.Width = 125;
            // 
            // sodt_HV
            // 
            this.sodt_HV.DataPropertyName = "sodt_HV";
            this.sodt_HV.HeaderText = "Số điện thoại";
            this.sodt_HV.MinimumWidth = 6;
            this.sodt_HV.Name = "sodt_HV";
            this.sodt_HV.ReadOnly = true;
            this.sodt_HV.Width = 125;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(72, 215);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 26);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(179, 250);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(121, 36);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // grdDssv
            // 
            this.grdDssv.AllowUserToAddRows = false;
            this.grdDssv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDssv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdDssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDssv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHV,
            this.tenHV,
            this.diem_1,
            this.diem_2,
            this.danhgia,
            this.diem_do_an,
            this.xet_tot_nghiep,
            this.xeploai,
            this.ghiChu});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDssv.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdDssv.Location = new System.Drawing.Point(8, 320);
            this.grdDssv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDssv.Name = "grdDssv";
            this.grdDssv.ReadOnly = true;
            this.grdDssv.RowHeadersWidth = 51;
            this.grdDssv.Size = new System.Drawing.Size(1135, 279);
            this.grdDssv.TabIndex = 1;
            this.grdDssv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDssv_CellClick);
            // 
            // maHV
            // 
            this.maHV.HeaderText = "Mã học viên";
            this.maHV.MinimumWidth = 6;
            this.maHV.Name = "maHV";
            this.maHV.ReadOnly = true;
            this.maHV.Width = 110;
            // 
            // tenHV
            // 
            this.tenHV.HeaderText = "Tên học viên";
            this.tenHV.MinimumWidth = 6;
            this.tenHV.Name = "tenHV";
            this.tenHV.ReadOnly = true;
            this.tenHV.Width = 180;
            // 
            // diem_1
            // 
            this.diem_1.HeaderText = "Điểm 1";
            this.diem_1.MinimumWidth = 6;
            this.diem_1.Name = "diem_1";
            this.diem_1.ReadOnly = true;
            this.diem_1.Width = 125;
            // 
            // diem_2
            // 
            this.diem_2.HeaderText = "Điểm 2";
            this.diem_2.MinimumWidth = 6;
            this.diem_2.Name = "diem_2";
            this.diem_2.ReadOnly = true;
            this.diem_2.Width = 125;
            // 
            // danhgia
            // 
            this.danhgia.HeaderText = "Đánh giá";
            this.danhgia.MinimumWidth = 6;
            this.danhgia.Name = "danhgia";
            this.danhgia.ReadOnly = true;
            this.danhgia.Width = 125;
            // 
            // diem_do_an
            // 
            this.diem_do_an.HeaderText = "Điểm đồ án";
            this.diem_do_an.MinimumWidth = 6;
            this.diem_do_an.Name = "diem_do_an";
            this.diem_do_an.ReadOnly = true;
            this.diem_do_an.Width = 125;
            // 
            // xet_tot_nghiep
            // 
            this.xet_tot_nghiep.HeaderText = "Tốt nghiệp";
            this.xet_tot_nghiep.MinimumWidth = 6;
            this.xet_tot_nghiep.Name = "xet_tot_nghiep";
            this.xet_tot_nghiep.ReadOnly = true;
            this.xet_tot_nghiep.Width = 125;
            // 
            // xeploai
            // 
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.MinimumWidth = 6;
            this.xeploai.Name = "xeploai";
            this.xeploai.ReadOnly = true;
            this.xeploai.Width = 125;
            // 
            // ghiChu
            // 
            this.ghiChu.HeaderText = "Ghi Chú";
            this.ghiChu.MinimumWidth = 6;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            this.ghiChu.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_dtb);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(757, 609);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 58);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng kết";
            // 
            // lb_dtb
            // 
            this.lb_dtb.AutoSize = true;
            this.lb_dtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dtb.Location = new System.Drawing.Point(138, 17);
            this.lb_dtb.Name = "lb_dtb";
            this.lb_dtb.Size = new System.Drawing.Size(32, 20);
            this.lb_dtb.TabIndex = 18;
            this.lb_dtb.Text = "dtb";
            this.lb_dtb.Click += new System.EventHandler(this.Lb_dtb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Điểm trung bình:";
            // 
            // Gui_ChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 708);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Gui_ChiTietLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết lớp học";
            this.Load += new System.EventHandler(this.Gui_ChiTietLopHoc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDssv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbSiSo;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.ComboBox cbTieuChiTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView grdDssv;
        private System.Windows.Forms.Label lbTenHocVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbMaHocVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdTimKiem;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExportPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt_HV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_do_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn xet_tot_nghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_dtb;
        private System.Windows.Forms.Label label1;
    }
}