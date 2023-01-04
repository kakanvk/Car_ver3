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

        Boolean checkthem = true;
        public HoaDonMoi()
        {
            InitializeComponent();
            MessageBox.Show("" + PhieuNhap.id);

            if (help.Mo_KN_CSDL())
            {
                //HienThiDL();
                if (HoaDonMoi.check != 1)
                {
                    //HienThiDl_phieuNhapMoi();
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            int id_nhanvien = Convert.ToInt32(Login.ID_STAFF);
            if (checkthem == true && PhieuNhap.check != 3)
            {
                SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = "insert into phieuNhap(manhanvien,maNSX) values(" + id_nhanvien + ")";
                command.ExecuteNonQuery();
                //NSX.HienThiDL();

                con.Close();
                checkthem = false;
            }
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(this);
            chiTietHoaDon.ShowDialog();
        }
    }
}
