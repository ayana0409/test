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
    public partial class frmHienThiSP : Form
    {
        public frmHienThiSP()
        {
            InitializeComponent();
        }

        private void frmHienThiSP_Load(object sender, EventArgs e)
        {
            SanPham sp = new SanPham(1234, "Laptop mạnh nhất vũ trụ", "Máy tính xách tay", 100000, "CPU 1000 nhân, 10TB RAM, 10000TB SSD, màn hình 16K siêu nét", "3019283102938103.jpg");
            SanPham sp2 = new SanPham(5678, "Laptop mạnh nhất vũ trụ", "Máy tính xách tay", 100000, "CPU 1000 nhân, 10TB RAM, 10000TB SSD, màn hình 16K siêu nét", "3019283102938103.jpg");

            HienThiSanPham ht1 = new HienThiSanPham();
            HienThiSanPham ht2 = new HienThiSanPham();
            ht1.WasClicked += UsersGrid_WasClicked;
            ht2.WasClicked += UsersGrid_WasClicked;
            ht1.Sp = sp;
            ht2.Sp = sp2;

            flowLayoutPanel1.Controls.Add(ht1);
            flowLayoutPanel1.Controls.Add(ht2);
        }

        void UsersGrid_WasClicked(object sender, EventArgs e)
        {
            // Set IsSelected for all UCs in the FlowLayoutPanel to false. 
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is HienThiSanPham)
                {
                    ((HienThiSanPham)c).IsSelected = false;
                }
            }
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_CursorChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (HienThiSanPham h in flowLayoutPanel1.Controls)
            {
                if (h is HienThiSanPham)
                {
                    if (h.IsSelected)
                    {
                        txtMa.Text = h.MaSp.ToString();
                        break;
                    }
                }
            }
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
