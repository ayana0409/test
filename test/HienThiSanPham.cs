using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace test
{
    public partial class HienThiSanPham : UserControl
    {
        public HienThiSanPham()
        {
            InitializeComponent();
        }
        private SanPham sp;

        private int maSp;
        private string tenSP;
        private string danhMuc;
        private string chiTiet;
        private float gia;
        private string hinh;
        private bool isSelected;

        public event EventHandler<EventArgs> WasClicked;

        private void HienThiSanPham_Click(object? sender, EventArgs e)
        {
            var wasClicked = WasClicked;
            if (wasClicked != null)
            {
                WasClicked(this, EventArgs.Empty);
            }

            IsSelected = true;
        }

        private void HienThiSanPham_MouseHover(object sender, EventArgs e)
        {
            //this.BackColor = SystemColors.GradientActiveCaption;
            //this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void HienThiSanPham_MouseLeave(object sender, EventArgs e)
        {
            //this.BackColor = SystemColors.Control;
            //this.BorderStyle = BorderStyle.FixedSingle;
        }
        public SanPham Sp
        {
            get { return sp; }
            set
            {
                sp = value;
                MaSp = value.Ma;
                TenSP = value.Ten;
                DanhMuc = value.DanhMuc;
                ChiTiet = value.ChiTiet;
                Gia = value.Gia;
                Hinh = value.Hinh;
            }
        }

        public int MaSp
        {
            get => maSp;
            set { maSp = value; txtMa.Text = value.ToString(); }
        }

        public string TenSP
        {
            get => tenSP;
            set { tenSP = value; txtTen.Text = value; }
        }

        public string DanhMuc
        {
            get => danhMuc;
            set { danhMuc = value; txtDM.Text = value; }
        }

        public float Gia
        {
            get => gia;
            set { gia = value; txtGia.Text = value.ToString() + "đ"; }
        }

        public string ChiTiet
        {
            get => chiTiet;
            set { chiTiet = value; rtbChiTiet.Text = value; }
        }

        public string Hinh
        {
            get => hinh;
            //set { hinh = value; pbHinh.ImageLocation = (value != "") ? Application.StartupPath + ".\\images\\" + value : Application.StartupPath + "\\images\\" + value; }
            set { hinh = value; pbHinh.ImageLocation = "D:\\Study\\Study Document\\5_Semester-1_2023-2024\\DotNET\\Project\\Test\\test\\test\\images\\" + value; }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.BackColor = IsSelected ? SystemColors.GradientActiveCaption : SystemColors.Control;
            }
        }
    }
}
