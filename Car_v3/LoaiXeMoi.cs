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
        public LoaiXeMoi()
        {
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
            command.CommandText = "insert into loaixe values(N'"+tb_tenLoai.Text.Trim()+"')";
            command.ExecuteNonQuery();
            //NSX.HienThiDL();
            this.Close();
            con.Close();
        }
        void HienThiDL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            string str;
            //int id_nsx_click = NSX.id;
            int id_nsx_click = 1;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM loaixe where maloai = @id", con);
            cmd.Parameters.AddWithValue("@id", id_nsx_click);
            SqlDataReader dr = cmd.ExecuteReader();
            if (NSX.check == 1)
            {

            }
            else if (NSX.check == 2)
            {
                while (dr.Read())
                {
                    tb_tenLoai.Text = dr.GetValue(1).ToString();
                    btn_luu.Enabled = false;
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
