using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOLayer
{
    public class cls_NhanVien
    {
        private string maNV, tenNV, diaChi, chucVu;

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
    
        private string taiKhoan, matKhau;
        private bool phaiNam;

        public bool PhaiNam
        {
            get { return phaiNam; }
            set { phaiNam = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }




       
    }
}
