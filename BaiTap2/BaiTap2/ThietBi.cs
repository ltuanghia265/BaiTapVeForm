﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi(string maThietBi,string tenThietbi, string nuocSanXuat,int donGia, int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietbi;
            NuocSanXuat = nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
            
        }

        public int ThanhTien(ThietBi tb)
        {
           return DonGia * SoLuong;
        }

        public string HienThi()
        {
            
            return string.Format("{0},{1},{2},{3},{4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }
    }
}
