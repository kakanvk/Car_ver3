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
    public partial class NSX : Form
    {
        help help = new help();
        DataTable tb;
        public static int check = 0;
        public NSX()
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
            NSXMoi nSXMoi = new NSXMoi(this);
            nSXMoi.ShowDialog();
        }
        public static int id = 0;
        private void dgv_NSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_NSX.Rows[e.RowIndex];

            dgv_NSX.CurrentRow.Selected = true;


            id = Convert.ToInt32(row.Cells["maNSX"].Value.ToString());
        }
        public void HienThiDL()
        {
            string str = "select * from nsx";
            tb = help.LayBang(str);
            dgv_NSX.DataSource = tb;
            dgv_NSX.AllowUserToAddRows = false;
            dgv_NSX.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            check = 2;
            NSXMoi nSXMoi = new NSXMoi(this);
            nSXMoi.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            NSXMoi nSXMoi = new NSXMoi(this);
            nSXMoi.ShowDialog();
        }
    }
}
