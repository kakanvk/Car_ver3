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
    public partial class HoaDon : Form
    {
        help help = new help();
        DataTable tb = new DataTable();
        public HoaDon()
        {
            if (help.Mo_KN_CSDL())
            {
                //HienthiDL();
            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }

        }
        public static int id;
        public static int check;

        private void btn_them_Click(object sender, EventArgs e)
        {
            id = 0;
            check = 1;
            HoaDonMoi hoaDonMoi = new HoaDonMoi();
            hoaDonMoi.ShowDialog();
        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            check = 2;
            HoaDonMoi hoaDonMoi = new HoaDonMoi();
            hoaDonMoi.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            HoaDonMoi hoaDonMoi = new HoaDonMoi();
            hoaDonMoi.ShowDialog();
        }
    }
}
