namespace Sistema_Gestion_Biblioteca
{
    partial class Visualizacion
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
            this.dgvvisu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvisu
            // 
            this.dgvvisu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvisu.Location = new System.Drawing.Point(0, 0);
            this.dgvvisu.Name = "dgvvisu";
            this.dgvvisu.RowHeadersWidth = 62;
            this.dgvvisu.RowTemplate.Height = 28;
            this.dgvvisu.Size = new System.Drawing.Size(1144, 430);
            this.dgvvisu.TabIndex = 0;
            // 
            // Visualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 430);
            this.Controls.Add(this.dgvvisu);
            this.Name = "Visualizacion";
            this.Text = "Visualizacion";
            this.Load += new System.EventHandler(this.Visualizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvvisu;
    }
}