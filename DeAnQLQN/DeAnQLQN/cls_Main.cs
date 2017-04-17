using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DeAnQLQN
{
   public class cls_Main
    {
       public static string path = Application.StartupPath + @"\chuoiketnoi.ini";
       public static string TenNhanVien = "";
       public static string TaiKhoan = "";
       public static string MaNV = "";
       //Các thông tin của chuỗi kết nối.\
       public static string MaMon= "";
       public static string serverName="";
       public static string dataBaseName="";
       public static string userID="";
       public static string passWord="";

       public static string Manhapxuat = "";
       public static int one;

       public static DateTime tungay ;
       public static DateTime dengay ;
       public static void ghichuoichuoiketnoivaofileini(string path,string servername,string databasename,string userid,string pass)
       {
           try
           {
               if (File.Exists(path))
                   File.Delete(path);
               using(StreamWriter sw=new StreamWriter(path))
               {
                   sw.WriteLine("servername="+servername);
                   sw.WriteLine("databasename=" + databasename);           

                   sw.WriteLine("username=" + userid);
                   sw.WriteLine("password=" + pass);
               }
           }
           catch (Exception)
           {
               
               throw;
           }
       }


    }
}
