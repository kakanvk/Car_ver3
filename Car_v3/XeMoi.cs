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
    public partial class XeMoi : Form
    {
        public XeMoi()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_themLoaiXe_Click(object sender, EventArgs e)
        {
            LoaiXeMoi xe = new LoaiXeMoi(this);
            xe.ShowDialog();
        }
    }
}
