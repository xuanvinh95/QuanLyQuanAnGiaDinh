using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BussLayer;

namespace DeAnQLQN
{
    public partial class frm_banTiec : Form
    {
        public frm_banTiec()
        {
            InitializeComponent();
        }
        int index = 0;
        string masp = "";
        Double TongTien = 0;
        BLL_BanHang bd = new BLL_BanHang(cls_Main.path);
        DataTable dtdshang, dtdshangdangban,dtchuatinh;
        string MaNV, MaHD, MaMon;
        DateTime NgayLapHD;
        double dongiaban;
        string err = "";
        string mahd = "";
        bool clickdgv = false;
        bool chon = false;

        private void banlose()
        {
            cbo_khuA.Enabled = false;
            cbo_KhuB.Enabled = false;
            cbo_KhuC.Enabled = false;
        }
        private void banopen()
        {
            cbo_khuA.Enabled = true;
            cbo_KhuB.Enabled = true;
            cbo_KhuC.Enabled = true;
        }
        private void menuclose()
        {
            cbo_lau.Enabled = false; btn_tanglau.Enabled = false; btn_giamlau.Enabled = false;
            cbo_1.Enabled = false; btn_tang1.Enabled = false; btn_giam1.Enabled = false;
            cbo_2.Enabled = false; btn_tang2.Enabled = false; btn_giam2.Enabled = false;
            cbo_3.Enabled = false; btn_tang3.Enabled = false; btn_giam3.Enabled = false;
        }
        private void menuopen()
        {
            cbo_lau.Enabled = true; btn_tanglau.Enabled = true; btn_giamlau.Enabled = true;
            cbo_1.Enabled = true; btn_tang1.Enabled = true; btn_giam1.Enabled = true;
            cbo_2.Enabled = true; btn_tang2.Enabled = true; btn_giam2.Enabled = true;
            cbo_3.Enabled = true; btn_tang3.Enabled = true; btn_giam3.Enabled = true;
        }
        private void cbo_index_1()
        {
            cbo_lau.SelectedIndex = -1;
            cbo_1.SelectedIndex = -1;
            cbo_2.SelectedIndex = -1;
            cbo_3.SelectedIndex = -1;
        }
        private void doimau(string ma)
        {
            if (ma == "A") 
          
            {
                groupBox1.BackColor = Color.BlanchedAlmond;
                groupBox2.BackColor = Color.Transparent;
                groupBox3.BackColor = Color.Transparent;
                groupBox4.BackColor = Color.Transparent;
            }
            if (ma == "B") 
            {
                groupBox2.BackColor = Color.BlanchedAlmond;
                groupBox1.BackColor = Color.Transparent;
                groupBox3.BackColor = Color.Transparent;
                groupBox4.BackColor = Color.Transparent;
            }
            if (ma == "C") 
            {
                groupBox3.BackColor = Color.BlanchedAlmond;
                groupBox2.BackColor = Color.Transparent;
                groupBox1.BackColor = Color.Transparent;
                groupBox4.BackColor = Color.Transparent;
            }
            if (ma == "D")
            {
                groupBox4.BackColor = Color.BlanchedAlmond;
                groupBox2.BackColor = Color.Transparent;
                groupBox3.BackColor = Color.Transparent;
                groupBox1.BackColor = Color.Transparent;
            }
        }
        private string layloaimon(string ma)
        {
            return ma.Substring(0, 1);
        }
        private void taoMaHoaDon(string ban)
        {
                
                DataTable dt = new DataTable();
                dt = bd.laybangHoaDon(ban);
                if (dt.Rows.Count <= 0)
                    mahd = "001";
                else
                {

                    int i = dt.Rows.Count;
                                        //mahd = (Convert.ToInt16(dt.Rows[i - 1]["MaHD"])+1).ToString();
                    i= Convert.ToInt16(dt.Rows[i - 1]["MaHD"].ToString().Substring(3,3)) + 1;
                    //mahd = (Convert.ToInt16(mahd) + 1).ToString();
                    if (i < 10)
                        mahd = "00";
                    else
                        if (i < 100)
                            mahd = "0";
                        else mahd = "";
                    mahd = mahd+i.ToString();
                }
                mahd = ban+mahd;
                lbl_MaHD.Text ="Mã HD: " +mahd;
            

        }
        private void Menumon()
        {
            DataTable dtc = new DataTable();
            dtc = bd.Laydanhsachmon("A");

            cbo_lau.DataSource = dtc;
            cbo_lau.ValueMember = "MaMon";
            cbo_lau.DisplayMember = "TenMon";

            DataTable dt1 = new DataTable();
            dt1 = bd.Laydanhsachmon("B");
            cbo_1.DataSource = dt1;
            cbo_1.ValueMember = "MaMon";
            cbo_1.DisplayMember = "TenMon";

            DataTable dt2 = new DataTable();
            dt2 = bd.Laydanhsachmon("C");
            cbo_2.DataSource = dt2;
            cbo_2.ValueMember = "MaMon";
            cbo_2.DisplayMember = "TenMon";

            DataTable dt3 = new DataTable();
            dt3 = bd.Laydanhsachmon("D");
            cbo_3.DataSource = dt3;
            cbo_3.ValueMember = "MaMon";
            cbo_3.DisplayMember = "TenMon";
            
        }
        private void xoaHoaDon()
        {
            bd.XoaHoadon(ref err, mahd);
            index = 0;
        }
        private void laydulieuhangdangban(string mahd)
        {
            TongTien=0;
            dtdshangdangban = new DataTable();
            dtdshangdangban = bd.Laydanhsachhangdangban(mahd);
            dgvdshangdangban.DataSource = dtdshangdangban;
            //dgvdshangdangban.r
            //for(int i =0;i<dgvdshangdangban.Rows.Count;i++)
            //{
            //    if (dtdshangdangban.Rows[i]["MaMon"].ToString() == comboBox1.SelectedValue.ToString())
            //        index = Convert.ToInt16(dtdshangdangban.Rows[i]["STT"]) - 1;
            //}
            for (int i = 0; i < dtdshangdangban.Rows.Count; i++)
                TongTien += Convert.ToDouble(dtdshangdangban.Rows[i]["ThanhGia"].ToString());
            lbl_Thanhtien.Text = "Thành Tiền: "+String.Format("{0:0,0 vnđ}",TongTien);
            if (index == dtdshangdangban.Rows.Count) index--;
            if (dtdshangdangban.Rows.Count > 1)
            {
                dgvdshangdangban.Rows[0].Selected = false;
                dgvdshangdangban.Rows[index].Selected = true;
            }

        }
        private void laykhu()
        {
            DataTable dta = new DataTable();
            dta = bd.LayKhu("A");

            cbo_khuA.DataSource = dta;
            cbo_khuA.ValueMember = "Khu";
            cbo_khuA.DisplayMember = "Khu";

            DataTable dtb= new DataTable();
            dtb = bd.LayKhu("B");

            cbo_KhuB.DataSource = dtb;
            cbo_KhuB.ValueMember = "Khu";
            cbo_KhuB.DisplayMember = "Khu";
            DataTable dtc = new DataTable();
            dtc = bd.LayKhu("C");

            cbo_KhuC.DataSource = dtc;
            cbo_KhuC.ValueMember = "Khu";
            cbo_KhuC.DisplayMember = "Khu";

            cbo_khuA.SelectedIndex = -1;
            cbo_KhuB.SelectedIndex = -1;
            cbo_KhuC.SelectedIndex = -1;

        }
        private void layhoadonchuatinhtien()
        {
            DataTable dt = new DataTable();
            dt =bd.hoadonchuatinh();
            dgv_chuatinh.DataSource = dt;
        }
        private void frm_banTiec_Load(object sender, EventArgs e)
        {
            //taoMaHoaDon();
            //comboBox1.SelectedIndex = -1;
            Menumon();
            cbo_index_1();     
            laydulieuhangdangban(mahd);
            lbl_MaHD.Text += mahd;
            //laydulieuhangdangban("2");
            lbl_Time.Text += DateTime.Now.ToShortDateString();
            //comboBox1.Text = "Chọn khách hàng";
            laykhu();
                  
            xoaHoaDon();
            lbl_MaHD.Text = "Mã HD: ";
            dgvdshangdangban.Visible = false;
            menuclose();
            layhoadonchuatinhtien();
            btn_chon.Enabled = true;
            btn_ref.Enabled = false;
            lbl_khu.Text = "Khu: " ;
            lbl_ban.Text = "Bàn: " ;
            txt_soluong.Enabled = false;
            btn_oksoluong.Enabled = false;
            if (cls_Main.MaNV.Substring(0, 2) != "AD")
            {
                btnThem.Enabled = false;
                btn_xoa.Enabled = false;
            }
        }

