using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Data;
using System.Data.SqlClient;
namespace BussLayer
{
    public partial class BLL_BaoCao
    {
        DataBase data;
        public BLL_BaoCao(string path)
        {
            data = new DataBase(path);
        }
        public DataTable Laythongtinhoadon(DateTime tungay, DateTime denngay)
        {
            return data.FillTable("PSP_tungaydenngay", CommandType.StoredProcedure
                , new SqlParameter("@tungay", tungay)
                , new SqlParameter("@denngay", denngay)
                );
        }
         public DataTable sosanh(DateTime tungay, DateTime denngay)
        {
            return data.FillTable("PSP_Sosanh_BanXuat", CommandType.StoredProcedure
                , new SqlParameter("@tungay", tungay)
                , new SqlParameter("@denngay", denngay)
                );
        }
        public DataTable laybangnhapxuat(int n, string ma)
        {
            return data.FillTable("PSP_ChiTietNhapXuat_Select", CommandType.StoredProcedure
                 , new SqlParameter("@nhaphang", n)
                 , new SqlParameter("@MaNhapXuat", ma)
                );
        }
         public DataTable Laythongtinchitiethoadon(string mahd)
        {
            return data.FillTable("PSP_ChiTietbaocao", CommandType.StoredProcedure, new SqlParameter("@mahd", mahd));
        }
        public DataTable layuotluongnguyenlieu(DateTime tungay, DateTime denngay)
        {
            return data.FillTable("PSP_uotluongnguyenlieu", CommandType.StoredProcedure, new SqlParameter("@tungay", tungay), new SqlParameter("@denngay", denngay));
        }
        public DataTable GiaTbNguyenLieu(DateTime tungay, DateTime denngay)
        {
            return data.FillTable("PSP_GiaTbNguyenLieu", CommandType.StoredProcedure
                , new SqlParameter("@tungay", tungay)
                , new SqlParameter("@denngay", denngay)
                );
        }
        public DataTable TongTren1SP(DateTime tungay, DateTime denngay)
        {
            return data.FillTable("PSP_XuatKho_TongTren1SP_TheoNgay", CommandType.StoredProcedure
                , new SqlParameter("@tungay", tungay)
                , new SqlParameter("@denngay", denngay)
                );
        }
        public DataTable PSP_NhapKho_select_ngay(DateTime tungay, DateTime denngay)
        {
            return data.FillTable("PSP_NhapKho_select_ngay", CommandType.StoredProcedure
                , new SqlParameter("@tungay", tungay)
                , new SqlParameter("@denngay", denngay)
                );
        }
        public DataTable PSP_XuatKho_select_ngay(DateTime tungay, DateTime denngay)
        {
            return data.FillTable("PSP_XuatKho_select_ngay", CommandType.StoredProcedure
                , new SqlParameter("@tungay", tungay)
                , new SqlParameter("@denngay", denngay)
                );
        }

    }
}
