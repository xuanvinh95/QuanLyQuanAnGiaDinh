using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Data;
using System.Data.SqlClient;

namespace BussLayer
{
    public class BLL_BanHang
    {
        DataBase data;
        public BLL_BanHang(string path)
        {
            data = new DataBase(path);
        }
        public bool TinhTien(ref string err, string MaHD)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_TinhTien", CommandType.StoredProcedure
                , new SqlParameter("@MaHD", MaHD)


                );
        }
        public bool upsoluongmon(ref string err, string MaHD,string MaMon,string so)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_HoaDOn_SoLuong_Update", CommandType.StoredProcedure
                , new SqlParameter("@MaHD", MaHD)
                , new SqlParameter("@MaMon", MaMon)
                , new SqlParameter("@Soluong", so)
                );
        }
        public bool XoaHoadon(ref string err, string MaHD)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_XoaHoaDon", CommandType.StoredProcedure
                , new SqlParameter("@MaHD", MaHD)


                );
        }
        public DataTable laybangHoaDon(string ban)
        {
            return data.FillTable("PSP_BangHoaDon", CommandType.StoredProcedure
                , new SqlParameter("@Ban", ban)
                );
        }
        public DataTable Laydanhsachmon(string loai)
        {
            return data.FillTable("PSP_BanHang_LayDanhSachMon", CommandType.StoredProcedure, new SqlParameter("@Loai", loai));
        }
        public DataTable Laydanhsachhangdangban(string mahd)
        {
            return data.FillTable("PSP_ChitietHoaDon_select", CommandType.StoredProcedure
                , new SqlParameter("@MaHD", mahd));
        }
        public bool LuuHoadon(ref string err, string MaHD,string MaNV, string MaMon)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_ChitietHoaDon", CommandType.StoredProcedure
                , new SqlParameter("@MaHD", MaHD)
                 , new SqlParameter("@MaNV", MaNV)
                , new SqlParameter("@MaMon", MaMon)

                );
        }
        public bool GiamMon(ref string err, string MaHD, string MaMon)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_GiamMon", CommandType.StoredProcedure
                , new SqlParameter("@MaHD", MaHD)
                , new SqlParameter("@MaMon", MaMon)
                );
        }

        public DataTable Laydulieukhachhang()
        {
            return data.FillTable("PSP_LayThongtinkhachhang", CommandType.StoredProcedure, null);
        }
        public bool Huy(ref string err, string mahd, string masp)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_HoaDon_Huy", CommandType.StoredProcedure, new SqlParameter("@mahd", mahd), new SqlParameter("@maSP", masp));
        }
        public DataTable inhoadon(string mahd)
        {
            return data.FillTable("PSP_hoadon_IN", CommandType.StoredProcedure, new SqlParameter("@mahd", mahd));
        }
        public bool capnhatdaban(string mahd)
        {
            return data.MyExcuteNonQuery("PSP_HoaDon_CapNhatDain", CommandType.StoredProcedure, new SqlParameter("@mahd", mahd));
        }

        public DataTable LayKhu(string khu)
        {
            return data.FillTable("PSP_LayKhu", CommandType.StoredProcedure
                , new SqlParameter("@Khu", khu));
        }
        public bool themban(ref string err, string ban)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_THemBan", CommandType.StoredProcedure
                , new SqlParameter("@Ban", ban)


                );
        }
        public bool xoaban(ref string err, string khu)
        {
            return data.MyExcuteNonQuery(ref err, "PSP_XoaBan", CommandType.StoredProcedure
                , new SqlParameter("@Khu", khu)


                );
        }
        public DataTable hoadonchuatinh()
        {
            return data.FillTable("PSP_HoaDonChuaTinh", CommandType.StoredProcedure, null);
        }

    }
}
