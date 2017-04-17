using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussLayer;
using System.Data.SqlClient;

namespace DeAnQLQN
{
    public partial class frm_dangNhap : Form
    {
        
        public frm_dangNhap()
        {
            InitializeComponent();
        }
        BLL_DangNhap bd;
        string err = null;
        bool nhap = true, nhap1 = true, chantxt = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_dangNhap_Load(object sender, EventArgs e)
        {

            chantxt = true;
            txttaikhoan.Text = "nhập tài khoản";
            txttaikhoan.ForeColor = Color.DarkGray;
            chantxt = false;
            txtmatkhau.Text = "nhập mật khẩu";
            txtmatkhau.ForeColor = Color.DarkGray;
           
            
            //********************************************************
            bd = new BLL_DangNhap(cls_Main.path);
            if (!bd.kiemtraketnoi())
            {
              
                ///...
                bd = new BLL_DangNhap(cls_Main.path);
            }
            txttaikhoan.Focus();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlDataReader _reader;
            if(string.IsNullOrEmpty(txtmatkhau.Text) ||string.IsNullOrEmpty(txttaikhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu");
            }
            _reader = bd.kiemtradangnhap(ref err, txttaikhoan.Text, txtmatkhau.Text);
            if (_reader != null)
            {
                if (_reader.HasRows == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (_reader.Read())
                    {
                        cls_Main.TenNhanVien = _reader.GetString(1);
                    }
                    //mo form main
                    cls_Main.MaNV = bd.laymanv(txttaikhoan.Text.ToLower()).Rows[0]["MaNV"].ToString();
                    frm_quanLy _frmMain = new frm_quanLy();
                    _frmMain.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                lblthongbaoloi.Text = err;
            }

        }

        private void txttaikhoan_MouseClick(object sender, MouseEventArgs e)
        {
            txttaikhoan.Text = "";
            txttaikhoan.ForeColor = Color.FromArgb(110, 89, 36);
         
        }

        private void txtmatkhau_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txttaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nhap)

                txttaikhoan.Text = "";
            txttaikhoan.ForeColor = Color.FromArgb(110, 89, 36);
            nhap = false;
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {
            if (!chantxt)
            {
                txtmatkhau.Text = "";
                txtmatkhau.UseSystemPasswordChar = true;
                txtmatkhau.ForeColor = Color.FromArgb(110, 89, 36);
            }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
         
                   
        }

        private void txtmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {

                
               
                
        }

        private void txtmatkhau_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

      

        

        

       

       
        
    }
}
