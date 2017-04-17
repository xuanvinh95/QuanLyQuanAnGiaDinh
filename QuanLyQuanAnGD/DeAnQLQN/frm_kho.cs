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
namespace DeAnQLQN
{
    public partial class frm_kho : Form
    {
        public frm_kho()
        {
            InitializeComponent();
        }
        BLL_Kho bd = new BLL_Kho(cls_Main.path);
        string manhapxuat = "",err="";
        DataTable dtkhohang,dtnhapxuat,dt;
        bool nhaphang = true;
        private void taomanhapxuat(int ktra)
        {
            DataTable dt = new DataTable();
            dt = bd.taomanhapxuat(ktra);
           if (dt.Rows.Count <= 0)
                manhapxuat = "1";
           else
            {

                manhapxuat = (dt.Rows.Count+1).ToString();
            }
           
        }
        private void laybangkhohang()
        {
            dtkhohang = new DataTable();
            dtkhohang = bd.laybangkhohang();
            dgv_Khohang.DataSource = dtkhohang;
        }
        private void laybangnhapxuat(int ktra)
        {
            dtnhapxuat = new DataTable();
            dtnhapxuat = bd.laybangnhapxuat(ktra, manhapxuat);
            dgv_nhapxuat.DataSource = dtnhapxuat;
        }
        private void textopen()
        {
            btn_ok.Enabled = true;
            btn_nguyenlieumoi.Enabled = true;
            txt_ten.Text = "";
            txt_soluong.Text = "";
            txt_donvi.Text = "";
            txt_giadv.Text = "";
            txt_ten.Enabled=true;
            txt_soluong.Enabled = true;
            txt_donvi.Enabled = true;
            txt_giadv.Enabled = true;
        }
        private void btn_nhapkho_Click(object sender, EventArgs e)
        {
            nhaphang = true;
            btn_nhapkho.Enabled = false;
            btn_xuatkho.Enabled = false;
            btn_luu.Enabled = true;
            btn_nhapkho.BackColor = Color.LightSalmon;
            label6.Text = "Bảng Nhập Kho";
            textopen();
            ///btn_ok.Text = "Nhập";
            dgv_nhapxuat.Visible = true;
            col_giadv.Visible = true;
            col_thanhgia.Visible = true;
            ////////////////////////////////////////////
            taomanhapxuat(1);
            laybangnhapxuat(1);
            //label6.Text = manhapxuat;
            //new SqlParameter("@MaNhap", MaNhap)
            //    , new SqlParameter("@TenSP", TenSP)
            //    , new SqlParameter("@SoLgSP", SoLgSP)
            //     , new SqlParameter("@DonVi", DonVi)
            //    , new SqlParameter("@Gia1DonVi", Gia1DonVi)
            //    , new SqlParameter("@ThanhTien", ThanhTien)
        }
        private bool kiemtratxt()
        {
            if (nhaphang)
            {
                if (string.IsNullOrEmpty(txt_ten.Text)
                    || string.IsNullOrEmpty(txt_soluong.Text)
                    || string.IsNullOrEmpty(txt_donvi.Text)
                    || string.IsNullOrEmpty(txt_giadv.Text)
                    )
                    return false;
                else return true;
            }
            else
            {
                if (string.IsNullOrEmpty(txt_ten.Text)
                    || string.IsNullOrEmpty(txt_soluong.Text)
                    || string.IsNullOrEmpty(txt_donvi.Text)
                    )
                    return false;
                else return true;
            }

        }
        private void btn_xuatkho_Click(object sender, EventArgs e)
        {
            nhaphang = false;
            btn_xuatkho.Enabled = false;
            btn_nhapkho.Enabled = false;
            btn_luu.Enabled = true;
            btn_xuatkho.BackColor = Color.LightSalmon;
            label6.Text = "Bảng Xuất Kho";
            btn_ok.Enabled = true;
            //btn_ok.Text = "Xuất";
            btn_nguyenlieumoi.Enabled = true;
            dgv_nhapxuat.Visible = true;
            textopen();
            txt_ten.Enabled = false;
            txt_donvi.Enabled = false;
            txt_giadv.Visible = false;
            txt_thanhtien.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            col_giadv.Visible = false;
            col_thanhgia.Visible = false;
            /////////////////////////////////////////////
            taomanhapxuat(0);
            laybangnhapxuat(0);
            //label6.Text = manhapxuat;
            label6.Text = manhapxuat;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = false;
            btn_nhapkho.Enabled = true;
            btn_xuatkho.Enabled = true;
            btn_ok.Enabled = false;
            btn_nguyenlieumoi.Enabled = false;
            btn_nhapkho.BackColor = Color.Transparent;
            btn_xuatkho.BackColor = Color.Transparent;
            dgv_nhapxuat.Visible = false;
            txt_thanhtien.Visible = true;
            txt_giadv.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Text = "";
            col_giadv.Visible = true;
            col_thanhgia.Visible = true;
            ////////////////////////////////////////////////
            if (nhaphang)
            {
                if (dgv_nhapxuat.Rows.Count <= 0) bd.xoanhapxuat(ref err, 1, manhapxuat, "0");
                else
                {
                    for (int i = 0; i < dgv_nhapxuat.Rows.Count; i++)
                    {

                        bd.khohangupdate(ref err, 1, dgv_nhapxuat.Rows[i].Cells["col_masp"].Value.ToString()
                            , dgv_nhapxuat.Rows[i].Cells["col_soluong"].Value.ToString());
                    }

                }
            }
            else
                if (dgv_nhapxuat.Rows.Count <= 0) bd.xoanhapxuat(ref err, 0, manhapxuat, "0");
                else
                {
                    for (int i = 0; i < dgv_nhapxuat.Rows.Count; i++)
                    {

                        bd.khohangupdate(ref err, 0, dgv_nhapxuat.Rows[i].Cells["col_masp"].Value.ToString()
                            , dgv_nhapxuat.Rows[i].Cells["col_soluong"].Value.ToString());
                    }

                }
            laybangkhohang();
            manhapxuat = "";
            
           
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            
            if (nhaphang)
            {
                if (kiemtratxt())
                {
                    bd.luunhapkho(ref err, manhapxuat,cls_Main.MaNV,txt_ten.Text.ToLower(), txt_soluong.Text
                        , txt_donvi.Text, txt_giadv.Text, txt_thanhtien.Text);
                    textopen();
                    laybangnhapxuat(1);
                }
                else MessageBox.Show("Có dữ liệu chưa nhập");
                
            }
            else
                if (kiemtratxt())
                {
                    bd.luuxuatkho(ref err, manhapxuat,cls_Main.MaNV, txt_ten.Text, txt_soluong.Text
                        , txt_donvi.Text);
                    textopen();
                    laybangnhapxuat(0);
                }
                else MessageBox.Show("Có dữ liệu chưa nhập");
            label7.Visible = false;
        }

