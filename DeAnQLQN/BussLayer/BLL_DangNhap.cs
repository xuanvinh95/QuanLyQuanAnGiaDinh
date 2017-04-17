using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Data.SqlClient;
using System.Data;

namespace BussLayer
{
    public class BLL_DangNhap
    {

        DataBase da;
        //hàm tạo sử dụng cho frm đăng nhập
        public BLL_DangNhap(string path)
        {
            //khởi tạo đối tượng database
            da = new DataBase(path);
        }
        public DataTable laymanv(string tk)
        {
            return da.FillTable("PSP_NhanVien_MaNV", CommandType.StoredProcedure
                , new SqlParameter("@TaiKhoan", tk)
                );
        }
        //hàm tạo sử dụng cho frm kết nối
        public BLL_DangNhap(string path, ref string servername, ref string databasename, ref string userid, ref string password)
        {
            //khởi tạo đối tượng database
            da = new DataBase(path, ref  servername, ref databasename, ref  userid, ref password);
        }
        public bool kiemtraketnoi()
        {
            return da.kiemtraketnoi();
        }
        public SqlDataReader kiemtradangnhap(ref string err, string taikhoan, string matkhau)
        {
            return da.MyExcuteReader(ref err, "PSP_NhanVien_KiemTraDangNhap", CommandType.StoredProcedure,
                new SqlParameter("@TaiKhoan", taikhoan),
                new SqlParameter("@MatKhau", matkhau));
        }
        public object laydulieu(ref string err)
        {
            return da.MyExcuteScalar(ref err, "", CommandType.StoredProcedure, null);
        }
    }
}
