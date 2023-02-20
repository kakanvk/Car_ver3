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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_v3
{
    public partial class ChiTietPhieuNhap : Form
    {

        help help = new help();
        DataTable tb = new DataTable();
        PhieuNhapMoi pnm;
        
        public ChiTietPhieuNhap(PhieuNhapMoi _pnm)
        {
            InitializeComponent();
            help = new help();
            pnm = _pnm;
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

            if(PhieuNhapMoi.check != 3)
            {
                str = "select * from sanpham";

                tb = help.LayBang(str);
                cb_tenSanPham.DataSource = tb;
                cb_tenSanPham.DisplayMember = "tensanpham";
                cb_tenSanPham.ValueMember = "masanpham";
                tb_thanhTien.Enabled = false;
            }
            else
            {
                str = "select * from sanpham where masanpham = "+PhieuNhapMoi.id_sanPham_cellclick+"";

                tb = help.LayBang(str);
                cb_tenSanPham.DataSource = tb;
                cb_tenSanPham.DisplayMember = "tensanpham";
                cb_tenSanPham.ValueMember = "masanpham";
                tb_thanhTien.Enabled = false;
            }
           
        }

        private bool kiemtratontai()
        {
            bool tatkt = false;
            int test = PhieuNhapMoi.id_sanPham_cellclick;
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = oto");
            con.Open();
            DataTable dt_kiemtra = new DataTable();
            if (PhieuNhap.check == 3)
            {
                SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from chitietnhap  where masanpham=" + test + " and  maphieunhap = (select max(maphieunhap) from phieunhap )", con);
                da_kiemtra.Fill(dt_kiemtra);
                if (dt_kiemtra.Rows.Count > 0)
                {
                    tatkt = true;
                }
                da_kiemtra.Dispose();
            }
            else
            {
                SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select * from chitietnhap  where masanpham=" + test + " and  maphieunhap = " + PhieuNhap.id_phieuNhap_cellclick + "", con);
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
            string str, str1;
            string query = "";
            if(tb_giaNhap.Text == "" || tb_soLuongNhap.Text == "" || cb_tenSanPham.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin");
            }
            if (PhieuNhap.check == 3)
            {
                query = "select maphieunhap from phieunhap where maphieunhap = "+PhieuNhap.id+"";
            }
            else
            {
                query = "select max(maphieunhap) from phieunhap";
            }



            tb = help.LayBang(query);
            foreach (DataRow dr in tb.Rows)
            {
                id = dr[0].ToString();
            }

            if (PhieuNhapMoi.check == 3)
            {
                str = "update  chitietnhap set soluongnhap = " + tb_soLuongNhap.Text + ", gianhap = " + tb_giaNhap.Text + ",thanhtienctn = "+tb_thanhTien.Text+" where masanpham = " + cb_tenSanPham.SelectedValue + "and maphieunhap = " + PhieuNhap.id_phieuNhap_cellclick + "";

            }
            else
            {
                str = "insert into chitietnhap values( " + cb_tenSanPham.SelectedValue + ",(select max(maphieunhap) from phieunhap)," + tb_soLuongNhap.Text + "," + tb_giaNhap.Text + "," + tb_thanhTien.Text + ")";

            }
            // sl xe
            if (kiemtratontai())
            {
                str1 = "update sanpham set sanpham.soluong = sanpham.soluong - chitietnhap.soluongnhap + " + tb_soLuongNhap.Text + " from sanpham, chitietnhap  where  sanpham.masanpham  = " + cb_tenSanPham.SelectedValue + " and chitietnhap.maphieunhap = " + id+"";
                help.CapNhatDL(str1);

            }
            else
            {
                str1 = "update sanpham set sanpham.soluong = sanpham.soluong  + " + tb_soLuongNhap.Text + " from sanpham, chitietnhap  where  sanpham.masanpham  = " + cb_tenSanPham.SelectedValue + " and chitietnhap.maphieunhap = " + id  + "";
                help.CapNhatDL(str1);
            }

            if (help.CapNhatDL(str) > 0 )
            {
                MessageBox.Show("Thêm thành công");
            }

            pnm.HienThiDl_phieuNhapMoi();
            this.Close();

        }
        private void tb_giaNhap_TextChanged(object sender, EventArgs e)
        {
            Multiply();

        }

        private void tb_soLuongNhap_TextChanged(object sender, EventArgs e)
        {
            Multiply();

        }

        public void Multiply()
        {
            int a, b;

            bool isAValid = int.TryParse(tb_giaNhap.Text, out a);
            bool isBValid = int.TryParse(tb_soLuongNhap.Text, out b);

            if (isAValid && isBValid)
                
                tb_thanhTien.Text = (a * b).ToString();

            else
                tb_thanhTien.Text = "Đầu vào không hợp lệ";
        }

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
