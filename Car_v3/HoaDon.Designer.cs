namespace Car_v3
{
    partial class HoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_timKiem = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_hoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_xoa = new Guna.UI.WinForms.GunaButton();
            this.btn_sua = new Guna.UI.WinForms.GunaButton();
            this.btn_chiTiet = new Guna.UI.WinForms.GunaButton();
            this.btn_them = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_timKiem = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_timKiem
            // 
            this.tb_timKiem.BaseColor = System.Drawing.Color.White;
            this.tb_timKiem.BorderColor = System.Drawing.Color.Silver;
            this.tb_timKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_timKiem.FocusedBaseColor = System.Drawing.Color.White;
            this.tb_timKiem.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_timKiem.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_timKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timKiem.Location = new System.Drawing.Point(52, 31);
            this.tb_timKiem.Name = "tb_timKiem";
            this.tb_timKiem.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.tb_timKiem.PasswordChar = '\0';
            this.tb_timKiem.SelectedText = "";
            this.tb_timKiem.Size = new System.Drawing.Size(648, 45);
            this.tb_timKiem.TabIndex = 50;
            this.tb_timKiem.TextChanged += new System.EventHandler(this.tb_timKiem_TextChanged);
            // 
            // dgv_hoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_hoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_hoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_hoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_hoaDon.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_hoaDon.EnableHeadersVisualStyles = false;
            this.dgv_hoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoaDon.Location = new System.Drawing.Point(52, 147);
            this.dgv_hoaDon.Name = "dgv_hoaDon";
            this.dgv_hoaDon.RowHeadersVisible = false;
            this.dgv_hoaDon.RowHeadersWidth = 62;
            this.dgv_hoaDon.RowTemplate.Height = 28;
            this.dgv_hoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoaDon.Size = new System.Drawing.Size(984, 338);
            this.dgv_hoaDon.TabIndex = 49;
            this.dgv_hoaDon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_hoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_hoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_hoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_hoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_hoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_hoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_hoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_hoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_hoaDon.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_hoaDon.ThemeStyle.ReadOnly = false;
            this.dgv_hoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_hoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoaDon.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_hoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoaDon_CellClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AnimationHoverSpeed = 0.07F;
            this.btn_xoa.AnimationSpeed = 0.03F;
            this.btn_xoa.BaseColor = System.Drawing.Color.Silver;
            this.btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_xoa.FocusedColor = System.Drawing.Color.Empty;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Image = null;
            this.btn_xoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_xoa.Location = new System.Drawing.Point(502, 522);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_xoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_xoa.OnHoverImage = null;
            this.btn_xoa.OnPressedColor = System.Drawing.Color.Black;
            this.btn_xoa.Size = new System.Drawing.Size(107, 42);
            this.btn_xoa.TabIndex = 46;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AnimationHoverSpeed = 0.07F;
            this.btn_sua.AnimationSpeed = 0.03F;
            this.btn_sua.BaseColor = System.Drawing.Color.Silver;
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_sua.FocusedColor = System.Drawing.Color.Empty;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Image = null;
            this.btn_sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_sua.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_sua.Location = new System.Drawing.Point(375, 522);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_sua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_sua.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_sua.OnHoverImage = null;
            this.btn_sua.OnPressedColor = System.Drawing.Color.Black;
            this.btn_sua.Size = new System.Drawing.Size(106, 42);
            this.btn_sua.TabIndex = 47;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_chiTiet
            // 
            this.btn_chiTiet.AnimationHoverSpeed = 0.07F;
            this.btn_chiTiet.AnimationSpeed = 0.03F;
            this.btn_chiTiet.BaseColor = System.Drawing.Color.Silver;
            this.btn_chiTiet.BorderColor = System.Drawing.Color.Black;
            this.btn_chiTiet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_chiTiet.FocusedColor = System.Drawing.Color.Empty;
            this.btn_chiTiet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chiTiet.ForeColor = System.Drawing.Color.Black;
            this.btn_chiTiet.Image = null;
            this.btn_chiTiet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_chiTiet.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_chiTiet.Location = new System.Drawing.Point(189, 522);
            this.btn_chiTiet.Name = "btn_chiTiet";
            this.btn_chiTiet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_chiTiet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_chiTiet.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_chiTiet.OnHoverImage = null;
            this.btn_chiTiet.OnPressedColor = System.Drawing.Color.Black;
            this.btn_chiTiet.Size = new System.Drawing.Size(165, 42);
            this.btn_chiTiet.TabIndex = 48;
            this.btn_chiTiet.Text = "Xem chi tiết";
            this.btn_chiTiet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_chiTiet.Click += new System.EventHandler(this.btn_chiTiet_Click);
            // 
            // btn_them
            // 
            this.btn_them.AnimationHoverSpeed = 0.07F;
            this.btn_them.AnimationSpeed = 0.03F;
            this.btn_them.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_them.BorderColor = System.Drawing.Color.Black;
            this.btn_them.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_them.FocusedColor = System.Drawing.Color.Empty;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = null;
            this.btn_them.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_them.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_them.Location = new System.Drawing.Point(52, 522);
            this.btn_them.Name = "btn_them";
            this.btn_them.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_them.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_them.OnHoverImage = null;
            this.btn_them.OnPressedColor = System.Drawing.Color.Black;
            this.btn_them.Size = new System.Drawing.Size(115, 42);
            this.btn_them.TabIndex = 45;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(47, 103);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(187, 30);
            this.gunaLabel1.TabIndex = 44;
            this.gunaLabel1.Text = "Lịch sử mua hàng";
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.AnimationHoverSpeed = 0.07F;
            this.btn_timKiem.AnimationSpeed = 0.03F;
            this.btn_timKiem.BackColor = System.Drawing.Color.Transparent;
            this.btn_timKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_timKiem.BorderColor = System.Drawing.Color.Black;
            this.btn_timKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_timKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btn_timKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.Color.White;
            this.btn_timKiem.Image = global::Car_v3.Properties.Resources.Picture2;
            this.btn_timKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_timKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_timKiem.Location = new System.Drawing.Point(725, 31);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_timKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_timKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_timKiem.OnHoverImage = null;
            this.btn_timKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btn_timKiem.Radius = 2;
            this.btn_timKiem.Size = new System.Drawing.Size(157, 45);
            this.btn_timKiem.TabIndex = 51;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 607);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.tb_timKiem);
            this.Controls.Add(this.dgv_hoaDon);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_chiTiet);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btn_timKiem;
        private Guna.UI.WinForms.GunaTextBox tb_timKiem;
        private Guna.UI.WinForms.GunaDataGridView dgv_hoaDon;
        private Guna.UI.WinForms.GunaButton btn_xoa;
        private Guna.UI.WinForms.GunaButton btn_sua;
        private Guna.UI.WinForms.GunaButton btn_chiTiet;
        private Guna.UI.WinForms.GunaButton btn_them;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}