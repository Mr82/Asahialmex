﻿namespace CsPresentacion
{
    partial class Frm_Reporte_Bajas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Bajas));
            this.RV_Bajas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FM_LISTADO_BAJASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Bajas = new CsPresentacion.DS_Bajas();
            this.FM_LISTADO_BAJASTableAdapter = new CsPresentacion.DS_BajasTableAdapters.FM_LISTADO_BAJASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_BAJASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Bajas)).BeginInit();
            this.SuspendLayout();
            // 
            // RV_Bajas
            // 
            this.RV_Bajas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FM_LISTADO_BAJASBindingSource;
            this.RV_Bajas.LocalReport.DataSources.Add(reportDataSource1);
            this.RV_Bajas.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Listado_bajas.rdlc";
            this.RV_Bajas.Location = new System.Drawing.Point(0, 0);
            this.RV_Bajas.Name = "RV_Bajas";
            this.RV_Bajas.ServerReport.BearerToken = null;
            this.RV_Bajas.Size = new System.Drawing.Size(1146, 534);
            this.RV_Bajas.TabIndex = 0;
            // 
            // FM_LISTADO_BAJASBindingSource
            // 
            this.FM_LISTADO_BAJASBindingSource.DataMember = "FM_LISTADO_BAJAS";
            this.FM_LISTADO_BAJASBindingSource.DataSource = this.DS_Bajas;
            // 
            // DS_Bajas
            // 
            this.DS_Bajas.DataSetName = "DS_Bajas";
            this.DS_Bajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FM_LISTADO_BAJASTableAdapter
            // 
            this.FM_LISTADO_BAJASTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Reporte_Bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 534);
            this.Controls.Add(this.RV_Bajas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Reporte_Bajas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Bajas de Empleados";
            this.Load += new System.EventHandler(this.Frm_Reporte_Bajas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_BAJASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Bajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RV_Bajas;
        private System.Windows.Forms.BindingSource FM_LISTADO_BAJASBindingSource;
        private DS_Bajas DS_Bajas;
        private DS_BajasTableAdapters.FM_LISTADO_BAJASTableAdapter FM_LISTADO_BAJASTableAdapter;
    }
}