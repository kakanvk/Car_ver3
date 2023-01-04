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
    public partial class ChiTietHoaDon : Form
    {
        help help = new help();
        DataTable tb = new DataTable();
        HoaDonMoi hdm;
        public ChiTietHoaDon(HoaDonMoi _hdm)
        {
            InitializeComponent();
            help = new help();
            hdm = _hdm;
            if (help.Mo_KN_CSDL())
            {
                //HienThiDL();
            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {

        }
    }
}
