using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }

        public NhanVien(string maNhanVien, string hoTen, DateTime ngaySinh, int heSoLuong, int heSoPhuCap)
        {
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap = heSoPhuCap;
        }

        public int TongLuong(NhanVien nv)
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }

        public string HienThi(NhanVien nv)
        {
            return string.Format("Mã số: " + MaNhanVien + "\n" + "Họ tên: " + HoTen + "\n" + "Ngày sinh: " + "\n" + NgaySinh.ToString() + "\n" + "Hệ số lương: " + HeSoLuong.ToString() + "\n" + "Hệ số phụ cấp: " + HeSoPhuCap.ToString());
        }
    }
    
}
