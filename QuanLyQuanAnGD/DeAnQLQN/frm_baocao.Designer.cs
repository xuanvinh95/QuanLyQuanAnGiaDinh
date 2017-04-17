namespace DeAnQLQN
{
    partial class frm_baocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_baocao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NhapXuat = new System.Windows.Forms.Button();
            this.dtpdenngay = new System.Windows.Forms.DateTimePicker();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txttonghoadon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltongloinhuan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltongngyuenlieu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltongdoanhthu = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_baocao = new System.Windows.Forms.DataGridView();
            this.colstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngayhoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 134);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_NhapXuat);
            this.groupBox1.Controls.Add(this.dtpdenngay);
            this.groupBox1.Controls.Add(this.dtptungay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttonghoadon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(436, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(857, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_NhapXuat
            // 
            this.btn_NhapXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NhapXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapXuat.Image")));
            this.btn_NhapXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapXuat.Location = new System.Drawing.Point(334, 57);
            this.btn_NhapXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NhapXuat.Name = "btn_NhapXuat";
            this.btn_NhapXuat.Size = new System.Drawing.Size(212, 73);
            this.btn_NhapXuat.TabIndex = 7;
            this.btn_NhapXuat.Text = "Nhập Xuất";
            this.btn_NhapXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NhapXuat.UseVisualStyleBackColor = true;
            this.btn_NhapXuat.Click += new System.EventHandler(this.btn_NhapXuat_Click);
            // 
            // dtpdenngay
            // 
            this.dtpdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdenngay.Location = new System.Drawing.Point(389, 23);
            this.dtpdenngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpdenngay.Name = "dtpdenngay";
            this.dtpdenngay.Size = new System.Drawing.Size(157, 26);
            this.dtpdenngay.TabIndex = 1;
            this.dtpdenngay.Value = new System.DateTime(2016, 5, 4, 0, 0, 0, 0);
            this.dtpdenngay.ValueChanged += new System.EventHandler(this.dtpdenngay_ValueChanged);
            // 
            // dtptungay
            // 
            this.dtptungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptungay.Location = new System.Drawing.Point(115, 25);
            this.dtptungay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(149, 26);
            this.dtptungay.TabIndex = 1;
            this.dtptungay.Value = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            this.dtptungay.ValueChanged += new System.EventHandler(this.dtptungay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến ngày";
            // 
            // txttonghoadon
            // 
            this.txttonghoadon.Location = new System.Drawing.Point(731, 25);
            this.txttonghoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttonghoadon.Name = "txttonghoadon";
            this.txttonghoadon.ReadOnly = true;
            this.txttonghoadon.Size = new System.Drawing.Size(104, 26);
            this.txttonghoadon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng số hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1456, 131);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbltongloinhuan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbltongngyuenlieu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbltongdoanhthu);
            this.groupBox2.Location = new System.Drawing.Point(515, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(700, 127);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(728, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(211, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // lbltongloinhuan
            // 
            this.lbltongloinhuan.AutoSize = true;
            this.lbltongloinhuan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongloinhuan.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltongloinhuan.Location = new System.Drawing.Point(388, 94);
            this.lbltongloinhuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltongloinhuan.Name = "lbltongloinhuan";
            this.lbltongloinhuan.Size = new System.Drawing.Size(62, 21);
            this.lbltongloinhuan.TabIndex = 5;
            this.lbltongloinhuan.Text = "label7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(117, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng tiền xuất nguyên liệu:";
            // 
            // lbltongngyuenlieu
            // 
            this.lbltongngyuenlieu.AutoSize = true;
            this.lbltongngyuenlieu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongngyuenlieu.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltongngyuenlieu.Location = new System.Drawing.Point(389, 50);
            this.lbltongngyuenlieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltongngyuenlieu.Name = "lbltongngyuenlieu";
            this.lbltongngyuenlieu.Size = new System.Drawing.Size(62, 21);
            this.lbltongngyuenlieu.TabIndex = 4;
            this.lbltongngyuenlieu.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(221, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng lợi nhuận:";
            // 
            // lbltongdoanhthu
            // 
            this.lbltongdoanhthu.AutoSize = true;
            this.lbltongdoanhthu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongdoanhthu.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltongdoanhthu.Location = new System.Drawing.Point(389, 17);
            this.lbltongdoanhthu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltongdoanhthu.Name = "lbltongdoanhthu";
            this.lbltongdoanhthu.Size = new System.Drawing.Size(62, 21);
            this.lbltongdoanhthu.TabIndex = 3;
            this.lbltongdoanhthu.Text = "label7";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_baocao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 265);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1456, 327);
            this.panel3.TabIndex = 2;
            // 
            // dgv_baocao
            // 
            this.dgv_baocao.AllowUserToAddRows = false;
            this.dgv_baocao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_baocao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_baocao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_baocao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_baocao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_baocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_baocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstt,
            this.colmahd,
            this.colmanv,
            this.colngayhoadon,
            this.coltongtien});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_baocao.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_baocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_baocao.Location = new System.Drawing.Point(0, 0);
            this.dgv_baocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_baocao.Name = "dgv_baocao";
            this.dgv_baocao.ReadOnly = true;
            this.dgv_baocao.RowHeadersVisible = false;
            this.dgv_baocao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_baocao.Size = new System.Drawing.Size(1456, 327);
            this.dgv_baocao.TabIndex = 0;
            this.dgv_baocao.DoubleClick += new System.EventHandler(this.dgv_baocao_DoubleClick);
            // 
            // colstt
            // 
            this.colstt.DataPropertyName = "STT";
            this.colstt.HeaderText = "STT";
            this.colstt.Name = "colstt";
            this.colstt.ReadOnly = true;
            this.colstt.Width = 50;
            // 
            // colmahd
            // 
            this.colmahd.DataPropertyName = "MaHD";
            this.colmahd.HeaderText = "MaHD";
            this.colmahd.Name = "colmahd";
            this.colmahd.ReadOnly = true;
            // 
            // colmanv
            // 
            this.colmanv.DataPropertyName = "MaNV";
            this.colmanv.HeaderText = "Mã Nhân Viên";
            this.colmanv.Name = "colmanv";
            this.colmanv.ReadOnly = true;
            this.colmanv.Width = 150;
            // 
            // colngayhoadon
            // 
            this.colngayhoadon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colngayhoadon.DataPropertyName = "NgayLapHoaDon";
            this.colngayhoadon.HeaderText = "Ngày lập hóa đơn";
            this.colngayhoadon.Name = "colngayhoadon";
            this.colngayhoadon.ReadOnly = true;
            // 
            // coltongtien
            // 
            this.coltongtien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,###0 vnđ";
            dataGridViewCellStyle3.NullValue = "0";
            this.coltongtien.DefaultCellStyle = dataGridViewCellStyle3;
            this.coltongtien.HeaderText = "Tổng tiền";
            this.coltongtien.Name = "coltongtien";
            this.coltongtien.ReadOnly = true;
            this.coltongtien.Width = 200;
            // 
            // frm_baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 592);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_baocao";
            this.Text = "frm_baocao";
            this.Load += new System.EventHandler(this.frm_baocao_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_baocao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttonghoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdenngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltongloinhuan;
        private System.Windows.Forms.Label lbltongngyuenlieu;
        private System.Windows.Forms.Label lbltongdoanhthu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_baocao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_NhapXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngayhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltongtien;
    }
}