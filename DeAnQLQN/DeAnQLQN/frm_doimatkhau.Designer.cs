namespace DeAnQLQN
{
    partial class frm_doimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_doimatkhau));
            this.btnluu = new System.Windows.Forms.Button();
            this.lbltentk = new System.Windows.Forms.Label();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.lblmkcu = new System.Windows.Forms.Label();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.lblmkm = new System.Windows.Forms.Label();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.lblmkm1 = new System.Windows.Forms.Label();
            this.txtmkm1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnluu.Location = new System.Drawing.Point(89, 190);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(96, 33);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltentk
            // 
            this.lbltentk.AutoSize = true;
            this.lbltentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltentk.ForeColor = System.Drawing.Color.White;
            this.lbltentk.Location = new System.Drawing.Point(55, 52);
            this.lbltentk.Name = "lbltentk";
            this.lbltentk.Size = new System.Drawing.Size(113, 16);
            this.lbltentk.TabIndex = 1;
            this.lbltentk.Text = "Tên Tài Khoản:";
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Enabled = false;
            this.txttentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttentaikhoan.Location = new System.Drawing.Point(174, 49);
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(167, 22);
            this.txttentaikhoan.TabIndex = 2;
            // 
            // lblmkcu
            // 
            this.lblmkcu.AutoSize = true;
            this.lblmkcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkcu.ForeColor = System.Drawing.Color.White;
            this.lblmkcu.Location = new System.Drawing.Point(71, 89);
            this.lblmkcu.Name = "lblmkcu";
            this.lblmkcu.Size = new System.Drawing.Size(97, 16);
            this.lblmkcu.TabIndex = 1;
            this.lblmkcu.Text = "Mật Khẩu Cũ:";
            // 
            // txtmkcu
            // 
            this.txtmkcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkcu.Location = new System.Drawing.Point(174, 86);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(167, 22);
            this.txtmkcu.TabIndex = 1;
            // 
            // lblmkm
            // 
            this.lblmkm.AutoSize = true;
            this.lblmkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkm.ForeColor = System.Drawing.Color.White;
            this.lblmkm.Location = new System.Drawing.Point(63, 126);
            this.lblmkm.Name = "lblmkm";
            this.lblmkm.Size = new System.Drawing.Size(104, 16);
            this.lblmkm.TabIndex = 1;
            this.lblmkm.Text = "Mật Khẩu Mới:";
            // 
            // txtmkm
            // 
            this.txtmkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkm.Location = new System.Drawing.Point(174, 123);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Size = new System.Drawing.Size(167, 22);
            this.txtmkm.TabIndex = 2;
            // 
            // lblmkm1
            // 
            this.lblmkm1.AutoSize = true;
            this.lblmkm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmkm1.ForeColor = System.Drawing.Color.White;
            this.lblmkm1.Location = new System.Drawing.Point(26, 164);
            this.lblmkm1.Name = "lblmkm1";
            this.lblmkm1.Size = new System.Drawing.Size(141, 16);
            this.lblmkm1.TabIndex = 1;
            this.lblmkm1.Text = "Nhập Lại Mật Khẩu:";
            // 
            // txtmkm1
            // 
            this.txtmkm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkm1.Location = new System.Drawing.Point(174, 161);
            this.txtmkm1.Name = "txtmkm1";
            this.txtmkm1.Size = new System.Drawing.Size(167, 22);
            this.txtmkm1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(485, 41);
            this.label7.TabIndex = 5;
            this.label7.Text = "Đổi Mật Khẩu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(347, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 124);
            this.label5.TabIndex = 6;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnreset.Location = new System.Drawing.Point(191, 189);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(96, 34);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(293, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Visible = false;
            // 
            // frm_doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(485, 232);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmkm1);
            this.Controls.Add(this.lblmkm1);
            this.Controls.Add(this.txtmkm);
            this.Controls.Add(this.lblmkm);
            this.Controls.Add(this.txtmkcu);
            this.Controls.Add(this.lblmkcu);
            this.Controls.Add(this.txttentaikhoan);
            this.Controls.Add(this.lbltentk);
            this.Controls.Add(this.btnluu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_doimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doimatkhau";
            this.Load += new System.EventHandler(this.frm_doimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lbltentk;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.Label lblmkcu;
        private System.Windows.Forms.TextBox txtmkcu;
        private System.Windows.Forms.Label lblmkm;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.Label lblmkm1;
        private System.Windows.Forms.TextBox txtmkm1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}