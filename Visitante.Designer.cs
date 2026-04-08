namespace Sistema_Gestion_Biblioteca
{
    partial class Visitante
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
            this.pnlencabezado = new System.Windows.Forms.Panel();
            this.dgvlibros = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.pnlencabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlencabezado
            // 
            this.pnlencabezado.BackColor = System.Drawing.Color.DarkGray;
            this.pnlencabezado.Controls.Add(this.dgvlibros);
            this.pnlencabezado.Controls.Add(this.panel3);
            this.pnlencabezado.Controls.Add(this.label3);
            this.pnlencabezado.Controls.Add(this.txtsearch);
            this.pnlencabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlencabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlencabezado.Name = "pnlencabezado";
            this.pnlencabezado.Size = new System.Drawing.Size(1132, 618);
            this.pnlencabezado.TabIndex = 19;
            // 
            // dgvlibros
            // 
            this.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibros.Location = new System.Drawing.Point(28, 224);
            this.dgvlibros.Name = "dgvlibros";
            this.dgvlibros.RowHeadersWidth = 62;
            this.dgvlibros.RowTemplate.Height = 28;
            this.dgvlibros.Size = new System.Drawing.Size(1080, 368);
            this.dgvlibros.TabIndex = 27;
            this.dgvlibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlibros_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(-4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 137);
            this.panel3.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(421, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(365, 42);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seleccion de Libros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar:";
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Location = new System.Drawing.Point(230, 169);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(225, 28);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // Visitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 618);
            this.Controls.Add(this.pnlencabezado);
            this.Name = "Visitante";
            this.Text = "Visitante";
            this.Load += new System.EventHandler(this.Visitante_Load);
            this.pnlencabezado.ResumeLayout(false);
            this.pnlencabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlencabezado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvlibros;
    }
}