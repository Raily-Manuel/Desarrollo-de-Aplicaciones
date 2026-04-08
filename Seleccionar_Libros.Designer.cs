namespace Sistema_Gestion_Biblioteca
{
    partial class Seleccionar_Libros
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.dgvlibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(12, 34);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(170, 48);
            this.btnaceptar.TabIndex = 29;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // dgvlibros
            // 
            this.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibros.Location = new System.Drawing.Point(12, 106);
            this.dgvlibros.Name = "dgvlibros";
            this.dgvlibros.RowHeadersWidth = 62;
            this.dgvlibros.RowTemplate.Height = 28;
            this.dgvlibros.Size = new System.Drawing.Size(726, 406);
            this.dgvlibros.TabIndex = 30;
            this.dgvlibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlibros_CellContentClick);
            // 
            // Seleccionar_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 524);
            this.Controls.Add(this.dgvlibros);
            this.Controls.Add(this.btnaceptar);
            this.Name = "Seleccionar_Libros";
            this.Text = "Seleccionar_Libros";
            this.Load += new System.EventHandler(this.Seleccionar_Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridView dgvlibros;
    }
}