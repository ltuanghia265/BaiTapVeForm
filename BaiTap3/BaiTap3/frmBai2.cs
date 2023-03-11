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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void tbSoN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbSoN.Text);
            int kq = 0;
            int gt = 1;
            if(rdTong.Checked)
            {
                for(int i = 0; i < n; i++)
                {
                    kq += i;
                }
                lbKetQua.Text = kq.ToString();
            }
            else
            {
                for(int i = 2;i <= n; i++)
                {
                    gt *= i;
                }
                lbKetQua.Text = gt.ToString();
            }    
            
        }
    }
}
