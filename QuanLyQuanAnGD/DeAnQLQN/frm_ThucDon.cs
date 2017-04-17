using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BussLayer;
using System.IO;
using DTOLayer;



namespace DeAnQLQN
{
    public partial class frm_ThucDon : Form
    {
        public frm_ThucDon()
        {
            InitializeComponent();
        }
        
        BLL_ThucDon bd = new BLL_ThucDon(cls_Main.path);
        cls_SanPham _thucdon;
        DataTable dt;
        string loai = "";
        
        
        private void loaddulieu(string lloai)
        {
            dt = new DataTable();
            dt = bd.LaySanPham(lloai);
            dgvThucDon.DataSource = dt.DefaultView;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
           
        }
        private void bingding()
        {
            txtmamon.Text = dgvThucDon.CurrentRow.Cells["colmamon"].Value.ToString();
            txttenmon.Text = dgvThucDon.CurrentRow.Cells["coltenmon"].Value.ToString();
            txtgiaban.Text = dgvThucDon.CurrentRow.Cells["coldongia"].Value.ToString();
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            txttenmon.Enabled = true;
            txtgiaban.Enabled = true;
            btnluu.Text = "Sữa món";

        }
    

        private void frm_ThucDon_Load(object sender, EventArgs e)
        {
            loaddulieu(loai);
            txtmamon.Enabled = false;
            txttenmon.Enabled = false;
            txtgiaban.Enabled = false;
            dgvThucDon.Visible = false;
            btnluu.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            txtloctensanpham.Text = "Nhập vào sản phẩm cần lọc";
            txtloctensanpham.ForeColor = Color.LightGray;

            //txttenmon.Enabled = false;
            //txtgiaban.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = string.Format("tenMon like '%{0}%'", txtloctensanpham.Text);
            dgvThucDon.DataSource = dv;
        }

      

        private void LayDuLieuVaoDTThucDon()
        {
            _thucdon = new cls_SanPham();
            if (!string.IsNullOrEmpty(txtmamon.Text))
            {
                _thucdon.MaMon = txtmamon.Text;
            }
            else
            {
                _thucdon.MaMon ="";
            }
            _thucdon.TenMon = txttenmon.Text;
            _thucdon.DonGia = Convert.ToInt32(txtgiaban.Text);
        }
       

      

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttenmon.Text))
            {
                LayDuLieuVaoDTThucDon();

                if (bd.capnhathucdon(_thucdon))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu(loai);
                }
                else
                {
                    MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmon.Focus();
            }
            
            btnluu.Enabled = false;
            
            loaddulieu(loai);
            txttenmon.Enabled = false;
            txtgiaban.Enabled = false;
            
            
        }
        private void resetcontrol()
        {
            txtgiaban.Text = "0";
            txttenmon.Text = "";
            txtmamon.Text = "";
            txttenmon.Focus();
        }
        private void btnthem_Click_1(object sender, EventArgs e)
        {
           // txttenmon.Enabled = true;
            //txtgiaban.Enabled = true;
            resetcontrol();
            btnthem.Enabled = false;
            txtmamon.Text = taomamon(loai);
            btnluu.Enabled = true;
            txttenmon.Enabled = true;
            txtgiaban.Enabled = true;
            btnluu.Text = "Lưu món";
            txttenmon.Focus();
        }
        
      
        private void dgvThucDon_Click_1(object sender, EventArgs e)
        {
            bingding();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bd.xoathucdon(dgvThucDon.CurrentRow.Cells["colmamon"].Value.ToString());
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show(dt.Rows[0]["thongbao"].ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu(loai);
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm này đã được bán không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            else
            {
                MessageBox.Show("Chưa chọn sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string taomamon(string lloai)
        {
            string ma= "";
            DataTable dt = new DataTable();
            dt = bd.LaySanPham(lloai);
            if (dt.Rows.Count <= 0)
                ma= "001";
            else
            {

                int i = dt.Rows.Count;
                i = Convert.ToInt16(dt.Rows[i - 1]["MaMon"].ToString().Substring(1,3)) + 1;

                if (i < 10)
                    ma= "00";
                else
                    if (i < 100)
                        ma = "0";
                  else ma= "";
                ma= ma+ i.ToString();
            }
            ma = lloai + ma;
            return ma;
        }

        private void btnLau_Click(object sender, EventArgs e)
        {
            loai = "A";
            loaddulieu(loai);
            dgvThucDon.Visible = true;

            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            lbltends.Text = "Danh sách món lẩu";
            
        }

        private void btnChienxao_Click(object sender, EventArgs e)
        {
            loai = "B";
            loaddulieu(loai);
            dgvThucDon.Visible = true ;
            
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            lbltends.Text = "Danh sách món chiên xào";
        }

        private void btnnuong_Click(object sender, EventArgs e)
        {
            loai = "C";
            loaddulieu(loai);
            dgvThucDon.Visible = true;

            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            lbltends.Text = "Danh sách món nướng";

        }

        private void btnnuocuong_Click(object sender, EventArgs e)
        {
            loai = "D";
            loaddulieu(loai);
            dgvThucDon.Visible = true;

            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            lbltends.Text = "Danh sách nước uông";

        }

        

        private void txtloctensanpham_Click(object sender, EventArgs e)
        {
            txtloctensanpham.Text = "";
            txtloctensanpham.ForeColor = Color.Black;
        }
      

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvThucDon_DoubleClick(object sender, EventArgs e)
        {
            cls_Main.MaMon = dgvThucDon.CurrentRow.Cells["colmamon"].Value.ToString();
            frm_nguyenlieu frm = new frm_nguyenlieu();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

      
      
       

       
       
    }
}
