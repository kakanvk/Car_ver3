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
    public partial class HoaDon : Form
    {
        public static int id, check;
        help help = new help();
        DataTable tb = new DataTable();
        public HoaDon()
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

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            check = 2;
            HoaDonMoi hoaDonMoi = new HoaDonMoi();
            hoaDonMoi.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            HoaDonMoi hoaDonMoi = new HoaDonMoi();
            hoaDonMoi.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }
        int id_hoaDon_cellclick;
        private void dgv_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_hoaDon.Rows[e.RowIndex];

            dgv_hoaDon.CurrentRow.Selected = true;

            id_hoaDon_cellclick = Convert.ToInt32(row.Cells["maHoaDon"].Value.ToString());

            id = Convert.ToInt32(row.Cells[0].Value.ToString());
            if (id != 0)
            {
                btn_chiTiet.Enabled = true;
                btn_sua.Enabled = true;
            }
        }
        public void HienthiDL()
        {
            string str = "select * from hoadon order by mahoadon";
            tb = help.LayBang(str);
            dgv_hoaDon.DataSource = tb;
            dgv_hoaDon.AllowUserToAddRows = false;
            dgv_hoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            id = 0;
            check = 1;
            HoaDonMoi hoaDonMoi = new HoaDonMoi();
            hoaDonMoi.ShowDialog();
        }
    }
}
