using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_v3
{
    public partial class NhanVienMoi : Form
    {
        help help = new help();
        DataTable tb = new DataTable();
        NhanVien nv ;

        public NhanVienMoi(NhanVien _nv)
        {

            InitializeComponent();
            nv = _nv;
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

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int id_nhanvien_click = NhanVien.id;
            if (tb_diaChi.Text == "" || tb_tenNhanVien.Text == "" || cb_gioiTinh.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_matKhau.Text == "")
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
               if(NhanVien.check == 1)
                {
                    //SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
                    string query = "insert into nhanvien values (" + cb_chucVu.SelectedValue + ",N'" + tb_tenNhanVien.Text.Trim() + "','" + ns_nhanVien.Value + "',N'" + cb_gioiTinh.Text.Trim() + "'," + tb_sdt.Text + ",'" + tb_matKhau.Text.Trim() + "','" + tb_email.Text.Trim() + "',N'" + tb_diaChi.Text.Trim() + "')";
                    help.CapNhatDL(query);
                    //string query = "insert into nhanvien values (" + cb_chucVu.SelectedValue + ",N'" + tb_tenNhanVien.Text.Trim() + "','" + ns_nhanVien.Value + "',N'" + cb_gioiTinh.Text.Trim() + "'," + tb_sdt.Text + ",'" + tb_matKhau.Text.Trim() + "','" + tb_email.Text.Trim() + "',N'" + tb_diaChi.Text.Trim() + "')";


                    nv.HienThiDL();
                    this.Close();
                }
               else if(NhanVien.check == 3)
                    {
                    //update
                    string query = "update nhanvien set maphanquyen =" + cb_chucVu.SelectedValue + ", tennhanvien = N'" + tb_tenNhanVien.Text.Trim() + "', ngaysinhnv = '" + ns_nhanVien.Value + "', gioitinhnv =N'" + cb_gioiTinh.Text.Trim() + "', sdtnhanvien = " + tb_sdt.Text + ", password = '" + tb_matKhau.Text.Trim() + "', emailnhanvien ='" + tb_email.Text.Trim() + "', diachinhanvien = N'" + tb_diaChi.Text.Trim() + "' where manhanvien = "+id_nhanvien_click+"";
                    help.CapNhatDL(query);

                    nv.HienThiDL();
                    this.Close();
                    }                                                           
            }
            catch
            {

            }
        }

        void HienThiDL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            string str;
            int id_nhanvien_click = NhanVien.id;
            con.Open();
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM nhanvien where manhanvien = @id",con);
            cmd.Parameters.AddWithValue("@id",id_nhanvien_click);
            SqlDataReader dr = cmd.ExecuteReader();
            if(NhanVien.check == 1)
            {
                                       
                    str = "select * from phanquyen";

                    tb = help.LayBang(str);
                    cb_chucVu.DataSource = tb;
                    cb_chucVu.DisplayMember = "tenphanQuyen";
                    cb_chucVu.ValueMember = "maphanQuyen";
                    

            }
            else if(NhanVien.check == 2)
                {
                    while (dr.Read())
                    {
                        tb_tenNhanVien.Text = dr.GetValue(2).ToString();
                        ns_nhanVien.Text = dr.GetValue(3).ToString();
                        cb_gioiTinh.Text = dr.GetValue(4).ToString();
                        tb_sdt.Text = dr.GetValue(5).ToString();
                        tb_matKhau.Text = dr.GetValue(6).ToString();
                        tb_email.Text = dr.GetValue(7).ToString();
                        tb_diaChi.Text = dr.GetValue(8).ToString();

                        tb_tenNhanVien.ReadOnly = true;
                        this.ns_nhanVien.Enabled = false;
                        cb_gioiTinh.Enabled = false;
                        tb_sdt.ReadOnly = true;
                        tb_matKhau.ReadOnly = true;
                        tb_email.ReadOnly = true;
                        tb_diaChi.ReadOnly = true;
                        btn_luu.Enabled = false;
                    }
                str = "select tenphanquyen, phanquyen.maphanquyen from nhanvien , phanquyen where nhanvien.manhanvien = " + id_nhanvien_click + " and phanquyen.maphanquyen = nhanvien.maphanquyen";


                tb = help.LayBang(str);
                cb_chucVu.DataSource = tb;
                cb_chucVu.DisplayMember = "tenphanQuyen";
                cb_chucVu.ValueMember = "maphanQuyen";
            }
                else
                {
                    while (dr.Read())
                    {
                        tb_tenNhanVien.Text = dr.GetValue(2).ToString();
                        ns_nhanVien.Text = dr.GetValue(3).ToString();
                        cb_gioiTinh.Text = dr.GetValue(4).ToString();
                        tb_sdt.Text = dr.GetValue(5).ToString();
                        tb_matKhau.Text = dr.GetValue(6).ToString();
                        tb_email.Text = dr.GetValue(7).ToString();
                        tb_diaChi.Text = dr.GetValue(8).ToString();
                    }

                str = "select * from phanquyen";

                tb = help.LayBang(str);
                cb_chucVu.DataSource = tb;
                cb_chucVu.DisplayMember = "tenphanQuyen";
                cb_chucVu.ValueMember = "maphanQuyen";
            }
            
            

            con.Close();
        }

        private void NhanVienMoi_Load(object sender, EventArgs e)
        {

        }
    }
}
