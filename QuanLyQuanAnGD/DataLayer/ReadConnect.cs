using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DataLayer
{
    /// <summary>
    /// Class trả về một chuỗi kết nối được đọc từ file.(*.ini, App.Config)
    /// </summary>
    public class ReadConnect
    {
        //field
        private string connectionString = "";

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        private bool winNT = true;

        public bool WinNT
        {
            get { return winNT; }
            set { winNT = value; }
        }
        private string iniFile = "";
        private string serverName = "";

        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        private string databaseName = "";

        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }
        private string userName = "";

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string instantName = "";
        private string passWord = "";

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private string connectionTimeout = "";
        private string portNo = "";
        //contructor
        public ReadConnect()
        {
            //khong lam gia ca
        }
        public ReadConnect(string serverName, string databaseName, string userName, string passWord)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.userName = userName;
            this.passWord = passWord;

        }
        public ReadConnect(ref string err, string iniFile)
        {
            this.iniFile = iniFile;
            docchuoiketnoitufileini(ref err, iniFile);
        }
        //method
        /// <summary>
        /// Hàm dùng để nối các thuộc tính trong chuỗi kết nối thành một chuỗi kết nối hoàn chỉnh
        /// </summary>
        /// <returns>Một chuỗi kết nối hoàn chỉnh với đầy dủ các thuộc tính</returns>
        private string TaoChuoiKetNoi()
        {
            string connstring = "";
            if (!instantName.Equals(""))
                serverName += @"\" + instantName;
            if (winNT)
                connstring = "Server=" + serverName + "; Database=" + databaseName + "; Integrated Security=true";
            else
                connstring = "Server=" + serverName + "; Database=" + databaseName + "; uid=" + userName + "; pwd=" + passWord;
            if (!portNo.Equals(""))
                connstring += " ;portNo=" + portNo;
            if (!connectionTimeout.Equals(""))
                connstring += " ;ConnectionTimeout=" + connectionTimeout;

            return connstring;
        }
        /// <summary>
        /// đọc dữ liệu từ file ini
        /// </summary>
        /// <param name="path">đường dẫn của file ini</param>
        public void docchuoiketnoitufileini(ref string err, string path)
        {
            try
            {
                using (StreamReader _reader = new StreamReader(path))
                {
                    string line = "";
                    while ((line = _reader.ReadLine()) != null)
                    {
                        switch (line.Substring(0, line.IndexOf('=')).ToLower())
                        {
                            case "servername":
                                serverName = line.Substring(line.IndexOf('=') + 1);
                                break;
                            case "databasename":
                                databaseName = line.Substring(line.IndexOf('=') + 1);
                                break;
                            case "username":
                                userName = line.Substring(line.IndexOf('=') + 1);
                                break;
                            case "password":
                                passWord = line.Substring(line.IndexOf('=') + 1);
                                break;
                            case "portno"://1433
                                portNo = line.Substring(line.IndexOf('=') + 1);
                                break;
                            case "connectiontimeout"://30
                                connectionTimeout = line.Substring(line.IndexOf('=') + 1);
                                break;
                        }
                    }
                    connectionString = TaoChuoiKetNoi();
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
        }
        public void ghichuoiketnoivaofileini(ref string err, string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    using (StreamWriter sw = new StreamWriter(path, true, Encoding.Unicode))
                    {
                        sw.WriteLine("serverName=" + serverName);
                        sw.WriteLine("databaseName=" + databaseName);
                        sw.WriteLine("userName=" + userName);
                        sw.WriteLine("passWord=" + passWord);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(path, true, Encoding.Unicode))
                    {
                        sw.WriteLine("serverName=" + serverName);
                        sw.WriteLine("databaseName=" + databaseName);
                        sw.WriteLine("userName=" + userName);
                        sw.WriteLine("passWord=" + passWord);
                    }
                }

            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
        }

    }
}
