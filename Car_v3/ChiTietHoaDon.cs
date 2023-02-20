using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string strup, strinsr, str2, str3;

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

        private bool kiemtratontai()
        {
            bool tatkt = false;
            int test = HoaDonMoi.id_sanPham_cellclick;
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = oto");
            con.Open();
            DataTable dt_kiemtra = new DataTable();
            if (PhieuNhap.check == 3)
            {
                SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from hoadonchitiet  where masanpham=" + test + " and  mahoadon = (select max(mahoadon) from hoadon )", con);
                da_kiemtra.Fill(dt_kiemtra);
                if (dt_kiemtra.Rows.Count > 0)
                {
                    tatkt = true;
                }
                da_kiemtra.Dispose();
            }
            else
            {
                SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from hoadonchitiet  where masanpham=" + test + " and  mahoadon = " + HoaDon.id_hoaDon_cellclick + "", con);
                da_kiemtra.Fill(dt_kiemtra);
                if (dt_kiemtra.Rows.Count > 0)
                {
                    tatkt = true;
                }
                da_kiemtra.Dispose();
            }
            return tatkt;
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
            if (HoaDonMoi.check == 3)
            {
                query = "select mahoadon from hoadon where mahoadon = " + HoaDon.id_hoaDon_cellclick + "";
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

            if (HoaDonMoi.check == 3)
            {
                strinsr = "insert into hoadonchitiet values(" + cb_tenSanPham.SelectedValue + "," + id + "," + tb_soLuongMua.Text + "," + tb_thueTruocBa.Text + "," + tb_phiDangKiem.Text + "," + tb_baoHiem.Text + "," + tb_BCDB.Text + "," + tb_giaBan.Text + "," + tb_thanhTien.Text + ")";
                if (kiemtratontai())
                {
                    strup = "update sanpham set sanpham.soluong = sanpham.soluong + hoadonchitiet.soluongmua - " + tb_soLuongMua.Text + " from sanpham, chitiethoadon  where  sanpham.masanpham  = " + cb_tenSanPham.SelectedValue + " and hoadonchitiet.mahoadon = " + HoaDon.id + "";

                }
                else
                {
                    strup = "update sanpham set sanpham.soluong = sanpham.soluong  - " + tb_soLuongMua.Text + " from sanpham, hoadonchitiet  where  sanpham.masanpham  = " + cb_tenSanPham.SelectedValue + " and hoadonchitiet.mahoadon = " + HoaDon.id_hoaDon_cellclick + "";

                }
            }
            else
            {
                strinsr = "insert into hoadonchitiet values( " + cb_tenSanPham.SelectedValue + ",(select max(mahoadon) from hoadon)," + tb_soLuongMua.Text + "," + tb_thueTruocBa.Text + "," + tb_phiDangKiem.Text + "," + tb_baoHiem.Text + "," + tb_BCDB.Text + "," + tb_giaBan.Text + "," + tb_thanhTien.Text + ")";
                if (kiemtratontai())
                {
                    strup = "update sanpham set sanpham.soluong = sanpham.soluong + hoadonchitiet .soluongmua - " + tb_soLuongMua.Text + " from sanpham, hoadonchitiet  where  sanpham.masanpham  = " + cb_tenSanPham.SelectedValue + " and hoadonchitiet.mahoadon = (select max(mahoadon) from hoadon)";

                }
                else
                {
                    strup = "update sanpham set sanpham.soluong = sanpham.soluong  - " + tb_soLuongMua.Text + " from sanpham, hoadonchitiet  where  sanpham.masanpham  = " + cb_tenSanPham.SelectedValue + " and hoadonchitiet.mahoadon = (select max(mahoadon) from hoadon)";

                }
            }

            help.CapNhatDL(strinsr);
            if (help.CapNhatDL(strup) > 0)
            {
                MessageBox.Show("Thêm thành công");
            }

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
