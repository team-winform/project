namespace main_GUI
{
    partial class GiangVienDialog_chiTiet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_classList = new System.Windows.Forms.DataGridView();
            this.id_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi tiết giảng viên";
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(3, 3);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(101, 38);
            this.bt_back.TabIndex = 2;
            this.bt_back.Text = "Quay lại";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tb_note);
            this.panel2.Controls.Add(this.tb_address);
            this.panel2.Controls.Add(this.tb_sdt);
            this.panel2.Controls.Add(this.tb_date);
            this.panel2.Controls.Add(this.tb_ten);
            this.panel2.Controls.Add(this.tb_ma);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 200);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Các lớp đang dạy";
            // 
            // tb_note
            // 
            this.tb_note.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_note.Enabled = false;
            this.tb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_note.Location = new System.Drawing.Point(799, 121);
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(189, 30);
            this.tb_note.TabIndex = 11;
            // 
            // tb_address
            // 
            this.tb_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_address.Enabled = false;
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(799, 67);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(189, 30);
            this.tb_address.TabIndex = 10;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_sdt.Enabled = false;
            this.tb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(799, 13);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(189, 30);
            this.tb_sdt.TabIndex = 9;
            // 
            // tb_date
            // 
            this.tb_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_date.Enabled = false;
            this.tb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_date.Location = new System.Drawing.Point(390, 122);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(180, 30);
            this.tb_date.TabIndex = 8;
            // 
            // tb_ten
            // 
            this.tb_ten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_ten.Enabled = false;
            this.tb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten.Location = new System.Drawing.Point(390, 69);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(180, 30);
            this.tb_ten.TabIndex = 7;
            // 
            // tb_ma
            // 
            this.tb_ma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_ma.Enabled = false;
            this.tb_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ma.Location = new System.Drawing.Point(390, 16);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(180, 30);
            this.tb_ma.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(702, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(694, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên giảng viên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã giảng viên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_classList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1251, 210);
            this.panel3.TabIndex = 2;
            // 
            // dgv_classList
            // 
            this.dgv_classList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_classList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_LH,
            this.ten_LH,
            this.ten_PH,
            this.ten_KH,
            this.siso,
            this.ngaybatdau,
            this.ngayketthuc});
            this.dgv_classList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_classList.Location = new System.Drawing.Point(0, 0);
            this.dgv_classList.Name = "dgv_classList";
            this.dgv_classList.RowHeadersWidth = 51;
            this.dgv_classList.RowTemplate.Height = 24;
            this.dgv_classList.Size = new System.Drawing.Size(1251, 210);
            this.dgv_classList.TabIndex = 0;
            // 
            // id_LH
            // 
            this.id_LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_LH.DataPropertyName = "id_LH";
            this.id_LH.HeaderText = "Mã lớp";
            this.id_LH.MinimumWidth = 6;
            this.id_LH.Name = "id_LH";
            // 
            // ten_LH
            // 
            this.ten_LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_LH.DataPropertyName = "ten_LH";
            this.ten_LH.HeaderText = "Tên lớp";
            this.ten_LH.MinimumWidth = 6;
            this.ten_LH.Name = "ten_LH";
            // 
            // ten_PH
            // 
            this.ten_PH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_PH.DataPropertyName = "ten_PH";
            this.ten_PH.HeaderText = "Phòng học";
            this.ten_PH.MinimumWidth = 6;
            this.ten_PH.Name = "ten_PH";
            // 
            // ten_KH
            // 
            this.ten_KH.DataPropertyName = "ten_KH";
            this.ten_KH.HeaderText = "Khóa học";
            this.ten_KH.MinimumWidth = 6;
            this.ten_KH.Name = "ten_KH";
            this.ten_KH.Width = 125;
            // 
            // siso
            // 
            this.siso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siso.DataPropertyName = "siSo";
            this.siso.HeaderText = "Sĩ số";
            this.siso.MinimumWidth = 6;
            this.siso.Name = "siso";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaybatdau.DataPropertyName = "ngayBatDau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.MinimumWidth = 6;
            this.ngaybatdau.Name = "ngaybatdau";
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayketthuc.DataPropertyName = "ngayKetThuc";
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.MinimumWidth = 6;
            this.ngayketthuc.Name = "ngayketthuc";
            // 
            // GiangVienDialog_chiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 472);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GiangVienDialog_chiTiet";
            this.Text = "GiangVienDialog_chiTiet";
            this.Load += new System.EventHandler(this.GiangVienDialog_chiTiet_Load);
            this.Leave += new System.EventHandler(this.GiangVienDialog_chiTiet_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_classList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_classList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
    }
}