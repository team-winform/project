namespace main_GUI
{
    partial class GUI_HocVien
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_HV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1177, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách học viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 73);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(426, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(255, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(836, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_HV,
            this.ten_HV,
            this.sodt_HV,
            this.ngaysinh_HV,
            this.diachi_HV,
            this.ngaytao,
            this.ngaysua});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 522);
            this.dataGridView1.TabIndex = 2;
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
            // ten_HV
            // 
            this.ten_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten_HV.DataPropertyName = "ten_HV";
            this.ten_HV.HeaderText = "Tên học viên";
            this.ten_HV.MinimumWidth = 6;
            this.ten_HV.Name = "ten_HV";
            this.ten_HV.ReadOnly = true;
            // 
            // sodt_HV
            // 
            this.sodt_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sodt_HV.DataPropertyName = "sodt_HV";
            this.sodt_HV.HeaderText = "Số điện thoại";
            this.sodt_HV.MinimumWidth = 6;
            this.sodt_HV.Name = "sodt_HV";
            this.sodt_HV.ReadOnly = true;
            // 
            // ngaysinh_HV
            // 
            this.ngaysinh_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysinh_HV.DataPropertyName = "ngaysinh_HV";
            this.ngaysinh_HV.HeaderText = "Ngày sinh";
            this.ngaysinh_HV.MinimumWidth = 6;
            this.ngaysinh_HV.Name = "ngaysinh_HV";
            this.ngaysinh_HV.ReadOnly = true;
            // 
            // diachi_HV
            // 
            this.diachi_HV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi_HV.DataPropertyName = "diachi_HV";
            this.diachi_HV.HeaderText = "Địa chỉ";
            this.diachi_HV.MinimumWidth = 6;
            this.diachi_HV.Name = "diachi_HV";
            this.diachi_HV.ReadOnly = true;
            // 
            // ngaytao
            // 
            this.ngaytao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaytao.DataPropertyName = "ngaytao";
            this.ngaytao.HeaderText = "Ngày tạo";
            this.ngaytao.MinimumWidth = 6;
            this.ngaytao.Name = "ngaytao";
            this.ngaytao.ReadOnly = true;
            // 
            // ngaysua
            // 
            this.ngaysua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysua.DataPropertyName = "ngaysua";
            this.ngaysua.HeaderText = "Ngày sửa";
            this.ngaysua.MinimumWidth = 6;
            this.ngaysua.Name = "ngaysua";
            this.ngaysua.ReadOnly = true;
            // 
            // GUI_HocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 667);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_HocVien";
            this.Text = "GUI_HocVien";
            this.Load += new System.EventHandler(this.GUI_HocVien_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_HV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysua;
    }
}