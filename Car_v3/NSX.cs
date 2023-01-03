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
        public NSX()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NSXMoi nSXMoi = new NSXMoi();
            nSXMoi.Show();
        }
        public static int id = 0;
        private void dgv_NSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_NSX.Rows[e.RowIndex];

            dgv_NSX.CurrentRow.Selected = true;


            id = Convert.ToInt32(row.Cells["maNSX"].Value.ToString());
        }

        private void NSX_Load(object sender, EventArgs e)
        {

        }
    }
}
