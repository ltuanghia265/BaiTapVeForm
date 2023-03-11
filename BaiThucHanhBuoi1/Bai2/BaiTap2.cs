using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class BaiTap2 : Form
    {
        public BaiTap2()
        {
            InitializeComponent();
        }

        private void BaiTap2_Load(object sender, EventArgs e)
        {

        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            MessageBox.Show("Ban chon gioi tinh Nam", "Thong bao");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNu.Checked)
            MessageBox.Show("Ban chon gioi tinh Nu", "Thong bao");
        }

        private void txtToMau_Click(object sender, EventArgs e)
        {
            if (rdRed.Checked)
                txtHopMau.BackColor = Color.Red;
            if (rdBlue.Checked)
                txtHopMau.BackColor = Color.Blue;
        }
    }
}
