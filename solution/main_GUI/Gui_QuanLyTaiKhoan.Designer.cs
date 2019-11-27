namespace main_GUI
{
    partial class Gui_QuanLyTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReloadGrdAccount = new System.Windows.Forms.Button();
            this.grdTaiKhoan = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClearAccount = new System.Windows.Forms.Button();
            this.btXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btCapNhatTaiKhoan = new System.Windows.Forms.Button();
            this.btThemTaiKhoan = new System.Windows.Forms.Button();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaiKhoan)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReloadGrdAccount
            // 
            this.btnReloadGrdAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadGrdAccount.Location = new System.Drawing.Point(80, 230);
            this.btnReloadGrdAccount.Name = "btnReloadGrdAccount";
            this.btnReloadGrdAccount.Size = new System.Drawing.Size(75, 23);
            this.btnReloadGrdAccount.TabIndex = 0;
            this.btnReloadGrdAccount.Text = "Reload";
            this.btnReloadGrdAccount.UseVisualStyleBackColor = true;
            this.btnReloadGrdAccount.Click += new System.EventHandler(this.btnReloadGrdAccount_Click);
            // 
            // grdTaiKhoan
            // 
            this.grdTaiKhoan.AllowUserToAddRows = false;
            this.grdTaiKhoan.AllowUserToDeleteRows = false;
            this.grdTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.level,
            this.hoten,
            this.phone});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTaiKhoan.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdTaiKhoan.Location = new System.Drawing.Point(80, 263);
            this.grdTaiKhoan.Name = "grdTaiKhoan";
            this.grdTaiKhoan.ReadOnly = true;
            this.grdTaiKhoan.Size = new System.Drawing.Size(691, 223);
            this.grdTaiKhoan.TabIndex = 2;
            this.grdTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTaiKhoan_CellClick);
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // level
            // 
            this.level.HeaderText = "Cấp bậc";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            this.level.Width = 130;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 150;
            // 
            // phone
            // 
            this.phone.HeaderText = "Số điện thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 150;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClearAccount);
            this.groupBox5.Controls.Add(this.btXoaTaiKhoan);
            this.groupBox5.Controls.Add(this.btCapNhatTaiKhoan);
            this.groupBox5.Controls.Add(this.btThemTaiKhoan);
            this.groupBox5.Controls.Add(this.cbLevel);
            this.groupBox5.Controls.Add(this.txtTaiKhoan);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtMatKhau);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(172, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(470, 175);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // btnClearAccount
            // 
            this.btnClearAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearAccount.Location = new System.Drawing.Point(394, 29);
            this.btnClearAccount.Name = "btnClearAccount";
            this.btnClearAccount.Size = new System.Drawing.Size(70, 28);
            this.btnClearAccount.TabIndex = 6;
            this.btnClearAccount.Text = "Clear";
            this.btnClearAccount.UseVisualStyleBackColor = true;
            this.btnClearAccount.Click += new System.EventHandler(this.btnClearAccount_Click);
            // 
            // btXoaTaiKhoan
            // 
            this.btXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoaTaiKhoan.Location = new System.Drawing.Point(327, 132);
            this.btXoaTaiKhoan.Name = "btXoaTaiKhoan";
            this.btXoaTaiKhoan.Size = new System.Drawing.Size(70, 28);
            this.btXoaTaiKhoan.TabIndex = 8;
            this.btXoaTaiKhoan.Text = "Xoá";
            this.btXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btXoaTaiKhoan.Click += new System.EventHandler(this.btXoaTaiKhoan_Click);
            // 
            // btCapNhatTaiKhoan
            // 
            this.btCapNhatTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhatTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCapNhatTaiKhoan.Location = new System.Drawing.Point(203, 132);
            this.btCapNhatTaiKhoan.Name = "btCapNhatTaiKhoan";
            this.btCapNhatTaiKhoan.Size = new System.Drawing.Size(70, 28);
            this.btCapNhatTaiKhoan.TabIndex = 4;
            this.btCapNhatTaiKhoan.Text = "Cập nhật";
            this.btCapNhatTaiKhoan.UseVisualStyleBackColor = true;
            this.btCapNhatTaiKhoan.Click += new System.EventHandler(this.btCapNhatTaiKhoan_Click);
            // 
            // btThemTaiKhoan
            // 
            this.btThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThemTaiKhoan.Location = new System.Drawing.Point(83, 132);
            this.btThemTaiKhoan.Name = "btThemTaiKhoan";
            this.btThemTaiKhoan.Size = new System.Drawing.Size(70, 28);
            this.btThemTaiKhoan.TabIndex = 3;
            this.btThemTaiKhoan.Text = "Thêm";
            this.btThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btThemTaiKhoan.Click += new System.EventHandler(this.btThemTaiKhoan_Click);
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Quản trị viên",
            "Quản lý",
            "Giảng viên",
            "Nhân viên"});
            this.cbLevel.Location = new System.Drawing.Point(177, 93);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(193, 24);
            this.cbLevel.TabIndex = 2;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(177, 29);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(193, 22);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(94, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Cấp bậc";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(177, 61);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(193, 22);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(94, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mật khẩu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(94, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tài khoản";
            // 
            // Gui_QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 507);
            this.Controls.Add(this.btnReloadGrdAccount);
            this.Controls.Add(this.grdTaiKhoan);
            this.Controls.Add(this.groupBox5);
            this.Name = "Gui_QuanLyTaiKhoan";
            this.Text = "Gui_QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.Gui_QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTaiKhoan)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReloadGrdAccount;
        private System.Windows.Forms.DataGridView grdTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnClearAccount;
        private System.Windows.Forms.Button btXoaTaiKhoan;
        private System.Windows.Forms.Button btCapNhatTaiKhoan;
        private System.Windows.Forms.Button btThemTaiKhoan;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}