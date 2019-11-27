namespace main_GUI
{
    partial class Dialog_QuanLyLichHocLopHoc
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
            this.grdLichHoc = new System.Windows.Forms.DataGridView();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMaLopHoc = new System.Windows.Forms.Label();
            this.lbTenLopHoc = new System.Windows.Forms.Label();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.lbNgayKetThuc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSuaLich = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLichHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdLichHoc
            // 
            this.grdLichHoc.AllowUserToAddRows = false;
            this.grdLichHoc.AllowUserToDeleteRows = false;
            this.grdLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLichHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngayBatDau,
            this.ngayKetThuc,
            this.thu,
            this.tiet});
            this.grdLichHoc.Location = new System.Drawing.Point(26, 157);
            this.grdLichHoc.Name = "grdLichHoc";
            this.grdLichHoc.ReadOnly = true;
            this.grdLichHoc.Size = new System.Drawing.Size(538, 192);
            this.grdLichHoc.TabIndex = 0;
            this.grdLichHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLichHoc_CellClick);
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.HeaderText = "Ngày bắt đầu";
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.ReadOnly = true;
            this.ngayBatDau.Width = 130;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.HeaderText = "Ngày kết thúc";
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.ReadOnly = true;
            this.ngayKetThuc.Width = 130;
            // 
            // thu
            // 
            this.thu.HeaderText = "Thứ";
            this.thu.Name = "thu";
            this.thu.ReadOnly = true;
            // 
            // tiet
            // 
            this.tiet.HeaderText = "Tiết";
            this.tiet.Name = "tiet";
            this.tiet.ReadOnly = true;
            // 
            // lbMaLopHoc
            // 
            this.lbMaLopHoc.AutoSize = true;
            this.lbMaLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLopHoc.Location = new System.Drawing.Point(32, 13);
            this.lbMaLopHoc.Name = "lbMaLopHoc";
            this.lbMaLopHoc.Size = new System.Drawing.Size(41, 15);
            this.lbMaLopHoc.TabIndex = 1;
            this.lbMaLopHoc.Text = "label1";
            // 
            // lbTenLopHoc
            // 
            this.lbTenLopHoc.AutoSize = true;
            this.lbTenLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLopHoc.Location = new System.Drawing.Point(198, 13);
            this.lbTenLopHoc.Name = "lbTenLopHoc";
            this.lbTenLopHoc.Size = new System.Drawing.Size(51, 20);
            this.lbTenLopHoc.TabIndex = 2;
            this.lbTenLopHoc.Text = "label2";
            // 
            // lbNgayBatDau
            // 
            this.lbNgayBatDau.AutoSize = true;
            this.lbNgayBatDau.Location = new System.Drawing.Point(136, 75);
            this.lbNgayBatDau.Name = "lbNgayBatDau";
            this.lbNgayBatDau.Size = new System.Drawing.Size(35, 13);
            this.lbNgayBatDau.TabIndex = 3;
            this.lbNgayBatDau.Text = "label1";
            // 
            // lbNgayKetThuc
            // 
            this.lbNgayKetThuc.AutoSize = true;
            this.lbNgayKetThuc.Location = new System.Drawing.Point(136, 109);
            this.lbNgayKetThuc.Name = "lbNgayKetThuc";
            this.lbNgayKetThuc.Size = new System.Drawing.Size(35, 13);
            this.lbNgayKetThuc.TabIndex = 4;
            this.lbNgayKetThuc.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btSuaLich);
            this.groupBox1.Location = new System.Drawing.Point(364, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(119, 46);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSuaLich
            // 
            this.btSuaLich.Location = new System.Drawing.Point(6, 46);
            this.btSuaLich.Name = "btSuaLich";
            this.btSuaLich.Size = new System.Drawing.Size(75, 23);
            this.btSuaLich.TabIndex = 0;
            this.btSuaLich.Text = "Sửa";
            this.btSuaLich.UseVisualStyleBackColor = true;
            // 
            // Dialog_QuanLyLichHocLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNgayKetThuc);
            this.Controls.Add(this.lbNgayBatDau);
            this.Controls.Add(this.lbTenLopHoc);
            this.Controls.Add(this.lbMaLopHoc);
            this.Controls.Add(this.grdLichHoc);
            this.Name = "Dialog_QuanLyLichHocLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch học";
            this.Load += new System.EventHandler(this.Dialog_QuanLyLichHocLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLichHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLichHoc;
        private System.Windows.Forms.Label lbMaLopHoc;
        private System.Windows.Forms.Label lbTenLopHoc;
        private System.Windows.Forms.Label lbNgayBatDau;
        private System.Windows.Forms.Label lbNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSuaLich;
    }
}