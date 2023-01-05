using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_v3
{
    public partial class XeMoi : Form
    {
        help help = new help();
        DataTable tb = new DataTable();
        Xe xe;

        public XeMoi(Xe _xe)
        {
            InitializeComponent();
            HienThiDL();
            this.xe = _xe;
        }

        public XeMoi()
        {
            InitializeComponent();
            HienThiDL();
            this.xe = null;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XeMoi_Load(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "Data Source=.;Integrated Security = True; Initial Catalog = Oto";
                if (Xe.check == 1)
                {
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand command = con.CreateCommand();
                    var image = new ImageConverter().ConvertTo(PictureBox1.Image, typeof(byte[]));
                    command.Parameters.AddWithValue("@image", image);

                    //command.CommandText = "insert into sanpham values (" + cb_nsx.SelectedValue + "," + cb_loaiXe.SelectedValue + ", N'" + tb_tenSanPham.Text.Trim() + "', N'" + tb_moTa.Text.Trim() + "', N'" + tb_mau.Text.Trim() + "', " + tb_giaBan.Text + ", @image" + ", N'" + tb_dongCo.Text.Trim() + "',N'" + tb_den.Text.Trim() + "',N'" + tb_hopSo.Text.Trim() + "'," + tb_soTuiKhi.Text + "'," + tb_soTuiKhi.Text + ")";

                    command.CommandText = "insert into sanpham(maloai, mansx, tensanpham, mota, mau, den, dongco, hopso, soluong, sotuikhi, gia,anh) values(" + cb_loaiXe.SelectedValue + "," + cb_nsx.SelectedValue + ", N'" + tb_tenSanPham.Text.Trim() + "', N'" + tb_moTa.Text.Trim() + "', N'" + tb_mau.Text + "', N'" + tb_den.Text.Trim() + "', N'" + tb_dongCo.Text + "', N'" + tb_hopSo.Text.Trim() + "', " + 0 + ", " + tb_soTuiKhi.Text + ", " + tb_giaBan.Text + ",@image)";

                    //command.CommandText = "insert into sanpham(maloai, mansx, tensanpham, mota, mau, den, dongco, hopso, soluong, sotuikhi, gia) values(1,2, N'A', N'sdgg', N'Đỏ', N'Đỏ', N'2 thì', N'2', 0, 2, 2)";

                    command.ExecuteNonQuery();
                    
                    if (xe!=null) xe.HienThiDL();
                    con.Close();
                    this.Close();
                }

                else if (Xe.check == 3)
                {

                    //update
                    int id_xe_click = Xe.id;
                    help.Mo_KN_CSDL();
                    string query = "update sanpham set maloai =" + cb_loaiXe.SelectedValue + ",gia = "+tb_giaBan.Text+", mansx = " + cb_nsx.SelectedValue + ", tenSanPham = N'" + tb_tenSanPham.Text.Trim() + "', mota = N'" + tb_moTa.Text.Trim() + "', mau =N'" + tb_mau.Text.Trim() + "', den = N'" + tb_den.Text + "', dongCo = N'" + tb_dongCo.Text.Trim() + "', hopso = N'" + tb_hopSo.Text.Trim() + "',  soTuiKhi = " + tb_soTuiKhi.Text + " where masanpham = " + id_xe_click + ";";
                    help.CapNhatDL(query);

                    

                    xe.HienThiDL();
                    this.Close();
                }
            }
            catch
            {

            }
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

        void HienThiDL()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            string str;
            int id_xe_click = Xe.id;
            con.Open();

            if (Xe.check == 1)
            {
                // Combobox Loại xe
                str = "select * from loaixe order by maloai";

                tb = help.LayBang(str);
                cb_loaiXe.DataSource = tb;
                cb_loaiXe.DisplayMember = "tenloai";
                cb_loaiXe.ValueMember = "maloai";


                // Combobox NSX
                str = "select mansx, tennsx from nsx order by mansx";

                tb = help.LayBang(str);
                cb_nsx.DataSource = tb;
                cb_nsx.DisplayMember = "tennsx";
                cb_nsx.ValueMember = "mansx";

            }

            else if(Xe.check ==2)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM sanpham where masanpham = @id", con);
                cmd.Parameters.AddWithValue("@id", id_xe_click);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tb_tenSanPham.Text = dr.GetValue(3).ToString();
                    tb_moTa.Text = dr.GetValue(4).ToString();
                    tb_mau.Text = dr.GetValue(5).ToString();
                    tb_giaBan.Text = dr.GetValue(6).ToString();
                    tb_dongCo.Text = dr.GetValue(8).ToString();
                    tb_den.Text = dr.GetValue(9).ToString();
                    tb_hopSo.Text = dr.GetValue(10).ToString();
                    tb_soTuiKhi.Text = dr.GetValue(11).ToString();
                    byte[] b = new byte[0];
                    b = (Byte[])(dr["anh"]);
                    MemoryStream ms = new MemoryStream(b);
                    PictureBox1.Image = Image.FromStream(ms);

                    tb_tenSanPham.Enabled = false;
                    tb_moTa.Enabled = false;
                    tb_mau.Enabled = false;
                    tb_giaBan.Enabled = false;
                    tb_dongCo.Enabled = false;
                    tb_den.Enabled = false;
                    tb_hopSo.Enabled = false;
                    tb_soTuiKhi.Enabled = false;
                    cb_loaiXe.Enabled = false;
                    cb_nsx.Enabled = false;
                    btn_themNSX.Enabled = false;
                    lb_themLoaiXe.Enabled = false;
                    btn_chonAnh.Enabled = false;
                    btn_luu.Enabled = false;
                }

                str = "select tenloai, loaixe.maloai from sanpham , loaixe where sanpham.masanpham = " + id_xe_click + " and loaixe.maloai = sanpham.maloai";

                tb = help.LayBang(str);
                cb_loaiXe.DataSource = tb;
                cb_loaiXe.DisplayMember = "tenloai";
                cb_loaiXe.ValueMember = "maloai";


                str = "select tennsx, nsx.mansx from sanpham , nsx where sanpham.masanpham = " + id_xe_click + " and nsx.mansx = sanpham.mansx";

                tb = help.LayBang(str);
                cb_nsx.DataSource = tb;
                cb_nsx.DisplayMember = "tennsx";
                cb_nsx.ValueMember = "mansx";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM sanpham where masanpham = @id", con);
                cmd.Parameters.AddWithValue("@id", id_xe_click);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tb_tenSanPham.Text = dr.GetValue(3).ToString();
                    tb_moTa.Text = dr.GetValue(4).ToString();
                    tb_mau.Text = dr.GetValue(5).ToString();
                    tb_giaBan.Text = dr.GetValue(6).ToString();
                    tb_dongCo.Text = dr.GetValue(8).ToString();
                    tb_den.Text = dr.GetValue(9).ToString();
                    tb_hopSo.Text = dr.GetValue(10).ToString();
                    tb_soTuiKhi.Text = dr.GetValue(11).ToString();
                    
                    byte[] b = new byte[0];
                    b = (Byte[])(dr["anh"]);
                    MemoryStream ms = new MemoryStream(b);
                    PictureBox1.Image = Image.FromStream(ms);
                    

                }

                //str = "select tenloai, loaixe.maloai from sanpham , loaixe where sanpham.masanpham = " + id_xe_click + " and loaixe.maloai = sanpham.maloai";
                str = "select * from loaixe;";

                tb = help.LayBang(str);
                cb_loaiXe.DataSource = tb;
                cb_loaiXe.DisplayMember = "tenloai";
                cb_loaiXe.ValueMember = "maloai";


                str = "select tennsx, nsx.mansx from sanpham , nsx where sanpham.masanpham = " + id_xe_click + " and nsx.mansx = sanpham.mansx";

                tb = help.LayBang(str);
                cb_nsx.DataSource = tb;
                cb_nsx.DisplayMember = "tennsx";
                cb_nsx.ValueMember = "mansx";


            }

            con.Close();
        }

        public void renderCbbLoaiXe()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            string str;
            con.Open();

            str = "select * from loaixe order by maloai";

            tb = help.LayBang(str);
            cb_loaiXe.DataSource = tb;
            cb_loaiXe.DisplayMember = "tenloai";
            cb_loaiXe.ValueMember = "maloai";

            con.Close();
        }


        public void renderCbbNSX()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Integrated Security = True; Initial Catalog = Oto");
            string str;
            con.Open();

            str = "select mansx, tennsx from nsx order by mansx";

            tb = help.LayBang(str);
            cb_nsx.DataSource = tb;
            cb_nsx.DisplayMember = "tennsx";
            cb_nsx.ValueMember = "mansx";

            con.Close();
        }

        private void lb_themLoaiXe_Click(object sender, EventArgs e)
        {
            LoaiXeMoi xe = new LoaiXeMoi(this);
            xe.ShowDialog();
        }

        private void btn_themNSX_Click(object sender, EventArgs e)
        {
            NSXMoi nsx = new NSXMoi(this);
            nsx.ShowDialog();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }
    }
}
