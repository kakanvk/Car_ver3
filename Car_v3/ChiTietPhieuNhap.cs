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
    public partial class ChiTietPhieuNhap : Form
    {

        help help = new help();
        DataTable tb = new DataTable();
        PhieuNhapMoi pnm;
        public ChiTietPhieuNhap(PhieuNhapMoi _pnm)
        {
            InitializeComponent();
            help = new help();
            pnm = _pnm;
            if (help.Mo_KN_CSDL())
            {
                HienThiDL();
            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
        }

        private void lb_themSanPham_Click(object sender, EventArgs e)
        {
            XeMoi xe = new XeMoi();
            xe.ShowDialog();
        }
        void HienThiDL()
        {
            string str;

            str = "select * from sanpham";

            tb = help.LayBang(str);
            cb_tenSanPham.DataSource = tb;
            cb_tenSanPham.DisplayMember = "tensanpham";
            cb_tenSanPham.ValueMember = "masanpham";
            tb_thanhTien.Enabled = false;
           
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string id = "";
            string str ="";
            string query = "";
            if(tb_giaNhap.Text == "" || tb_soLuongNhap.Text == "" || cb_tenSanPham.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin");
            }

            if (PhieuNhap.check == 3)
            {
                query = "select maphieunhap from phieunhap where maphieunhap = "+PhieuNhap.id+"";
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
            MessageBox.Show(id);
            
            str = "insert into chitietnhap values(" + cb_tenSanPham.SelectedValue + "," + id + "," + tb_soLuongNhap.Text + "," + tb_giaNhap.Text + "," + tb_thanhTien.Text + ")";
            help.CapNhatDL(str);
            
            pnm.HienThiDl_phieuNhapMoi();
            this.Close();





            


        }
        private void tb_giaNhap_TextChanged(object sender, EventArgs e)
        {
            Multiply();

        }

        private void tb_soLuongNhap_TextChanged(object sender, EventArgs e)
        {
            Multiply();

        }

        public void Multiply()
        {
            int a, b;

            bool isAValid = int.TryParse(tb_giaNhap.Text, out a);
            bool isBValid = int.TryParse(tb_soLuongNhap.Text, out b);

            if (isAValid && isBValid)
                tb_thanhTien.Text = (a * b).ToString();

            else
                tb_thanhTien.Text = "Đầu vào không hợp lệ";
        }

        private void ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
