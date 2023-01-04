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
    public partial class PhieuNhapMoi : Form
    {
        help help = new help();
        DataTable tb = new DataTable();
        public PhieuNhapMoi()
        {
            InitializeComponent();
            
           
            if (help.Mo_KN_CSDL())
            {
                HienThiDL();

            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
            
        }

        

        private void PhieuNhapMoi_Load(object sender, EventArgs e)
        {
            
        }
        public void HienThiDL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");

            //int id_nhanVien = Int32.Parse(Login.ID_STAFF);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM nhanvien where manhanvien = 1", con);
            //cmd.Parameters.AddWithValue("@id", id_nhanVien);
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

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(tb_maNSX.Text == "")
            {
                MessageBox.Show("Chọn nhà sản xuất");
            }
            int id_nhanvien = Convert.ToInt32(Login.ID_STAFF);
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            con.Open();
            SqlCommand command = con.CreateCommand();
            //command.Parameters.AddWithValue("@image", image);
            command.CommandText = "insert into phieuNhap(manhanvien,maNSX) values(" +id_nhanvien+ ","+tb_maNSX.Text+")";
            command.ExecuteNonQuery();
           //NSX.HienThiDL();
            this.Close();
            con.Close();



            ChiTietPhieuNhap phieuNhap = new ChiTietPhieuNhap();
            phieuNhap.ShowDialog();




        }

        private void cb_tenNSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_maNSX.Text = cb_tenNSX.SelectedValue.ToString();
        }
    }
    
    
}
