namespace DeAnQLQN
{
    partial class frm_baocao_nhapxuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_baocao_nhapxuat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.dgv_nhap = new System.Windows.Forms.DataGridView();
            this.colstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colngayxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmaxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvxuat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Xuat);
            this.panel1.Controls.Add(this.btn_nhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvxuat);
            this.panel2.Controls.Add(this.dgv_nhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 360);
            this.panel2.TabIndex = 1;
            // 
            // btn_nhap
            // 
            this.btn_nhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_nhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_nhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhap.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhap.Image")));
            this.btn_nhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nhap.Location = new System.Drawing.Point(0, 0);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(130, 74);
            this.btn_nhap.TabIndex = 0;
            this.btn_nhap.Text = "Nhập";
            this.btn_nhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhap.UseVisualStyleBackColor = false;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Xuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Xuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xuat.Image")));
            this.btn_Xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xuat.Location = new System.Drawing.Point(688, 0);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(130, 74);
            this.btn_Xuat.TabIndex = 1;
            this.btn_Xuat.Text = "Xuất";
            this.btn_Xuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Xuat.UseVisualStyleBackColor = false;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // dgv_nhap
            // 
            this.dgv_nhap.AllowUserToAddRows = false;
            this.dgv_nhap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgv_nhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_nhap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_nhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colstt,
            this.colmanhap,
            this.colmanv,
            this.colngaynhap});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhap.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_nhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhap.Location = new System.Drawing.Point(0, 0);
            this.dgv_nhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_nhap.Name = "dgv_nhap";
            this.dgv_nhap.ReadOnly = true;
            this.dgv_nhap.RowHeadersVisible = false;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_nhap.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_nhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhap.Size = new System.Drawing.Size(818, 360);
            this.dgv_nhap.TabIndex = 3;
            this.dgv_nhap.DoubleClick += new System.EventHandler(this.dgv_nhap_DoubleClick);
            // 
            // colstt
            // 
            this.colstt.DataPropertyName = "STT";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colstt.DefaultCellStyle = dataGridViewCellStyle15;
            this.colstt.HeaderText = "STT";
            this.colstt.Name = "colstt";
            this.colstt.ReadOnly = true;
            this.colstt.Width = 50;
            // 
            // colmanhap
            // 
            this.colmanhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colmanhap.DataPropertyName = "MaNhap";
            this.colmanhap.HeaderText = "Mã Nhập";
            this.colmanhap.Name = "colmanhap";
            this.colmanhap.ReadOnly = true;
            // 
            // colmanv
            // 
            this.colmanv.DataPropertyName = "MaNV";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colmanv.DefaultCellStyle = dataGridViewCellStyle16;
            this.colmanv.HeaderText = "Nhân Viên Nhập";
            this.colmanv.Name = "colmanv";
            this.colmanv.ReadOnly = true;
            this.colmanv.Width = 200;
            // 
            // colngaynhap
            // 
            this.colngaynhap.DataPropertyName = "NgayNhap";
            this.colngaynhap.HeaderText = "Ngày Nhập";
            this.colngaynhap.Name = "colngaynhap";
            this.colngaynhap.ReadOnly = true;
            this.colngaynhap.Width = 150;
            // 
            // colngayxuat
            // 
            this.colngayxuat.DataPropertyName = "NgayXuat";
            this.colngayxuat.HeaderText = "Ngày Xuất";
            this.colngayxuat.Name = "colngayxuat";
            this.colngayxuat.ReadOnly = true;
            this.colngayxuat.Width = 150;
            // 
            // col_manv
            // 
            this.col_manv.DataPropertyName = "MaNV";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_manv.DefaultCellStyle = dataGridViewCellStyle19;
            this.col_manv.HeaderText = "Nhân Viên Xuất";
            this.col_manv.Name = "col_manv";
            this.col_manv.ReadOnly = true;
            this.col_manv.Width = 200;
            // 
            // colmaxuat
            // 
            this.colmaxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colmaxuat.DataPropertyName = "MaXuat";
            this.colmaxuat.HeaderText = "Mã Xuât";
            this.colmaxuat.Name = "colmaxuat";
            this.colmaxuat.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STT";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dgvxuat
            // 
            this.dgvxuat.AllowUserToAddRows = false;
            this.dgvxuat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.dgvxuat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvxuat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvxuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colmaxuat,
            this.col_manv,
            this.colngayxuat});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvxuat.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvxuat.Location = new System.Drawing.Point(0, 0);
            this.dgvxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvxuat.Name = "dgvxuat";
            this.dgvxuat.ReadOnly = true;
            this.dgvxuat.RowHeadersVisible = false;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvxuat.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvxuat.Size = new System.Drawing.Size(818, 360);
            this.dgvxuat.TabIndex = 4;
            this.dgvxuat.Visible = false;
            this.dgvxuat.DoubleClick += new System.EventHandler(this.dgvxuat_DoubleClick);
            // 
            // frm_baocao_nhapxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_baocao_nhapxuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhập xuất";
            this.Load += new System.EventHandler(this.frm_baocao_nhapxuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Xuat;
        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngaynhap;
        private System.Windows.Forms.DataGridView dgvxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmaxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colngayxuat;
    }
}