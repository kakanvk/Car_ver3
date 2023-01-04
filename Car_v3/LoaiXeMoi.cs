using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_v3
{
    public partial class LoaiXeMoi : Form
    {
        LoaiXe LoaiXe;
        XeMoi XeMoi;
        help help = new help(); 
       
        public LoaiXeMoi(LoaiXe _loaiXe)
        {
            LoaiXe = _loaiXe;
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

        public LoaiXeMoi(XeMoi _xeMoi)
        {
            XeMoi = _xeMoi;
            InitializeComponent();
        }

        string str = "Data Source=.;Integrated Security = True; Initial Catalog = Oto";
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (tb_tenLoai.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin!!!");
                return;
            }
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand command = con.CreateCommand();
           if(LoaiXe.check == 1)
            {
                command.CommandText = "insert into loaixe values(N'" + tb_tenLoai.Text.Trim() + "')";
            }
            else
            {
                command.CommandText = "update loaixe set tenloai = N'" + tb_tenLoai.Text.Trim() + "' where maloai = "+LoaiXe.id+"";
            }
            command.ExecuteNonQuery();
            LoaiXe.HienThiDL();
            this.Close();
            con.Close();
        }
        void HienThiDL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            string str;
            //int id_nsx_click = NSX.id;
            int id_loaiXE = LoaiXe.id;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM loaixe where maloai = @id", con);
            cmd.Parameters.AddWithValue("@id", id_loaiXE);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (LoaiXe.check == 1)
            {

            }
            else if (LoaiXe.check == 2)
            {
                while (dr.Read())
                {
                    tb_tenLoai.Text = dr.GetValue(1).ToString();
                    btn_luu.Enabled = false;
                    tb_tenLoai.Enabled = false;
                }

            }
            else
            {
                while (dr.Read())
                {
                    tb_tenLoai.Text = dr.GetValue(1).ToString();

                }
            }
            con.Close();
        }
    }
}
