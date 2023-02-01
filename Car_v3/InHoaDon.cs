using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_v3
{
    public partial class InHoaDon : Form
    {
        DataSet ds;
        int MA;
        help hp = new help();
        public InHoaDon(int mA)
        {
            InitializeComponent();
            MA = mA;    
        }
        string str = "Data Source=.;Integrated Security = True; Initial Catalog = Oto";
        SqlConnection conn = null;
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            if(conn == null)
                conn = new SqlConnection(str);
            string sql = "select a.mahoadon, a.NGAYMUA, b.tensanpham, a.Thanhtienban from hoadon as a, sanpham as b, hoadonchitiet as c where c.mahoadon = "+this.MA+" and c.masanpham = b.masanpham and a.mahoadon ="+this.MA+"";
            SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
            ds =  new DataSet();
            adap.Fill(ds, "tam");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Car_v3.Report1.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["tam"];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            DataRow rw = this.ds.Tables["tam"].Rows[0];

            DateTime ngaythangnam = Convert.ToDateTime(rw["NGAYMUA"].ToString());
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
               

                new Microsoft.Reporting.WinForms.ReportParameter("ngay" , ngaythangnam.Day.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("thang", ngaythangnam.Month.ToString()),
                new Microsoft.Reporting.WinForms. ReportParameter("nam", ngaythangnam.Year.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("tongtien",hp.ChuyenSoSangChuoi(Convert.ToDouble(rw["THANHTIENBAN"].ToString())))
            };
                this.reportViewer1.LocalReport.SetParameters(para);
                this.reportViewer1.RefreshReport();
        }
            
            

        }


}