        private void txt_giadv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txt_giadv_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_giadv.Text) && !string.IsNullOrEmpty(txt_soluong.Text))
            
                txt_thanhtien.Text = (Convert.ToDouble(txt_soluong.Text) * Convert.ToDouble(txt_giadv.Text)).ToString();
            if(nhaphang)label7.Visible = true;

            if (!string.IsNullOrEmpty(txt_giadv.Text)) label7.Text = String.Format("{0:0,0 vnđ}", Convert.ToDouble(txt_giadv.Text));
                  
        }

        private void frm_kho_Load(object sender, EventArgs e)
        {
            //manhapxuat = "1";
            //laybangnhapxuat(1);
           
            laybangkhohang();
            textBox1.Text = "nhập tên sản phẩm cần loc";
            textBox1.ForeColor = Color.Gray;
            laybangkhohang();
            //dgv_Khohang.Enabled = false;
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_giadv.Text) && !string.IsNullOrEmpty(txt_soluong.Text))

                txt_thanhtien.Text = (Convert.ToDouble(txt_soluong.Text) * Convert.ToDouble(txt_giadv.Text)).ToString();
            
            if (!nhaphang)
                if (dgv_Khohang.Rows.Count > 0)
                    if (!string.IsNullOrEmpty(txt_soluong.Text))
                        if (Convert.ToDouble(txt_soluong.Text) >
                            Convert.ToDouble(dgv_Khohang.CurrentRow.Cells["colsoluong"].Value.ToString()))
                            txt_soluong.Text = "";
            //MessageBox.Show(dgv_Khohang.CurrentRow.Cells["col_soluong"].Value.ToString());
        }

        private void dgv_Khohang_Click(object sender, EventArgs e)
        {

             txt_ten.Text = dgv_Khohang.CurrentRow.Cells["coltensp"].Value.ToString();
             txt_soluong.Text = "";
             txt_donvi.Text = dgv_Khohang.CurrentRow.Cells["coldonvi"].Value.ToString(); 
             //txt_giadv.Text = dgv_Khohang.CurrentRow.Cells["colgia1donvi"].Value.ToString();
             //txt_thanhtien.Text = dgv_Khohang.CurrentRow.Cells["colthanhgia"].Value.ToString();
             txt_ten.Enabled = false;
             txt_donvi.Enabled = false;
             if (bd.giamoi(dgv_Khohang.CurrentRow.Cells["colmasp"].Value.ToString()).Rows.Count > 0)
                 txt_giadv.Text = bd.giamoi(dgv_Khohang.CurrentRow.Cells["colmasp"].Value.ToString()).Rows[0]["Gia1DonVi"].ToString();
             else txt_giadv.Text = "";
           
        }

        private void btn_nguyenlieumoi_Click(object sender, EventArgs e)
        {
            if(nhaphang)
            {
            label7.Text = "";
            label7.Visible = false;
            textopen();}
            
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            txt_thanhtien.Text = "0";
        }

        private void frm_kho_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nhaphang) bd.xoanhapxuat(ref err, 1, manhapxuat, "0");
            else  bd.xoanhapxuat(ref err, 0, manhapxuat, "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_nhapxuat_Click(object sender, EventArgs e)
        {
            if (dgv_nhapxuat.Rows.Count > 0)
            {
                txt_ten.Text = dgv_nhapxuat.CurrentRow.Cells["col_tensp"].Value.ToString();
                txt_soluong.Text = dgv_nhapxuat.CurrentRow.Cells["col_soluong"].Value.ToString();
                txt_donvi.Text = dgv_nhapxuat.CurrentRow.Cells["col_donvi"].Value.ToString();
                if(nhaphang)txt_giadv.Text = dgv_nhapxuat.CurrentRow.Cells["col_giadv"].Value.ToString();
                if(nhaphang)txt_thanhtien.Text = dgv_nhapxuat.CurrentRow.Cells["col_thanhgia"].Value.ToString();
                txt_ten.Enabled = false;
                txt_donvi.Enabled = false;
                button1.Enabled = true;
            }
            //MessageBox.Show(dgv_nhapxuat.Rows[0].Cells["col_masp"].Value.ToString());
            
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_kho_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = false;
            btn_nhapkho.Enabled = true;
            btn_xuatkho.Enabled = true;
           
            btn_nhapkho.BackColor = Color.Transparent;
            btn_xuatkho.BackColor = Color.Transparent;
            dgv_nhapxuat.Visible = false;
            txt_thanhtien.Visible = true;
            txt_giadv.Visible = true;
            textopen();
            label7.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            txt_ten.Enabled = false;
            txt_soluong.Enabled = false;
            txt_donvi.Enabled = false;
            txt_giadv.Enabled = false;
            label6.Text = "";
            btn_ok.Enabled = false;
            btn_nguyenlieumoi.Enabled = false;
            ///////////////////////////////////////////
            if (nhaphang) bd.xoanhapxuat(ref err, 1, manhapxuat, "0");
            else bd.xoanhapxuat(ref err, 0, manhapxuat, "0");
            laybangkhohang();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (nhaphang)
            {
                if(dgv_nhapxuat.Rows.Count>0)
                bd.xoanhapxuat(ref err, 1, manhapxuat,
                    dgv_nhapxuat.CurrentRow.Cells["col_masp"].Value.ToString());
                laybangnhapxuat(1);
            }
            else
            {

                bd.xoanhapxuat(ref err, 0, manhapxuat,
                    dgv_nhapxuat.CurrentRow.Cells["col_masp"].Value.ToString());
                laybangnhapxuat(0);
            }
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView();
            dv = dtkhohang.DefaultView;
            dv.RowFilter = string.Format("TenSP like '%{0}%'", textBox1.Text);
            dgv_Khohang.DataSource = dv;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }



    }
}
