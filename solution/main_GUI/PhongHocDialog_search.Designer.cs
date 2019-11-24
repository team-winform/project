namespace main_GUI
{
    partial class PhongHocDialog_search
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
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_tim = new System.Windows.Forms.Button();
            this.cb_loai = new System.Windows.Forms.ComboBox();
            this.tb_ph = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.dgv_ph = new System.Windows.Forms.DataGridView();
            this.id_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.succhua_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu_PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ph)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_ph);
            this.panel1.Controls.Add(this.cb_loai);
            this.panel1.Controls.Add(this.bt_tim);
            this.panel1.Controls.Add(this.bt_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 140);
            this.panel1.TabIndex = 0;
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(12, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(123, 37);
            this.bt_back.TabIndex = 0;
            this.bt_back.Text = "Quay lại";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // bt_tim
            // 
            this.bt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Location = new System.Drawing.Point(737, 80);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(99, 32);
            this.bt_tim.TabIndex = 2;
            this.bt_tim.Text = "Tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.Bt_tim_Click);
            // 
            // cb_loai
            // 
            this.cb_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loai.FormattingEnabled = true;
            this.cb_loai.Items.AddRange(new object[] {
            "Theo mã",
            "Theo tên"});
            this.cb_loai.Location = new System.Drawing.Point(213, 81);
            this.cb_loai.Name = "cb_loai";
            this.cb_loai.Size = new System.Drawing.Size(121, 33);
            this.cb_loai.TabIndex = 3;
            // 
            // tb_ph
            // 
            this.tb_ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ph.Location = new System.Drawing.Point(388, 83);
            this.tb_ph.Name = "tb_ph";
            this.tb_ph.Size = new System.Drawing.Size(278, 30);
            this.tb_ph.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm kiếm phòng học";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_xoa);
            this.panel2.Controls.Add(this.bt_sua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 71);
            this.panel2.TabIndex = 1;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(318, 23);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(88, 36);
            this.bt_sua.TabIndex = 0;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.Bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(657, 23);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(88, 36);
            this.bt_xoa.TabIndex = 1;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.Bt_xoa_Click);
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
            this.dgv_ph.Location = new System.Drawing.Point(0, 140);
            this.dgv_ph.Name = "dgv_ph";
            this.dgv_ph.ReadOnly = true;
            this.dgv_ph.RowHeadersWidth = 51;
            this.dgv_ph.RowTemplate.Height = 24;
            this.dgv_ph.Size = new System.Drawing.Size(1027, 316);
            this.dgv_ph.TabIndex = 2;
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
            // PhongHocDialog_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 527);
            this.Controls.Add(this.dgv_ph);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhongHocDialog_search";
            this.Text = "PhongHocDialog_search";
            this.Load += new System.EventHandler(this.PhongHocDialog_search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ph;
        private System.Windows.Forms.ComboBox cb_loai;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.DataGridView dgv_ph;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn succhua_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu_PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysua;
    }
}