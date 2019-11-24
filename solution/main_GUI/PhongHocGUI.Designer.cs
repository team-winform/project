namespace main_GUI
{
    partial class PhongHocGUI
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
            this.dgv_ph = new System.Windows.Forms.DataGridView();
            this.id_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.succhua_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ph)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ph
            // 
            this.dgv_ph.AllowUserToAddRows = false;
            this.dgv_ph.AllowUserToDeleteRows = false;
            this.dgv_ph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_PH,
            this.ten_PH,
            this.succhua_PH,
            this.ghichu_PH,
            this.ngaytao,
            this.ngaysua});
            this.dgv_ph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ph.Location = new System.Drawing.Point(0, 0);
            this.dgv_ph.Name = "dgv_ph";
            this.dgv_ph.ReadOnly = true;
            this.dgv_ph.RowHeadersWidth = 51;
            this.dgv_ph.RowTemplate.Height = 24;
            this.dgv_ph.Size = new System.Drawing.Size(1167, 534);
            this.dgv_ph.TabIndex = 0;
            // 
            // id_PH
            // 
            this.id_PH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_PH.DataPropertyName = "id";
            this.id_PH.HeaderText = "Mã phòng";
            this.id_PH.MinimumWidth = 6;
            this.id_PH.Name = "id_PH";
            this.id_PH.ReadOnly = true;
            // 
            // ten_PH
            // 
            this.ten_PH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_PH.DataPropertyName = "name";
            this.ten_PH.HeaderText = "Tên phòng";
            this.ten_PH.MinimumWidth = 6;
            this.ten_PH.Name = "ten_PH";
            this.ten_PH.ReadOnly = true;
            // 
            // succhua_PH
            // 
            this.succhua_PH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.succhua_PH.DataPropertyName = "maxSeat";
            this.succhua_PH.HeaderText = "Sức chứa";
            this.succhua_PH.MinimumWidth = 6;
            this.succhua_PH.Name = "succhua_PH";
            this.succhua_PH.ReadOnly = true;
            // 
            // ghichu_PH
            // 
            this.ghichu_PH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghichu_PH.DataPropertyName = "note";
            this.ghichu_PH.HeaderText = "Ghi chú";
            this.ghichu_PH.MinimumWidth = 6;
            this.ghichu_PH.Name = "ghichu_PH";
            this.ghichu_PH.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_tim);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 100);
            this.panel1.TabIndex = 1;
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Location = new System.Drawing.Point(943, 24);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(111, 40);
            this.bt_tim.TabIndex = 3;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.Bt_tim_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(689, 24);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(111, 40);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.Bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(435, 24);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(111, 40);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.Bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(181, 24);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(111, 40);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.Bt_them_Click);
            // 
            // PhongHocGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_ph);
            this.Name = "PhongHocGUI";
            this.Text = "PhongHocGUI";
            this.Load += new System.EventHandler(this.PhongHocGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ph)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn succhua_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysua;
    }
}