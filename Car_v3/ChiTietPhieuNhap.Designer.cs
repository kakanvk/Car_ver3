namespace Car_v3
{
    partial class ChiTietPhieuNhap
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
            this.cb_tenSanPham = new Guna.UI.WinForms.GunaComboBox();
            this.tb_thanhTien = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.tb_giaNhap = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.tb_soLuongNhap = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lb_themSanPham = new Guna.UI.WinForms.GunaLabel();
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
            this.btn_huy.Location = new System.Drawing.Point(257, 312);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Size = new System.Drawing.Size(98, 42);
            this.btn_huy.TabIndex = 20;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
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
            this.btn_luu.Location = new System.Drawing.Point(378, 312);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_luu.OnHoverImage = null;
            this.btn_luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_luu.Size = new System.Drawing.Size(94, 42);
            this.btn_luu.TabIndex = 19;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // cb_tenSanPham
            // 
            this.cb_tenSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cb_tenSanPham.BaseColor = System.Drawing.Color.White;
            this.cb_tenSanPham.BorderColor = System.Drawing.Color.Silver;
            this.cb_tenSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_tenSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tenSanPham.FocusedColor = System.Drawing.Color.Empty;
            this.cb_tenSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_tenSanPham.ForeColor = System.Drawing.Color.Black;
            this.cb_tenSanPham.FormattingEnabled = true;
            this.cb_tenSanPham.Location = new System.Drawing.Point(192, 29);
            this.cb_tenSanPham.Name = "cb_tenSanPham";
            this.cb_tenSanPham.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_tenSanPham.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_tenSanPham.Size = new System.Drawing.Size(280, 35);
            this.cb_tenSanPham.TabIndex = 18;
            // 
            // tb_thanhTien
            // 
            this.tb_thanhTien.BaseColor = System.Drawing.Color.White;
            this.tb_thanhTien.BorderColor = System.Drawing.Color.Silver;
            this.tb_thanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_thanhTien.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_thanhTien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_thanhTien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_thanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_thanhTien.Location = new System.Drawing.Point(192, 239);
            this.tb_thanhTien.Name = "tb_thanhTien";
            this.tb_thanhTien.PasswordChar = '\0';
            this.tb_thanhTien.SelectedText = "";
            this.tb_thanhTien.Size = new System.Drawing.Size(280, 40);
            this.tb_thanhTien.TabIndex = 15;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(25, 247);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(100, 25);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "Thành tiền";
            // 
            // tb_giaNhap
            // 
            this.tb_giaNhap.BaseColor = System.Drawing.Color.White;
            this.tb_giaNhap.BorderColor = System.Drawing.Color.Silver;
            this.tb_giaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_giaNhap.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_giaNhap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_giaNhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_giaNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_giaNhap.Location = new System.Drawing.Point(192, 184);
            this.tb_giaNhap.Name = "tb_giaNhap";
            this.tb_giaNhap.PasswordChar = '\0';
            this.tb_giaNhap.SelectedText = "";
            this.tb_giaNhap.Size = new System.Drawing.Size(280, 40);
            this.tb_giaNhap.TabIndex = 16;
            this.tb_giaNhap.TextChanged += new System.EventHandler(this.tb_giaNhap_TextChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(25, 192);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(85, 25);
            this.gunaLabel3.TabIndex = 12;
            this.gunaLabel3.Text = "Giá nhập";
            // 
            // tb_soLuongNhap
            // 
            this.tb_soLuongNhap.BaseColor = System.Drawing.Color.White;
            this.tb_soLuongNhap.BorderColor = System.Drawing.Color.Silver;
            this.tb_soLuongNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_soLuongNhap.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_soLuongNhap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_soLuongNhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_soLuongNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_soLuongNhap.Location = new System.Drawing.Point(192, 131);
            this.tb_soLuongNhap.Name = "tb_soLuongNhap";
            this.tb_soLuongNhap.PasswordChar = '\0';
            this.tb_soLuongNhap.SelectedText = "";
            this.tb_soLuongNhap.Size = new System.Drawing.Size(280, 40);
            this.tb_soLuongNhap.TabIndex = 17;
            this.tb_soLuongNhap.TextChanged += new System.EventHandler(this.tb_soLuongNhap_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(25, 139);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 25);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "Số lượng nhập";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(25, 34);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(125, 25);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "Tên sản phẩm";
            // 
            // lb_themSanPham
            // 
            this.lb_themSanPham.AutoSize = true;
            this.lb_themSanPham.BackColor = System.Drawing.Color.Transparent;
            this.lb_themSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_themSanPham.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_themSanPham.Location = new System.Drawing.Point(289, 75);
            this.lb_themSanPham.Name = "lb_themSanPham";
            this.lb_themSanPham.Size = new System.Drawing.Size(183, 25);
            this.lb_themSanPham.TabIndex = 22;
            this.lb_themSanPham.Text = "Thêm sản phẩm khác";
            this.lb_themSanPham.Click += new System.EventHandler(this.lb_themSanPham_Click);
            // 
            // ChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 381);
            this.Controls.Add(this.lb_themSanPham);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.cb_tenSanPham);
            this.Controls.Add(this.tb_thanhTien);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.tb_giaNhap);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.tb_soLuongNhap);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "ChiTietPhieuNhap";
            this.Text = "ChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.ChiTietPhieuNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_huy;
        private Guna.UI.WinForms.GunaButton btn_luu;
        private Guna.UI.WinForms.GunaComboBox cb_tenSanPham;
        private Guna.UI.WinForms.GunaTextBox tb_thanhTien;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox tb_giaNhap;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox tb_soLuongNhap;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lb_themSanPham;
    }
}