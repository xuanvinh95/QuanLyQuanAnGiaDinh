using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using System.Data;
using DTOLayer;
using System.Data.SqlClient;


namespace BussLayer
{
    public class BLL_ThucDon
    {
         DataBase data;
         public BLL_ThucDon(string path)
         {
          data=new DataBase(path);
         }
         public DataTable LaySanPham(string loai)
         {
             return data.FillTable("PSP_ThucDon_Select", CommandType.StoredProcedure, new SqlParameter("@MaPL",loai));
         }
         public DataTable xoathucdon(string mamon)
         {
             return data.FillTable("PSP_ThucDon_Delete", CommandType.StoredProcedure, new SqlParameter("@MaMon", mamon));
         }
         public bool capnhathucdon(cls_SanPham _thucdon)
         {
             return data.MyExcuteNonQuery("PSP_ThucDon_CapNhat", CommandType.StoredProcedure
                ,new SqlParameter("@MaMon",_thucdon.MaMon)
                 , new SqlParameter("@TenMon", _thucdon.TenMon)
                 ,new SqlParameter("@DonGia",_thucdon.DonGia));

         }

    }
}
