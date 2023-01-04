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

        help help = new help();
        DataTable tb = new DataTable();
        public PhieuNhap()
        {
            InitializeComponent();
            HienthiDL();
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

        private void dgv_phieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_phieuNhap.Rows[e.RowIndex];

            dgv_phieuNhap.CurrentRow.Selected = true;
            

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
            PhieuNhapMoi phieuNhap = new PhieuNhapMoi();
            phieuNhap.ShowDialog();
        }

        public void HienthiDL()
        {
            string str = "select * from phieunhap";
            tb = help.LayBang(str);
            dgv_phieuNhap.DataSource = tb;
            dgv_phieuNhap.AllowUserToAddRows = false;
            dgv_phieuNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            PhieuNhapMoi phieuNhap = new PhieuNhapMoi();
            phieuNhap.ShowDialog();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string str = "delete PHIEUNHAP where MAPHIEUNHAP ="+id+"";
            help.CapNhatDL(str);
            MessageBox.Show(str);
            HienthiDL();
        }
    }
}
