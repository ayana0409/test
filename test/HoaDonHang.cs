using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class HoaDonHang
    {
        private int ma;
        private string trangthai;
        public HoaDonHang() { 
        ma = 1;
            trangthai = string.Empty;
        }
        public HoaDonHang(int ma, string trangthai)
        {
            Ma = ma;
            Trangthai = trangthai;
        }

        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Ma { get => ma; set => ma = value; }
    }
}
