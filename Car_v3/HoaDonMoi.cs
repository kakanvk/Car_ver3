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
        public static int id_khachHang;
        HoaDon hoaDon;
        int id_sanPham_cellclick;
        Boolean checkthem = true;
        public HoaDonMoi(HoaDon _hoaDon)
        {
            InitializeComponent();
            hoaDon = _hoaDon;
            if (help.Mo_KN_CSDL())
            {
                HienThiDL();
                if (HoaDon.check != 1)
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
            tb_tongSoLuong.Enabled = false;
            tb_thanhTien.Enabled = false;
            if (HoaDon.check == 2)
            {
                btn_luu.Enabled = false;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
                cb_khachHang.Enabled = false;
                
            }

        }

       public void HienThiDL_HoaDonMoi()
        {
            string id = "";
            string query;

            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            con.Open();
            SqlCommand cmd1;
            if (HoaDon.check == 3 || HoaDon.check == 2)
            {
                cmd1 = new SqlCommand("SELECT hoadonchitiet.mahoadon,SUM(soluongmua) as soluong ,SUM (THANHTIENHDCT) as thanhtien frOM hoadonchitiet where mahoadon = " + HoaDon.id + " GROUP BY mahoadon", con);

            }
            else
            {
                cmd1 = new SqlCommand("SELECT hoadonchitiet.mahoadon,SUM(soluongmua) as soluong ,SUM (THANHTIENHDCT) as thanhtien frOM hoadonchitiet where mahoadon = (   SELECT MAX(mahoadon)  FROM hoadon ) GROUP BY mahoadon", con);

            }

            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                tb_tongSoLuong.Text = dr1.GetValue(1).ToString();
                tb_thanhTien.Text = dr1.GetValue(2).ToString();
            }


            if (HoaDon.check != 1)
            {
                query = "select * from hoadon where mahoadon = " + HoaDon.id + "";
            }
            else
            {
                query = "select max(mahoadon) from hoadon";
            }
            tb = help.LayBang(query);
            foreach (DataRow dr in tb.Rows)
            {
                id = dr[0].ToString();
            }
            string str ="select * from hoadonchitiet where mahoadon =" + id + "";
            tb = help.LayBang(str);
            con.Close();
            dgv_hoaDonMoi.DataSource = tb;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            check = 1;
            int id_nhanvien = Convert.ToInt32(Login.ID_STAFF);
            if (checkthem == true && HoaDon.check != 3)
            {
                SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
                con.Open();
                SqlCommand command = con.CreateCommand();
                id_khachHang = Convert.ToInt32(cb_khachHang.SelectedValue.ToString());
                command.CommandText = "insert into HOADON(MAKHACHHANG,MANHANVIEN) values("+cb_khachHang.SelectedValue+","+Login.ID_STAFF+")";
                command.ExecuteNonQuery();
               

                con.Close();
                
                checkthem = false;

                
            }
            
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(this);
            chiTietHoaDon.ShowDialog();
        }

        private void dgv_hoaDonMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_hoaDonMoi.Rows[e.RowIndex];

            dgv_hoaDonMoi.CurrentRow.Selected = true;


            id_sanPham_cellclick = Convert.ToInt32(row.Cells["maSanPham"].Value.ToString());

            if (id != 0)
            {
                btn_sua.Enabled = true;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            con.Open();
            SqlCommand command = con.CreateCommand();
            if (HoaDon.check == 3)
            {
                command.CommandText = "update hoadon set diachigiao ='" + tb_diaChiGiao.Text+ "',ngayMua = '"+ngayMua.Value+"',ghichu = N'" + tb_ghiChu.Text + "' , thanhtienban = " + tb_thanhTien.Text + " from hoadon where mahoadon =" + HoaDon.id + "";
            }
            else
            {
                command.CommandText = "update hoadon set diachigiao ='" + tb_diaChiGiao.Text + "',ngayMua = '" + ngayMua.Value + "',ghichu = N'" + tb_ghiChu.Text + "' , thanhtienban = " + tb_thanhTien.Text + " FROM hoadon  WHERE mahoadon = (   SELECT MAX(mahoadon)  FROM hoadon ) ";
            }
            command.ExecuteNonQuery();
            hoaDon.HienthiDL();
            this.Close();

            con.Close();
          
           
            
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            con.Open();
            SqlCommand command = con.CreateCommand();
            if (HoaDon.check == 3)
            {
                command.CommandText = "delete hoadonchitiet  where mahoadon =" + HoaDon.id + "";
                command.ExecuteNonQuery();
            }
            else
            {
                command.CommandText = "delete hoadonchitiet  WHERE mahoadon = (   SELECT MAX(mahoadon)  FROM hoadon ) ";
                command.ExecuteNonQuery();

                
            }
            if(check ==1)
            {
                command.CommandText = "delete hoadon  WHERE mahoadon = (   SELECT MAX(mahoadon)  FROM hoadon ) ";
                command.ExecuteNonQuery();
            }


            hoaDon.HienthiDL();
            this.Close();

            con.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete hoadonchitiet where masanpham = " + id_sanPham_cellclick + " ";
            help.CapNhatDL(query);
            HienThiDL_HoaDonMoi();
            HienThiDL();
        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            InHoaDon hd = new InHoaDon(HoaDon.id);
            hd.Show();
        }

        private void HoaDonMoi_Load(object sender, EventArgs e)
        {

        }
    }      
 }

    
    
