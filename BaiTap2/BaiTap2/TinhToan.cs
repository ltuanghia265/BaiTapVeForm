using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class TinhToan
    {
        public static void NoiChuoi(string ho, string ten,ref string s)
        {
            s = ho + " " + ten;
        }
        public static long TinhGiaiThua(int n)
        {
            int kq = 1;
            for(int i = 2; i <= n; i++)
            {
                kq*= i;
            }
            return kq;
        }
    }
}
