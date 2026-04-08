namespace Sistema_Gestion_Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlbarranav = new System.Windows.Forms.Panel();
            this.btnpres = new System.Windows.Forms.Button();
            this.btnreglec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbxlogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlpags = new System.Windows.Forms.Panel();
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnelimilec = new System.Windows.Forms.Button();
            this.pnlbarranav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxlogo)).BeginInit();
            this.pnlcontent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlbarranav
            // 
            this.pnlbarranav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlbarranav.Controls.Add(this.btnelimilec);
            this.pnlbarranav.Controls.Add(this.btnpres);
            this.pnlbarranav.Controls.Add(this.btnreglec);
            this.pnlbarranav.Controls.Add(this.label1);
            this.pnlbarranav.Controls.Add(this.ptbxlogo);
            this.pnlbarranav.Controls.Add(this.button1);
            this.pnlbarranav.Controls.Add(this.pnlpags);
            this.pnlbarranav.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlbarranav.Location = new System.Drawing.Point(0, -1);
            this.pnlbarranav.Name = "pnlbarranav";
            this.pnlbarranav.Size = new System.Drawing.Size(234, 621);
            this.pnlbarranav.TabIndex = 24;
            // 
            // btnpres
            // 
            this.btnpres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpres.FlatAppearance.BorderSize = 0;
            this.btnpres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnpres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpres.ForeColor = System.Drawing.Color.White;
            this.btnpres.Location = new System.Drawing.Point(18, 324);
            this.btnpres.Name = "btnpres";
            this.btnpres.Size = new System.Drawing.Size(196, 90);
            this.btnpres.TabIndex = 23;
            this.btnpres.Text = "Prestamos";
            this.btnpres.UseVisualStyleBackColor = true;
            this.btnpres.Click += new System.EventHandler(this.btnregusu_Click);
            // 
            // btnreglec
            // 
            this.btnreglec.BackColor = System.Drawing.Color.Transparent;
            this.btnreglec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreglec.FlatAppearance.BorderSize = 0;
            this.btnreglec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnreglec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnreglec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreglec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreglec.ForeColor = System.Drawing.Color.White;
            this.btnreglec.Location = new System.Drawing.Point(18, 228);
            this.btnreglec.Name = "btnreglec";
            this.btnreglec.Size = new System.Drawing.Size(196, 90);
            this.btnreglec.TabIndex = 22;
            this.btnreglec.Text = "Registro de lectores";
            this.btnreglec.UseVisualStyleBackColor = false;
            this.btnreglec.Click += new System.EventHandler(this.btnreglec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(101, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library";
            // 
            // ptbxlogo
            // 
            this.ptbxlogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbxlogo.Image")));
            this.ptbxlogo.Location = new System.Drawing.Point(11, 13);
            this.ptbxlogo.Name = "ptbxlogo";
            this.ptbxlogo.Size = new System.Drawing.Size(80, 80);
            this.ptbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxlogo.TabIndex = 0;
            this.ptbxlogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registro de Prestamos\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlpags
            // 
            this.pnlpags.BackColor = System.Drawing.Color.LightGray;
            this.pnlpags.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlpags.Location = new System.Drawing.Point(239, 0);
            this.pnlpags.Name = "pnlpags";
            this.pnlpags.Size = new System.Drawing.Size(1013, 621);
            this.pnlpags.TabIndex = 21;
            // 
            // pnlcontent
            // 
            this.pnlcontent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlcontent.Controls.Add(this.panel1);
            this.pnlcontent.Location = new System.Drawing.Point(234, -1);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(1016, 618);
            this.pnlcontent.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(155, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 231);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(607, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestion del Sistema de Biblioteca";
            // 
            // btnelimilec
            // 
            this.btnelimilec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnelimilec.FlatAppearance.BorderSize = 0;
            this.btnelimilec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnelimilec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnelimilec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelimilec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelimilec.ForeColor = System.Drawing.Color.White;
            this.btnelimilec.Location = new System.Drawing.Point(18, 420);
            this.btnelimilec.Name = "btnelimilec";
            this.btnelimilec.Size = new System.Drawing.Size(196, 90);
            this.btnelimilec.TabIndex = 24;
            this.btnelimilec.Text = "Eliminar Lectores";
            this.btnelimilec.UseVisualStyleBackColor = true;
            this.btnelimilec.Click += new System.EventHandler(this.btnelimilec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 618);
            this.Controls.Add(this.pnlcontent);
            this.Controls.Add(this.pnlbarranav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlbarranav.ResumeLayout(false);
            this.pnlbarranav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxlogo)).EndInit();
            this.pnlcontent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbarranav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbxlogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlpags;
        private System.Windows.Forms.Panel pnlcontent;
        private System.Windows.Forms.Button btnpres;
        private System.Windows.Forms.Button btnreglec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnelimilec;
    }
}

