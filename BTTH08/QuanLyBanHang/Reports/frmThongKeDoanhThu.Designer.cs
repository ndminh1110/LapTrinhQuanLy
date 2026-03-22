namespace QuanLyBanHang.Reports
{
    partial class frmThongKeDoanhThu
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
            dtpTuNgay = new DateTimePicker();
            btnLocKetQua = new Button();
            btnHienTatCa = new Button();
            dtpDenNgay = new DateTimePicker();
            SuspendLayout();
            // 
            // reportViewer
            // 
            reportViewer.Location = new Point(0, 65);
            reportViewer.Name = "reportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(801, 387);
            reportViewer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 17);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(83, 14);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(198, 27);
            dtpTuNgay.TabIndex = 4;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(587, 12);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(94, 29);
            btnLocKetQua.TabIndex = 6;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(694, 12);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(94, 29);
            btnHienTatCa.TabIndex = 7;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(372, 13);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(198, 27);
            dtpDenNgay.TabIndex = 8;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDenNgay);
            Controls.Add(btnHienTatCa);
            Controls.Add(btnLocKetQua);
            Controls.Add(dtpTuNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reportViewer);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private Button btnLocKetQua;
        private Button btnHienTatCa;
        private DateTimePicker dtpDenNgay;
    }
}