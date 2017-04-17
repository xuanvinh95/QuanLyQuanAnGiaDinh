using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussLayer;

namespace DeAnQLQN
{
    public partial class frm_baocao : Form
    {
        public frm_baocao()
        {
            InitializeComponent();
        }
        BLL_BaoCao bd = new BLL_BaoCao(cls_Main.path);
        DataTable dthoadon,uotluongnguenlieu;
        private void hienthidanhsachhoadon()
        {
            dthoadon = new DataTable();
            dthoadon = bd.Laythongtinhoadon(dtptungay.Value, dtpdenngay.Value);
            dgv_baocao.DataSource = dthoadon;
        }
        private void layuotluongnguyenlieu()
        {
            //uotluongnguenlieu = new DataTable();
            //uotluongnguenlieu = bd.layuotluongnguyenlieu(dtptungay.Value, dtpdenngay.Value);
            DataTable d1 = new DataTable();
            DataTable d2 = new DataTable();
            d1 = bd.GiaTbNguyenLieu(dtptungay.Value, dtpdenngay.Value);
            d2 = bd.TongTren1SP(dtptungay.Value, dtpdenngay.Value);
            double tongulnl = 0;
            for (int i = 0; i < d1.Rows.Count; i++)
                for (int j = 0; j < d2.Rows.Count; j++)
               
                    if (d1.Rows[i]["MaSP"].ToString() == d2.Rows[j]["MaSP"].ToString())
                        tongulnl += Convert.ToDouble(d1.Rows[i]["GiaTB"].ToString()) * Convert.ToDouble(d2.Rows[j]["SoLgSP"].ToString());
                
                    //for (int i = 0; i < uotluongnguenlieu.Rows.Count; i++)
                    //{
                    //    tongulnl += Convert.ToDouble(uotluongnguenlieu.Rows[i]["ThanhTien"].ToString());
                    //}
                    lbltongngyuenlieu.Text = string.Format("{0:#,###0 vnđ}", tongulnl);
        }
        private void tongloinhuan()
        {
            //uotluongnguenlieu = new DataTable();
            //uotluongnguenlieu = bd.layuotluongnguyenlieu(dtptungay.Value, dtpdenngay.Value);
            double tongulnl = 0;
            DataTable d1 = new DataTable();
            DataTable d2 = new DataTable();
            d1 = bd.GiaTbNguyenLieu(dtptungay.Value, dtpdenngay.Value);
            d2 = bd.TongTren1SP(dtptungay.Value, dtpdenngay.Value);
            double tongthanhtien = 0;
            double tongloinhuan = 0;
            for (int i = 0; i < d1.Rows.Count; i++)
                for (int j = 0; j < d2.Rows.Count; j++)
                     if (d1.Rows[i]["MaSP"].ToString() == d2.Rows[j]["MaSP"].ToString())
                         tongulnl += Convert.ToDouble(d1.Rows[i]["GiaTB"].ToString()) * Convert.ToDouble(d2.Rows[j]["SoLgSP"].ToString());
            

            for (int i = 0; i < dthoadon.Rows.Count; i++)
            {
                tongthanhtien += Convert.ToDouble(dthoadon.Rows[i]["TongTien"].ToString());
            }
            tongloinhuan = tongthanhtien - tongulnl;
            lbltongloinhuan.Text = string.Format("{0:#,###0 vnđ}", tongloinhuan);
        }
        private void frm_baocao_Load(object sender, EventArgs e)
        {
            hienthidanhsachhoadon();
            layuotluongnguyenlieu();
            tongloinhuan();
            txttonghoadon.Text = dgv_baocao.Rows.Count.ToString();
            double tongthanhtien = 0;
           
            for (int i = 0; i < dthoadon.Rows.Count; i++)
            {
                tongthanhtien += Convert.ToDouble(dthoadon.Rows[i]["TongTien"].ToString());
            }
            lbltongdoanhthu.Text = string.Format("{0:#,###0 vnđ}", tongthanhtien);
        }

       

        private void dtptungay_ValueChanged(object sender, EventArgs e)
        {
            hienthidanhsachhoadon();
            layuotluongnguyenlieu();
            tongloinhuan();
            txttonghoadon.Text = dgv_baocao.Rows.Count.ToString();
            double tongthanhtien = 0;

            for (int i = 0; i < dthoadon.Rows.Count; i++)
            {
                tongthanhtien += Convert.ToDouble(dthoadon.Rows[i]["TongTien"].ToString());
            }
            lbltongdoanhthu.Text = string.Format("{0:#,###0 vnđ}", tongthanhtien);
        }