        private void cbo_indexchanged()
        {
            if (MaHD.Length == 6)
            {
                if (bd.LuuHoadon(ref err, MaHD,cls_Main.MaNV, MaMon))
                {

                    DataTable dt = new DataTable();
                    dt = bd.Laydanhsachhangdangban(mahd);
                    for (int i = 0; i < dt.Rows.Count; i++)
                        if (dt.Rows[i]["MaMon"].ToString() == MaMon)
                            index = Convert.ToInt16(dt.Rows[i]["STT"]) - 1;

                    laydulieuhangdangban(MaHD);



                }
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (clickdgv == false)
            {
                if (cbo_lau.SelectedIndex > -1)
                {
                    
                    ////MaNV = cls_Main.MaNV;
                    MaHD = mahd;
                    MaMon = cbo_lau.SelectedValue.ToString();
                    doimau(layloaimon(MaMon));
                    cbo_indexchanged();
                }
            }
           
        }

       

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            xoaHoaDon();
            laydulieuhangdangban(mahd);
            cbo_khuA.SelectedIndex = -1;
            cbo_KhuB.SelectedIndex = -1;
            cbo_KhuC.SelectedIndex = -1;
            mahd = "";
            lbl_MaHD.Text = "Mã HD: " + mahd;
            banopen();
            dgvdshangdangban.Visible = false;
            menuclose();
            btn_chon.Enabled = true;
            //btn_xoachuatinh.Enabled = true;
            btn_ref.Enabled = false;
            index = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            bd.TinhTien(ref err, mahd);
            //taoMaHoaDon();
            reportprinthoadon inhd = new reportprinthoadon(mahd);
            inhd.ShowDialog();
            cbo_khuA.SelectedIndex = -1;
            cbo_KhuB.SelectedIndex = -1;
            cbo_KhuC.SelectedIndex = -1;
            mahd = "";
            lbl_MaHD.Text = "Mã HD: ";
            banopen();
            dgvdshangdangban.Visible = false;
            menuclose();
            laydulieuhangdangban(mahd);
            btn_lammoi.Enabled = true;

            btn_chon.Enabled = true;
            layhoadonchuatinhtien();
            banlose();
           
            
        }

