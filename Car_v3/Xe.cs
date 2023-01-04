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
    public partial class Xe : Form
    {
        help help = new help();
        DataTable tb;
        public static int id = 0;
        public static int check = 0;

        public Xe()
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
          
        private void btn_them_Click(object sender, EventArgs e)
        {
            check = 1;
            XeMoi xeMoi = new XeMoi(this);
            xeMoi.ShowDialog();
        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            check = 2;
            XeMoi xeMoi = new XeMoi(this);
            xeMoi.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            XeMoi xeMoi = new XeMoi(this);
            xeMoi.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete sanpham where masanpham = " + id + "";
            help.CapNhatDL(query);

            HienThiDL();
        }

        private void Xe_Load(object sender, EventArgs e)
        {

        }

        public void HienThiDL()
        {

            string str = "select maSanPham, mansx, maloai, tenSanPham, mota, mau, gia from SANPHAM order by maSanPham";
            //str = "select a.MANHANVIEN , B.TENPHANQUYEN FROM NHANVIEN AS a ,PHANQUYEN AS b where a.MAPHANQUYEN = b.MAPHANQUYEN;";
            tb = help.LayBang(str);
            dgv_xe.DataSource = tb;
            dgv_xe.AllowUserToAddRows = false;
            dgv_xe.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_xe.Columns[0].HeaderText = "Mã xe";
            dgv_xe.Columns[1].HeaderText = "NSX";
            dgv_xe.Columns[2].HeaderText = "Loại xe";
            dgv_xe.Columns[3].HeaderText = "Tên sản phẩm";
            dgv_xe.Columns[4].HeaderText = "Mô tả";
            dgv_xe.Columns[5].HeaderText = "Màu sắc";
            dgv_xe.Columns[6].HeaderText = "Giá";
        }

        private void dgv_xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_xe.Rows[e.RowIndex];

            dgv_xe.CurrentRow.Selected = true;

            id = Convert.ToInt32(row.Cells[0].Value.ToString());
        }

        
    }
}
