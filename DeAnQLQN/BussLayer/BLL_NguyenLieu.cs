using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussLayer
{
    public class BLL_NguyenLieu
    {
        DataBase data;
        public BLL_NguyenLieu(string path)
        {
            data = new DataBase(path);
        }

        public DataTable laybangnhapxuat( string ma)
        {
            return data.FillTable("PSP_ChiTietMon_Select", CommandType.StoredProcedure
                 //, new SqlParameter("@nhaphang", n)
                 , new SqlParameter("@MaMon", ma)
                );
        }
        public DataTable laytenmon(string ma)
        {
            return data.FillTable("PSP_ThucDon_LayTenMon", CommandType.StoredProcedure
                //, new SqlParameter("@nhaphang", n)
                 , new SqlParameter("@MaMon", ma)
                );
        }
        public DataTable laybangkhohang()
        {
            return data.FillTable("PSP_KhoHang_Select", CommandType.StoredProcedure
                , null
                );
        }
        public DataTable taomanhapxuat(int n)
        {
            return data.FillTable("PSP_NhapXuatKho_select", CommandType.StoredProcedure
                 , new SqlParameter("@nhaphang", n)
                //, new SqlParameter("@MaNhapXuat", ma)
                );
        }
        public bool luunhapchitietmon(ref string err, string MaMon, string TenSP
            , string LuongDung, string DonVi)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChiTietMon", CommandType.StoredProcedure
                , new SqlParameter("@MaMon", MaMon)
                , new SqlParameter("@TenSP", TenSP)
                , new SqlParameter("@LuongDung", LuongDung)
                 , new SqlParameter("@DonVi", DonVi)
              
                );
        }
        public bool luuxuatkho(ref string err, string MaXuat, string TenSP
           , string SoLgSP, string DonVi)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChiTietXuatKho", CommandType.StoredProcedure
                , new SqlParameter("@MaXuat", MaXuat)
                , new SqlParameter("@TenSP", TenSP)
                , new SqlParameter("@SoLgSP", SoLgSP)
                 , new SqlParameter("@DonVi", DonVi)

                );
        }
        public bool xoactmon(ref string err, string MaNhapXuat, string MaSP)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChiTietMon_Xoa", CommandType.StoredProcedure

                , new SqlParameter("@MaMon", MaNhapXuat)
                 , new SqlParameter("@MaSP", MaSP)

                );
        }
        public bool khohangupdate(ref string err, int n, string MaSP, string SoLgSP)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_Khohang_Update", CommandType.StoredProcedure
                , new SqlParameter("@nhaphang", n)
                , new SqlParameter("@MaSP", MaSP)
                 , new SqlParameter("@SoLgSP", SoLgSP)

                );
        }
        public DataTable giamoi(string ma)
        {
            return data.FillTable("PSP_ChiTietNK_NewGia", CommandType.StoredProcedure
                 , new SqlParameter("@MaSP", ma)
                //, new SqlParameter("@MaNhapXuat", ma)
                );
        }
    }
}
