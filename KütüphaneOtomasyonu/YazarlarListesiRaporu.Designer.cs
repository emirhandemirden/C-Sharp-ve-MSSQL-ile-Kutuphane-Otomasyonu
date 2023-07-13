namespace KütüphaneOtomasyonu
{
    partial class YazarlarListesiRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarlarListesiRaporu));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yazarlarDataSet = new KütüphaneOtomasyonu.YazarlarDataSet();
            this.yazarlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarlarTableAdapter = new KütüphaneOtomasyonu.YazarlarDataSetTableAdapters.YazarlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.yazarlarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KütüphaneOtomasyonu.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // yazarlarDataSet
            // 
            this.yazarlarDataSet.DataSetName = "YazarlarDataSet";
            this.yazarlarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazarlarBindingSource
            // 
            this.yazarlarBindingSource.DataMember = "Yazarlar";
            this.yazarlarBindingSource.DataSource = this.yazarlarDataSet;
            // 
            // yazarlarTableAdapter
            // 
            this.yazarlarTableAdapter.ClearBeforeFill = true;
            // 
            // YazarlarListesiRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YazarlarListesiRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yazarlar Listesi Raporu";
            this.Load += new System.EventHandler(this.YazarlarListesiRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private YazarlarDataSet yazarlarDataSet;
        private System.Windows.Forms.BindingSource yazarlarBindingSource;
        private YazarlarDataSetTableAdapters.YazarlarTableAdapter yazarlarTableAdapter;
    }
}