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
    public partial class Login : Form
    {
        public static string ID_LEVEL = "";
        public static string ID_STAFF = "";

        DataTable tb = new DataTable();
        help help = new help();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            ID_LEVEL = getIDLevel(tb_tenDangNhap.Text, tb_matKhau.Text);
            ID_STAFF = getIDStaff(tb_tenDangNhap.Text, tb_matKhau.Text);
            if (tb_tenDangNhap.Text == "")
            {
                MessageBox.Show("Chưa nhập email !");
                tb_tenDangNhap.Focus();
             }
            else if(tb_matKhau.Text == "") 
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                tb_matKhau.Focus();
            }
            else if (ID_LEVEL != "" && ID_STAFF !="")
            {
                TrangChu main = new TrangChu();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
            }
        }

        private string getIDLevel(string username, string pass)
        {
            string id = "";
            try
            {
                help.Mo_KN_CSDL();
                string str = "SELECT * FROM nhanVien WHERE emailnhanvien ='" + tb_tenDangNhap.Text.Trim() + "' and password='" + tb_matKhau.Text.Trim() + "'";
                tb = help.LayBang(str);
                if (tb != null)
                {
                    foreach (DataRow dr in tb.Rows)
                    {
                        id = dr["maPhanQuyen"].ToString();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                help.DongKN();
            }
            return id;
        }
        private string getIDStaff(string username, string pass)
        {
            string id = "";
            try
            {
                help.Mo_KN_CSDL();
                string str = "SELECT * FROM nhanVien WHERE emailnhanvien ='" + tb_tenDangNhap.Text.Trim() + "' and password='" + tb_matKhau.Text.Trim() + "'";
                tb = help.LayBang(str);
                if (tb != null)
                {
                    foreach (DataRow dr in tb.Rows)
                    {
                        id = dr["maNhanVien"].ToString();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                help.DongKN();
            }
            return id;
        }
    }
}