        private void btn_tang_Click(object sender, EventArgs e)
        {
            if (cbo_lau.SelectedIndex > -1)
            {
                //index = comboBox1.SelectedIndex;
                ////MaNV = cls_Main.MaNV;
                MaHD = mahd;
                MaMon = cbo_lau.SelectedValue.ToString();
                if (bd.LuuHoadon(ref err, MaHD,cls_Main.MaNV, MaMon))
                laydulieuhangdangban(MaHD);
                
            }
        }
       
        private void btn_giam_Click(object sender, EventArgs e)
        {
            if (cbo_lau.SelectedIndex > -1)
            {
                //index = comboBox1.SelectedIndex;
                //MessageBox.Show(dtchuatinh.Rows[index]["SoLuong"].ToString());
                //MaNV = cls_Main.MaNV;
                MaHD = mahd;
                MaMon = cbo_lau.SelectedValue.ToString();
                if (bd.GiamMon(ref err, MaHD, MaMon))
                        laydulieuhangdangban(MaHD);
            }
        }
        bool themban=true;
        private string laymaKhu(string ban)
        {
            DataTable dt = new DataTable();
            dt = bd.LayKhu(ban);
            string ma;
            if (dt.Rows.Count <= 0)
                ma = "01";
            else
            {

                int i = dt.Rows.Count;
                //mahd = (Convert.ToInt16(dt.Rows[i - 1]["MaHD"])+1).ToString();
                i = Convert.ToInt16(dt.Rows[i - 1]["Khu"].ToString().Substring(1,2)) + 1;
                //mahd = (Convert.ToInt16(mahd) + 1).ToString();
                if (i < 10)
                    ma= "0";
                else
                     ma= "";
                ma = ma + i.ToString();
            }
            ma = ban + ma;
            return ma;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btn_khua.Visible = true;
            btn_khub.Visible = true;
            btn_khuc.Visible = true;
            btn_xoa.Enabled = false;
            themban = true;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_khua.Visible = true;
            btn_khub.Visible = true;
            btn_khuc.Visible = true;
            btnThem.Enabled = false;
            themban = false;
        }

