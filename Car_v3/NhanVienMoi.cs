using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_v3
{
    public partial class NhanVienMoi : Form
    {
        help help = new help();
        DataTable tb;

        public NhanVienMoi()
        {
            InitializeComponent();
            help = new help();
            if (help.Mo_KN_CSDL())
            {
                //   MessageBox.Show("Mo Dc CSDL Roi","Thông Báo!!!");
                HienThiDL();

            }
            else
            {
                MessageBox.Show("kết nối dữ liệu thất bại");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (tb_diaChi.Text == "" || tb_tenNhanVien.Text == "" || cb_gioiTinh.Text == "" || tb_sdt.Text == "" || tb_email.Text == "" || tb_matKhau.Text == "")
            {
                MessageBox.Show("Nhập đủ thông tin!!!");
                return;
            }
            if (tb_sdt.Text.Trim().Length > 10)
            {
                MessageBox.Show("Số điện thoại sai");
                tb_sdt.Focus();
                return;
            }
            try
            {

                string query = "insert into nhanvien values (" + cb_chucVu.SelectedValue + ",N'" + tb_tenNhanVien.Text.Trim() + "','" + ns_nhanVien.Value + "',N'" + cb_gioiTinh.Text.Trim() + "'," + tb_sdt.Text + ",'" + tb_matKhau.Text.Trim() + "','" + tb_email.Text.Trim() + "',N'" + tb_diaChi.Text.Trim() + "')";
                help.CapNhatDL(query);
                //HienThiDL();

            }
            catch
            {

            }
        }

        void HienThiDL()
        {
            string str;
            str = "SELECT * FROM phanquyen";
            //DataTable bang = new DataTable();
            tb = help.LayBang(str);

            cb_chucVu.DataSource = tb;
            cb_chucVu.DisplayMember = "tenphanQuyen";
            cb_chucVu.ValueMember = "maphanQuyen";
            str = "select maNhanVien as 'Mã Nhân Viên', tenNhanVien as 'Tên Nhân Viên', diachiNhanVien as 'Địa Chỉ', sdtNhanVien as 'SĐT', nhanvien.maphanquyen as 'Chức Vụ'from nhanvien,phanquyen where phanquyen.maphanquyen= nhanvien.maphanquyen";
            //str = "select a.MANHANVIEN , B.TENPHANQUYEN FROM NHANVIEN AS a ,PHANQUYEN AS b where a.MAPHANQUYEN = b.MAPHANQUYEN;";
            tb = help.LayBang(str);
            /*NhanVien.
            NhanVien.dgv_nhanVien.DataSource = tb;
            list_nhanVien.Columns[0].HeaderText = "MÃ NHÂN VIÊN";
            list_nhanVien.Columns[1].HeaderText = "TÊN PHÂN QUYỀN";
            list_nhanVien.AllowUserToAddRows = false;
            list_nhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            */
        }

        private void NhanVienMoi_Load(object sender, EventArgs e)
        {

        }
    }
}
