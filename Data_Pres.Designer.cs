namespace Sistema_Gestion_Biblioteca
{
    partial class Data_Pres
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
            this.dgvpres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpres
            // 
            this.dgvpres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpres.Location = new System.Drawing.Point(0, 0);
            this.dgvpres.Name = "dgvpres";
            this.dgvpres.RowHeadersWidth = 62;
            this.dgvpres.RowTemplate.Height = 28;
            this.dgvpres.Size = new System.Drawing.Size(1018, 629);
            this.dgvpres.TabIndex = 0;
            this.dgvpres.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpres_CellDoubleClick);
            // 
            // Data_Pres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 629);
            this.Controls.Add(this.dgvpres);
            this.Name = "Data_Pres";
            this.Text = "Data_Pres";
            this.Load += new System.EventHandler(this.Data_Pres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpres;
    }
}