        private void btn_khua_Click(object sender, EventArgs e)
        {
            clickdgv = true;
            btn_xoa.Enabled = true;
            btnThem.Enabled = true;
            btn_khua.Visible = false;
            btn_khub.Visible = false;
            btn_khuc.Visible = false;
            if (themban)
            {
                bd.themban(ref err, laymaKhu("A"));
                MessageBox.Show("Đã thêm Bàn Khu A\nClick Làm Mới Để Xem");
            }
            else
            {
                bd.xoaban(ref err, "A");
                MessageBox.Show("Đã Xóa Bàn Khu A\nClick Làm Mới Để Xem");
            }
            laykhu();
            mahd = ""; lbl_MaHD.Text = "Mã HD: ";
            clickdgv = false;
        }
       

        private void btn_khub_Click(object sender, EventArgs e)
        {
            clickdgv = true;
            btn_xoa.Enabled = true;
            btnThem.Enabled = true;
            btn_khua.Visible = false;
            btn_khub.Visible = false;
            btn_khuc.Visible = false;
            if (themban)
            {
                bd.themban(ref err, laymaKhu("B"));
                MessageBox.Show("Đã thêm Bàn Khu B\nClick Làm Mới Để Xem");
            }
            else
            {
                bd.xoaban(ref err, "B");
                MessageBox.Show("Đã Xóa Bàn Khu B\nClick Làm Mới Để Xem");
            }
            laykhu();
            mahd = ""; lbl_MaHD.Text = "Mã HD: ";
            clickdgv = false;
        }

        private void btn_khuc_Click(object sender, EventArgs e)
        {
            clickdgv = true;
            btn_xoa.Enabled = true;
            btnThem.Enabled = true;
            btn_khua.Visible = false;
            btn_khub.Visible = false;
            btn_khuc.Visible = false;
            if (themban)
            {
                bd.themban(ref err, laymaKhu("C"));
                MessageBox.Show("Đã thêm Bàn Khu C \nClick Làm Mới Để Xem");
            }
            else
            {
                bd.xoaban(ref err, "C");
                MessageBox.Show("Đã Xóa Bàn Khu C\nClick Làm Mới Để Xem");
            }
            laykhu();
            mahd = ""; lbl_MaHD.Text = "Mã HD: ";
            clickdgv = false;
        }

             

        private void cbo_khuA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(clickdgv==false)
                if (cbo_khuA.SelectedIndex > -1)
                {
                    int id = cbo_khuA.SelectedIndex;
                    cbo_KhuB.SelectedIndex = -1;
                    cbo_KhuC.SelectedIndex = -1;
                    cbo_khuA.SelectedIndex = id;
                    //mahd = cbo_khuA.SelectedItem.ToString() ;
                    taoMaHoaDon(cbo_khuA.SelectedValue.ToString());
                    if (chon)
                    {
                        for (int i = 0; i < dtchuatinh.Rows.Count; i++)
                            for (int j = 0; j < Convert.ToInt16(dtchuatinh.Rows[i]["SoLuong"].ToString()); j++)
                                bd.LuuHoadon(ref err, mahd, cls_Main.MaNV, dtchuatinh.Rows[i]["MaMon"].ToString());
                        laydulieuhangdangban(mahd);
                    }
                    //lbl_MaHD.Text = cbo_khuA.SelectedValue.ToString();
                    banlose();
                    dgvdshangdangban.Visible = true;
                    menuopen();
                    cbo_index_1(); 
                    btn_chon.Enabled = false;
                    //btn_xoachuatinh.Enabled = false;
                    lbl_khu.Text = "Khu: " + mahd.Substring(0, 1);
                    lbl_ban.Text = "Bàn: " + mahd.Substring(0, 3);
                }
        }

