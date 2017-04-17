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
    public partial class frm_baocao_nhapxuat : Form
    {
        public frm_baocao_nhapxuat()
        {
            InitializeComponent();
        }
        bool nhap = true;
        BLL_BaoCao bd = new BLL_BaoCao(cls_Main.path);
        DataTable dtnhap,dtxuat;
        private void btn_nhap_Click(object sender, EventArgs e)
        {
            nhap = true;
            dgv_nhap.Visible = true;
            dgvxuat.Visible = false;
            btn_nhap.BackColor=Color.OldLace;
            btn_Xuat.BackColor = Color.Transparent;
            dtnhap = new DataTable();
            dtnhap = bd.PSP_NhapKho_select_ngay(cls_Main.tungay, cls_Main.dengay);
            dgv_nhap.DataSource = dtnhap;
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            nhap = false;
            dgv_nhap.Visible = false;
            dgvxuat.Visible = true;
            btn_Xuat.BackColor = Color.OldLace;
            btn_nhap.BackColor = Color.Transparent;
            dtxuat = new DataTable();
            dtxuat = bd.PSP_XuatKho_select_ngay(cls_Main.tungay, cls_Main.dengay);
            dgvxuat.DataSource = dtxuat;
        }

        private void frm_baocao_nhapxuat_Load(object sender, EventArgs e)
        {
            dgv_nhap.Visible = false;
        }

        private void dgvxuat_DoubleClick(object sender, EventArgs e)
        {
            if (dgvxuat.Rows.Count > 0)
                {
                    cls_Main.one = 0;
                    cls_Main.Manhapxuat = dgvxuat.CurrentRow.Cells["colmaxuat"].Value.ToString();
                    frm_baocao_chitietNX frm = new frm_baocao_chitietNX();
                    frm.ShowDialog();
                }

        }

        private void dgv_nhap_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_nhap.Rows.Count > 0)
            {
                //{
                cls_Main.one = 1;
                cls_Main.Manhapxuat = dgv_nhap.CurrentRow.Cells["colmanhap"].Value.ToString();
                //MessageBox.Show(dgv_nhap.CurrentRow.Cells["colmanhap"].ToString());
                frm_baocao_chitietNX frm = new frm_baocao_chitietNX();
                frm.ShowDialog();
            }
            //}
           // MessageBox.Show("cc");
               
        }
    }
}
