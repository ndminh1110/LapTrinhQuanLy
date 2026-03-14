using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel.Design;
using System.IO;
using Microsoft.Reporting.WinForms;
using QuanLyBanHang.Data;

using DisplayMode = Microsoft.Reporting.WinForms.DisplayMode;

namespace QuanLyBanHang.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLBHDbContext context = new QLBHDbContext();

        QLBHDataSet.DoanhThuDataTable danhSachDoanhThuDataTable = new QLBHDataSet.DoanhThuDataTable();

        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var danhSachDoanhThu = context.SanPham.Select(r => new
            {
                r.ID,
                r.TenSanPham,
                r.DonGia,
                r.SoLuong,
                DoanhThu = r.DonGia * r.SoLuong
            }).ToList();

            danhSachDoanhThuDataTable.Clear();

            foreach (var row in danhSachDoanhThu)
            {
                danhSachDoanhThuDataTable.AddDoanhThuRow(
                    row.ID,
                    row.TenSanPham,
                    row.DonGia,
                    row.SoLuong,
                    row.DoanhThu
                );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachDoanhThu";
            reportDataSource.Value = danhSachDoanhThuDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath =Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }
    }
}