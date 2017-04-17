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
    public partial class frm_baocaochitiet : Form
    {
        string mahd="";
        BLL_BaoCao bd = new BLL_BaoCao(cls_Main.path);
        DataTable dtchitiethoadon;
        public DataGridView dgv_baocao;
        public frm_baocaochitiet()
        {
            InitializeComponent();
        }

        public frm_baocaochitiet(DataGridView dgv_baocao)
        {
            // TODO: Complete member initialization
            this.dgv_baocao = dgv_baocao;
        }
       
      
        private void laydulieuchitiethoadon(string mahd)
        {
            dtchitiethoadon=new DataTable();
            dtchitiethoadon=bd.Laythongtinchitiethoadon(mahd);
            dgv_chitiethoidon.DataSource=dtchitiethoadon;
            
        }

        private void frm_baocaochitiet_Load(object sender, EventArgs e)
        {
            double tongtien=0;
            if (dgv_baocao.Rows.Count > 0)
            {
                mahd = dgv_baocao.CurrentRow.Cells["colmahd"].Value.ToString();
                laydulieuchitiethoadon(mahd);
            }
            for(int i=0;i<dgv_chitiethoidon.Rows.Count;i++)
            {
                tongtien += Convert.ToDouble(dtchitiethoadon.Rows[i]["ThanhTien"].ToString());
            }
            lbltongtien.Text = string.Format("{0:#,###0 vnđ}", tongtien);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
