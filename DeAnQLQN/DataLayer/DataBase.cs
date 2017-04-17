using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DataBase
    {
        ReadConnect rc = new ReadConnect();
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter da;
        int a;

        public string err = "";
        /// <summary>
        /// Hàm tạo không lấy thuộc tính chuỗi kết nối
        /// </summary>
        /// <param name="path">đường dẫn file kết nối</param>
        public DataBase(string path)
        {
            cnn = new SqlConnection();
            rc.docchuoiketnoitufileini(ref err, path);
            cnn.ConnectionString = rc.ConnectionString;

        }
        /// <summary>
        /// Hàm tạo cho phép lấy thuộc tính chuỗi kết nối
        /// </summary>
        /// <param name="path">đường dẫn file kết nối</param>
        /// <param name="servername">Tên server</param>
        /// <param name="databasename">Tên database</param>
        /// <param name="userid">tài khoản</param>
        /// <param name="password">mật khẩu</param>
        public DataBase(string path, ref string servername, ref string databasename, ref string userid, ref string password)
        {
            cnn = new SqlConnection();
            rc.docchuoiketnoitufileini(ref err, path);
            cnn.ConnectionString = rc.ConnectionString;
            servername = rc.ServerName;
            databasename = rc.DatabaseName;
            userid = rc.UserName;
            password = rc.PassWord;

        }
        public bool kiemtraketnoi()
        {
            try
            {
                cnn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }

        public SqlDataReader MyExcuteReader(ref string err, string sql, CommandType ct, params SqlParameter[] param)
        {
            try
            {
                SqlDataReader _reader;//không khởi tạo
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 300;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                _reader = cmd.ExecuteReader();
                return _reader;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }


        }

        public bool MyExcuteNonQuery(ref string err, string sql, CommandType ct, params SqlParameter[] param)
        {
            bool ketqua = false;
            try
            {

                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 300;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.ExecuteNonQuery();
                ketqua = true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return ketqua;
        }
        public bool MyExcuteNonQuery(string sql, CommandType ct, params SqlParameter[] param)
        {
            bool ketqua = false;
            try
            {

                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 300;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.ExecuteNonQuery();
                ketqua = true;
            }
            catch (Exception)
            {
            }
            finally
            {
                cnn.Close();
            }
            return ketqua;
        }
        public object MyExcuteScalar(ref string err, string sql, CommandType ct, params SqlParameter[] param)
        {
            object ketqua = null;
            try
            {

                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 300;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                ketqua = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                err = ex.Message;

            }
            finally
            {
                cnn.Close();
            }
            return ketqua;
        }

        public DataTable FillTable(string sql, CommandType ct, params SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            try
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 300;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (SqlParameter item in param)
                        cmd.Parameters.Add(item);
                }
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex) { err = ex.Message; }
            finally { cnn.Close(); }
            return dt;
        }
        public DataSet FillDataSet(string sql, CommandType ct, params SqlParameter[] param)
        {
            DataSet ds = new DataSet();
            try
            {

                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = ct;
                cmd.CommandTimeout = 300;
                cmd.Parameters.Clear();
                if (param != null)
                {
                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                err = ex.Message;

            }
            finally
            {
                cnn.Close();
            }
            return ds;
        }
    }
}
