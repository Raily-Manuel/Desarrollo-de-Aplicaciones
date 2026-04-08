namespace Sistema_Gestion_Biblioteca
{
    partial class Report_Lectores
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
            this.rvlects = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistema_Gestion_BibliotecaDataSet2 = new Sistema_Gestion_Biblioteca.Sistema_Gestion_BibliotecaDataSet2();
            this.sistemaGestionBibliotecaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Gestion_BibliotecaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionBibliotecaDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvlects
            // 
            this.rvlects.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Lectores";
            reportDataSource1.Value = this.sistemaGestionBibliotecaDataSet2BindingSource;
            this.rvlects.LocalReport.DataSources.Add(reportDataSource1);
            this.rvlects.LocalReport.ReportEmbeddedResource = "Sistema_Gestion_Biblioteca.Report_Lectores.rdlc";
            this.rvlects.Location = new System.Drawing.Point(0, 0);
            this.rvlects.Name = "rvlects";
            this.rvlects.ServerReport.BearerToken = null;
            this.rvlects.Size = new System.Drawing.Size(1262, 629);
            this.rvlects.TabIndex = 0;
            // 
            // sistema_Gestion_BibliotecaDataSet2
            // 
            this.sistema_Gestion_BibliotecaDataSet2.DataSetName = "Sistema_Gestion_BibliotecaDataSet2";
            this.sistema_Gestion_BibliotecaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaGestionBibliotecaDataSet2BindingSource
            // 
            this.sistemaGestionBibliotecaDataSet2BindingSource.DataSource = this.sistema_Gestion_BibliotecaDataSet2;
            this.sistemaGestionBibliotecaDataSet2BindingSource.Position = 0;
            // 
            // Report_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 629);
            this.Controls.Add(this.rvlects);
            this.Name = "Report_Lectores";
            this.Text = "Report_Lectores";
            this.Load += new System.EventHandler(this.Report_Lectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Gestion_BibliotecaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionBibliotecaDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvlects;
        private System.Windows.Forms.BindingSource sistemaGestionBibliotecaDataSet2BindingSource;
        private Sistema_Gestion_BibliotecaDataSet2 sistema_Gestion_BibliotecaDataSet2;
    }
}