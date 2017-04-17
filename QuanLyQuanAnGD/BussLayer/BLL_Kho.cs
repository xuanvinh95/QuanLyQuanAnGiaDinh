using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussLayer
{
    public class BLL_Kho
    {
        DataBase data;
        public BLL_Kho(string path)
        {
            data = new DataBase(path);
        }

        public DataTable laybangnhapxuat(int n, string ma)
        {
            return data.FillTable("PSP_ChiTietNhapXuat_Select", CommandType.StoredProcedure
                 , new SqlParameter("@nhaphang", n)
                 , new SqlParameter("@MaNhapXuat", ma)
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
        public bool luunhapkho(ref string err, string MaNhap,string MaNV, string TenSP
            , string SoLgSP, string DonVi, string Gia1DonVi, string ThanhTien)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChiTietNhapKho", CommandType.StoredProcedure
                , new SqlParameter("@MaNhap", MaNhap)
                 , new SqlParameter("@MaNV", MaNV)
                , new SqlParameter("@TenSP", TenSP)
                , new SqlParameter("@SoLgSP", SoLgSP)
                 , new SqlParameter("@DonVi", DonVi)
                , new SqlParameter("@Gia1DonVi", Gia1DonVi)
                , new SqlParameter("@ThanhTien", ThanhTien)
                );
        }
        public bool luuxuatkho(ref string err, string MaXuat,string MaNV, string TenSP
           , string SoLgSP, string DonVi)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChiTietXuatKho", CommandType.StoredProcedure
                , new SqlParameter("@MaXuat", MaXuat)
                , new SqlParameter("@MaNV", MaNV)
                , new SqlParameter("@TenSP", TenSP)
                , new SqlParameter("@SoLgSP", SoLgSP)
                 , new SqlParameter("@DonVi", DonVi)

                );
        }
        public bool xoanhapxuat(ref string err, int n, string MaNhapXuat, string MaSP)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChitietNhapXuat_delete", CommandType.StoredProcedure
                , new SqlParameter("@nhaphang", n)
                , new SqlParameter("@MaNhapXuat", MaNhapXuat)
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
