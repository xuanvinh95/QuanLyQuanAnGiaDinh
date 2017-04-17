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
