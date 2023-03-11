using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int stt = cbbSanPham.SelectedIndex;
            SanPham sp = new SanPham();
            
            if (rdTT.Checked)
            {
                switch (stt)
                {
                    case 0:
                        {
                            sp.MaSanPham = "HH001";
                            sp.TenSanPham = "Tai nghe không dây";
                            sp.LoaiSanPham = "Tai nghe";
                            sp.NgaySanXuat = new DateTime(2020,03,16);
                            lbKetQua.Text = sp.HienThi();
                            break;
                        }
                    case 1:
                        {
                            sp.MaSanPham = "HH002";
                            sp.TenSanPham = "Bàn phím không dây";
                            sp.LoaiSanPham = "Bàn phím";
                            sp.NgaySanXuat = new DateTime(2018,03,16);
                            lbKetQua.Text = sp.HienThi();
                            break;
                        }
                }

            }
            else
                switch (stt)
                {
                    case 0:
                        {
                            sp.MaSanPham = "HH001";
                            sp.TenSanPham = "Tai nghe không dây";
                            sp.LoaiSanPham = "Tai nghe";
                            sp.NgaySanXuat = new DateTime(03 / 16 / 2020);
                            lbKetQua.Text = sp.NamHetHan(sp).ToString();
                            break;
                        }
                    case 1:
                        {
                            sp.MaSanPham = "HH002";
                            sp.TenSanPham = "Bàn phím không dây";
                            sp.LoaiSanPham = "Bàn phím";
                            sp.NgaySanXuat = new DateTime(03 / 16 / 2018);
                            lbKetQua.Text = sp.NamHetHan(sp).ToString();
                            break;
                        }
                }
        }
    }
}
