namespace main_GUI
{
    partial class Dialog_LichHoc
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
            this.lbTenLop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTenPH = new System.Windows.Forms.Label();
            this.lbTenGV = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.grdLichHoc = new System.Windows.Forms.DataGridView();
            this.week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbThoiGian = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLichHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLop.Location = new System.Drawing.Point(365, 33);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(68, 20);
            this.lbTenLop.TabIndex = 0;
            this.lbTenLop.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảng viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thứ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời gian:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Từ ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đến ngày:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mã lớp:";
            // 
            // lbTenPH
            // 
            this.lbTenPH.AutoSize = true;
            this.lbTenPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenPH.Location = new System.Drawing.Point(164, 82);
            this.lbTenPH.Name = "lbTenPH";
            this.lbTenPH.Size = new System.Drawing.Size(45, 16);
            this.lbTenPH.TabIndex = 9;
            this.lbTenPH.Text = "label9";
            // 
            // lbTenGV
            // 
            this.lbTenGV.AutoSize = true;
            this.lbTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenGV.Location = new System.Drawing.Point(163, 108);
            this.lbTenGV.Name = "lbTenGV";
            this.lbTenGV.Size = new System.Drawing.Size(52, 16);
            this.lbTenGV.TabIndex = 10;
            this.lbTenGV.Text = "label10";
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThu.Location = new System.Drawing.Point(413, 82);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(52, 16);
            this.lbThu.TabIndex = 11;
            this.lbThu.Text = "label11";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(413, 108);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(52, 16);
            this.lbThoiGian.TabIndex = 12;
            this.lbThoiGian.Text = "label12";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(641, 82);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(52, 16);
            this.lbFrom.TabIndex = 13;
            this.lbFrom.Text = "label13";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(641, 108);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(52, 16);
            this.lbTo.TabIndex = 14;
            this.lbTo.Text = "label14";
            // 
            // grdLichHoc
            // 
            this.grdLichHoc.AllowUserToAddRows = false;
            this.grdLichHoc.AllowUserToDeleteRows = false;
            this.grdLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLichHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.week,
            this.from,
            this.to,
            this.mon,
            this.tue,
            this.wed,
            this.thu,
            this.fri,
            this.sat,
            this.sun});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLichHoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdLichHoc.Location = new System.Drawing.Point(33, 175);
            this.grdLichHoc.Name = "grdLichHoc";
            this.grdLichHoc.RowHeadersVisible = false;
            this.grdLichHoc.Size = new System.Drawing.Size(793, 254);
            this.grdLichHoc.TabIndex = 15;
            // 
            // week
            // 
            this.week.HeaderText = "W";
            this.week.Name = "week";
            this.week.Width = 30;
            // 
            // from
            // 
            this.from.HeaderText = "Từ ngày";
            this.from.Name = "from";
            // 
            // to
            // 
            this.to.HeaderText = "Đến ngày";
            this.to.Name = "to";
            // 
            // mon
            // 
            this.mon.HeaderText = "Mon";
            this.mon.Name = "mon";
            this.mon.Width = 80;
            // 
            // tue
            // 
            this.tue.HeaderText = "Tue";
            this.tue.Name = "tue";
            this.tue.Width = 80;
            // 
            // wed
            // 
            this.wed.HeaderText = "Wed";
            this.wed.Name = "wed";
            this.wed.Width = 80;
            // 
            // thu
            // 
            this.thu.HeaderText = "Thu";
            this.thu.Name = "thu";
            this.thu.Width = 80;
            // 
            // fri
            // 
            this.fri.HeaderText = "Fri";
            this.fri.Name = "fri";
            this.fri.Width = 80;
            // 
            // sat
            // 
            this.sat.HeaderText = "Sat";
            this.sat.Name = "sat";
            this.sat.Width = 80;
            // 
            // sun
            // 
            this.sun.HeaderText = "Sun";
            this.sun.Name = "sun";
            this.sun.Width = 80;
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.Location = new System.Drawing.Point(106, 143);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(121, 24);
            this.cbThoiGian.TabIndex = 16;
            this.cbThoiGian.SelectedIndexChanged += new System.EventHandler(this.cbThoiGian_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thời gian";
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(390, 447);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 28);
            this.btLuu.TabIndex = 18;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(93, 20);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(45, 15);
            this.lbMaLop.TabIndex = 19;
            this.lbMaLop.Text = "Mã lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(711, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(752, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Phòng học bận";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(33, 447);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(75, 29);
            this.btExport.TabIndex = 22;
            this.btExport.Text = "Xuất PDF";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // Dialog_LichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 485);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbThoiGian);
            this.Controls.Add(this.grdLichHoc);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbThoiGian);
            this.Controls.Add(this.lbThu);
            this.Controls.Add(this.lbTenGV);
            this.Controls.Add(this.lbTenPH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTenLop);
            this.Name = "Dialog_LichHoc";
            this.Text = "Dialog_LichHoc";
            this.Load += new System.EventHandler(this.Dialog_LichHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLichHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTenPH;
        private System.Windows.Forms.Label lbTenGV;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.DataGridView grdLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn week;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tue;
        private System.Windows.Forms.DataGridViewTextBoxColumn wed;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fri;
        private System.Windows.Forms.DataGridViewTextBoxColumn sat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sun;
        private System.Windows.Forms.ComboBox cbThoiGian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btExport;
    }
}