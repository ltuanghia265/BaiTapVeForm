using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int hoten = int.Parse(tbHoTen.Text);
            int ho =int.Parse("");
            int ten = int.Parse("");
            int n1 = int.Parse(tbSoNguyen1.Text);
            int n2 = int.Parse(tbSoNguyen2.Text);
            int kq  = int.Parse("");
            string r1 = "True";
            string r2 = "False";
            if(rdTach.Checked)
            {
                
                
            }
            else
            {
                
            }
        }
    }
}
