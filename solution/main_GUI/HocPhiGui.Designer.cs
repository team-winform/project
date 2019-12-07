namespace main_GUI
{
    partial class HocPhiGui
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_HocPhi = new System.Windows.Forms.DataGridView();
            this.bt_xacNhanHP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Huy = new System.Windows.Forms.Button();
            this.cb_lanNop = new System.Windows.Forms.ComboBox();
            this.bt_ChonLanNop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_selectLop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_listClass = new System.Windows.Forms.ComboBox();
            this.id_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nop_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nop_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xet_tot_nghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocPhi)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_HocPhi
            // 
            this.dgv_HocPhi.AllowUserToAddRows = false;
            this.dgv_HocPhi.AllowUserToDeleteRows = false;
            this.dgv_HocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HocPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_HV,
            this.ten_HV,
            this.hocphi,
            this.nop_1,
            this.date1,
            this.nop_2,
            this.date2,
            this.xet_tot_nghiep,
            this.xeploai});
            this.dgv_HocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HocPhi.Location = new System.Drawing.Point(0, 100);
            this.dgv_HocPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_HocPhi.Name = "dgv_HocPhi";
            this.dgv_HocPhi.RowHeadersWidth = 51;
            this.dgv_HocPhi.RowTemplate.Height = 24;
            this.dgv_HocPhi.Size = new System.Drawing.Size(1223, 342);
            this.dgv_HocPhi.TabIndex = 8;
            // 
            // bt_xacNhanHP
            // 
            this.bt_xacNhanHP.Enabled = false;
            this.bt_xacNhanHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xacNhanHP.Location = new System.Drawing.Point(495, 22);
            this.bt_xacNhanHP.Name = "bt_xacNhanHP";
            this.bt_xacNhanHP.Size = new System.Drawing.Size(129, 38);
            this.bt_xacNhanHP.TabIndex = 5;
            this.bt_xacNhanHP.Text = "Xác nhận";
            this.bt_xacNhanHP.UseVisualStyleBackColor = true;
            this.bt_xacNhanHP.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_xacNhanHP);
            this.panel2.Controls.Add(this.bt_Huy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 71);
            this.panel2.TabIndex = 7;
            // 
            // bt_Huy
            // 
            this.bt_Huy.Enabled = false;
            this.bt_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Huy.Location = new System.Drawing.Point(650, 21);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(107, 39);
            this.bt_Huy.TabIndex = 6;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Visible = false;
            // 
            // cb_lanNop
            // 
            this.cb_lanNop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lanNop.Enabled = false;
            this.cb_lanNop.FormattingEnabled = true;
            this.cb_lanNop.Items.AddRange(new object[] {
            "Lần 1",
            "Lần 2"});
            this.cb_lanNop.Location = new System.Drawing.Point(37, 29);
            this.cb_lanNop.Name = "cb_lanNop";
            this.cb_lanNop.Size = new System.Drawing.Size(153, 33);
            this.cb_lanNop.TabIndex = 3;
            // 
            // bt_ChonLanNop
            // 
            this.bt_ChonLanNop.Enabled = false;
            this.bt_ChonLanNop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ChonLanNop.Location = new System.Drawing.Point(196, 28);
            this.bt_ChonLanNop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ChonLanNop.Name = "bt_ChonLanNop";
            this.bt_ChonLanNop.Size = new System.Drawing.Size(139, 37);
            this.bt_ChonLanNop.TabIndex = 4;
            this.bt_ChonLanNop.Text = "Bắt đầu";
            this.bt_ChonLanNop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_lanNop);
            this.groupBox1.Controls.Add(this.bt_ChonLanNop);
            this.groupBox1.Location = new System.Drawing.Point(814, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Lần nộp";
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
            this.panel1.Size = new System.Drawing.Size(1223, 100);
            this.panel1.TabIndex = 6;
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
            // hocphi
            // 
            this.hocphi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hocphi.DataPropertyName = "HocPhi";
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.hocphi.DefaultCellStyle = dataGridViewCellStyle15;
            this.hocphi.HeaderText = "Học phí";
            this.hocphi.MaxInputLength = 8;
            this.hocphi.MinimumWidth = 6;
            this.hocphi.Name = "hocphi";
            // 
            // nop_1
            // 
            this.nop_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nop_1.DataPropertyName = "nop1";
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.nop_1.DefaultCellStyle = dataGridViewCellStyle16;
            this.nop_1.HeaderText = "Nộp lần 1";
            this.nop_1.MaxInputLength = 8;
            this.nop_1.MinimumWidth = 6;
            this.nop_1.Name = "nop_1";
            // 
            // date1
            // 
            this.date1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date1.DataPropertyName = "Date1";
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.date1.DefaultCellStyle = dataGridViewCellStyle17;
            this.date1.HeaderText = "Ngày nộp lần 1";
            this.date1.MinimumWidth = 6;
            this.date1.Name = "date1";
            this.date1.ReadOnly = true;
            // 
            // nop_2
            // 
            this.nop_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nop_2.DataPropertyName = "nop_lan_2";
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.nop_2.DefaultCellStyle = dataGridViewCellStyle18;
            this.nop_2.HeaderText = "Nộp lần 2";
            this.nop_2.MaxInputLength = 8;
            this.nop_2.MinimumWidth = 6;
            this.nop_2.Name = "nop_2";
            // 
            // date2
            // 
            this.date2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date2.DataPropertyName = "date2";
            dataGridViewCellStyle19.Format = "d";
            dataGridViewCellStyle19.NullValue = null;
            this.date2.DefaultCellStyle = dataGridViewCellStyle19;
            this.date2.HeaderText = "Ngày nộp lần 2";
            this.date2.MaxInputLength = 4;
            this.date2.MinimumWidth = 6;
            this.date2.Name = "date2";
            // 
            // xet_tot_nghiep
            // 
            this.xet_tot_nghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xet_tot_nghiep.DataPropertyName = "Graduating";
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.xet_tot_nghiep.DefaultCellStyle = dataGridViewCellStyle20;
            this.xet_tot_nghiep.HeaderText = "Hoàn thành";
            this.xet_tot_nghiep.MaxInputLength = 8;
            this.xet_tot_nghiep.MinimumWidth = 6;
            this.xet_tot_nghiep.Name = "xet_tot_nghiep";
            this.xet_tot_nghiep.ReadOnly = true;
            // 
            // xeploai
            // 
            this.xeploai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xeploai.DataPropertyName = "Rank";
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = null;
            this.xeploai.DefaultCellStyle = dataGridViewCellStyle21;
            this.xeploai.HeaderText = "Còn nợ";
            this.xeploai.MaxInputLength = 8;
            this.xeploai.MinimumWidth = 6;
            this.xeploai.Name = "xeploai";
            this.xeploai.ReadOnly = true;
            // 
            // HocPhiGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 513);
            this.Controls.Add(this.dgv_HocPhi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HocPhiGui";
            this.Text = "HocPhiGui";
            this.Load += new System.EventHandler(this.HocPhiGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocPhi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_HocPhi;
        private System.Windows.Forms.Button bt_xacNhanHP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_Huy;
        private System.Windows.Forms.ComboBox cb_lanNop;
        private System.Windows.Forms.Button bt_ChonLanNop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_selectLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_listClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocphi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nop_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nop_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xet_tot_nghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn xeploai;
    }
}