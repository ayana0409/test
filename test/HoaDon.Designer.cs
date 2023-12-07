namespace test
{
    partial class HoaDon
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
            txtMa = new Label();
            btnChiTiet = new Button();
            txtTrangThai = new Label();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.AutoEllipsis = true;
            txtMa.AutoSize = true;
            txtMa.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMa.Location = new Point(17, 8);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(76, 18);
            txtMa.TabIndex = 0;
            txtMa.Text = "Đơn hàng:";
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = SystemColors.ActiveCaption;
            btnChiTiet.Location = new Point(560, 3);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(31, 31);
            btnChiTiet.TabIndex = 1;
            btnChiTiet.Text = "...";
            btnChiTiet.UseVisualStyleBackColor = false;
            // 
            // txtTrangThai
            // 
            txtTrangThai.AutoEllipsis = true;
            txtTrangThai.AutoSize = true;
            txtTrangThai.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTrangThai.Location = new Point(329, 8);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(80, 18);
            txtTrangThai.TabIndex = 2;
            txtTrangThai.Text = "Trạng thái:";
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtTrangThai);
            Controls.Add(btnChiTiet);
            Controls.Add(txtMa);
            Name = "HoaDon";
            Size = new Size(594, 37);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnChiTiet;
        public Label txtMa;
        public Label txtTrangThai;
    }
}
