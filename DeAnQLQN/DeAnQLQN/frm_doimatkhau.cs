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
    public partial class frm_doimatkhau : Form
    {
        public frm_doimatkhau()
        {
            InitializeComponent();
        }
        bool rs = false;
        BLL_DoiMatKhau bd = new BLL_DoiMatKhau(cls_Main.path);
        string err = "";
        private void frm_doimatkhau_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = bd.laybangNhanVien();
            comboBox1.DataSource = dt1;
            comboBox1.ValueMember = "MaNV";
            comboBox1.DisplayMember = "MaNV";
            txttentaikhoan.Text = bd.laytk(cls_Main.MaNV).Rows[0]["TaiKhoan"].ToString();
            if (cls_Main.MaNV.Substring(0, 2).ToString() != "AD")
            {
                btnreset.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!rs)
            {
                if (txtmkm.Text == txtmkm1.Text)
                {
                    if (bd.doimatkhau(cls_Main.MaNV, txtmkcu.Text, txtmkm.Text).Rows[0]["err"].ToString() == "0")
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thành Công");
                        txtmkcu.Text = "";
                        txtmkm.Text = "";
                        txtmkm1.Text = "";
                    }
                    else MessageBox.Show("Mật Khẩu Cũ Không Đúng");
                }
                else MessageBox.Show("Mật Khẩu Mới Không Giống Nhau");
            }
            else
            {
                comboBox1.Visible = false;
                txtmkm.Visible = true;
                txtmkcu.Visible = true;
                txtmkm1.Visible = true;
                txttentaikhoan.Visible = true;
                lbltentk.Text = "Tên Tài Khoản:";
                lblmkcu.Visible = true;
                lblmkm.Visible = true;
                lblmkm1.Visible = true;
                btnluu.Enabled = true;
                //btnluu.Text = "Lưu";
                bd.PSP_reset_matkhau(ref err, comboBox1.SelectedValue.ToString());
                MessageBox.Show("Reset Thành Công");
                rs = false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            txtmkm.Visible = false;
            txtmkcu.Visible = false;
            txtmkm1.Visible = false;
            txttentaikhoan.Visible = false;
            lbltentk.Text = "Reset mật khẩu:";
            lblmkcu.Visible = false;
            lblmkm.Visible = false;
            lblmkm1.Visible = false;
            //btnluu.Enabled = false;
            //btnluu.Text = "Refresh";
            rs = true;
        }
        
        //string manv = cls_Main.MaNV;
    }
}
