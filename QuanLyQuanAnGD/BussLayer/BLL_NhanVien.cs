using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Data.SqlClient;
using System.Data;
using DTOLayer;
using BussLayer;

namespace BussLayer
{
    
    public class BLL_NhanVien
    { 
        DataBase data;
        public BLL_NhanVien(string path)
        {
            //khởi tạo đối tượng database
            data = new DataBase(path);
        }
        public DataTable laybangNhanVien()
        {
            return data.FillTable("PSP_laybangNhanVien", CommandType.StoredProcedure, null);

        }
        public DataTable Laydulieunhanvien(int manhanvien)
        {
            return data.FillTable("PSP_LayNhanVientheomaso", CommandType.StoredProcedure, new SqlParameter("@MaNhanVien", manhanvien));

        }
        public DataTable ktratk(string tk)
        {
            return data.FillTable("PSP_KiemTraTKTonTai", CommandType.StoredProcedure
                , new SqlParameter("@TaiKhoan", tk)
                );

        }
        public bool Them_SuaNhanVien(ref string err,cls_NhanVien _nhanvien)
        {
            return data.MyExcuteNonQuery("PSP_NhanVien_ThemSua", CommandType.StoredProcedure
                , new SqlParameter("@MaNV", _nhanvien.MaNV) 
                , new SqlParameter("@TenNV", _nhanvien.TenNV)
                , new SqlParameter("@PhaiNam", _nhanvien.PhaiNam)
                 , new SqlParameter("@DiaChi", _nhanvien.DiaChi)
                  , new SqlParameter("@ChucVu", _nhanvien.ChucVu)
                , new SqlParameter("@TaiKhoan", _nhanvien.TaiKhoan)
                , new SqlParameter("@MatKhau", _nhanvien.MatKhau));
        }
        public bool XoaNhanVien(ref string err, string manv)
        {
            return data.MyExcuteNonQuery("PSP_NhanVien_Xoa", CommandType.StoredProcedure, 
                new SqlParameter("@MaNV", manv));
        }

    }
}
