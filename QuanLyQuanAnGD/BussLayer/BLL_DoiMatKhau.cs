using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussLayer
{
    public class BLL_DoiMatKhau
    {
        DataBase data;
        public BLL_DoiMatKhau(string path)
        {
            data = new DataBase(path);
        }
        public DataTable laybangNhanVien()
        {
            return data.FillTable("PSP_laybangNhanVien", CommandType.StoredProcedure, null);

        }
        public DataTable laytk(string tk)
        {
            return data.FillTable("PSP_NhanVien_taikhoan", CommandType.StoredProcedure
                , new SqlParameter("@MaNV", tk)
                );
        }
        public DataTable doimatkhau(string tk,string mkc,string mkm)
        {
            return data.FillTable("DoiMatKhau", CommandType.StoredProcedure
                , new SqlParameter("@MaNV", tk)
                , new SqlParameter("@matkhaucu", mkc)
                , new SqlParameter("@matkhaumoi", mkm)
                );
        }
        public bool PSP_reset_matkhau(ref string err, string MaXuat)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_reset_matkhau", CommandType.StoredProcedure
                , new SqlParameter("@MaNV", MaXuat)
               

                );
        }
    }
}
