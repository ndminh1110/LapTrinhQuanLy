namespace QuanLyBanHang.Reports
{
    partial class frmThongKeSanPham
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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new Label();
            label2 = new Label();
            btnLocKetQua = new Button();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(-1, 66);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(801, 387);
            reportViewer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Hãng sản xuất:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 23);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Loại sản phẩm:";
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(662, 19);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 3;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(115, 20);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(208, 28);
            cboHangSanXuat.TabIndex = 4;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(448, 20);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(208, 28);
            cboLoaiSanPham.TabIndex = 5;
            // 
            // frmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboLoaiSanPham);
            Controls.Add(cboHangSanXuat);
            Controls.Add(btnLocKetQua);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reportViewer);
            Name = "frmThongKeSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sản phẩm";
            Load += frmThongKeSanPham_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Label label1;
        private Label label2;
        private Button btnLocKetQua;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
    }
}