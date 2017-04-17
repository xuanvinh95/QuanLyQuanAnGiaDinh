using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeAnQLQN
{
    public partial class frm_quanLy : Form
    {
        public frm_quanLy()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Form1 frm = new Form1();
            frm.Text = "Child Form";
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frm_quanLy_Load(object sender, EventArgs e)
        {
            if (cls_Main.MaNV.Substring(0, 2) != "AD")
            {
                button2.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void xButton4_Click(object sender, EventArgs e)
        {

            frm_banTiec frm = new frm_banTiec();
            frm.Text = "Child Form";
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void xButton2_Click(object sender, EventArgs e)
        {
            frm_ThucDon frtd = new frm_ThucDon();
            frtd.Text = "Child Form";
            frtd.MdiParent = this;
            frtd.Dock = DockStyle.Fill;
            frtd.Show();
        }

        private void xButton3_Click(object sender, EventArgs e)
        {
            frm_nhanvien frtd = new frm_nhanvien();
            frtd.Text = "Child Form";
            frtd.MdiParent = this;
            frtd.Dock = DockStyle.Fill;
            frtd.Show();
        }

        private void xButton1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_banTiec frm = new frm_banTiec();
            frm.Text = "Child Form";
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frm_nhanvien frtd = new frm_nhanvien();
            frtd.Text = "Child Form";
            frtd.MdiParent = this;
            frtd.Dock = DockStyle.Fill;
            frtd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ThucDon frtd = new frm_ThucDon();
            frtd.Text = "Child Form";
            frtd.MdiParent = this;
            frtd.Dock = DockStyle.Fill;
            frtd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_kho frtd = new frm_kho();
            frtd.Text = "Child Form";
            frtd.MdiParent = this;
            frtd.Dock = DockStyle.Fill;
            frtd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_baocao frtd = new frm_baocao();
            frtd.Text = "Child Form";
            frtd.MdiParent = this;
            frtd.Dock = DockStyle.Fill;
            frtd.Show();
        }
        bool menuopen = false;
        private void btnthietlap_Click(object sender, EventArgs e)
        {
           
            
        } 
        private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
        {
            contextMenuStrip1.Close();
        }
    

        private void âToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void btnthietlap_MouseLeave(object sender, EventArgs e)
        {
           
        }

        
       
       

        

       
    }
}
