using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }

        public SanPham() { }

        public int NamHetHan(SanPham sp)
        {
            return NgaySanXuat.Year + 3;
        }

        public string HienThi()
        {
            return string.Format("Mã sản phẩm: " + MaSanPham + "\n" + "Tên sản phẩm: " + TenSanPham + "\n" + "Loại sản phẩm: " + LoaiSanPham + "\n" + "Ngày sản xuất: " + NgaySanXuat);
        }
    }
}
