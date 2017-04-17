namespace DeAnQLQN
{
    partial class reportprinthoadon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PSP_hoadon_INBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_inhoadon = new DeAnQLQN.DS_inhoadon();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PSP_hoadon_INTableAdapter = new DeAnQLQN.DS_inhoadonTableAdapters.PSP_hoadon_INTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PSP_hoadon_INBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_inhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // PSP_hoadon_INBindingSource
            // 
            this.PSP_hoadon_INBindingSource.DataMember = "PSP_hoadon_IN";
            this.PSP_hoadon_INBindingSource.DataSource = this.DS_inhoadon;
            // 
            // DS_inhoadon
            // 
            this.DS_inhoadon.DataSetName = "DS_inhoadon";
            this.DS_inhoadon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_hoadon";
            reportDataSource1.Value = this.PSP_hoadon_INBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DeAnQLQN.report_inhoadon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(822, 488);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 488);
            this.panel1.TabIndex = 1;
            // 
            // PSP_hoadon_INTableAdapter
            // 
            this.PSP_hoadon_INTableAdapter.ClearBeforeFill = true;
            // 
            // reportprinthoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 488);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "reportprinthoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Thanh Toán";
            this.Load += new System.EventHandler(this.reportprinthoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PSP_hoadon_INBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_inhoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource PSP_hoadon_INBindingSource;
        private DS_inhoadon DS_inhoadon;
        private DS_inhoadonTableAdapters.PSP_hoadon_INTableAdapter PSP_hoadon_INTableAdapter;
    }
}