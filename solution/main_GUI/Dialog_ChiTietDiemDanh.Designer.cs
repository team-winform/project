namespace main_GUI
{
    partial class Dialog_ChiTietDiemDanh
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ten_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_LH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydiemdanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết điểm danh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten_HV,
            this.id_HV,
            this.id_LH,
            this.ngaydiemdanh});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 510);
            this.dataGridView1.TabIndex = 1;
            // 
            // ten_HV
            // 
            this.ten_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_HV.DataPropertyName = "ten_HV";
            this.ten_HV.HeaderText = "Tên học viên";
            this.ten_HV.MinimumWidth = 6;
            this.ten_HV.Name = "ten_HV";
            this.ten_HV.ReadOnly = true;
            // 
            // id_HV
            // 
            this.id_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_HV.DataPropertyName = "id_HV";
            this.id_HV.HeaderText = "Mã học viên";
            this.id_HV.MinimumWidth = 6;
            this.id_HV.Name = "id_HV";
            this.id_HV.ReadOnly = true;
            // 
            // id_LH
            // 
            this.id_LH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_LH.DataPropertyName = "ten_LH";
            this.id_LH.HeaderText = "Tên lớp học";
            this.id_LH.MinimumWidth = 6;
            this.id_LH.Name = "id_LH";
            this.id_LH.ReadOnly = true;
            // 
            // ngaydiemdanh
            // 
            this.ngaydiemdanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaydiemdanh.DataPropertyName = "ngayDiemDanh";
            this.ngaydiemdanh.HeaderText = "Ngày điểm danh";
            this.ngaydiemdanh.MinimumWidth = 6;
            this.ngaydiemdanh.Name = "ngaydiemdanh";
            this.ngaydiemdanh.ReadOnly = true;
            // 
            // Dialog_ChiTietDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Dialog_ChiTietDiemDanh";
            this.Text = "Dialog_ChiTietDiemDanh";
            this.Load += new System.EventHandler(this.Dialog_ChiTietDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_LH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydiemdanh;
    }
}