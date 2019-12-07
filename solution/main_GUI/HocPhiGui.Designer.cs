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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgv_HocPhi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_hocphi = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_sohv = new System.Windows.Forms.Label();
            this.lb_tongphi = new System.Windows.Forms.Label();
            this.lb_tongthu = new System.Windows.Forms.Label();
            this.lb_tongno = new System.Windows.Forms.Label();
            this.tb_soHV = new System.Windows.Forms.TextBox();
            this.tb_tongPhi = new System.Windows.Forms.TextBox();
            this.tb_tongThu = new System.Windows.Forms.TextBox();
            this.tb_Tongno = new System.Windows.Forms.TextBox();
            this.id_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nop2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocPhi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_xacNhanHP
            // 
            this.bt_xacNhanHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xacNhanHP.Location = new System.Drawing.Point(495, 22);
            this.bt_xacNhanHP.Name = "bt_xacNhanHP";
            this.bt_xacNhanHP.Size = new System.Drawing.Size(129, 38);
            this.bt_xacNhanHP.TabIndex = 5;
            this.bt_xacNhanHP.Text = "Xác nhận";
            this.bt_xacNhanHP.UseVisualStyleBackColor = true;
            this.bt_xacNhanHP.Visible = false;
            this.bt_xacNhanHP.Click += new System.EventHandler(this.Bt_xacNhanHP_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
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
            this.bt_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Huy.Location = new System.Drawing.Point(650, 21);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(107, 39);
            this.bt_Huy.TabIndex = 6;
            this.bt_Huy.Text = "Hủy";
            this.bt_Huy.UseVisualStyleBackColor = true;
            this.bt_Huy.Visible = false;
            this.bt_Huy.Click += new System.EventHandler(this.Bt_Huy_Click);
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
            this.cb_lanNop.SelectedIndexChanged += new System.EventHandler(this.Cb_lanNop_SelectedIndexChanged);
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
            this.bt_ChonLanNop.Click += new System.EventHandler(this.Bt_ChonLanNop_Click);
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
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bt_selectLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_listClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 150);
            this.panel1.TabIndex = 6;
            // 
            // bt_selectLop
            // 
            this.bt_selectLop.Enabled = false;
            this.bt_selectLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_selectLop.Location = new System.Drawing.Point(592, 22);
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
            this.label1.Location = new System.Drawing.Point(43, 31);
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
            this.cb_listClass.Location = new System.Drawing.Point(179, 28);
            this.cb_listClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_listClass.Name = "cb_listClass";
            this.cb_listClass.Size = new System.Drawing.Size(379, 33);
            this.cb_listClass.TabIndex = 1;
            // 
            // dgv_HocPhi
            // 
            this.dgv_HocPhi.AllowUserToAddRows = false;
            this.dgv_HocPhi.AllowUserToDeleteRows = false;
            this.dgv_HocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HocPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_HV,
            this.ten_HV,
            this.nop1,
            this.date1,
            this.nop2,
            this.date2,
            this.complete,
            this.conno});
            this.dgv_HocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HocPhi.Location = new System.Drawing.Point(0, 150);
            this.dgv_HocPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_HocPhi.Name = "dgv_HocPhi";
            this.dgv_HocPhi.RowHeadersWidth = 51;
            this.dgv_HocPhi.RowTemplate.Height = 24;
            this.dgv_HocPhi.Size = new System.Drawing.Size(1223, 292);
            this.dgv_HocPhi.TabIndex = 9;
            this.dgv_HocPhi.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_HocPhi_EditingControlShowing);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_hocphi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(225, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Học phí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "VNĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            // 
            // tb_hocphi
            // 
            this.tb_hocphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hocphi.ForeColor = System.Drawing.Color.Red;
            this.tb_hocphi.Location = new System.Drawing.Point(78, 26);
            this.tb_hocphi.Name = "tb_hocphi";
            this.tb_hocphi.Size = new System.Drawing.Size(177, 28);
            this.tb_hocphi.TabIndex = 10;
            this.tb_hocphi.Text = "Chưa chọn lớp";
            this.tb_hocphi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_tongPhi);
            this.groupBox3.Controls.Add(this.tb_soHV);
            this.groupBox3.Controls.Add(this.lb_tongphi);
            this.groupBox3.Controls.Add(this.lb_sohv);
            this.groupBox3.Location = new System.Drawing.Point(13, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 53);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_Tongno);
            this.groupBox4.Controls.Add(this.tb_tongThu);
            this.groupBox4.Controls.Add(this.lb_tongno);
            this.groupBox4.Controls.Add(this.lb_tongthu);
            this.groupBox4.Location = new System.Drawing.Point(798, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(413, 53);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // lb_sohv
            // 
            this.lb_sohv.AutoSize = true;
            this.lb_sohv.Location = new System.Drawing.Point(6, 18);
            this.lb_sohv.Name = "lb_sohv";
            this.lb_sohv.Size = new System.Drawing.Size(52, 17);
            this.lb_sohv.TabIndex = 0;
            this.lb_sohv.Text = "Số HV:";
            this.lb_sohv.Visible = false;
            // 
            // lb_tongphi
            // 
            this.lb_tongphi.AutoSize = true;
            this.lb_tongphi.Location = new System.Drawing.Point(113, 17);
            this.lb_tongphi.Name = "lb_tongphi";
            this.lb_tongphi.Size = new System.Drawing.Size(68, 17);
            this.lb_tongphi.TabIndex = 1;
            this.lb_tongphi.Text = "Tổng phí:";
            this.lb_tongphi.Visible = false;
            // 
            // lb_tongthu
            // 
            this.lb_tongthu.AutoSize = true;
            this.lb_tongthu.Location = new System.Drawing.Point(16, 17);
            this.lb_tongthu.Name = "lb_tongthu";
            this.lb_tongthu.Size = new System.Drawing.Size(69, 17);
            this.lb_tongthu.TabIndex = 0;
            this.lb_tongthu.Text = "Tổng thu:";
            this.lb_tongthu.Visible = false;
            // 
            // lb_tongno
            // 
            this.lb_tongno.AutoSize = true;
            this.lb_tongno.Location = new System.Drawing.Point(212, 17);
            this.lb_tongno.Name = "lb_tongno";
            this.lb_tongno.Size = new System.Drawing.Size(65, 17);
            this.lb_tongno.TabIndex = 1;
            this.lb_tongno.Text = "Tổng nợ:";
            this.lb_tongno.Visible = false;
            // 
            // tb_soHV
            // 
            this.tb_soHV.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.tb_soHV.Location = new System.Drawing.Point(65, 15);
            this.tb_soHV.Name = "tb_soHV";
            this.tb_soHV.ReadOnly = true;
            this.tb_soHV.Size = new System.Drawing.Size(42, 22);
            this.tb_soHV.TabIndex = 2;
            this.tb_soHV.Visible = false;
            // 
            // tb_tongPhi
            // 
            this.tb_tongPhi.ForeColor = System.Drawing.Color.Lime;
            this.tb_tongPhi.Location = new System.Drawing.Point(188, 18);
            this.tb_tongPhi.Name = "tb_tongPhi";
            this.tb_tongPhi.ReadOnly = true;
            this.tb_tongPhi.Size = new System.Drawing.Size(216, 22);
            this.tb_tongPhi.TabIndex = 3;
            this.tb_tongPhi.Visible = false;
            // 
            // tb_tongThu
            // 
            this.tb_tongThu.ForeColor = System.Drawing.Color.Navy;
            this.tb_tongThu.Location = new System.Drawing.Point(91, 16);
            this.tb_tongThu.Name = "tb_tongThu";
            this.tb_tongThu.ReadOnly = true;
            this.tb_tongThu.Size = new System.Drawing.Size(115, 22);
            this.tb_tongThu.TabIndex = 2;
            this.tb_tongThu.Visible = false;
            // 
            // tb_Tongno
            // 
            this.tb_Tongno.ForeColor = System.Drawing.Color.Red;
            this.tb_Tongno.Location = new System.Drawing.Point(284, 16);
            this.tb_Tongno.Name = "tb_Tongno";
            this.tb_Tongno.ReadOnly = true;
            this.tb_Tongno.Size = new System.Drawing.Size(100, 22);
            this.tb_Tongno.TabIndex = 3;
            this.tb_Tongno.Visible = false;
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
            // nop1
            // 
            this.nop1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nop1.DataPropertyName = "nop1";
            dataGridViewCellStyle1.NullValue = null;
            this.nop1.DefaultCellStyle = dataGridViewCellStyle1;
            this.nop1.HeaderText = "Nộp lần 1";
            this.nop1.MaxInputLength = 10;
            this.nop1.MinimumWidth = 6;
            this.nop1.Name = "nop1";
            // 
            // date1
            // 
            this.date1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date1.DataPropertyName = "Date1";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.date1.DefaultCellStyle = dataGridViewCellStyle2;
            this.date1.HeaderText = "Ngày nộp lần 1";
            this.date1.MinimumWidth = 6;
            this.date1.Name = "date1";
            this.date1.ReadOnly = true;
            // 
            // nop2
            // 
            this.nop2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nop2.DataPropertyName = "nop2";
            dataGridViewCellStyle3.NullValue = null;
            this.nop2.DefaultCellStyle = dataGridViewCellStyle3;
            this.nop2.HeaderText = "Nộp lần 2";
            this.nop2.MaxInputLength = 10;
            this.nop2.MinimumWidth = 6;
            this.nop2.Name = "nop2";
            // 
            // date2
            // 
            this.date2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date2.DataPropertyName = "date2";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.date2.DefaultCellStyle = dataGridViewCellStyle4;
            this.date2.HeaderText = "Ngày nộp lần 2";
            this.date2.MaxInputLength = 4;
            this.date2.MinimumWidth = 6;
            this.date2.Name = "date2";
            // 
            // complete
            // 
            this.complete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.complete.DataPropertyName = "complete";
            dataGridViewCellStyle5.NullValue = null;
            this.complete.DefaultCellStyle = dataGridViewCellStyle5;
            this.complete.HeaderText = "Hoàn thành";
            this.complete.MaxInputLength = 8;
            this.complete.MinimumWidth = 6;
            this.complete.Name = "complete";
            this.complete.ReadOnly = true;
            // 
            // conno
            // 
            this.conno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.conno.DataPropertyName = "conno";
            dataGridViewCellStyle6.NullValue = null;
            this.conno.DefaultCellStyle = dataGridViewCellStyle6;
            this.conno.HeaderText = "Còn nợ";
            this.conno.MaxInputLength = 8;
            this.conno.MinimumWidth = 6;
            this.conno.Name = "conno";
            this.conno.ReadOnly = true;
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
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocPhi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_hocphi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgv_HocPhi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_Tongno;
        private System.Windows.Forms.TextBox tb_tongThu;
        private System.Windows.Forms.Label lb_tongno;
        private System.Windows.Forms.Label lb_tongthu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_tongPhi;
        private System.Windows.Forms.TextBox tb_soHV;
        private System.Windows.Forms.Label lb_tongphi;
        private System.Windows.Forms.Label lb_sohv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nop1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nop2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn complete;
        private System.Windows.Forms.DataGridViewTextBoxColumn conno;
    }
}