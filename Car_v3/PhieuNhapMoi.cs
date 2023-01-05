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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Car_v3
{
    public partial class PhieuNhapMoi : Form
    {
        help help = new help();
        DataTable tb = new DataTable();
        public static int id =0;
        public static int check = 0;
        int id_phieuNhap_cellclick;
        int id_sanPham_cellclick;

        Boolean checkthem = true;
        public PhieuNhapMoi()
        {
            InitializeComponent();
           
            if (help.Mo_KN_CSDL())
            {
                HienThiDL();
                if(PhieuNhap.check != 1) {
                    HienThiDl_phieuNhapMoi();
                }

            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
            
        }
        private void PhieuNhapMoi_Load(object sender, EventArgs e)
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
            string query = "select * from nsx";

            tb = help.LayBang(query);
            cb_tenNSX.DataSource = tb;
            cb_tenNSX.DisplayMember = "tenNSX";
            cb_tenNSX.ValueMember = "maNSX";
            tb_maNSX.Text = cb_tenNSX.SelectedValue.ToString();
            if (PhieuNhap.check == 2)
            {
                btn_luu.Enabled = false;
                btn_them.Enabled = false;
                btn_xoa.Enabled = false;    
                btn_sua.Enabled = false;
                cb_tenNSX.Enabled = false;
                tb_tongSoLuong.Enabled = false ;
                tb_tongThanhTien.Enabled = false ;  
            }

        }
        public void HienThiDl_phieuNhapMoi()
        {
            string id = "";
            string query;

            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            con.Open();
            SqlCommand cmd1;
            if (PhieuNhap.check == 3 || PhieuNhap.check ==2)
            {
                cmd1 = new SqlCommand("SELECT CHITIETNHAP.maphieunhap,SUM(soluongnhap) as soluong ,SUM (thanhtienCTN) as thanhtien frOM CHITIETNHAP where maphieunhap = "+PhieuNhap.id+" GROUP BY maphieunhap", con);

            }
            else
            {
                cmd1 = new SqlCommand("SELECT CHITIETNHAP.maphieunhap,SUM(soluongnhap) as soluong , SUM (thanhtienCTN) as thanhtien frOM CHITIETNHAP where MAPHIEUNHAP = (   SELECT MAX(MAPHIEUNHAP)  FROM PHIEUNHAP ) GROUP BY maphieunhap", con);

            }
            
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                tb_tongSoLuong.Text = dr1.GetValue(1).ToString();
                tb_tongThanhTien.Text = dr1.GetValue(2).ToString();
            }


            if (PhieuNhap.check != 1)
            {
                query = "select * from phieunhap where maphieunhap = "+PhieuNhap.id+"";
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
            string str = "select * from chitietnhap where maphieunhap ="+id+"";
            tb = help.LayBang(str);
            con.Close();
            dgv_phieuNhapMoi.DataSource = tb;

        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string query;
            if (PhieuNhap.check == 3)
            {
                query = "update phieunhap set ngayNhap =" + ngayNhap.Value + ", thanhtien = " + tb_tongThanhTien.Text + " from phieunhap where maphieunhap ="+ PhieuNhap.id + "";
            }
            else
            {
                query = "UPDATE PHIEUNHAP SET ngayNhap =" + ngayNhap.Value + ", thanhtien = " + tb_tongThanhTien.Text + " FROM PHIEUNHAP  WHERE MAPHIEUNHAP = (   SELECT MAX(MAPHIEUNHAP)  FROM PHIEUNHAP ); ";
            }
            help.CapNhatDL(query);
            MessageBox.Show(query);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(tb_maNSX.Text == "")
            {
                MessageBox.Show("Chọn nhà sản xuất");
            }
            int id_nhanvien = Convert.ToInt32(Login.ID_STAFF);
            if(checkthem == true && PhieuNhap.check !=3)
            {
                SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
                con.Open();
                SqlCommand command = con.CreateCommand();
                //command.Parameters.AddWithValue("@image", image);
                command.CommandText = "insert into phieuNhap(manhanvien,maNSX) values(" + id_nhanvien + "," + tb_maNSX.Text + ")";
                command.ExecuteNonQuery();
                //NSX.HienThiDL();

                con.Close();
                checkthem = false;
            }
            ChiTietPhieuNhap phieuNhap = new ChiTietPhieuNhap(this);
            phieuNhap.ShowDialog();
        }

        private void cb_tenNSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_maNSX.Text = cb_tenNSX.SelectedValue.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete chitietnhap where masanpham = " + id_sanPham_cellclick + " ";
            help.CapNhatDL(query);
            HienThiDl_phieuNhapMoi();
            HienThiDL();
            
        }

        private void dgv_phieuNhap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_phieuNhapMoi.Rows[e.RowIndex];

            dgv_phieuNhapMoi.CurrentRow.Selected = true;


            id_sanPham_cellclick = Convert.ToInt32(row.Cells["maSanPham"].Value.ToString());
            id_phieuNhap_cellclick = Convert.ToInt32(row.Cells["maSanPham"].Value.ToString());

            if (id != 0)
            {
                btn_sua.Enabled = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap phieuNhap = new ChiTietPhieuNhap(this);
            phieuNhap.ShowDialog();
        }
    }
    
    
}
