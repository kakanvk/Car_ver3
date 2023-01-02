﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_v3
{
    public partial class TrangChu : Form
    {
        help help = new help();
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_QLNSX_Click(object sender, EventArgs e)
        {
            NSX newNSX = new NSX();
            newNSX.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            PhieuNhap newPN = new PhieuNhap();
            newPN.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (help.Checkper() !=3){ }
            else
            {
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void btn_nhanVien_Click(object sender, EventArgs e)
        {
            if (help.Checkper() == 2)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.Show();
            }
            else
                MessageBox.Show("Chức năng này không giành cho bạn !");
        }
    }
}
