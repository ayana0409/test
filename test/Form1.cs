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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HoaDonHang dh1 = new HoaDonHang(1234, "Chưa thanh toán");

            HoaDon hd = new();
            hd.Hd = dh1;


            HoaDonHang dh2 = new HoaDonHang(12342331, "Đã thanh toán");

            HoaDon hd2 = new();
            hd2.Hd = dh2;

            HoaDon hd3 = new();
            hd3.Hd = dh2;

            HoaDon hd4 = new();
            hd4.Hd = dh1;

            HoaDon hd5 = new();
            hd5.Hd = dh2;

            HoaDon hd6 = new();
            hd6.Hd = dh2;

            HoaDon hd7 = new();
            hd7.Hd = dh2;

            HoaDon hd8 = new();
            hd8.Hd = dh2;

            HoaDon hd9 = new();
            hd9.Hd = dh2;

            HoaDon hd10 = new();
            hd10.Hd = dh2;

            HoaDon hd11 = new();
            hd11.Hd = dh2;

            flowLayoutPanel1.Controls.Add(hd);
            flowLayoutPanel1.Controls.Add(hd2);
            flowLayoutPanel1.Controls.Add(hd3);
            flowLayoutPanel1.Controls.Add(hd4);
            flowLayoutPanel1.Controls.Add(hd5);
            flowLayoutPanel1.Controls.Add(hd6);
            flowLayoutPanel1.Controls.Add(hd7);
            flowLayoutPanel1.Controls.Add(hd8);
            flowLayoutPanel1.Controls.Add(hd9);
            flowLayoutPanel1.Controls.Add(hd10);
            flowLayoutPanel1.Controls.Add(hd11);
        }
    }
}
