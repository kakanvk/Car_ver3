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
                HienThiDL();
            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string id = "";
            string str = "";
            string query = "";
            if (tb_giaBan.Text == "" || tb_soLuongMua.Text == "" || cb_tenSanPham.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin");
            }

            if (HoaDon.check == 3)
            {
                query = "select mahoadon from hoadon where mahoadon = " + HoaDon.id + "";
            }
            else
            {
                query = "select max(maHoaDon) from hoadon";
            }


            tb = help.LayBang(query);
            foreach (DataRow dr in tb.Rows)
            {
                id = dr[0].ToString();
            }

            str = "insert into hoadonchitiet values(" + cb_tenSanPham.SelectedValue + "," + id + "," + tb_soLuongMua.Text + ","+tb_thueTruocBa.Text+","+tb_phiDangKiem.Text+","+tb_baoHiem.Text+","+tb_BCDB.Text+"," + tb_giaBan.Text + "," + tb_thanhTien.Text + ")";
            help.CapNhatDL(str);
            hdm.HienThiDL_HoaDonMoi();
            this.Close();
        }

        void HienThiDL()
        {
            string str;

            str = "select * from sanpham";

            tb = help.LayBang(str);
            cb_tenSanPham.DataSource = tb;
            cb_tenSanPham.DisplayMember = "tensanpham";
            cb_tenSanPham.ValueMember = "masanpham";
            tb_thanhTien.Enabled = false;

        }

        

        public void Multiply()
        {
            int a, b;

            bool isAValid = int.TryParse(tb_giaBan.Text, out a);
            bool isBValid = int.TryParse(tb_soLuongMua.Text, out b);

            if (isAValid && isBValid)
            {
                tb_thanhTien.Text = (a * b*0.02+90000+1560000+300000).ToString();
                tb_thueTruocBa.Text = (a * b * 0.02).ToString();
                tb_phiDangKiem.Text = "90000";
                tb_BCDB.Text = "1560000";
                tb_baoHiem.Text = "300000";
            }   
            else
                tb_thanhTien.Text = "Đầu vào không hợp lệ";
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void tb_soLuongNhap_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }

        private void tb_giaNhap_TextChanged(object sender, EventArgs e)
        {
            Multiply();
        }
    }
}
