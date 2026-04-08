namespace Sistema_Gestion_Biblioteca
{
    partial class Report_Prestamos
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
            this.sistemaGestionBibliotecaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_Gestion_BibliotecaDataSet = new Sistema_Gestion_Biblioteca.Sistema_Gestion_BibliotecaDataSet();
            this.rvpres = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionBibliotecaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Gestion_BibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sistemaGestionBibliotecaDataSetBindingSource
            // 
            this.sistemaGestionBibliotecaDataSetBindingSource.DataSource = this.sistema_Gestion_BibliotecaDataSet;
            this.sistemaGestionBibliotecaDataSetBindingSource.Position = 0;
            // 
            // sistema_Gestion_BibliotecaDataSet
            // 
            this.sistema_Gestion_BibliotecaDataSet.DataSetName = "Sistema_Gestion_BibliotecaDataSet";
            this.sistema_Gestion_BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvpres
            // 
            this.rvpres.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Prestamos";
            reportDataSource1.Value = this.sistemaGestionBibliotecaDataSetBindingSource;
            this.rvpres.LocalReport.DataSources.Add(reportDataSource1);
            this.rvpres.LocalReport.ReportEmbeddedResource = "Sistema_Gestion_Biblioteca.Report_Prestamos.rdlc";
            this.rvpres.Location = new System.Drawing.Point(0, 0);
            this.rvpres.Name = "rvpres";
            this.rvpres.ServerReport.BearerToken = null;
            this.rvpres.Size = new System.Drawing.Size(1058, 545);
            this.rvpres.TabIndex = 0;
            this.rvpres.Load += new System.EventHandler(this.rvpres_Load);
            // 
            // Report_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 545);
            this.Controls.Add(this.rvpres);
            this.Name = "Report_Prestamos";
            this.Text = "Report_Prestamos";
            this.Load += new System.EventHandler(this.Report_Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionBibliotecaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Gestion_BibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvpres;
        private System.Windows.Forms.BindingSource sistemaGestionBibliotecaDataSetBindingSource;
        private Sistema_Gestion_BibliotecaDataSet sistema_Gestion_BibliotecaDataSet;
    }
}