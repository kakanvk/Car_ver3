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
    public partial class PhieuNhap : Form
    {
        DataTable tb = new DataTable();

        help help = new help();
       
        public PhieuNhap()
        {
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
            PhieuNhapMoi phieuNhap = new PhieuNhapMoi();
            phieuNhap.ShowDialog();
        }

       

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            check = 2;
            PhieuNhapMoi phieuNhap = new PhieuNhapMoi();
            phieuNhap.ShowDialog();
        }

        void HienthiDL()
        {
            DataTable tb = new DataTable();
            string str = "select mansx, tennsx from nsx";
            tb = help.LayBang(str);
            dgv_phieuNhapp.DataSource = tb;
            dgv_phieuNhapp.AllowUserToAddRows = false;
            dgv_phieuNhapp.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            PhieuNhapMoi phieuNhap = new PhieuNhapMoi();
            phieuNhap.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete phieunhap where maphieunhap  ="+id+"";
            help.CapNhatDL(query);

            HienthiDL();
        }

        private void dgv_phieuNhap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_phieuNhapp.Rows[e.RowIndex];

            dgv_phieuNhapp.CurrentRow.Selected = true;


            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            if (id != 0)
            {
                btn_chiTiet.Enabled = true;
                btn_sua.Enabled = true;
            }
        }
    }
}
