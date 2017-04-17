using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussLayer;
using System.Threading;
using System.Data;
using System.Data.SqlClient;

namespace DeAnQLQN
{
    public partial class frm_nguyenlieu : Form
    {
        public frm_nguyenlieu()
        {
            InitializeComponent();
        }
        BLL_NguyenLieu bd = new BLL_NguyenLieu(cls_Main.path);
        string manhapxuat = cls_Main.MaMon, err = "";
        DataTable dtkhohang, dtnhapxuat;
        bool nhaphang = true;
     
        private void laybangkhohang()
        {
            dtkhohang = new DataTable();
            dtkhohang = bd.laybangkhohang();
            dgv_Khohang.DataSource = dtkhohang;
        }
        private void laybangnhapxuat()
        {
            dtnhapxuat = new DataTable();
            dtnhapxuat = bd.laybangnhapxuat(manhapxuat);
            dgv_nhapxuat.DataSource = dtnhapxuat;
        }
        private void textopen()
        {
            btn_ok.Enabled = true;
            btn_nguyenlieumoi.Enabled = true;
            txt_ten.Text = "";
            txt_soluong.Text = "";
            txt_donvi.Text = "";
            
            txt_ten.Enabled = true;
            txt_soluong.Enabled = true;
            txt_donvi.Enabled = true;
            
        }
      
        private bool kiemtratxt()
        {
           
                if (string.IsNullOrEmpty(txt_ten.Text)
                    || string.IsNullOrEmpty(txt_soluong.Text)
                    || string.IsNullOrEmpty(txt_donvi.Text)
                    )
                    return false;
                else return true;
          

        }
        

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frm_kho_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

       

        private void frm_nguyenlieu_Load(object sender, EventArgs e)
        {
            laybangkhohang();
            laybangnhapxuat();
            txtloctensanpham.Text = "Nhập tên sản phẩm cần lọc";
            txtloctensanpham.ForeColor = Color.LightGray;
            laybangkhohang();
            label6.Text ="Nguyên Liệu Chính Món: " +bd.laytenmon(cls_Main.MaMon).Rows[0]["TenMon"].ToString();
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {

            if (kiemtratxt())
            {
                bd.luunhapchitietmon(ref err, manhapxuat, txt_ten.Text.ToLower(), txt_soluong.Text
                    , txt_donvi.Text);
                textopen();
                laybangnhapxuat();
            }
            else MessageBox.Show("Có dữ liệu chưa nhập");
            textopen();

        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            textopen();
        }

        private void btn_nguyenlieumoi_Click_1(object sender, EventArgs e)
        {
            textopen();
        }

        private void dgv_Khohang_Click_1(object sender, EventArgs e)
        {
            txt_ten.Text = dgv_Khohang.CurrentRow.Cells["coltensp"].Value.ToString();
            txt_soluong.Text = "";
            txt_donvi.Text = dgv_Khohang.CurrentRow.Cells["coldonvi"].Value.ToString();
            //txt_giadv.Text = dgv_Khohang.CurrentRow.Cells["colgia1donvi"].Value.ToString();
            //txt_thanhtien.Text = dgv_Khohang.CurrentRow.Cells["colthanhgia"].Value.ToString();
            txt_ten.Enabled = false;
            txt_donvi.Enabled = false;
            txt_soluong.Enabled = true;
        }

        private void dgv_nhapxuat_Click_1(object sender, EventArgs e)
        {
            if (dgv_nhapxuat.Rows.Count > 0)
            {
                txt_ten.Text = dgv_nhapxuat.CurrentRow.Cells["col_tensp"].Value.ToString();
                txt_soluong.Text = dgv_nhapxuat.CurrentRow.Cells["col_soluong"].Value.ToString();
                txt_donvi.Text = dgv_nhapxuat.CurrentRow.Cells["col_donvi"].Value.ToString();

                txt_ten.Enabled = false;
                txt_donvi.Enabled = false;
                txt_soluong.Enabled = true;
                button1.Enabled = true;
            }
            //MessageBox.Show(dgv_nhapxuat.Rows[0].Cells["col_masp"].Value.ToString());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (dgv_nhapxuat.Rows.Count > 0)
                bd.xoactmon(ref err, manhapxuat,
                    dgv_nhapxuat.CurrentRow.Cells["col_masp"].Value.ToString());


            button1.Enabled = false;
            laybangnhapxuat();
        }

        private void txt_soluong_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_soluong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string decimalString = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            char decimalChar = Convert.ToChar(decimalString);

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }
            else if (e.KeyChar.ToString() == decimalString && txt_soluong.Text.IndexOf(decimalString) == -1)
            { }
            else
            {
                e.Handled = true;
            }
        }

        private void txtloctensanpham_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView();
            dv = dtkhohang.DefaultView;
            dv.RowFilter = string.Format("TenSP like '%{0}%'", txtloctensanpham.Text);
            dgv_Khohang.DataSource = dv;
        }

        private void txtloctensanpham_Click(object sender, EventArgs e)
        {
            txtloctensanpham.Text = "";
            txtloctensanpham.ForeColor = Color.Black;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

       



    }
}
