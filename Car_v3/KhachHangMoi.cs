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
    public partial class KhachHangMoi : Form
    {
        KhachHang kh;
        help help = new help();
        DataTable tb = new DataTable();
        public KhachHangMoi(KhachHang _kh)
        {
            InitializeComponent();
            kh = _kh;

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

        void HienThiDL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            string str;
            int id_nhanvien_click = kh.id;
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM khachHang where maKhachHang = @id", con);
            cmd.Parameters.AddWithValue("@id", id_nhanvien_click);
            SqlDataReader dr = cmd.ExecuteReader();
            if (kh.checkButton == 1)
            {
                // Button Thêm mới
            }
            else if (kh.checkButton == 2)
            {
                // Button xem chi tiết
                while (dr.Read())
                {
                    tb_tenKhachHang.Text = dr.GetValue(1).ToString();
                    tb_diaChi.Text = dr.GetValue(2).ToString();
                    cb_gioiTinh.Text = dr.GetValue(3).ToString();
                    tb_sdt.Text = dr.GetValue(4).ToString();                
                    tb_email.Text = dr.GetValue(5).ToString();

                    tb_tenKhachHang.ReadOnly = true;
                    cb_gioiTinh.Enabled = false;
                    tb_sdt.ReadOnly = true;
                    tb_email.ReadOnly = true;
                    tb_diaChi.ReadOnly = true;
                    btn_luu.Enabled = false;
                }
            }
            else
            {
                while (dr.Read())
                {
                    tb_tenKhachHang.Text = dr.GetValue(1).ToString();
                    tb_diaChi.Text = dr.GetValue(2).ToString();
                    cb_gioiTinh.Text = dr.GetValue(3).ToString();
                    tb_sdt.Text = dr.GetValue(4).ToString();
                    tb_email.Text = dr.GetValue(5).ToString();
                }

            }

            con.Close();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void KhachHangMoi_Load(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int id_khachhang_click = kh.id;
            if (tb_diaChi.Text == "" || tb_tenKhachHang.Text == "" || cb_gioiTinh.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" )
            {
                MessageBox.Show("Nhập đủ thông tin!!!");
                return;
            }
            if (tb_sdt.Text.Trim().Length > 10)
            {
                MessageBox.Show("Số điện thoại sai");
                tb_sdt.Focus();
                return;
            }
            try
            {
                if (kh.checkButton == 1)
                {
                    //SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
                    string query = "insert into khachhang values (N'" + tb_tenKhachHang.Text.Trim() + "',N'" + tb_diaChi.Text.Trim() + "',N'" + cb_gioiTinh.Text.Trim() + "','" + tb_sdt.Text + "','" + tb_email.Text.Trim() + "')";
                    help.CapNhatDL(query);
                    //string query = "insert into nhanvien values (" + cb_chucVu.SelectedValue + ",N'" + tb_tenNhanVien.Text.Trim() + "','" + ns_nhanVien.Value + "',N'" + cb_gioiTinh.Text.Trim() + "'," + tb_sdt.Text + ",'" + tb_matKhau.Text.Trim() + "','" + tb_email.Text.Trim() + "',N'" + tb_diaChi.Text.Trim() + "')";

                    kh.HienThiDL();
                    this.Close();
                }
                else if (kh.checkButton == 3)
                {
                    //update
                    string query = "update khachhang set tenKhachHang = N'" + tb_tenKhachHang.Text.Trim() + "', diaChiKhachHang = N'" + tb_diaChi.Text.Trim() + "', gioiTinhKH = N'" + cb_gioiTinh.Text.Trim() + "', sdtKhachHang = '" + tb_sdt.Text + "', emailKhachHang ='" + tb_email.Text.Trim() + "' where maKhachHang = " + id_khachhang_click + "";
                    help.CapNhatDL(query);

                    kh.HienThiDL();
                    this.Close();
                }

            }
            catch
            {

            }
        }
    }
}
