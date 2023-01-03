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
    public partial class NSXMoi : Form
    {
        help help = new help();
        DataTable tb;
        NSX NSX;
        public NSXMoi(NSX nSX)
        {
            InitializeComponent();
            NSX = nSX;
            help = new help();
            if (help.Mo_KN_CSDL())
            {
                HienThiDL();

            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
            NSX = nSX;
        }
        string str = "Data Source=.;Integrated Security = True; Initial Catalog = Oto";
        

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (tb_diaChi.Text == "" || tb_tenNSX.Text == "" || tb_sdt.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin!!!");
                return;
            }
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(PictureBox1.Image, typeof(byte[]));
            command.Parameters.AddWithValue("@image", image);
            command.CommandText = "insert into nsx values(N'" + tb_tenNSX.Text.Trim() + "',N'" + tb_diaChi.Text.Trim() + "'," + tb_sdt.Text.Trim() + ",@image)";
            command.ExecuteNonQuery();
            NSX.HienThiDL();
            this.Close();
            con.Close();
        }
        void HienThiDL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            string str;
            int id_nsx_click = NSX.id;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM nsx where maNSX = @id", con);
            cmd.Parameters.AddWithValue("@id", id_nsx_click);
            SqlDataReader dr = cmd.ExecuteReader();
            if (NSX.check == 1)
            {

            }
            else if (NSX.check == 2)
            {
                while (dr.Read())
                {
                    tb_tenNSX.Text = dr.GetValue(1).ToString();
                    tb_diaChi.Text = dr.GetValue(2).ToString();
                    tb_sdt.Text = dr.GetValue(3).ToString();
                    byte[] b = new byte[0];
                    b = (Byte[])(dr["logoNSX"]);
                    MemoryStream ms = new MemoryStream(b);
                    PictureBox1.Image = Image.FromStream(ms);

                    tb_tenNSX.ReadOnly = true;
                    tb_diaChi.ReadOnly = true;
                    tb_sdt.ReadOnly = true;
                    btn_luu.Enabled = false;
                }
                
            }
            else
            {
                while (dr.Read())
                {
                    tb_tenNSX.Text = dr.GetValue(1).ToString();
                    tb_diaChi.Text = dr.GetValue(2).ToString();
                    tb_sdt.Text = dr.GetValue(3).ToString();
                    byte[] b = new byte[0];
                    b = (Byte[])(dr["logoNSX"]);
                    MemoryStream ms = new MemoryStream(b);
                    PictureBox1.Image = Image.FromStream(ms);
                }
            }


            con.Close();
        }
        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png)|*.jpg;*.jpeg;.*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                PictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
