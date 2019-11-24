namespace main_GUI
{
    partial class Dialog_ThongTinKhoaHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siso_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1124, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách lớp học của khóa:  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 420);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_LH,
            this.ten_LH,
            this.ten_GV,
            this.siso_LH,
            this.ngaybatdau,
            this.ngayketthuc,
            this.ghichu_LH});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_LH
            // 
            this.id_LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_LH.DataPropertyName = "id_LH";
            this.id_LH.HeaderText = "Mã lớp";
            this.id_LH.MinimumWidth = 6;
            this.id_LH.Name = "id_LH";
            this.id_LH.ReadOnly = true;
            // 
            // ten_LH
            // 
            this.ten_LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_LH.DataPropertyName = "ten_LH";
            this.ten_LH.HeaderText = "Tên lớp";
            this.ten_LH.MinimumWidth = 6;
            this.ten_LH.Name = "ten_LH";
            this.ten_LH.ReadOnly = true;
            // 
            // ten_GV
            // 
            this.ten_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_GV.DataPropertyName = "ten_GV";
            this.ten_GV.HeaderText = "Tên giảng viên";
            this.ten_GV.MinimumWidth = 6;
            this.ten_GV.Name = "ten_GV";
            this.ten_GV.ReadOnly = true;
            // 
            // siso_LH
            // 
            this.siso_LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siso_LH.DataPropertyName = "siso_LH";
            this.siso_LH.HeaderText = "Sĩ số";
            this.siso_LH.MinimumWidth = 6;
            this.siso_LH.Name = "siso_LH";
            this.siso_LH.ReadOnly = true;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.MinimumWidth = 6;
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.ReadOnly = true;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayketthuc.DataPropertyName = "ngayketthuc";
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.MinimumWidth = 6;
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.ReadOnly = true;
            // 
            // ghichu_LH
            // 
            this.ghichu_LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu_LH.DataPropertyName = "ghichu_LH";
            this.ghichu_LH.HeaderText = "Ghi chú";
            this.ghichu_LH.MinimumWidth = 6;
            this.ghichu_LH.Name = "ghichu_LH";
            this.ghichu_LH.ReadOnly = true;
            // 
            // Dialog_ThongTinKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 493);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Dialog_ThongTinKhoaHoc";
            this.Text = "Dialog_ThongTinKhoaHoc";
            this.Load += new System.EventHandler(this.Dialog_ThongTinKhoaHoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn siso_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu_LH;
    }
}