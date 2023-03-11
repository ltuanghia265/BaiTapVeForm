using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            int a =int.Parse(tbSoA.Text);
            int b=int.Parse(tbSoB.Text);
            int n=int.Parse(tbSoN.Text);
            int kq = 0;
            if (rdTong2So.Checked)
                TinhToan.CongHaiSo(a, b, ref kq);
            else
                kq=TinhToan.TongDaySo(n);

            lbKetQua.Text=kq.ToString();
        }
    }
}
