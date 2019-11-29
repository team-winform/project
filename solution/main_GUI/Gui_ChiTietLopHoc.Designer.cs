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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btReload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTenHocVien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTieuChiTimKiem = new System.Windows.Forms.ComboBox();
            this.lbMaHocVien = new System.Windows.Forms.Label();
            this.grdTimKiem = new System.Windows.Forms.DataGridView();
            this.tk_mahv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk_tenhv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk_ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tk_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.lbSiSo = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.grdDssv = new System.Windows.Forms.DataGridView();
            this.maHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btExportPDF = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDssv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btExportPDF);
            this.tabPage1.Controls.Add(this.btReload);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lbSiSo);
            this.tabPage1.Controls.Add(this.lbMaLop);
            this.tabPage1.Controls.Add(this.lbTenLop);
            this.tabPage1.Controls.Add(this.grdDssv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý sinh viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btReload
            // 
            this.btReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReload.Location = new System.Drawing.Point(6, 218);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(64, 28);
            this.btReload.TabIndex = 11;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTenHocVien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTieuChiTimKiem);
            this.groupBox1.Controls.Add(this.lbMaHocVien);
            this.groupBox1.Controls.Add(this.grdTimKiem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(315, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 238);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý học viên";
            // 
            // lbTenHocVien
            // 
            this.lbTenHocVien.AutoSize = true;
            this.lbTenHocVien.Location = new System.Drawing.Point(117, 78);
            this.lbTenHocVien.Name = "lbTenHocVien";
            this.lbTenHocVien.Size = new System.Drawing.Size(45, 16);
            this.lbTenHocVien.TabIndex = 10;
            this.lbTenHocVien.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên học viên";
            // 
            // cbTieuChiTimKiem
            // 
            this.cbTieuChiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTieuChiTimKiem.FormattingEnabled = true;
            this.cbTieuChiTimKiem.Items.AddRange(new object[] {
            "Ngày sinh",
            "Họ tên",
            "Số điện thoại"});
            this.cbTieuChiTimKiem.Location = new System.Drawing.Point(300, 165);
            this.cbTieuChiTimKiem.Name = "cbTieuChiTimKiem";
            this.cbTieuChiTimKiem.Size = new System.Drawing.Size(121, 24);
            this.cbTieuChiTimKiem.TabIndex = 3;
            // 
            // lbMaHocVien
            // 
            this.lbMaHocVien.AutoSize = true;
            this.lbMaHocVien.Location = new System.Drawing.Point(117, 40);
            this.lbMaHocVien.Name = "lbMaHocVien";
            this.lbMaHocVien.Size = new System.Drawing.Size(45, 16);
            this.lbMaHocVien.TabIndex = 8;
            this.lbMaHocVien.Text = "label5";
            // 
            // grdTimKiem
            // 
            this.grdTimKiem.AllowUserToAddRows = false;
            this.grdTimKiem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tk_mahv,
            this.tk_tenhv,
            this.tk_ngaysinh,
            this.tk_sdt});
            this.grdTimKiem.Location = new System.Drawing.Point(213, 21);
            this.grdTimKiem.Name = "grdTimKiem";
            this.grdTimKiem.ReadOnly = true;
            this.grdTimKiem.RowHeadersVisible = false;
            this.grdTimKiem.Size = new System.Drawing.Size(295, 112);
            this.grdTimKiem.TabIndex = 12;
            // 
            // tk_mahv
            // 
            this.tk_mahv.HeaderText = "Mã HV";
            this.tk_mahv.Name = "tk_mahv";
            this.tk_mahv.ReadOnly = true;
            this.tk_mahv.Width = 65;
            // 
            // tk_tenhv
            // 
            this.tk_tenhv.HeaderText = "Tên học viên";
            this.tk_tenhv.Name = "tk_tenhv";
            this.tk_tenhv.ReadOnly = true;
            // 
            // tk_ngaysinh
            // 
            this.tk_ngaysinh.HeaderText = "Ngày sinh";
            this.tk_ngaysinh.Name = "tk_ngaysinh";
            this.tk_ngaysinh.ReadOnly = true;
            // 
            // tk_sdt
            // 
            this.tk_sdt.HeaderText = "Số điện thoại";
            this.tk_sdt.Name = "tk_sdt";
            this.tk_sdt.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã học viên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(300, 139);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(121, 22);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(120, 161);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 31);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(326, 195);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 29);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(9, 161);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 31);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // lbSiSo
            // 
            this.lbSiSo.AutoSize = true;
            this.lbSiSo.Location = new System.Drawing.Point(16, 47);
            this.lbSiSo.Name = "lbSiSo";
            this.lbSiSo.Size = new System.Drawing.Size(35, 13);
            this.lbSiSo.TabIndex = 9;
            this.lbSiSo.Text = "label3";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(16, 13);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(35, 13);
            this.lbMaLop.TabIndex = 8;
            this.lbMaLop.Text = "label2";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(142, 8);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(51, 20);
            this.lbTenLop.TabIndex = 7;
            this.lbTenLop.Text = "label1";
            // 
            // grdDssv
            // 
            this.grdDssv.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDssv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDssv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHV,
            this.tenHV,
            this.diem1,
            this.diem2,
            this.diem3,
            this.diem4,
            this.ghiChu});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDssv.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDssv.Location = new System.Drawing.Point(6, 260);
            this.grdDssv.Name = "grdDssv";
            this.grdDssv.ReadOnly = true;
            this.grdDssv.Size = new System.Drawing.Size(830, 227);
            this.grdDssv.TabIndex = 1;
            this.grdDssv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDssv_CellClick);
            // 
            // maHV
            // 
            this.maHV.HeaderText = "Mã học viên";
            this.maHV.Name = "maHV";
            this.maHV.ReadOnly = true;
            this.maHV.Width = 110;
            // 
            // tenHV
            // 
            this.tenHV.HeaderText = "Tên học viên";
            this.tenHV.Name = "tenHV";
            this.tenHV.ReadOnly = true;
            this.tenHV.Width = 150;
            // 
            // diem1
            // 
            this.diem1.HeaderText = "Điểm số 1";
            this.diem1.Name = "diem1";
            this.diem1.ReadOnly = true;
            // 
            // diem2
            // 
            this.diem2.HeaderText = "Điểm số 2";
            this.diem2.Name = "diem2";
            this.diem2.ReadOnly = true;
            // 
            // diem3
            // 
            this.diem3.HeaderText = "Điểm số 3";
            this.diem3.Name = "diem3";
            this.diem3.ReadOnly = true;
            // 
            // diem4
            // 
            this.diem4.HeaderText = "Điểm số 4";
            this.diem4.Name = "diem4";
            this.diem4.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.HeaderText = "Ghi Chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btExportPDF
            // 
            this.btExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportPDF.Location = new System.Drawing.Point(88, 218);
            this.btExportPDF.Name = "btExportPDF";
            this.btExportPDF.Size = new System.Drawing.Size(86, 28);
            this.btExportPDF.TabIndex = 12;
            this.btExportPDF.Text = "Xuất PDF";
            this.btExportPDF.UseVisualStyleBackColor = true;
            this.btExportPDF.Click += new System.EventHandler(this.btExportPDF_Click);
            // 
            // Gui_ChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "Gui_ChiTietLopHoc";
            this.Text = "Gui_ChiTietLopHoc";
            this.Load += new System.EventHandler(this.Gui_ChiTietLopHoc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDssv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_mahv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_tenhv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tk_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.Button btExportPDF;
    }
}