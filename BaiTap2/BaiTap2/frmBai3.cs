using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string ho=tbHo.Text;
            string ten=tbTen.Text;
            string kq = "";
            int n =int.Parse(tbSoN.Text);
            if (rdNoiChuoi.Checked)
            {
                TinhToan.NoiChuoi(ho, ten, ref kq);
            }
            else
               kq= TinhToan.TinhGiaiThua(n).ToString();

            lbKetQua.Text = kq;
            
        }
    }
}
