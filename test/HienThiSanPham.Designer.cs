namespace test
{
    partial class HienThiSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbHinh = new PictureBox();
            txtTen = new Label();
            txtDM = new Label();
            rtbChiTiet = new RichTextBox();
            txtMa = new Label();
            txtGia = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHinh).BeginInit();
            SuspendLayout();
            // 
            // pbHinh
            // 
            pbHinh.InitialImage = null;
            pbHinh.Location = new Point(3, 24);
            pbHinh.Name = "pbHinh";
            pbHinh.Size = new Size(142, 123);
            pbHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinh.TabIndex = 0;
            pbHinh.TabStop = false;
            pbHinh.Click += HienThiSanPham_Click;
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTen.Location = new Point(151, 3);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(108, 21);
            txtTen.TabIndex = 1;
            txtTen.Text = "Tên sản phẩm:";
            txtTen.Click += HienThiSanPham_Click;
            // 
            // txtDM
            // 
            txtDM.AutoSize = true;
            txtDM.Font = new Font("Segoe UI", 11.25F);
            txtDM.Location = new Point(151, 24);
            txtDM.Name = "txtDM";
            txtDM.Size = new Size(79, 20);
            txtDM.TabIndex = 2;
            txtDM.Text = "Danh mục:";
            txtDM.Click += HienThiSanPham_Click;
            // 
            // rtbChiTiet
            // 
            rtbChiTiet.BackColor = SystemColors.GradientInactiveCaption;
            rtbChiTiet.BorderStyle = BorderStyle.FixedSingle;
            rtbChiTiet.Location = new Point(151, 48);
            rtbChiTiet.Name = "rtbChiTiet";
            rtbChiTiet.ReadOnly = true;
            rtbChiTiet.Size = new Size(549, 99);
            rtbChiTiet.TabIndex = 4;
            rtbChiTiet.Text = "";
            rtbChiTiet.Click += HienThiSanPham_Click;
            // 
            // txtMa
            // 
            txtMa.AutoSize = true;
            txtMa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMa.Location = new Point(3, 3);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(32, 21);
            txtMa.TabIndex = 5;
            txtMa.Text = "Mã";
            txtMa.Click += HienThiSanPham_Click;
            // 
            // txtGia
            // 
            txtGia.AutoSize = true;
            txtGia.Font = new Font("Segoe UI", 11.25F);
            txtGia.Location = new Point(462, 24);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(31, 20);
            txtGia.TabIndex = 6;
            txtGia.Text = "Giá";
            txtGia.Click += HienThiSanPham_Click;
            // 
            // HienThiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtGia);
            Controls.Add(txtMa);
            Controls.Add(rtbChiTiet);
            Controls.Add(txtDM);
            Controls.Add(txtTen);
            Controls.Add(pbHinh);
            Name = "HienThiSanPham";
            Size = new Size(701, 148);
            Click += HienThiSanPham_Click;
            MouseLeave += HienThiSanPham_MouseLeave;
            MouseHover += HienThiSanPham_MouseHover;
            ((System.ComponentModel.ISupportInitialize)pbHinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbHinh;
        private Label txtTen;
        private Label txtDM;
        private RichTextBox rtbChiTiet;
        private Label txtMa;
        private Label txtGia;
    }
}
