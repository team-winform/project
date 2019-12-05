namespace main_GUI
{
    partial class DiemGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_listClass = new System.Windows.Forms.ComboBox();
            this.bt_selectLop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_chonDiem = new System.Windows.Forms.ComboBox();
            this.bt_nhapDiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_xacNhanDiem = new System.Windows.Forms.Button();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.dgv_Diem = new System.Windows.Forms.DataGridView();
            this.id_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_do_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xet_tot_nghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu_HVLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa chọn lớp:";
            // 
            // cb_listClass
            // 
            this.cb_listClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_listClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_listClass.FormattingEnabled = true;
            this.cb_listClass.Location = new System.Drawing.Point(179, 41);
            this.cb_listClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_listClass.Name = "cb_listClass";
            this.cb_listClass.Size = new System.Drawing.Size(379, 33);
            this.cb_listClass.TabIndex = 1;
            // 
            // bt_selectLop
            // 
            this.bt_selectLop.Enabled = false;
            this.bt_selectLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selectLop.Location = new System.Drawing.Point(592, 35);
            this.bt_selectLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_selectLop.Name = "bt_selectLop";
            this.bt_selectLop.Size = new System.Drawing.Size(112, 42);
            this.bt_selectLop.TabIndex = 2;
            this.bt_selectLop.Text = "Chọn";
            this.bt_selectLop.UseVisualStyleBackColor = true;
            this.bt_selectLop.Click += new System.EventHandler(this.Bt_selectLop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bt_selectLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_listClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 100);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_chonDiem);
            this.groupBox1.Controls.Add(this.bt_nhapDiem);
            this.groupBox1.Location = new System.Drawing.Point(814, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn điểm";
            // 
            // cb_chonDiem
            // 
            this.cb_chonDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chonDiem.Enabled = false;
            this.cb_chonDiem.FormattingEnabled = true;
            this.cb_chonDiem.Items.AddRange(new object[] {
            "Điểm 1",
            "Điểm 2",
            "Điểm đồ án"});
            this.cb_chonDiem.Location = new System.Drawing.Point(37, 29);
            this.cb_chonDiem.Name = "cb_chonDiem";
            this.cb_chonDiem.Size = new System.Drawing.Size(153, 33);
            this.cb_chonDiem.TabIndex = 4;
            this.cb_chonDiem.SelectedIndexChanged += new System.EventHandler(this.Cb_chonDiem_SelectedIndexChanged);
            // 
            // bt_nhapDiem
            // 
            this.bt_nhapDiem.Enabled = false;
            this.bt_nhapDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhapDiem.Location = new System.Drawing.Point(196, 28);
            this.bt_nhapDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_nhapDiem.Name = "bt_nhapDiem";
            this.bt_nhapDiem.Size = new System.Drawing.Size(139, 37);
            this.bt_nhapDiem.TabIndex = 0;
            this.bt_nhapDiem.Text = "Bắt đầu";
            this.bt_nhapDiem.UseVisualStyleBackColor = true;
            this.bt_nhapDiem.Click += new System.EventHandler(this.Bt_nhapDiem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_xacNhanDiem);
            this.panel2.Controls.Add(this.bt_Huy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 71);
            this.panel2.TabIndex = 4;
            // 
            // bt_xacNhanDiem
            // 
            this.bt_xacNhanDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xacNhanDiem.Location = new System.Drawing.Point(420, 21);
            this.bt_xacNhanDiem.Name = "bt_xacNhanDiem";
            this.bt_xacNhanDiem.Size = new System.Drawing.Size(129, 38);
            this.bt_xacNhanDiem.TabIndex = 2;
            this.bt_xacNhanDiem.Text = "Xác nhận";
            this.bt_xacNhanDiem.UseVisualStyleBackColor = true;
            this.bt_xacNhanDiem.Visible = false;
            this.bt_xacNhanDiem.Click += new System.EventHandler(this.Bt_xacNhanDiem_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Huy.Location = new System.Drawing.Point(728, 21);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(107, 39);
            this.bt_Huy.TabIndex = 1;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Visible = false;
            this.bt_Huy.Click += new System.EventHandler(this.Bt_Huy_Click);
            // 
            // dgv_Diem
            // 
            this.dgv_Diem.AllowUserToAddRows = false;
            this.dgv_Diem.AllowUserToDeleteRows = false;
            this.dgv_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_HV,
            this.ten_HV,
            this.diem_1,
            this.diem_2,
            this.danhgia,
            this.diem_do_an,
            this.xet_tot_nghiep,
            this.xeploai,
            this.ghichu_HVLH});
            this.dgv_Diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Diem.Location = new System.Drawing.Point(0, 100);
            this.dgv_Diem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Diem.Name = "dgv_Diem";
            this.dgv_Diem.RowHeadersWidth = 51;
            this.dgv_Diem.RowTemplate.Height = 24;
            this.dgv_Diem.Size = new System.Drawing.Size(1220, 357);
            this.dgv_Diem.TabIndex = 5;
            this.dgv_Diem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_Diem_EditingControlShowing);
            this.dgv_Diem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_Diem_KeyDown);
            this.dgv_Diem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Dgv_Diem_KeyUp);
            // 
            // id_HV
            // 
            this.id_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_HV.DataPropertyName = "StudentId";
            this.id_HV.HeaderText = "Mã học viên";
            this.id_HV.MinimumWidth = 6;
            this.id_HV.Name = "id_HV";
            this.id_HV.ReadOnly = true;
            // 
            // ten_HV
            // 
            this.ten_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_HV.DataPropertyName = "StudentName";
            this.ten_HV.HeaderText = "Tên học viên";
            this.ten_HV.MinimumWidth = 6;
            this.ten_HV.Name = "ten_HV";
            this.ten_HV.ReadOnly = true;
            // 
            // diem_1
            // 
            this.diem_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diem_1.DataPropertyName = "Point1";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.diem_1.DefaultCellStyle = dataGridViewCellStyle2;
            this.diem_1.HeaderText = "Điểm 1";
            this.diem_1.MaxInputLength = 2;
            this.diem_1.MinimumWidth = 6;
            this.diem_1.Name = "diem_1";
            // 
            // diem_2
            // 
            this.diem_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diem_2.DataPropertyName = "Point2";
            this.diem_2.HeaderText = "Điểm 2";
            this.diem_2.MaxInputLength = 2;
            this.diem_2.MinimumWidth = 6;
            this.diem_2.Name = "diem_2";
            // 
            // danhgia
            // 
            this.danhgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.danhgia.DataPropertyName = "Rate";
            this.danhgia.HeaderText = "Đánh giá";
            this.danhgia.MinimumWidth = 6;
            this.danhgia.Name = "danhgia";
            this.danhgia.ReadOnly = true;
            // 
            // diem_do_an
            // 
            this.diem_do_an.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diem_do_an.DataPropertyName = "PointFinal";
            this.diem_do_an.HeaderText = "Điểm đồ án";
            this.diem_do_an.MaxInputLength = 2;
            this.diem_do_an.MinimumWidth = 6;
            this.diem_do_an.Name = "diem_do_an";
            // 
            // xet_tot_nghiep
            // 
            this.xet_tot_nghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xet_tot_nghiep.DataPropertyName = "Graduating";
            this.xet_tot_nghiep.HeaderText = "Tốt nghiệp";
            this.xet_tot_nghiep.MinimumWidth = 6;
            this.xet_tot_nghiep.Name = "xet_tot_nghiep";
            this.xet_tot_nghiep.ReadOnly = true;
            // 
            // xeploai
            // 
            this.xeploai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xeploai.DataPropertyName = "Rank";
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.MinimumWidth = 6;
            this.xeploai.Name = "xeploai";
            this.xeploai.ReadOnly = true;
            // 
            // ghichu_HVLH
            // 
            this.ghichu_HVLH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu_HVLH.DataPropertyName = "Note";
            this.ghichu_HVLH.HeaderText = "Ghi chú";
            this.ghichu_HVLH.MinimumWidth = 6;
            this.ghichu_HVLH.Name = "ghichu_HVLH";
            this.ghichu_HVLH.ReadOnly = true;
            // 
            // DiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 528);
            this.Controls.Add(this.dgv_Diem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DiemGUI";
            this.Text = "DiemGUI";
            this.Load += new System.EventHandler(this.DiemGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Diem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_listClass;
        private System.Windows.Forms.Button bt_selectLop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.Button bt_nhapDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_chonDiem;
        private System.Windows.Forms.Button bt_xacNhanDiem;
        public System.Windows.Forms.DataGridView dgv_Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem_do_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn xet_tot_nghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu_HVLH;
    }
}