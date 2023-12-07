using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class HoaDon : UserControl
    {


        private HoaDonHang hd;
        private int maDH;
        private string trangThai;

        public HoaDon()
        {
            InitializeComponent();
            Hd = new HoaDonHang();
            txtMa.Text = maDH.ToString();
        }


        [Category("Custom Props")]
        internal HoaDonHang Hd { get { return hd; } set { hd = value; MaDH = value.Ma; TrangThai = value.Trangthai; } }


        [Category("Custom Props")]
        public int MaDH { get => maDH; set { maDH = value; txtMa.Text = "Đơn hàng: " + value.ToString(); } }

        public string TrangThai { get => trangThai; set { trangThai = value; txtTrangThai.Text = "Trạng thái: " + value; } }
    }
}
