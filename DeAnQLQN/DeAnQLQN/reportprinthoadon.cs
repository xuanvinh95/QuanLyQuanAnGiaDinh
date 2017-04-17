using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussLayer;
using Microsoft.Reporting.WinForms;

namespace DeAnQLQN
{
    public partial class reportprinthoadon : Form
    {
        string mahd;
        public reportprinthoadon(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }
        BLL_BanHang bd = new BLL_BanHang(cls_Main.path);
        private DataTable laydulieu()
        {
            return bd.inhoadon(mahd);
        }
        private void hienthi()
        {
            DataTable table = new DataTable();
            table.Clear();
            table = laydulieu();
            //reset lai khung hiển thị report
            reportViewer1.Reset();
            //gán tên report cần hiển thị trong khung nhìn viewer
            // reportViewer1.LocalReport.ReportPath = @"E:\Download\ExamCSharp\ExamQLBH\ExamQLBH\rpt_danhsachkhachhang.rdlc";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DeAnQLQN.report_inhoadon.rdlc";

            //làm sạch khung nhìn
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource newDataSource = new ReportDataSource("DS_hoadon", table);
            reportViewer1.LocalReport.DataSources.Add(newDataSource);
            //lam tuoi report

            reportViewer1.RefreshReport();
        }
        private void reportprinthoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_inhoadon.PSP_hoadon_IN' table. You can move, or remove it, as needed.
           

            hienthi();
        }
    }
}
