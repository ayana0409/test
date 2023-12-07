namespace test
{
    partial class frmHienThiSP
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            txtMa = new TextBox();
            button1 = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(726, 370);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.MouseLeave += flowLayoutPanel1_MouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(1, 249);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(732, 392);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(785, 93);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(100, 23);
            txtMa.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(785, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(396, 246);
            reportViewer1.TabIndex = 0;
            // 
            // frmHienThiSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 681);
            Controls.Add(button1);
            Controls.Add(txtMa);
            Controls.Add(groupBox1);
            Controls.Add(reportViewer1);
            Name = "frmHienThiSP";
            Text = "frmHienThiSP";
            Load += frmHienThiSP_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox txtMa;
        private Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}