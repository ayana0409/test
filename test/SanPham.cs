using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class SanPham
    {
        public SanPham() {
            Ma = 1;
            Ten = "Unknown";
            ChiTiet = "Sản phẩm này tuyệt vời lắm. Mua ngay đi!";
            Gia = 100000;
            Hinh = "";
        }
        public SanPham(int ma, string ten, string danhmuc,float gia, string chitiet, string hinh = "")
        {
            this.Ma = ma;
            this.Ten = ten;
            this.Gia = gia;
            this.DanhMuc = danhmuc;
            this.ChiTiet = chitiet;
            this.Hinh = hinh;
        }
        public int Ma { set; get; }
        public string Ten { get; set; }
        public string DanhMuc { get; set; }
        public string ChiTiet { get; set; }
        public float Gia { get; set; }
        public string Hinh { get; set; }
    }
}
