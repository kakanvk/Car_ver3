﻿using System;
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

        

        public void HienThiDL()
        {

            string str = "select maNhanVien , tenNhanVien as 'Tên Nhân Viên', diachiNhanVien as 'Địa Chỉ', sdtNhanVien as 'SĐT', nhanvien.maphanquyen as 'Chức Vụ'from nhanvien,phanquyen where phanquyen.maphanquyen= nhanvien.maphanquyen order by manhanvien";
            //str = "select a.MANHANVIEN , B.TENPHANQUYEN FROM NHANVIEN AS a ,PHANQUYEN AS b where a.MAPHANQUYEN = b.MAPHANQUYEN;";
            tb = help.LayBang(str);
            dgv_nhanVien.DataSource = tb;
            dgv_nhanVien.AllowUserToAddRows = false;
            dgv_nhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        public static int id = 0;
        public static int check = 0;
        private void dgv_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_nhanVien.Rows[e.RowIndex];

            dgv_nhanVien.CurrentRow.Selected = true;


           id = Convert.ToInt32(row.Cells["MANHANVIEN"].Value.ToString());
           
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            check = 1;
            NhanVienMoi nhanVienMoi = new NhanVienMoi(this);
            nhanVienMoi.ShowDialog();
        }

        private void btn_chiTiet_Click(object sender, EventArgs e)
        {
            check = 2;
            NhanVienMoi nhanVienMoi = new NhanVienMoi(this);
            
            nhanVienMoi.ShowDialog();
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            check = 3;
            NhanVienMoi nhanVienMoi = new NhanVienMoi(this);
            nhanVienMoi.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string query = "delete nhanvien where manhanvien = " + id + "";
            help.CapNhatDL(query);

            HienThiDL();
        }
    }
}
