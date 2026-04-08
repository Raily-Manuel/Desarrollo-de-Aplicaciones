namespace Sistema_Gestion_Biblioteca
{
    partial class Visu_Lectores
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
            this.dgvlectores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlectores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlectores
            // 
            this.dgvlectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlectores.Location = new System.Drawing.Point(0, 0);
            this.dgvlectores.Name = "dgvlectores";
            this.dgvlectores.RowHeadersWidth = 62;
            this.dgvlectores.RowTemplate.Height = 28;
            this.dgvlectores.Size = new System.Drawing.Size(980, 433);
            this.dgvlectores.TabIndex = 0;
            this.dgvlectores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlectores_CellContentClick);
            // 
            // Visu_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 431);
            this.Controls.Add(this.dgvlectores);
            this.Name = "Visu_Lectores";
            this.Text = "Visu_Lectores";
            this.Load += new System.EventHandler(this.Visu_Lectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlectores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlectores;
    }
}