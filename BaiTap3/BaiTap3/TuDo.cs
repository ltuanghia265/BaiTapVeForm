using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    internal class TuDo
    {
        public static void TachChuoi(string hoten,string s1, string s2)
        {
            hoten = hoten.Trim();
            var temp = hoten.Split(' ').Where(x => x != " ");
            var n = temp.Count();

            s2 = temp.ElementAt(n - 1);
            s1 = temp.ElementAt(0);
        }
        public static bool ThuTu(int n1, int n2)
        {
            
            if(n2==n1+1)
            {
                return true;
            }
            else { return false; }
        }
    }
}
