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
    public partial class ChiTietPhieuNhap : Form
    {

        help help = new help();
        DataTable tb = new DataTable();
        public ChiTietPhieuNhap()
        {
            InitializeComponent();
            help = new help();
            if (help.Mo_KN_CSDL())
            {
                HienThiDL();
            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
        }

        private void lb_themSanPham_Click(object sender, EventArgs e)
        {
            XeMoi xe = new XeMoi();
            xe.ShowDialog();
        }
        void HienThiDL()
        {
            string str;

            str = "select * from sanpham";

            tb = help.LayBang(str);
            cb_tenSanPham.DataSource = tb;
            cb_tenSanPham.DisplayMember = "tensanpham";
            cb_tenSanPham.ValueMember = "masanpham";
        }
    }
}
