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
    public partial class frm_baocao_chitietNX : Form
    {
        public frm_baocao_chitietNX()
        {
            InitializeComponent();
        }
        BLL_BaoCao bd = new BLL_BaoCao(cls_Main.path);
        private void frm_baocao_chitietNX_Load(object sender, EventArgs e)
        {
            //label1.Text = cls_Main.one.ToString() + " " + cls_Main.Manhapxuat;
            if (cls_Main.one == 0)
            {
                col_giadv.Visible = false;
                col_thanhgia.Visible = false;
            }
            dgv_nhapxuat.DataSource = bd.laybangnhapxuat(cls_Main.one, cls_Main.Manhapxuat);
        }
    }
}