        private void cbo_KhuB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickdgv == false)
            if (cbo_KhuB.SelectedIndex > -1)
            {
                int id = cbo_KhuB.SelectedIndex;
                cbo_khuA.SelectedIndex = -1;
                cbo_KhuC.SelectedIndex = -1;
                cbo_KhuB.SelectedIndex = id;
                //mahd = cbo_KhuB.SelectedItem.ToString();
                taoMaHoaDon(cbo_KhuB.SelectedValue.ToString());
                if (chon)
                {
                    for (int i = 0; i < dtchuatinh.Rows.Count; i++)
                        for (int j = 0; j < Convert.ToInt16(dtchuatinh.Rows[i]["SoLuong"].ToString()); j++)
                            bd.LuuHoadon(ref err, mahd, cls_Main.MaNV, dtchuatinh.Rows[i]["MaMon"].ToString());
                    laydulieuhangdangban(mahd);
                }
                //lbl_MaHD.Text = cbo_KhuB.SelectedValue.ToString();
                banlose();
                dgvdshangdangban.Visible = true;
                menuopen();
                cbo_index_1();
                btn_chon.Enabled = false;
                //btn_xoachuatinh.Enabled = false;
                lbl_khu.Text = "Khu: " + mahd.Substring(0, 1);
                lbl_ban.Text = "Bàn: " + mahd.Substring(0, 3);
            }
        }

        private void cbo_KhuC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickdgv == false)
            if (cbo_KhuC.SelectedIndex > -1)
            {
                int id = cbo_KhuC.SelectedIndex;
                cbo_khuA.SelectedIndex = -1;
                cbo_KhuB.SelectedIndex = -1;
                cbo_KhuC.SelectedIndex = id;
                //mahd = cbo_KhuC.SelectedItem.ToString();
                taoMaHoaDon(cbo_KhuC.SelectedValue.ToString());
                if (chon)
                {
                    for (int i = 0; i < dtchuatinh.Rows.Count; i++)
                        for (int j = 0; j < Convert.ToInt16(dtchuatinh.Rows[i]["SoLuong"].ToString()); j++)
                            bd.LuuHoadon(ref err, mahd, cls_Main.MaNV, dtchuatinh.Rows[i]["MaMon"].ToString());
                    laydulieuhangdangban(mahd);
                }
                //lbl_MaHD.Text = cbo_KhuC.SelectedValue.ToString();
                banlose();
                dgvdshangdangban.Visible = true;
                menuopen();
                cbo_index_1();
                btn_chon.Enabled = false;
                //btn_xoachuatinh.Enabled = false;
                lbl_khu.Text = "Khu: " + mahd.Substring(0, 1);
                lbl_ban.Text = "Bàn: " + mahd.Substring(0, 3);
            }
        }

        private void btn_tinhsau_Click(object sender, EventArgs e)
        {
            cbo_khuA.SelectedIndex = -1;
            cbo_KhuB.SelectedIndex = -1;
            cbo_KhuC.SelectedIndex = -1;
            mahd = "";
            lbl_MaHD.Text = "Mã HD: " + mahd;
            banlose();
            dgvdshangdangban.Visible = false;
            menuclose();
            layhoadonchuatinhtien();
            btn_lammoi.Enabled = true;
            //btn_xoachuatinh.Enabled = false;
            btn_chon.Enabled = true;
            chon = false;
            btn_ref.Enabled = false;
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            
            if (dgv_chuatinh.Rows.Count > 0)
            {
                mahd = dgv_chuatinh.CurrentRow.Cells["col_mahd"].Value.ToString();
                dtchuatinh = new DataTable();
                dtchuatinh = bd.Laydanhsachhangdangban(mahd);

                cbo_index_1();
                laydulieuhangdangban(mahd);
                dgvdshangdangban.Visible = true;
                lbl_MaHD.Text = "Mã HD: " + mahd;
                menuopen();
                btn_lammoi.Enabled = false;
                //btn_xoachuatinh.Enabled = true;
                btn_chon.Enabled = false;
                banlose();
                chon = true;
                btn_ref.Enabled = true;
                lbl_khu.Text = "Khu: " + mahd.Substring(0, 1);
                lbl_ban.Text = "Bàn: " + mahd.Substring(0,3);
                if(dgv_chuatinh.Rows.Count>0)btn_chuyenban.Enabled = true;
            }
        }

        private void dgvdshangdangban_Click(object sender, EventArgs e)
        {
            clickdgv = true;
            string str = dgvdshangdangban.CurrentRow.Cells["colmamon"].Value.ToString();
            int idex = 0;
            DataTable dt = new DataTable();

            dt = bd.Laydanhsachmon(layloaimon(str));
            doimau(layloaimon(str));
            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["MaMon"].ToString() == str)
                    idex = Convert.ToInt16(dt.Rows[i]["STT"]) - 1;
            if (layloaimon(str) == "A") cbo_lau.SelectedIndex = idex;
            if (layloaimon(str) == "B") cbo_1.SelectedIndex = idex;
            if (layloaimon(str) == "C") cbo_2.SelectedIndex = idex;
            if (layloaimon(str) == "D") cbo_3.SelectedIndex = idex;
            dt = new DataTable();
            dt = bd.Laydanhsachhangdangban(mahd);
            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["MaMon"].ToString() == str)
                    index = Convert.ToInt16(dt.Rows[i]["STT"]) - 1;
            txt_soluong.Enabled = true;
            btn_oksoluong.Enabled = true;
            txt_soluong.Text = dgvdshangdangban.Rows[index].Cells["colsoluong"].Value.ToString();
            clickdgv = false;
        }

        //private void btn_xoachuatinh_Click(object sender, EventArgs e)
        //{
        //    btn_lammoi.Enabled = true;
        //    xoaHoaDon();
        //    laydulieuhangdangban(mahd);
        //    cbo_khuA.SelectedIndex = -1;
        //    cbo_KhuB.SelectedIndex = -1;
        //    cbo_KhuC.SelectedIndex = -1;
        //    mahd = "";
        //    lbl_MaHD.Text = "Mã HD: " + mahd;
        //    layhoadonchuatinhtien();
        //    btn_xoachuatinh.Enabled = false;
        //    btn_chon.Enabled = true;
        //}

        private void frm_banTiec_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if(!chon)
            //    xoaHoaDon();
        }

        private void btn_giam2_Click(object sender, EventArgs e)
        {
            if (cbo_2.SelectedIndex > -1)
            {
                //index = comboBox1.SelectedIndex;
                //MessageBox.Show(dtchuatinh.Rows[index]["SoLuong"].ToString());
                ////MaNV = cls_Main.MaNV;
                MaHD = mahd;
                MaMon = cbo_2.SelectedValue.ToString();
                if (bd.GiamMon(ref err, MaHD, MaMon))
                    laydulieuhangdangban(MaHD);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xoaHoaDon();
             
            for (int i = 0; i < dtchuatinh.Rows.Count; i++)
                for (int j = 0; j < Convert.ToInt16(dtchuatinh.Rows[i]["SoLuong"].ToString()); j++)
                bd.LuuHoadon(ref err, dtchuatinh.Rows[i]["MaHD"].ToString(),cls_Main.MaNV, dtchuatinh.Rows[i]["MaMon"].ToString());
            laydulieuhangdangban(mahd);
            
        }

        private void cbo_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickdgv == false)
            {
                if (cbo_1.SelectedIndex > -1)
                {
                    //MaNV = cls_Main.MaNV;
                    MaHD = mahd;
                    MaMon = cbo_1.SelectedValue.ToString();
                    doimau(layloaimon(MaMon));
                    cbo_indexchanged();
                }
            }
        }

        private void cbo_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickdgv == false)
            {
                if (cbo_2.SelectedIndex > -1)
                {
                    //MaNV = cls_Main.MaNV;
                    MaHD = mahd;
                    MaMon = cbo_2.SelectedValue.ToString();
                    doimau(layloaimon(MaMon));
                    cbo_indexchanged();
                }
            }
        }

        private void cbo_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clickdgv == false)
            {
                if (cbo_3.SelectedIndex > -1)
                {
                    //MaNV = cls_Main.MaNV;
                    MaHD = mahd;
                    MaMon = cbo_3.SelectedValue.ToString();
                    doimau(layloaimon(MaMon));
                    cbo_indexchanged();
                }
            }
        }

        private void btn_tang1_Click(object sender, EventArgs e)
        {
            if (cbo_1.SelectedIndex > -1)
            {
                //index = comboBox1.SelectedIndex;
                //MaNV = cls_Main.MaNV;
                MaHD = mahd;
                MaMon = cbo_1.SelectedValue.ToString();
                if (bd.LuuHoadon(ref err, MaHD, cls_Main.MaNV, MaMon))
                    laydulieuhangdangban(MaHD);

            }
        }

        private void btn_tang2_Click(object sender, EventArgs e)
        {
            if (cbo_2.SelectedIndex > -1)
            {
                //index = comboBox1.SelectedIndex;
                //MaNV = cls_Main.MaNV;
                MaHD = mahd;
                MaMon = cbo_2.SelectedValue.ToString();
                if (bd.LuuHoadon(ref err, MaHD, cls_Main.MaNV, MaMon))
                    laydulieuhangdangban(MaHD);

            }
        }

        private void btn_tang3_Click(object sender, EventArgs e)
        {
            if (cbo_3.SelectedIndex > -1)
            {
                //index = comboBox1.SelectedIndex;
                //MaNV = cls_Main.MaNV;
                MaHD = mahd;
                MaMon = cbo_3.SelectedValue.ToString();
                if (bd.LuuHoadon(ref err, MaHD, cls_Main.MaNV, MaMon))
                    laydulieuhangdangban(MaHD);

            }
        }

        private void btn_giam1_Click(object sender, EventArgs e)
        {
            if (cbo_1.SelectedIndex > -1)
            {
                //index = comboBox1.SelectedIndex;
                //MessageBox.Show(dtchuatinh.Rows[index]["SoLuong"].ToString());
                //MaNV = cls_Main.MaNV;
                MaHD = mahd;
                MaMon = cbo_1.SelectedValue.ToString();
                if (bd.GiamMon(ref err, MaHD, MaMon))
                    laydulieuhangdangban(MaHD);
            }
        }

        private void btn_giam3_Click(object sender, EventArgs e)
        {
            if (cbo_3.SelectedIndex > -1)
            {
                //index = comboBox1.SelectedIndex;
                //MessageBox.Show(dtchuatinh.Rows[index]["SoLuong"].ToString());
                //MaNV = cls_Main.MaNV;
                MaHD = mahd;
                MaMon = cbo_3.SelectedValue.ToString();
                if (bd.GiamMon(ref err, MaHD, MaMon))
                    laydulieuhangdangban(MaHD);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MaHD_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_oksoluong_Click(object sender, EventArgs e)
        {
            txt_soluong.Enabled = false;
            btn_oksoluong.Enabled = false;
            
            if(!String.IsNullOrEmpty(txt_soluong.Text))
            bd.upsoluongmon(ref err
                ,mahd,dgvdshangdangban.Rows[index].Cells["colmamon"].Value.ToString()
                ,txt_soluong.Text);
            //MessageBox.Show(mahd+" "+dgvdshangdangban.Rows[index].Cells["colmamon"].Value.ToString()+" "+txt_soluong.Text);
            laydulieuhangdangban(mahd);
            
        }

        private void txt_soluong_Click(object sender, EventArgs e)
        {
            txt_soluong.Text = "";
        }

        private void btn_chuyenban_Click(object sender, EventArgs e)
        {
            btn_chuyenban.Enabled = false;
            cbo_khuA.Enabled = true;
            cbo_KhuB.Enabled = true;
            cbo_KhuC.Enabled = true;
            xoaHoaDon();
        }

       
       

      

      
       

        

        
       

       

       

        

       

        

       

        

      
    }
}
