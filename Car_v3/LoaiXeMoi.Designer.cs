namespace Car_v3
{
    partial class LoaiXeMoi
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
            this.tb_tenLoai = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
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
            this.btn_huy.Location = new System.Drawing.Point(255, 156);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Size = new System.Drawing.Size(98, 42);
            this.btn_huy.TabIndex = 46;
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
            this.btn_luu.Location = new System.Drawing.Point(379, 156);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_luu.OnHoverImage = null;
            this.btn_luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_luu.Size = new System.Drawing.Size(94, 42);
            this.btn_luu.TabIndex = 45;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // tb_tenLoai
            // 
            this.tb_tenLoai.BaseColor = System.Drawing.Color.White;
            this.tb_tenLoai.BorderColor = System.Drawing.Color.Silver;
            this.tb_tenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tenLoai.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_tenLoai.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_tenLoai.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_tenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_tenLoai.Location = new System.Drawing.Point(193, 31);
            this.tb_tenLoai.Name = "tb_tenLoai";
            this.tb_tenLoai.PasswordChar = '\0';
            this.tb_tenLoai.SelectedText = "";
            this.tb_tenLoai.Size = new System.Drawing.Size(280, 40);
            this.tb_tenLoai.TabIndex = 42;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(26, 39);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 25);
            this.gunaLabel2.TabIndex = 33;
            this.gunaLabel2.Text = "Tên loại";
            // 
            // LoaiXeMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 233);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.tb_tenLoai);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "LoaiXeMoi";
            this.Text = "LoaiXeMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btn_huy;
        private Guna.UI.WinForms.GunaButton btn_luu;
        private Guna.UI.WinForms.GunaTextBox tb_tenLoai;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}