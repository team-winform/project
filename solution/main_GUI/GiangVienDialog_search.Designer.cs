namespace main_GUI
{
    partial class GiangVienDialog_search
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.dgv_GV = new System.Windows.Forms.DataGridView();
            this.id_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_tim = new System.Windows.Forms.Button();
            this.tb_gv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_loaitk = new System.Windows.Forms.ComboBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgv_GV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 447);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_xoa);
            this.panel2.Controls.Add(this.bt_sua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 61);
            this.panel2.TabIndex = 2;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_xoa.Location = new System.Drawing.Point(638, 8);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(109, 44);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.Bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_sua.Location = new System.Drawing.Point(358, 8);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(109, 44);
            this.bt_sua.TabIndex = 5;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.Bt_sua_Click);
            // 
            // dgv_GV
            // 
            this.dgv_GV.AllowUserToAddRows = false;
            this.dgv_GV.AllowUserToDeleteRows = false;
            this.dgv_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_GV,
            this.ten_GV,
            this.ngaysinh_GV,
            this.sodt_GV,
            this.diachi_GV,
            this.ngaytao,
            this.ngaysua,
            this.ghichu_GV});
            this.dgv_GV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_GV.Location = new System.Drawing.Point(0, 0);
            this.dgv_GV.Name = "dgv_GV";
            this.dgv_GV.ReadOnly = true;
            this.dgv_GV.RowHeadersWidth = 51;
            this.dgv_GV.RowTemplate.Height = 24;
            this.dgv_GV.Size = new System.Drawing.Size(1104, 447);
            this.dgv_GV.TabIndex = 1;
            // 
            // id_GV
            // 
            this.id_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_GV.DataPropertyName = "id";
            this.id_GV.HeaderText = "Mã giảng viên";
            this.id_GV.MinimumWidth = 6;
            this.id_GV.Name = "id_GV";
            this.id_GV.ReadOnly = true;
            // 
            // ten_GV
            // 
            this.ten_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_GV.DataPropertyName = "name";
            this.ten_GV.HeaderText = "Tên giảng viên";
            this.ten_GV.MinimumWidth = 6;
            this.ten_GV.Name = "ten_GV";
            this.ten_GV.ReadOnly = true;
            // 
            // ngaysinh_GV
            // 
            this.ngaysinh_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysinh_GV.DataPropertyName = "dayOfBirth";
            this.ngaysinh_GV.HeaderText = "Ngày sinh";
            this.ngaysinh_GV.MinimumWidth = 6;
            this.ngaysinh_GV.Name = "ngaysinh_GV";
            this.ngaysinh_GV.ReadOnly = true;
            // 
            // sodt_GV
            // 
            this.sodt_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sodt_GV.DataPropertyName = "phone";
            this.sodt_GV.HeaderText = "Số điện thoại";
            this.sodt_GV.MinimumWidth = 6;
            this.sodt_GV.Name = "sodt_GV";
            this.sodt_GV.ReadOnly = true;
            // 
            // diachi_GV
            // 
            this.diachi_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi_GV.DataPropertyName = "address";
            this.diachi_GV.HeaderText = "Địa chỉ";
            this.diachi_GV.MinimumWidth = 6;
            this.diachi_GV.Name = "diachi_GV";
            this.diachi_GV.ReadOnly = true;
            // 
            // ngaytao
            // 
            this.ngaytao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaytao.DataPropertyName = "created";
            this.ngaytao.HeaderText = "Ngày tạo";
            this.ngaytao.MinimumWidth = 6;
            this.ngaytao.Name = "ngaytao";
            this.ngaytao.ReadOnly = true;
            // 
            // ngaysua
            // 
            this.ngaysua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysua.DataPropertyName = "updated";
            this.ngaysua.HeaderText = "Ngày sửa";
            this.ngaysua.MinimumWidth = 6;
            this.ngaysua.Name = "ngaysua";
            this.ngaysua.ReadOnly = true;
            // 
            // ghichu_GV
            // 
            this.ghichu_GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu_GV.DataPropertyName = "note";
            this.ghichu_GV.HeaderText = "Ghi chú";
            this.ghichu_GV.MinimumWidth = 6;
            this.ghichu_GV.Name = "ghichu_GV";
            this.ghichu_GV.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_tim);
            this.panel3.Controls.Add(this.tb_gv);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cb_loaitk);
            this.panel3.Controls.Add(this.bt_back);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 172);
            this.panel3.TabIndex = 7;
            // 
            // bt_tim
            // 
            this.bt_tim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_tim.Location = new System.Drawing.Point(879, 128);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(112, 36);
            this.bt_tim.TabIndex = 9;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.Bt_tim_Click_1);
            // 
            // tb_gv
            // 
            this.tb_gv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_gv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gv.Location = new System.Drawing.Point(395, 131);
            this.tb_gv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_gv.Name = "tb_gv";
            this.tb_gv.Size = new System.Drawing.Size(427, 34);
            this.tb_gv.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm giảng viên";
            // 
            // cb_loaitk
            // 
            this.cb_loaitk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_loaitk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_loaitk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_loaitk.FormattingEnabled = true;
            this.cb_loaitk.Items.AddRange(new object[] {
            "Theo mã",
            "Theo tên"});
            this.cb_loaitk.Location = new System.Drawing.Point(172, 128);
            this.cb_loaitk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_loaitk.Name = "cb_loaitk";
            this.cb_loaitk.Size = new System.Drawing.Size(180, 33);
            this.cb_loaitk.TabIndex = 6;
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(28, 14);
            this.bt_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(112, 36);
            this.bt_back.TabIndex = 5;
            this.bt_back.Text = "Quay lại";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // GiangVienDialog_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GiangVienDialog_search";
            this.Text = "GiangVienDialog_search";
            this.Load += new System.EventHandler(this.GiangVienDialog_search_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu_GV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox tb_gv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_loaitk;
        private System.Windows.Forms.Button bt_back;
    }
}