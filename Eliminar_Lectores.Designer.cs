namespace Sistema_Gestion_Biblioteca
{
    partial class Eliminar_Lectores
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
            this.pnlinter = new System.Windows.Forms.Panel();
            this.txtelilec = new System.Windows.Forms.TextBox();
            this.btnelilec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvlects = new System.Windows.Forms.DataGridView();
            this.cNUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlinter.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlinter
            // 
            this.pnlinter.BackColor = System.Drawing.Color.DarkGray;
            this.pnlinter.Controls.Add(this.dgvlects);
            this.pnlinter.Controls.Add(this.txtelilec);
            this.pnlinter.Controls.Add(this.btnelilec);
            this.pnlinter.Controls.Add(this.label2);
            this.pnlinter.Controls.Add(this.panel3);
            this.pnlinter.Location = new System.Drawing.Point(-2, -2);
            this.pnlinter.Name = "pnlinter";
            this.pnlinter.Size = new System.Drawing.Size(1023, 633);
            this.pnlinter.TabIndex = 1;
            // 
            // txtelilec
            // 
            this.txtelilec.BackColor = System.Drawing.Color.White;
            this.txtelilec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtelilec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtelilec.Location = new System.Drawing.Point(77, 195);
            this.txtelilec.Name = "txtelilec";
            this.txtelilec.Size = new System.Drawing.Size(282, 32);
            this.txtelilec.TabIndex = 4;
            this.txtelilec.TextChanged += new System.EventHandler(this.txtelilec_TextChanged);
            // 
            // btnelilec
            // 
            this.btnelilec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelilec.Location = new System.Drawing.Point(691, 149);
            this.btnelilec.Name = "btnelilec";
            this.btnelilec.Size = new System.Drawing.Size(248, 78);
            this.btnelilec.TabIndex = 3;
            this.btnelilec.Text = "Eliminar";
            this.btnelilec.UseVisualStyleBackColor = true;
            this.btnelilec.Click += new System.EventHandler(this.btnelilec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Lector";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label8.Size = new System.Drawing.Size(440, 42);
            this.label8.TabIndex = 0;
            this.label8.Text = "Eliminacion de Lectores";
            // 
            // dgvlects
            // 
            this.dgvlects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlects.Location = new System.Drawing.Point(14, 257);
            this.dgvlects.Name = "dgvlects";
            this.dgvlects.RowHeadersWidth = 62;
            this.dgvlects.RowTemplate.Height = 28;
            this.dgvlects.Size = new System.Drawing.Size(994, 344);
            this.dgvlects.TabIndex = 26;
            // 
            // cNUsuariosBindingSource
            // 
            this.cNUsuariosBindingSource.DataSource = typeof(Capa_Negocio.CN_Usuarios);
            // 
            // Eliminar_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 629);
            this.Controls.Add(this.pnlinter);
            this.Name = "Eliminar_Lectores";
            this.Text = "Eliminar_Lectores";
            this.Load += new System.EventHandler(this.Eliminar_Lectores_Load);
            this.pnlinter.ResumeLayout(false);
            this.pnlinter.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlinter;
        private System.Windows.Forms.TextBox txtelilec;
        private System.Windows.Forms.Button btnelilec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvlects;
        private System.Windows.Forms.BindingSource cNUsuariosBindingSource;
    }
}