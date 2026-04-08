namespace Sistema_Gestion_Biblioteca
{
    partial class Report_Usuarios
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
            this.rvusus = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistema_Gestion_BibliotecaDataSet2 = new Sistema_Gestion_Biblioteca.Sistema_Gestion_BibliotecaDataSet2();
            this.sistemaGestionBibliotecaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Gestion_BibliotecaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionBibliotecaDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvusus
            // 
            this.rvusus.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Usuarios";
            reportDataSource1.Value = this.sistemaGestionBibliotecaDataSet2BindingSource;
            this.rvusus.LocalReport.DataSources.Add(reportDataSource1);
            this.rvusus.LocalReport.ReportEmbeddedResource = "Sistema_Gestion_Biblioteca.Report_Usuarios.rdlc";
            this.rvusus.Location = new System.Drawing.Point(0, 0);
            this.rvusus.Name = "rvusus";
            this.rvusus.ServerReport.BearerToken = null;
            this.rvusus.Size = new System.Drawing.Size(1262, 629);
            this.rvusus.TabIndex = 0;
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
            // Report_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 629);
            this.Controls.Add(this.rvusus);
            this.Name = "Report_Usuarios";
            this.Text = "Report_Usuarios";
            this.Load += new System.EventHandler(this.Report_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_Gestion_BibliotecaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaGestionBibliotecaDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvusus;
        private System.Windows.Forms.BindingSource sistemaGestionBibliotecaDataSet2BindingSource;
        private Sistema_Gestion_BibliotecaDataSet2 sistema_Gestion_BibliotecaDataSet2;
    }
}