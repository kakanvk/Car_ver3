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
    public partial class NhanVien : Form
    {
        help help = new help();
        DataTable tb;
        public NhanVien()
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            NhanVienMoi nhanVienMoi = new NhanVienMoi();
            nhanVienMoi.ShowDialog();
        }

        void HienThiDL()
        {

            string str = "select maNhanVien as 'Mã Nhân Viên', tenNhanVien as 'Tên Nhân Viên', diachiNhanVien as 'Địa Chỉ', sdtNhanVien as 'SĐT', nhanvien.maphanquyen as 'Chức Vụ'from nhanvien,phanquyen where phanquyen.maphanquyen= nhanvien.maphanquyen";
            //str = "select a.MANHANVIEN , B.TENPHANQUYEN FROM NHANVIEN AS a ,PHANQUYEN AS b where a.MAPHANQUYEN = b.MAPHANQUYEN;";
            tb = help.LayBang(str);
            dgv_nhanVien.DataSource = tb;
            dgv_nhanVien.AllowUserToAddRows = false;
            dgv_nhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dgv_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
