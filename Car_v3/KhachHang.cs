using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_v3
{
    public partial class KhachHang : Form
    {
        help help = new help();
        DataTable tb;
        public static int id;
        public static int check = 0;
        public KhachHang()
        {
            InitializeComponent();
            help = new help();
            if (help.Mo_KN_CSDL())
            {
                HienThiDL();
            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            check = 1;
            KhachHangMoi khachHangMoi = new KhachHangMoi(this);
            khachHangMoi.ShowDialog();
        }
        public void HienThiDL()
        {
            string str = "select * from khachhang order by maKhachHang";
            //MAKHACHHANG as 'Mã khách hàng', tenKhachHang as 'Tên khách hàng', diachiKhachHang as 'Địa Chỉ', sdtkhachhang as 'SĐT'
            //str = "select a.MANHANVIEN , B.TENPHANQUYEN FROM NHANVIEN AS a ,PHANQUYEN AS b where a.MAPHANQUYEN = b.MAPHANQUYEN;";
            tb = help.LayBang(str);
            dgv_khachHang.DataSource = tb;
            dgv_khachHang.AllowUserToAddRows = false;
            dgv_khachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            check = 2;
            KhachHangMoi khachHangMoi = new KhachHangMoi(this);
            khachHangMoi.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            KhachHangMoi khachHangMoi = new KhachHangMoi(this);
            khachHangMoi.ShowDialog();
        }

        private void dgv_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_khachHang.Rows[e.RowIndex];

            dgv_khachHang.CurrentRow.Selected = true;

            id = Convert.ToInt32(row.Cells[0].Value.ToString());
        }

        private void tb_timKiem_TextChanged(object sender, EventArgs e)
        {
            (dgv_khachHang.DataSource as DataTable).DefaultView.RowFilter = string.Format("tenkhachhang LIKE '%{0}%' or diachiKhachhang like '%{0}%'", tb_timKiem.Text);

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string str = "delete khachhang where maKhachHang =" + id + "";
            if (help.CapNhatDL(str) == 0)
            {
                MessageBox.Show("Khách hàng đã mua sản phẩm !");
                return;
            }

            HienThiDL();
        }
    }
}
