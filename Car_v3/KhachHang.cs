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
        public int id;
        public int checkButton = 1;

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

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }
        public void HienThiDL()
        {
            string str = "select MAKHACHHANG as 'Mã khách hàng', tenKhachHang as 'Tên khách hàng', diachiKhachHang as 'Địa Chỉ', sdtkhachhang as 'SĐT' from khachhang order by maKhachHang";
            //str = "select a.MANHANVIEN , B.TENPHANQUYEN FROM NHANVIEN AS a ,PHANQUYEN AS b where a.MAPHANQUYEN = b.MAPHANQUYEN;";
            tb = help.LayBang(str);
            dgv_khachHang.DataSource = tb;
            dgv_khachHang.AllowUserToAddRows = false;
            dgv_khachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.checkButton = 1;
            KhachHangMoi khachHangMoi = new KhachHangMoi(this);
            khachHangMoi.ShowDialog();
        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            this.checkButton = 2;
            KhachHangMoi khachHangMoi = new KhachHangMoi(this);
            khachHangMoi.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            this.checkButton = 3;
            KhachHangMoi khachHangMoi = new KhachHangMoi(this);
            khachHangMoi.ShowDialog();
        }

        private void dgv_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_khachHang.Rows[e.RowIndex];

            dgv_khachHang.CurrentRow.Selected = true;

            this.id = Convert.ToInt32(row.Cells[0].Value.ToString());
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete khachhang where makhachhang = " + this.id + "";
            help.CapNhatDL(query);

            HienThiDL();
        }
    }
}
