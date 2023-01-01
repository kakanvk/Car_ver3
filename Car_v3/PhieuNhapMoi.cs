using System;
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
    public partial class PhieuNhapMoi : Form
    {
        public PhieuNhapMoi()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap phieuNhap = new ChiTietPhieuNhap();
            phieuNhap.Show();
        }
    }
}