        private void dtpdenngay_ValueChanged(object sender, EventArgs e)
        {
            hienthidanhsachhoadon();
            layuotluongnguyenlieu();
            tongloinhuan();
            txttonghoadon.Text = dgv_baocao.Rows.Count.ToString();
            double tongthanhtien = 0;

            for (int i = 0; i < dthoadon.Rows.Count; i++)
            {
                tongthanhtien += Convert.ToDouble(dthoadon.Rows[i]["TongTien"].ToString());
            }
            lbltongdoanhthu.Text = string.Format("{0:#,###0 vnđ}", tongthanhtien);
        }

        

        private void dgv_baocao_DoubleClick(object sender, EventArgs e)
        {
            frm_baocaochitiet bcchitiet = new frm_baocaochitiet();
            bcchitiet.dgv_baocao = dgv_baocao;
            bcchitiet.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //khoi tao excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //khoi taoWorbppk
            Microsoft.Office.Interop.Excel._Workbook worbook = app.Workbooks.Add(Type.Missing);
            
            //khoi tao sheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = worbook.Sheets["Sheet1"];
            worksheet = worbook.ActiveSheet;
            app.Visible = true;
            //khoi tao vào sheet
            worksheet.Cells[2, 3] = "BÁO CÁO HÓA ĐƠN VÀ LỢI NHUẬN";
            worksheet.Cells[4, 3] = "STT";
            worksheet.Cells[4, 4] = "MaHD";
            worksheet.Cells[4, 5] = "Ngày Lập HD";
            worksheet.Cells[4, 6] = "Tổng Tiền";
            for (int i = 0; i < dgv_baocao.Rows.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                   worksheet.Cells[i + 5, j + 3] = dgv_baocao.Rows[i].Cells[j].Value;
               }
            }
            int cdai = dgv_baocao.RowCount;
            worksheet.Cells[cdai + 5, 5]= "Tổng Tiền:";
            worksheet.Cells[cdai + 5, 6] = lbltongdoanhthu.Text;
            worksheet.Cells[cdai + 6, 5] = "Tổng tiền nguyên liệu: ";
            worksheet.Cells[cdai + 6, 6] = lbltongngyuenlieu.Text;
            worksheet.Cells[cdai + 7, 5] = "Tổng lợi nhuận: ";
            worksheet.Cells[cdai + 7, 6] = lbltongloinhuan.Text;
          //định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;
          //định dạng cột
            worksheet.Range["C1"].ColumnWidth = 8.25;
            worksheet.Range["D1"].ColumnWidth = 8.25;
            worksheet.Range["E1"].ColumnWidth = 28;
            worksheet.Range["F1"].ColumnWidth = 15;
            //định dạng font
            worksheet.Range["C2", "F100"].Font.Name = "Times New Roman";
            worksheet.Range["C2", "F100"].Font.Size = 14;
            worksheet.Range["C2", "F2"].MergeCells = true;
            
            worksheet.Range["C2", "F2"].Font.Bold = true;
            worksheet.Range["C4", "F4"].Font.Bold = true;
            //ke bảng 
            worksheet.Range["C4", "F" + (cdai + 4)].Borders.LineStyle = 1;
            worksheet.Range["C2", "F2"].HorizontalAlignment = 3;
            worksheet.Range["C4", "F4"].HorizontalAlignment = 3;
            worksheet.Range["C5", "C" + (cdai + 4)].HorizontalAlignment = 3;
            worksheet.Range["D4", "D" + (cdai + 4)].HorizontalAlignment = 3;
            worksheet.Range["E5", "E" + (cdai + 4)].HorizontalAlignment = 3;
          
            worksheet.Range["F5", "F100"].NumberFormat = "#,##0";
           
        }

        private void btn_NhapXuat_Click(object sender, EventArgs e)
        {
            cls_Main.tungay = dtptungay.Value;
            cls_Main.dengay = dtpdenngay.Value;
            frm_baocao_nhapxuat frm = new frm_baocao_nhapxuat();
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cls_Main.tungay = dtptungay.Value;
            cls_Main.dengay = dtpdenngay.Value;
        }

        
    }
}
