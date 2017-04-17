namespace DeAnQLQN
{
    partial class frm_baocao_chitietNX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_nhapxuat = new System.Windows.Forms.DataGridView();
            this.col_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_giadv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thanhgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_nhapxuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 363);
            this.panel2.TabIndex = 1;
            // 
            // dgv_nhapxuat
            // 
            this.dgv_nhapxuat.AllowUserToAddRows = false;
            this.dgv_nhapxuat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgv_nhapxuat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nhapxuat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_nhapxuat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhapxuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nhapxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_stt,
            this.col_masp,
            this.col_tensp,
            this.col_soluong,
            this.col_donvi,
            this.col_giadv,
            this.col_thanhgia});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhapxuat.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_nhapxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhapxuat.Location = new System.Drawing.Point(0, 0);
            this.dgv_nhapxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_nhapxuat.Name = "dgv_nhapxuat";
            this.dgv_nhapxuat.ReadOnly = true;
            this.dgv_nhapxuat.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_nhapxuat.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_nhapxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhapxuat.Size = new System.Drawing.Size(819, 363);
            this.dgv_nhapxuat.TabIndex = 4;
            // 
            // col_stt
            // 
            this.col_stt.DataPropertyName = "STT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_stt.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_stt.HeaderText = "STT";
            this.col_stt.Name = "col_stt";
            this.col_stt.ReadOnly = true;
            this.col_stt.Width = 50;
            // 
            // col_masp
            // 
            this.col_masp.DataPropertyName = "MaSP";
            this.col_masp.HeaderText = "Mã Sp";
            this.col_masp.Name = "col_masp";
            this.col_masp.ReadOnly = true;
            this.col_masp.Visible = false;
            // 
            // col_tensp
            // 
            this.col_tensp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_tensp.DataPropertyName = "TenSP";
            this.col_tensp.HeaderText = "Tên sản phẩm";
            this.col_tensp.Name = "col_tensp";
            this.col_tensp.ReadOnly = true;
            // 
            // col_soluong
            // 
            this.col_soluong.DataPropertyName = "SoLgSP";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_soluong.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_soluong.HeaderText = "Số lượng";
            this.col_soluong.Name = "col_soluong";
            this.col_soluong.ReadOnly = true;
            // 
            // col_donvi
            // 
            this.col_donvi.DataPropertyName = "DonVi";
            this.col_donvi.HeaderText = "Đơn vị";
            this.col_donvi.Name = "col_donvi";
            this.col_donvi.ReadOnly = true;
            // 
            // col_giadv
            // 
            this.col_giadv.DataPropertyName = "Gia1DonVi";
            dataGridViewCellStyle5.Format = "#,###0 vnđ";
            dataGridViewCellStyle5.NullValue = "0";
            this.col_giadv.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_giadv.HeaderText = "Giá/Đơnvị";
            this.col_giadv.Name = "col_giadv";
            this.col_giadv.ReadOnly = true;
            this.col_giadv.Width = 120;
            // 
            // col_thanhgia
            // 
            this.col_thanhgia.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,###0 vnđ";
            dataGridViewCellStyle6.NullValue = null;
            this.col_thanhgia.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_thanhgia.HeaderText = "Thành Giá";
            this.col_thanhgia.Name = "col_thanhgia";
            this.col_thanhgia.ReadOnly = true;
            this.col_thanhgia.Width = 120;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Nhập Xuất";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_baocao_chitietNX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frm_baocao_chitietNX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo chi tiết nhập xuất";
            this.Load += new System.EventHandler(this.frm_baocao_chitietNX_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapxuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_nhapxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_giadv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thanhgia;
        private System.Windows.Forms.Label label1;

    }
}