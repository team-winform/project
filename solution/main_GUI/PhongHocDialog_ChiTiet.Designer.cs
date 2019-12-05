namespace main_GUI
{
    partial class PhongHocDialog_ChiTiet
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_gc = new System.Windows.Forms.TextBox();
            this.tb_updated = new System.Windows.Forms.TextBox();
            this.tb_created = new System.Windows.Forms.TextBox();
            this.tb_sc = new System.Windows.Forms.TextBox();
            this.tb_tp = new System.Windows.Forms.TextBox();
            this.tb_maP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_LH = new System.Windows.Forms.DataGridView();
            this.id_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết phòng học";
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(3, 0);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(102, 43);
            this.bt_back.TabIndex = 0;
            this.bt_back.Text = "Quay lại";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_LH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 200);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tb_gc);
            this.panel3.Controls.Add(this.tb_updated);
            this.panel3.Controls.Add(this.tb_created);
            this.panel3.Controls.Add(this.tb_sc);
            this.panel3.Controls.Add(this.tb_tp);
            this.panel3.Controls.Add(this.tb_maP);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1146, 255);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Các lớp đang sử dụng";
            // 
            // tb_gc
            // 
            this.tb_gc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_gc.Enabled = false;
            this.tb_gc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gc.Location = new System.Drawing.Point(732, 140);
            this.tb_gc.Name = "tb_gc";
            this.tb_gc.Size = new System.Drawing.Size(254, 30);
            this.tb_gc.TabIndex = 11;
            // 
            // tb_updated
            // 
            this.tb_updated.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_updated.Enabled = false;
            this.tb_updated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_updated.Location = new System.Drawing.Point(732, 86);
            this.tb_updated.Name = "tb_updated";
            this.tb_updated.Size = new System.Drawing.Size(254, 30);
            this.tb_updated.TabIndex = 10;
            // 
            // tb_created
            // 
            this.tb_created.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_created.Enabled = false;
            this.tb_created.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_created.Location = new System.Drawing.Point(732, 37);
            this.tb_created.Name = "tb_created";
            this.tb_created.Size = new System.Drawing.Size(254, 30);
            this.tb_created.TabIndex = 9;
            // 
            // tb_sc
            // 
            this.tb_sc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_sc.Enabled = false;
            this.tb_sc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sc.Location = new System.Drawing.Point(284, 145);
            this.tb_sc.Name = "tb_sc";
            this.tb_sc.Size = new System.Drawing.Size(254, 30);
            this.tb_sc.TabIndex = 8;
            // 
            // tb_tp
            // 
            this.tb_tp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_tp.Enabled = false;
            this.tb_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tp.Location = new System.Drawing.Point(284, 88);
            this.tb_tp.Name = "tb_tp";
            this.tb_tp.Size = new System.Drawing.Size(254, 30);
            this.tb_tp.TabIndex = 7;
            // 
            // tb_maP
            // 
            this.tb_maP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_maP.Enabled = false;
            this.tb_maP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maP.Location = new System.Drawing.Point(284, 29);
            this.tb_maP.Name = "tb_maP";
            this.tb_maP.Size = new System.Drawing.Size(254, 30);
            this.tb_maP.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên phòng:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(628, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(617, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày sửa:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(620, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày tạo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sức chứa:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng:";
            // 
            // dgv_LH
            // 
            this.dgv_LH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_LH,
            this.ten_LH,
            this.ten_KH,
            this.ten_GV,
            this.siSo,
            this.ngaybatdau,
            this.ngayketthuc});
            this.dgv_LH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LH.Location = new System.Drawing.Point(0, 0);
            this.dgv_LH.Name = "dgv_LH";
            this.dgv_LH.RowHeadersWidth = 51;
            this.dgv_LH.RowTemplate.Height = 24;
            this.dgv_LH.Size = new System.Drawing.Size(1146, 200);
            this.dgv_LH.TabIndex = 0;
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
            // ten_KH
            // 
            this.ten_KH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_KH.DataPropertyName = "ten_KH";
            this.ten_KH.HeaderText = "Khóa học";
            this.ten_KH.MinimumWidth = 6;
            this.ten_KH.Name = "ten_KH";
            // 
            // ten_GV
            // 
            this.ten_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_GV.DataPropertyName = "ten_GV";
            this.ten_GV.HeaderText = "Tên giảng viên";
            this.ten_GV.MinimumWidth = 6;
            this.ten_GV.Name = "ten_GV";
            // 
            // siSo
            // 
            this.siSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siSo.DataPropertyName = "siSo";
            this.siSo.HeaderText = "Sĩ số";
            this.siSo.MinimumWidth = 6;
            this.siSo.Name = "siSo";
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
            // PhongHocDialog_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 519);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhongHocDialog_ChiTiet";
            this.Text = "PhongHocDialog_ChiTiet";
            this.Load += new System.EventHandler(this.PhongHocDialog_ChiTiet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_gc;
        private System.Windows.Forms.TextBox tb_updated;
        private System.Windows.Forms.TextBox tb_created;
        private System.Windows.Forms.TextBox tb_sc;
        private System.Windows.Forms.TextBox tb_tp;
        private System.Windows.Forms.TextBox tb_maP;
        private System.Windows.Forms.DataGridView dgv_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn siSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
    }
}