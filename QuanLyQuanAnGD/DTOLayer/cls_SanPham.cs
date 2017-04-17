using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOLayer
{
    public class cls_SanPham
    {
        private string maMon;

        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
        }
        private String tenMon;

        public String TenMon
        {
            get { return tenMon; }
            set { tenMon = value; }
        }
        private float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
    }
}
