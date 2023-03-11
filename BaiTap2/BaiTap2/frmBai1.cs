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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
           
        }

        private void rdThongTin_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdThanhTien_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            if(rdThongTin.Checked)
            {
                ThietBi tb = new ThietBi("H001","Chuột","Việt Nam",200000,200);
                lbThongBao.Text=tb.HienThi();
            }
            else
            {
                ThietBi tb = new ThietBi("H001", "Chuột", "Việt Nam", 200000, 200);
                lbThongBao.Text = tb.ThanhTien(tb).ToString();
            }
        }
    }
}
