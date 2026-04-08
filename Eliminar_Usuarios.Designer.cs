namespace Sistema_Gestion_Biblioteca
{
    partial class Eliminar_Usuarios
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
            this.pnlinter = new System.Windows.Forms.Panel();
            this.dgvusus = new System.Windows.Forms.DataGridView();
            this.txteliusu = new System.Windows.Forms.TextBox();
            this.btneliusu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlinter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusus)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlinter
            // 
            this.pnlinter.BackColor = System.Drawing.Color.DarkGray;
            this.pnlinter.Controls.Add(this.dgvusus);
            this.pnlinter.Controls.Add(this.txteliusu);
            this.pnlinter.Controls.Add(this.btneliusu);
            this.pnlinter.Controls.Add(this.label2);
            this.pnlinter.Controls.Add(this.panel3);
            this.pnlinter.Location = new System.Drawing.Point(-2, -2);
            this.pnlinter.Name = "pnlinter";
            this.pnlinter.Size = new System.Drawing.Size(1023, 633);
            this.pnlinter.TabIndex = 2;
            // 
            // dgvusus
            // 
            this.dgvusus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusus.Location = new System.Drawing.Point(14, 257);
            this.dgvusus.Name = "dgvusus";
            this.dgvusus.RowHeadersWidth = 62;
            this.dgvusus.RowTemplate.Height = 28;
            this.dgvusus.Size = new System.Drawing.Size(994, 344);
            this.dgvusus.TabIndex = 26;
            // 
            // txteliusu
            // 
            this.txteliusu.BackColor = System.Drawing.Color.White;
            this.txteliusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txteliusu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteliusu.Location = new System.Drawing.Point(77, 195);
            this.txteliusu.Name = "txteliusu";
            this.txteliusu.Size = new System.Drawing.Size(282, 32);
            this.txteliusu.TabIndex = 4;
            // 
            // btneliusu
            // 
            this.btneliusu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliusu.Location = new System.Drawing.Point(691, 149);
            this.btneliusu.Name = "btneliusu";
            this.btneliusu.Size = new System.Drawing.Size(248, 78);
            this.btneliusu.TabIndex = 3;
            this.btneliusu.Text = "Eliminar";
            this.btneliusu.UseVisualStyleBackColor = true;
            this.btneliusu.Click += new System.EventHandler(this.btneliusu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Usuario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 100);
            this.panel3.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(304, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(442, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Eliminacion de Usuarios";
            // 
            // Eliminar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 629);
            this.Controls.Add(this.pnlinter);
            this.Name = "Eliminar_Usuarios";
            this.Text = "Eliminar_Usuarios";
            this.Load += new System.EventHandler(this.Eliminar_Usuarios_Load);
            this.pnlinter.ResumeLayout(false);
            this.pnlinter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusus)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlinter;
        private System.Windows.Forms.DataGridView dgvusus;
        private System.Windows.Forms.TextBox txteliusu;
        private System.Windows.Forms.Button btneliusu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
    }
}