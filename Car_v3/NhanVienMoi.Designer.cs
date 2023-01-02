namespace Car_v3
{
    partial class NhanVienMoi
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
            this.btn_huy = new Guna.UI.WinForms.GunaButton();
            this.btn_luu = new Guna.UI.WinForms.GunaButton();
            this.ns_nhanVien = new Guna.UI.WinForms.GunaDateTimePicker();
            this.tb_matKhau = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.tb_email = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.tb_diaChi = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.tb_tenNhanVien = new Guna.UI.WinForms.GunaTextBox();
            this.tb_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cb_gioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.cb_chucVu = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.AnimationHoverSpeed = 0.07F;
            this.btn_huy.AnimationSpeed = 0.03F;
            this.btn_huy.BaseColor = System.Drawing.Color.Silver;
            this.btn_huy.BorderColor = System.Drawing.Color.Black;
            this.btn_huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.Black;
            this.btn_huy.Image = null;
            this.btn_huy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_huy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_huy.Location = new System.Drawing.Point(256, 497);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Size = new System.Drawing.Size(98, 42);
            this.btn_huy.TabIndex = 28;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_luu
            // 
            this.btn_luu.AnimationHoverSpeed = 0.07F;
            this.btn_luu.AnimationSpeed = 0.03F;
            this.btn_luu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_luu.BorderColor = System.Drawing.Color.Black;
            this.btn_luu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_luu.FocusedColor = System.Drawing.Color.Empty;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Image = null;
            this.btn_luu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_luu.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_luu.Location = new System.Drawing.Point(380, 497);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_luu.OnHoverImage = null;
            this.btn_luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_luu.Size = new System.Drawing.Size(94, 42);
            this.btn_luu.TabIndex = 27;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // ns_nhanVien
            // 
            this.ns_nhanVien.BaseColor = System.Drawing.Color.White;
            this.ns_nhanVien.BorderColor = System.Drawing.Color.Silver;
            this.ns_nhanVien.CustomFormat = null;
            this.ns_nhanVien.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ns_nhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ns_nhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ns_nhanVien.ForeColor = System.Drawing.Color.Black;
            this.ns_nhanVien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ns_nhanVien.Location = new System.Drawing.Point(194, 132);
            this.ns_nhanVien.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ns_nhanVien.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ns_nhanVien.Name = "ns_nhanVien";
            this.ns_nhanVien.OnHoverBaseColor = System.Drawing.Color.White;
            this.ns_nhanVien.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ns_nhanVien.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ns_nhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.ns_nhanVien.Size = new System.Drawing.Size(280, 40);
            this.ns_nhanVien.TabIndex = 26;
            this.ns_nhanVien.Text = "1/2/2023";
            this.ns_nhanVien.Value = new System.DateTime(2023, 1, 2, 0, 0, 0, 0);
            // 
            // tb_matKhau
            // 
            this.tb_matKhau.BaseColor = System.Drawing.Color.White;
            this.tb_matKhau.BorderColor = System.Drawing.Color.Silver;
            this.tb_matKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_matKhau.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_matKhau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_matKhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_matKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_matKhau.Location = new System.Drawing.Point(194, 414);
            this.tb_matKhau.Name = "tb_matKhau";
            this.tb_matKhau.PasswordChar = '\0';
            this.tb_matKhau.SelectedText = "";
            this.tb_matKhau.Size = new System.Drawing.Size(280, 40);
            this.tb_matKhau.TabIndex = 23;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(27, 422);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(89, 25);
            this.gunaLabel8.TabIndex = 18;
            this.gunaLabel8.Text = "Mật khẩu";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(27, 197);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(84, 25);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Giới tính";
            // 
            // tb_email
            // 
            this.tb_email.BaseColor = System.Drawing.Color.White;
            this.tb_email.BorderColor = System.Drawing.Color.Silver;
            this.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_email.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_email.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_email.Location = new System.Drawing.Point(194, 358);
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordChar = '\0';
            this.tb_email.SelectedText = "";
            this.tb_email.Size = new System.Drawing.Size(280, 40);
            this.tb_email.TabIndex = 19;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(27, 366);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(56, 25);
            this.gunaLabel7.TabIndex = 11;
            this.gunaLabel7.Text = "Email";
            // 
            // tb_diaChi
            // 
            this.tb_diaChi.BaseColor = System.Drawing.Color.White;
            this.tb_diaChi.BorderColor = System.Drawing.Color.Silver;
            this.tb_diaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_diaChi.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_diaChi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_diaChi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_diaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_diaChi.Location = new System.Drawing.Point(194, 302);
            this.tb_diaChi.Name = "tb_diaChi";
            this.tb_diaChi.PasswordChar = '\0';
            this.tb_diaChi.SelectedText = "";
            this.tb_diaChi.Size = new System.Drawing.Size(280, 40);
            this.tb_diaChi.TabIndex = 21;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(27, 140);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(94, 25);
            this.gunaLabel3.TabIndex = 15;
            this.gunaLabel3.Text = "Ngày sinh";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(27, 310);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(67, 25);
            this.gunaLabel6.TabIndex = 14;
            this.gunaLabel6.Text = "Địa chỉ";
            // 
            // tb_tenNhanVien
            // 
            this.tb_tenNhanVien.BaseColor = System.Drawing.Color.White;
            this.tb_tenNhanVien.BorderColor = System.Drawing.Color.Silver;
            this.tb_tenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tenNhanVien.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_tenNhanVien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_tenNhanVien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_tenNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_tenNhanVien.Location = new System.Drawing.Point(194, 77);
            this.tb_tenNhanVien.Name = "tb_tenNhanVien";
            this.tb_tenNhanVien.PasswordChar = '\0';
            this.tb_tenNhanVien.SelectedText = "";
            this.tb_tenNhanVien.Size = new System.Drawing.Size(280, 40);
            this.tb_tenNhanVien.TabIndex = 24;
            // 
            // tb_sdt
            // 
            this.tb_sdt.BaseColor = System.Drawing.Color.White;
            this.tb_sdt.BorderColor = System.Drawing.Color.Silver;
            this.tb_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_sdt.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_sdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_sdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_sdt.Location = new System.Drawing.Point(194, 247);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.PasswordChar = '\0';
            this.tb_sdt.SelectedText = "";
            this.tb_sdt.Size = new System.Drawing.Size(280, 40);
            this.tb_sdt.TabIndex = 25;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(27, 85);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(127, 25);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "Tên nhân viên";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(27, 255);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(122, 25);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "Số điện thoại";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 25);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "Chức vụ";
            // 
            // cb_gioiTinh
            // 
            this.cb_gioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cb_gioiTinh.BaseColor = System.Drawing.Color.White;
            this.cb_gioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.cb_gioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_gioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cb_gioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_gioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cb_gioiTinh.FormattingEnabled = true;
            this.cb_gioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioiTinh.Location = new System.Drawing.Point(194, 191);
            this.cb_gioiTinh.Name = "cb_gioiTinh";
            this.cb_gioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_gioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_gioiTinh.Size = new System.Drawing.Size(280, 35);
            this.cb_gioiTinh.TabIndex = 29;
            // 
            // cb_chucVu
            // 
            this.cb_chucVu.BackColor = System.Drawing.Color.Transparent;
            this.cb_chucVu.BaseColor = System.Drawing.Color.White;
            this.cb_chucVu.BorderColor = System.Drawing.Color.Silver;
            this.cb_chucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_chucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chucVu.FocusedColor = System.Drawing.Color.Empty;
            this.cb_chucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_chucVu.ForeColor = System.Drawing.Color.Black;
            this.cb_chucVu.FormattingEnabled = true;
            this.cb_chucVu.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_chucVu.Location = new System.Drawing.Point(194, 24);
            this.cb_chucVu.Name = "cb_chucVu";
            this.cb_chucVu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_chucVu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_chucVu.Size = new System.Drawing.Size(280, 35);
            this.cb_chucVu.TabIndex = 30;
            // 
            // NhanVienMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 567);
            this.Controls.Add(this.cb_chucVu);
            this.Controls.Add(this.cb_gioiTinh);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.ns_nhanVien);
            this.Controls.Add(this.tb_matKhau);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.tb_diaChi);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.tb_tenNhanVien);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "NhanVienMoi";
            this.Text = "NhanVienMoi";
            this.Load += new System.EventHandler(this.NhanVienMoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_huy;
        private Guna.UI.WinForms.GunaButton btn_luu;
        private Guna.UI.WinForms.GunaDateTimePicker ns_nhanVien;
        private Guna.UI.WinForms.GunaTextBox tb_matKhau;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox tb_email;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox tb_diaChi;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox tb_tenNhanVien;
        private Guna.UI.WinForms.GunaTextBox tb_sdt;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cb_gioiTinh;
        private Guna.UI.WinForms.GunaComboBox cb_chucVu;
    }
}