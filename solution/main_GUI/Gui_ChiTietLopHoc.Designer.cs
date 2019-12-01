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
            this.diem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDssv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btExportPDF);
            this.tabPage1.Controls.Add(this.btReload);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grdDssv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(863, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý học viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbMaLop);
            this.groupBox3.Controls.Add(this.lbSiSo);
            this.groupBox3.Controls.Add(this.lbTenLop);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 197);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp học";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(6, 75);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(45, 16);
            this.lbMaLop.TabIndex = 8;
            this.lbMaLop.Text = "label2";
            // 
            // lbSiSo
            // 
            this.lbSiSo.AutoSize = true;
            this.lbSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiSo.Location = new System.Drawing.Point(6, 109);
            this.lbSiSo.Name = "lbSiSo";
            this.lbSiSo.Size = new System.Drawing.Size(45, 16);
            this.lbSiSo.TabIndex = 9;
            this.lbSiSo.Text = "label3";
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(19, 33);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(52, 18);
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
            this.groupBox2.Location = new System.Drawing.Point(275, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 178);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Học viên đang chọn";
            // 
            // lbTenHocVien
            // 
            this.lbTenHocVien.AutoSize = true;
            this.lbTenHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHocVien.Location = new System.Drawing.Point(101, 90);
            this.lbTenHocVien.Name = "lbTenHocVien";
            this.lbTenHocVien.Size = new System.Drawing.Size(45, 16);
            this.lbTenHocVien.TabIndex = 10;
            this.lbTenHocVien.Text = "label7";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(26, 135);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 31);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(137, 135);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 31);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên học viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã học viên";
            // 
            // lbMaHocVien
            // 
            this.lbMaHocVien.AutoSize = true;
            this.lbMaHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHocVien.Location = new System.Drawing.Point(101, 52);
            this.lbMaHocVien.Name = "lbMaHocVien";
            this.lbMaHocVien.Size = new System.Drawing.Size(45, 16);
            this.lbMaHocVien.TabIndex = 8;
            this.lbMaHocVien.Text = "label5";
            // 
            // btExportPDF
            // 
            this.btExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportPDF.Location = new System.Drawing.Point(76, 218);
            this.btExportPDF.Name = "btExportPDF";
            this.btExportPDF.Size = new System.Drawing.Size(81, 28);
            this.btExportPDF.TabIndex = 12;
            this.btExportPDF.Text = "Xuất PDF";
            this.btExportPDF.UseVisualStyleBackColor = true;
            this.btExportPDF.Click += new System.EventHandler(this.btExportPDF_Click);
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
            this.groupBox1.Controls.Add(this.cbTieuChiTimKiem);
            this.groupBox1.Controls.Add(this.grdTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(514, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 238);
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
            this.cbTieuChiTimKiem.Location = new System.Drawing.Point(190, 175);
            this.cbTieuChiTimKiem.Name = "cbTieuChiTimKiem";
            this.cbTieuChiTimKiem.Size = new System.Drawing.Size(101, 24);
            this.cbTieuChiTimKiem.TabIndex = 3;
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
            this.id_HV,
            this.ten_HV,
            this.ngaysinh_HV,
            this.sodt_HV});
            this.grdTimKiem.Location = new System.Drawing.Point(11, 21);
            this.grdTimKiem.Name = "grdTimKiem";
            this.grdTimKiem.ReadOnly = true;
            this.grdTimKiem.RowHeadersVisible = false;
            this.grdTimKiem.Size = new System.Drawing.Size(323, 148);
            this.grdTimKiem.TabIndex = 12;
            this.grdTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTimKiem_CellClick);
            // 
            // id_HV
            // 
            this.id_HV.DataPropertyName = "id_HV";
            this.id_HV.HeaderText = "Mã HV";
            this.id_HV.Name = "id_HV";
            this.id_HV.ReadOnly = true;
            this.id_HV.Width = 65;
            // 
            // ten_HV
            // 
            this.ten_HV.DataPropertyName = "ten_HV";
            this.ten_HV.HeaderText = "Tên học viên";
            this.ten_HV.Name = "ten_HV";
            this.ten_HV.ReadOnly = true;
            // 
            // ngaysinh_HV
            // 
            this.ngaysinh_HV.DataPropertyName = "ngaysinh_HV";
            this.ngaysinh_HV.HeaderText = "Ngày sinh";
            this.ngaysinh_HV.Name = "ngaysinh_HV";
            this.ngaysinh_HV.ReadOnly = true;
            // 
            // sodt_HV
            // 
            this.sodt_HV.DataPropertyName = "sodt_HV";
            this.sodt_HV.HeaderText = "Số điện thoại";
            this.sodt_HV.Name = "sodt_HV";
            this.sodt_HV.ReadOnly = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(54, 175);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(121, 22);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(134, 203);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(91, 29);
            this.btTimKiem.TabIndex = 4;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // grdDssv
            // 
            this.grdDssv.AllowUserToAddRows = false;
            this.grdDssv.AllowUserToDeleteRows = false;
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
            this.grdDssv.Size = new System.Drawing.Size(851, 227);
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
            this.tenHV.Width = 180;
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
            // Gui_ChiTietLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 534);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn diem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}