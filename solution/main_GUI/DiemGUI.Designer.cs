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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_listClass = new System.Windows.Forms.ComboBox();
            this.bt_selectLop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_nhapDiem = new System.Windows.Forms.Button();
            this.bt_suaDiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ten_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem_do_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xet_tot_nghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu_HVLH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa chọn lớp:";
            // 
            // cb_listClass
            // 
            this.cb_listClass.FormattingEnabled = true;
            this.cb_listClass.Location = new System.Drawing.Point(138, 47);
            this.cb_listClass.Name = "cb_listClass";
            this.cb_listClass.Size = new System.Drawing.Size(121, 24);
            this.cb_listClass.TabIndex = 1;
            // 
            // bt_selectLop
            // 
            this.bt_selectLop.Location = new System.Drawing.Point(311, 47);
            this.bt_selectLop.Name = "bt_selectLop";
            this.bt_selectLop.Size = new System.Drawing.Size(75, 23);
            this.bt_selectLop.TabIndex = 2;
            this.bt_selectLop.Text = "Chọn";
            this.bt_selectLop.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_selectLop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_listClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_suaDiem);
            this.panel2.Controls.Add(this.bt_nhapDiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 72);
            this.panel2.TabIndex = 4;
            // 
            // bt_nhapDiem
            // 
            this.bt_nhapDiem.Location = new System.Drawing.Point(327, 20);
            this.bt_nhapDiem.Name = "bt_nhapDiem";
            this.bt_nhapDiem.Size = new System.Drawing.Size(75, 23);
            this.bt_nhapDiem.TabIndex = 0;
            this.bt_nhapDiem.Text = "Nhập điểm";
            this.bt_nhapDiem.UseVisualStyleBackColor = true;
            // 
            // bt_suaDiem
            // 
            this.bt_suaDiem.Location = new System.Drawing.Point(695, 20);
            this.bt_suaDiem.Name = "bt_suaDiem";
            this.bt_suaDiem.Size = new System.Drawing.Size(75, 23);
            this.bt_suaDiem.TabIndex = 1;
            this.bt_suaDiem.Text = "Sửa điểm";
            this.bt_suaDiem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten_LH,
            this.ten_HV,
            this.diem_1,
            this.diem_2,
            this.danhgia,
            this.diem_do_an,
            this.xet_tot_nghiep,
            this.xeploai,
            this.ghichu_HVLH});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 356);
            this.dataGridView1.TabIndex = 5;
            // 
            // ten_LH
            // 
            this.ten_LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_LH.HeaderText = "Tên lớp";
            this.ten_LH.MinimumWidth = 6;
            this.ten_LH.Name = "ten_LH";
            // 
            // ten_HV
            // 
            this.ten_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_HV.HeaderText = "Tên học viên";
            this.ten_HV.MinimumWidth = 6;
            this.ten_HV.Name = "ten_HV";
            // 
            // diem_1
            // 
            this.diem_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diem_1.HeaderText = "Điểm 1";
            this.diem_1.MinimumWidth = 6;
            this.diem_1.Name = "diem_1";
            // 
            // diem_2
            // 
            this.diem_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diem_2.HeaderText = "Điểm 2";
            this.diem_2.MinimumWidth = 6;
            this.diem_2.Name = "diem_2";
            // 
            // danhgia
            // 
            this.danhgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.danhgia.HeaderText = "Đánh giá";
            this.danhgia.MinimumWidth = 6;
            this.danhgia.Name = "danhgia";
            // 
            // diem_do_an
            // 
            this.diem_do_an.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diem_do_an.HeaderText = "Điểm đồ án";
            this.diem_do_an.MinimumWidth = 6;
            this.diem_do_an.Name = "diem_do_an";
            // 
            // xet_tot_nghiep
            // 
            this.xet_tot_nghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xet_tot_nghiep.HeaderText = "Tốt nghiệp";
            this.xet_tot_nghiep.MinimumWidth = 6;
            this.xet_tot_nghiep.Name = "xet_tot_nghiep";
            // 
            // xeploai
            // 
            this.xeploai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.MinimumWidth = 6;
            this.xeploai.Name = "xeploai";
            // 
            // ghichu_HVLH
            // 
            this.ghichu_HVLH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu_HVLH.HeaderText = "Ghi chú";
            this.ghichu_HVLH.MinimumWidth = 6;
            this.ghichu_HVLH.Name = "ghichu_HVLH";
            // 
            // DiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DiemGUI";
            this.Text = "DiemGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_listClass;
        private System.Windows.Forms.Button bt_selectLop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_suaDiem;
        private System.Windows.Forms.Button bt_nhapDiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_LH;
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