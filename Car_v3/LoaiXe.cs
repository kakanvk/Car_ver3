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
    public partial class LoaiXe : Form
    {
        help help = new help();
        DataTable tb;
        public LoaiXe()
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
        public static int check = 0;
        public static int id = 0;
        private void btn_them_Click(object sender, EventArgs e)
        {
            id = 0;
            check = 1;
            LoaiXeMoi xe = new LoaiXeMoi(this);
            xe.ShowDialog();
        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            
            check = 2;
            LoaiXeMoi xe = new LoaiXeMoi(this);
            xe.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            LoaiXeMoi xe = new LoaiXeMoi(this);
            xe.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete loaixe where maloai = " + id + "";
            help.CapNhatDL(query);

            HienThiDL();
        }

        private void dgv_loaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dgv_loaiXe.Rows[e.RowIndex];

            dgv_loaiXe.CurrentRow.Selected = true;


            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            if (id != 0)
            {
                btn_chiTiet.Enabled = true;
                btn_sua.Enabled = true;
            }
        }
        public void HienThiDL()
        {

            string str = "select maloai , tenloai  from loaixe order by maloai";
            //str = "select a.MANHANVIEN , B.TENPHANQUYEN FROM NHANVIEN AS a ,PHANQUYEN AS b where a.MAPHANQUYEN = b.MAPHANQUYEN;";
            tb = help.LayBang(str);
            dgv_loaiXe.DataSource = tb;
            dgv_loaiXe.AllowUserToAddRows = false;
            dgv_loaiXe.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgv_loaiXe.Columns[0].HeaderText = "Mã loại xe";
            dgv_loaiXe.Columns[1].HeaderText = "Tên loại xe";
            
            if (id == 0)
            {
                btn_chiTiet.Enabled = false;
                btn_sua.Enabled = false;
            }
        }

        private void LoaiXe_Load(object sender, EventArgs e)
        {

        }

        

        private void tb_timKiem_TextChanged_1(object sender, EventArgs e)
        {
            (dgv_loaiXe.DataSource as DataTable).DefaultView.RowFilter = string.Format("tenloai LIKE '%{0}%'", tb_timKiem.Text);
        }
    }
}
