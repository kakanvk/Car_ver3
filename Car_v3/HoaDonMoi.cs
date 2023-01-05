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
    public partial class HoaDonMoi : Form
    {
        help help = new help();
        DataTable tb = new DataTable();
        public static int id = 0;
        public static int check = 0;
        int id_phieuNhap_cellclick;
        int id_sanPham_cellclick;
        public static int id_khachHang;

        Boolean checkthem = true;
        public HoaDonMoi()
        {
            InitializeComponent();

            if (help.Mo_KN_CSDL())
            {
                HienThiDL();
                if (HoaDonMoi.check != 1)
                {
                    HienThiDL_HoaDonMoi();
                }

            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }

        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        void HienThiDL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");

            int id_nhanVien = Int32.Parse(Login.ID_STAFF);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM nhanvien where manhanvien = @id", con);
            cmd.Parameters.AddWithValue("@id", id_nhanVien);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tb_tenNhanVien.Text = dr.GetValue(2).ToString();

            }
            string query = "select * from khachhang";

            tb = help.LayBang(query);
            cb_khachHang.DataSource = tb;
            cb_khachHang.DisplayMember = "tenKhachhnag";
            cb_khachHang.ValueMember = "maKhachHang";
            tb_diaChiGiao.ReadOnly = false;
            
            if (HoaDon.check == 2)
            {
                btn_luu.Enabled = false;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
                cb_khachHang.Enabled = false;
                tb_tongSoLuong.Enabled = false;
                tb_thanhTien.Enabled = false;
            }

        }

       public void HienThiDL_HoaDonMoi()
        {
            string id = "";
            string query;
            
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            con.Open();
            SqlCommand cmd1;
            if (PhieuNhap.check == 3 || PhieuNhap.check == 2)
            {
                cmd1 = new SqlCommand("SELECT hoadonchitiet.mahoadon,SUM(soluongmua) as soluong ,SUM (THANHTIENHDCT) as thanhtien frOM hoadonchitiet where mahoadon = " + HoaDon.id + " GROUP BY mahoadon", con);

            }
            else
            {
                cmd1 = new SqlCommand("SELECT hoadonchitiet.mahoadon,SUM(soluongmua) as soluong , SUM (THANHTIENHDCT) as thanhtien frOM hoadonchitiet where mahoadon = (   SELECT MAX(mahoadon)  FROM hoadon ) GROUP BY mahoadon", con);

            }

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                tb_tongSoLuong.Text = dr1.GetValue(1).ToString();
                tb_thanhTien.Text = dr1.GetValue(2).ToString();
            }

            
            if (HoaDon.check != 1)
            {
                query = "select * from Hoadon where mahoadon = " + HoaDon.id + "";
            }
            else
            {
                query = "select max(mahoadon) from HoaDon";
            }
            tb = help.LayBang(query);
            foreach (DataRow dr in tb.Rows)
            {
                id = dr[0].ToString();
            }
            string str = "select * from hoadonchitiet where mahoadon =" + HoaDon.id + "";
            tb = help.LayBang(str);
            dgv_hoaDonMoi.DataSource = tb;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int id_nhanvien = Convert.ToInt32(Login.ID_STAFF);
            if (checkthem == true && PhieuNhap.check != 3)
            {
                SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
                con.Open();
                SqlCommand command = con.CreateCommand();
                id_khachHang = Convert.ToInt32(cb_khachHang.SelectedValue.ToString());
                command.CommandText = "insert into HOADON(MAKHACHHANG,MANHANVIEN) values("+cb_khachHang.SelectedValue+","+Login.ID_STAFF+")";
                command.ExecuteNonQuery();
                //NSX.HienThiDL();

                con.Close();
                checkthem = false;

                
            }
            
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(this);
            chiTietHoaDon.ShowDialog();
        }

        private void dgv_hoaDonMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }      
 }

    
    
