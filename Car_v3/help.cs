using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Car_v3
{
    internal class help
    {
        public SqlConnection kn;
        public SqlCommand lenh;
      
        public help()
        {
            string str = "Data Source=.;Integrated Security = True; Initial Catalog = Oto";
            kn = new SqlConnection();
            kn.ConnectionString = str;

        }
        public help(string str)
        {

            kn = new SqlConnection();
            kn.ConnectionString = str;

        }
        public bool Mo_KN_CSDL()
        {
            try
            {
                kn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public  int CapNhatDL(string str)
        {
            try
            {
                lenh = new SqlCommand(str, kn);
               return lenh.ExecuteNonQuery();

            }
            catch { 
                return 0;
            }
            
        }
        public DataTable LayBang(string str)
        {
            SqlDataAdapter bodocghi = new SqlDataAdapter(str, kn);
            DataTable bang = new DataTable();
            bodocghi.Fill(bang);
            return bang;

        }
        public int Checkper()
        {
            string code = Login.ID_LEVEL;
            int check = 1;
            if ("1" == code)
            {
                check = 1;
            }
            else if ("2" == code)
            {
                check = 2;
            }
            else
                check = 3;
            return check;
        }
        public void DongKN()
        {
            kn.Close();
        }
    }
}