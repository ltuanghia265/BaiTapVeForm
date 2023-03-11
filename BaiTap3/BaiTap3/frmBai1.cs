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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (rdThongTin.Checked)
            {
                NhanVien nv = new NhanVien("2115241", "Lê Tuấn Nghĩa", new DateTime(05 / 26 / 2003), 5, 10);
                lbKetQua.Text = nv.HienThi(nv);
                
            }
            else
            {
                NhanVien nv = new NhanVien("2115241", "Lê Tuấn Nghĩa", new DateTime(05 / 26 / 2003), 5, 10);
                lbKetQua.Text = nv.TongLuong(nv).ToString();
            }
            
        }
    }
}
