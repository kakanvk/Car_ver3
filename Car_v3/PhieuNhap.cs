using System;
using System.Collections;
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
    public partial class PhieuNhap : Form
    {
        public static int id_phieuNhap_cellclick;
        help help = new help();
        DataTable tb = new DataTable();
        public PhieuNhap()
        {
            InitializeComponent();

            if (help.Mo_KN_CSDL())
            {
                HienthiDL();
                
            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
        }
        public static int id;
        public static int check;

        private void btn_them_Click(object sender, EventArgs e)
        {
            id = 0;
            check = 1;
            PhieuNhapMoi phieuNhap = new PhieuNhapMoi(this);
            phieuNhap.ShowDialog();
        }
        private void dgv_phieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_phieuNhap.Rows[e.RowIndex];

            dgv_phieuNhap.CurrentRow.Selected = true;

            id_phieuNhap_cellclick = Convert.ToInt32(row.Cells["maPhieunhap"].Value.ToString());

            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            if (id != 0)
            {
                btn_chiTiet.Enabled = true;
                btn_sua.Enabled = true;
            }

        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            check = 2;
            PhieuNhapMoi phieuNhap = new PhieuNhapMoi(this);
            phieuNhap.ShowDialog();
        }

        public void HienthiDL()
        {
            string str = "select * from phieunhap order by maphieunhap";
            tb = help.LayBang(str);
            dgv_phieuNhap.DataSource = tb;
            dgv_phieuNhap.AllowUserToAddRows = false;
            dgv_phieuNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            PhieuNhapMoi phieuNhap = new PhieuNhapMoi(this);
            phieuNhap.ShowDialog();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
               
                    string str = "delete PHIEUNHAP where MAPHIEUNHAP =" + id_phieuNhap_cellclick + "";
                if (help.CapNhatDL(str) <= 0)
                {
                    MessageBox.Show("Xóa thất bại");
                }
                
                    HienthiDL();
            }
        }

        private void tb_timKiem_TextChanged(object sender, EventArgs e)
        {
            (dgv_phieuNhap.DataSource as DataTable).DefaultView.RowFilter = string.Format("MAPHIEUNHAP  LIKE '{0}%' ", tb_timKiem.Text);
        }
    }
}
