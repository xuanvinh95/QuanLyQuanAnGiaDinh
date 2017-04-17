using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussLayer;
using DTOLayer;

namespace DeAnQLQN
{
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }
        BLL_NhanVien bd;
        string err = "";
        cls_NhanVien _nhanvien;
        DataTable dt;
        bool ktrasai = false;
        bool oksua = false;
        
        private void loaddulieu()
        {
            dgvNhanVien.DataSource = bd.Laydulieunhanvien(0);   
        }
        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            bd = new BLL_NhanVien(cls_Main.path);
            loaddulieu();
            btnluu.Enabled = false;
            txtennhanvien.Enabled = false;
            txtmatkhau.Enabled = false;
            txttaikhoan.Enabled = false;
            txtdiachi.Enabled = false;
            txtmanhanvien.Enabled = false;
            cbochucvu.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void loaddulieuvaonhanvien()
        {
            _nhanvien = new cls_NhanVien();
            _nhanvien.MaNV = txtmanhanvien.Text;

            _nhanvien.TenNV = txtennhanvien.Text;
            _nhanvien.PhaiNam = rdonu.Checked;
            _nhanvien.DiaChi = txtdiachi.Text;
            _nhanvien.ChucVu = cbochucvu.Text;
            
            _nhanvien.TaiKhoan = txttaikhoan.Text;
            if (!oksua)
            if(bd.ktratk(txttaikhoan.Text).Rows[0]["err"].ToString()=="1"&&!string.IsNullOrEmpty(txttaikhoan.Text))
            {
                ktrasai = true;
                MessageBox.Show("Tài Khoản Đã Tồn Tại");
            }
            else
              if (!string.IsNullOrEmpty(txttaikhoan.Text) && string.IsNullOrEmpty(txtmatkhau.Text))
                {
                    ktrasai = true;
                    MessageBox.Show("Thiếu Mật Khẩu!");
                }
                else ktrasai = false;
            _nhanvien.MatKhau = txtmatkhau.Text;
        }
        private string taomaNV()
        {
            string manv="";
            DataTable dt = new DataTable();
            dt = bd.laybangNhanVien();
            if (dt.Rows.Count <= 0)
                manv = "0001";
            else
            {

                int i = dt.Rows.Count;
                i = Convert.ToInt16(dt.Rows[i - 1]["MaNV"].ToString().Substring(3, 3)) + 1;
               
                if (i < 10)
                    manv = "000";
                else
                    if (i < 100)
                        manv = "00";
                    else
                        if (i < 1000)
                            manv = "0";
                        else manv = "";
                manv= manv + i.ToString();
            }
            manv="NV" + manv;
            return manv;
        }
        private void bingding()
        {
            
            txtmanhanvien.Text = dgvNhanVien.CurrentRow.Cells["colmanhanvien"].Value.ToString();
            txtennhanvien.Text = dgvNhanVien.CurrentRow.Cells["colhoten"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["colphainam"].Value.ToString() == "Nam")
                rdonam.Checked = true;
            else
                rdonu.Checked = true;
            txtdiachi.Text = dgvNhanVien.CurrentRow.Cells["coldiachi"].Value.ToString();
            cbochucvu.Text = dgvNhanVien.CurrentRow.Cells["colchucvu"].Value.ToString();
            txttaikhoan.Text = dgvNhanVien.CurrentRow.Cells["coltaikhoan"].Value.ToString();
           

        }


       

  
        private void resetControl()
        {
            
            txtennhanvien.Text = "";
            txtmanhanvien.Text = "";
            txtmatkhau.Text = "";
            txttaikhoan.Text = "";
            txtdiachi.Text = "";
            cbochucvu.Text = "";
        }
        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            bingding();
            txtennhanvien.Enabled = true;
            txtmatkhau.Enabled = true;
            txttaikhoan.Enabled = true;
           
            txtdiachi.Enabled = true;
            cbochucvu.Enabled = true;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Text = "Sữa Nhân Viên";
            txtmatkhau.Enabled = false;
            txttaikhoan.Enabled = false;
            oksua = true;
        }

   
      

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            txtennhanvien.Enabled = true;
            txtmatkhau.Enabled = true;
            txttaikhoan.Enabled = true;
            txtdiachi.Enabled = true;
            txtmanhanvien.Text = taomaNV();
            txtdiachi.Enabled = true;
            cbochucvu.Enabled = true;
            btnluu.Enabled = true;
            btnluu.Text = "Lưu Nhân Viên";
            btnthem.Enabled = false;
            txtmanhanvien.Focus();
            oksua = false;
            
        }

        private void btnluu_Click_1(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtennhanvien.Text))
            {
                loaddulieuvaonhanvien();
                if(!ktrasai)
                if (bd.Them_SuaNhanVien(ref err, _nhanvien))
                {
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddulieu();
                    resetControl();
                    txtennhanvien.Enabled = false;
                    txtmatkhau.Enabled = false;
                    txttaikhoan.Enabled = false;
                    txtdiachi.Enabled = false;
                    txtdiachi.Enabled = false;
                    cbochucvu.Enabled = false;
                    btnxoa.Enabled = false;


                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            txtennhanvien.Enabled = false;
            txtmatkhau.Enabled = false;
            txttaikhoan.Enabled = false;
            txtdiachi.Enabled = false;
            cbochucvu.Enabled = false;
            btnxoa.Enabled = false;
            
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmanhanvien.Text))
            {
                if (bd.XoaNhanVien(ref err, txtmanhanvien.Text))
                {


                    MessageBox.Show("Xóa Thành Công!", "Thông báo");
                    loaddulieu();
                    resetControl();

                }
                else
                {
                    MessageBox.Show("Xóa không thành công","Thông báo");
                    resetControl();

                }

            }
            txtennhanvien.Enabled = false;
            txtmatkhau.Enabled = false;
            txttaikhoan.Enabled = false;
            txtdiachi.Enabled = false;
            txtdiachi.Enabled = false;
            cbochucvu.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
        }
    }
}
