namespace Car_v3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_dangNhap = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tb_matKhau = new Guna.UI.WinForms.GunaTextBox();
            this.tb_tenDangNhap = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Car_v3.Properties.Resources.Picture2__1_;
            this.gunaPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.InitialImage")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(53, 55);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(326, 465);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 13;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.AnimationHoverSpeed = 0.07F;
            this.btn_dangNhap.AnimationSpeed = 0.03F;
            this.btn_dangNhap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_dangNhap.BorderColor = System.Drawing.Color.Black;
            this.btn_dangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_dangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangNhap.Image = null;
            this.btn_dangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_dangNhap.Location = new System.Drawing.Point(436, 379);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_dangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dangNhap.OnHoverImage = null;
            this.btn_dangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dangNhap.Size = new System.Drawing.Size(359, 42);
            this.btn_dangNhap.TabIndex = 12;
            this.btn_dangNhap.Text = "ĐĂNG NHẬP";
            this.btn_dangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(431, 272);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 25);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "Mật khẩu";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(431, 171);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(134, 25);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Tên đăng nhập";
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
            this.tb_matKhau.Location = new System.Drawing.Point(436, 310);
            this.tb_matKhau.Name = "tb_matKhau";
            this.tb_matKhau.PasswordChar = '*';
            this.tb_matKhau.SelectedText = "";
            this.tb_matKhau.Size = new System.Drawing.Size(359, 40);
            this.tb_matKhau.TabIndex = 8;
            // 
            // tb_tenDangNhap
            // 
            this.tb_tenDangNhap.BaseColor = System.Drawing.Color.White;
            this.tb_tenDangNhap.BorderColor = System.Drawing.Color.Silver;
            this.tb_tenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tenDangNhap.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_tenDangNhap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_tenDangNhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_tenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_tenDangNhap.Location = new System.Drawing.Point(436, 209);
            this.tb_tenDangNhap.Name = "tb_tenDangNhap";
            this.tb_tenDangNhap.PasswordChar = '\0';
            this.tb_tenDangNhap.SelectedText = "";
            this.tb_tenDangNhap.Size = new System.Drawing.Size(359, 40);
            this.tb_tenDangNhap.TabIndex = 7;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.Location = new System.Drawing.Point(556, 113);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(139, 28);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "ĐĂNG NHẬP";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 549);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.tb_matKhau);
            this.Controls.Add(this.tb_tenDangNhap);
            this.Controls.Add(this.gunaLabel4);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btn_dangNhap;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox tb_matKhau;
        private Guna.UI.WinForms.GunaTextBox tb_tenDangNhap;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}

