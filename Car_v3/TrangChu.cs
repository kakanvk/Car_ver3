using System;
using System.Collections;
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
    public partial class TrangChu : Form
    {
        help help = new help();
        DataTable tb = new DataTable();

        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_QLNSX_Click(object sender, EventArgs e)
        {
            NSX newNSX = new NSX();
            newNSX.Show();
        }


        int id;
        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (help.Checkper() !=3){ }
            else
            {
                Login login = new Login();
                login.ShowDialog();
            }
            if(Login.ID_LEVEL =="1")
            {
                lb_chucvu.Text = "Nhân Viên";

            }
            else
            {
                lb_chucvu.Text = "Quản lý";
            }

            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            con.Open();
            SqlCommand cmd1;
            cmd1 = new SqlCommand("select tennhanvien from nhanvien where manhanvien = " + Login.ID_STAFF + "",con);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                lb_tennhanvien.Text = dr1.GetValue(0).ToString();
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

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            LoaiXe loaiXe = new LoaiXe();
            loaiXe.Show();
        }

        private void btn_phieuNhap_Click(object sender, EventArgs e)
        {

            PhieuNhap newPN = new PhieuNhap();
            newPN.Show();
        }

        private void btn_hoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Xe xe = new Xe();
            xe.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Login.ID_LEVEL = "";
            Login.ID_STAFF = "";
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
