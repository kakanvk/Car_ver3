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
        Boolean checkthem = true;
        public PhieuNhapMoi()
        {
            InitializeComponent();
            MessageBox.Show("" + PhieuNhap.id);
           
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

        }
        public void HienThiDl_phieuNhapMoi()
        {
            string id = "";
            string query;
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
            dgv_phieuNhap.DataSource = tb;

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

        private void dgv_phieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
    
}
