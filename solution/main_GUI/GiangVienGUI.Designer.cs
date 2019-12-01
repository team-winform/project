namespace main_GUI
{
    partial class GiangVienGUI
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
            this.dgv_GV = new System.Windows.Forms.DataGridView();
            this.id_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu_GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv_GV.Size = new System.Drawing.Size(1030, 450);
            this.dgv_GV.TabIndex = 0;
            this.dgv_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgv_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellDoubleClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_tim);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 92);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // bt_tim
            // 
            this.bt_tim.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_tim.Location = new System.Drawing.Point(876, 25);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(109, 44);
            this.bt_tim.TabIndex = 3;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.Bt_tim_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_xoa.Location = new System.Drawing.Point(596, 25);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(109, 44);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.Bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_sua.Location = new System.Drawing.Point(316, 25);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(109, 44);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.Bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_them.Location = new System.Drawing.Point(36, 25);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(109, 44);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.Bt_them_Click);
            // 
            // GiangVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_GV);
            this.Name = "GiangVienGUI";
            this.Text = "GiangVienGUI";
            this.Load += new System.EventHandler(this.GiangVienGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_GV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu_GV;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
    }
}