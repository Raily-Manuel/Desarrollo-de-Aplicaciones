namespace Sistema_Gestion_Biblioteca
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlbarranav = new System.Windows.Forms.Panel();
            this.btnregusu = new System.Windows.Forms.Button();
            this.btnlects = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbxlogo = new System.Windows.Forms.PictureBox();
            this.btnusus = new System.Windows.Forms.Button();
            this.pnlpags = new System.Windows.Forms.Panel();
            this.btnelimiusu = new System.Windows.Forms.Button();
            this.pnlcontent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlbarranav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlcontent
            // 
            this.pnlcontent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlcontent.Controls.Add(this.panel1);
            this.pnlcontent.Location = new System.Drawing.Point(234, -1);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(1016, 618);
            this.pnlcontent.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(116, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 231);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(738, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administracion del Sistema de Biblioteca";
            // 
            // pnlbarranav
            // 
            this.pnlbarranav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlbarranav.Controls.Add(this.btnelimiusu);
            this.pnlbarranav.Controls.Add(this.btnregusu);
            this.pnlbarranav.Controls.Add(this.btnlects);
            this.pnlbarranav.Controls.Add(this.label1);
            this.pnlbarranav.Controls.Add(this.ptbxlogo);
            this.pnlbarranav.Controls.Add(this.btnusus);
            this.pnlbarranav.Controls.Add(this.pnlpags);
            this.pnlbarranav.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlbarranav.Location = new System.Drawing.Point(0, -1);
            this.pnlbarranav.Name = "pnlbarranav";
            this.pnlbarranav.Size = new System.Drawing.Size(234, 621);
            this.pnlbarranav.TabIndex = 26;
            this.pnlbarranav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbarranav_Paint);
            // 
            // btnregusu
            // 
            this.btnregusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregusu.FlatAppearance.BorderSize = 0;
            this.btnregusu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnregusu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnregusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregusu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregusu.ForeColor = System.Drawing.Color.White;
            this.btnregusu.Location = new System.Drawing.Point(18, 329);
            this.btnregusu.Name = "btnregusu";
            this.btnregusu.Size = new System.Drawing.Size(196, 90);
            this.btnregusu.TabIndex = 23;
            this.btnregusu.Text = "Registro de Usuarios";
            this.btnregusu.UseVisualStyleBackColor = true;
            this.btnregusu.Click += new System.EventHandler(this.btnregusu_Click);
            // 
            // btnlects
            // 
            this.btnlects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlects.FlatAppearance.BorderSize = 0;
            this.btnlects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnlects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlects.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlects.ForeColor = System.Drawing.Color.White;
            this.btnlects.Location = new System.Drawing.Point(18, 233);
            this.btnlects.Name = "btnlects";
            this.btnlects.Size = new System.Drawing.Size(196, 90);
            this.btnlects.TabIndex = 22;
            this.btnlects.Text = "Lectores";
            this.btnlects.UseVisualStyleBackColor = true;
            this.btnlects.Click += new System.EventHandler(this.btnlects_Click);
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
            // btnusus
            // 
            this.btnusus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusus.FlatAppearance.BorderSize = 0;
            this.btnusus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnusus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnusus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusus.ForeColor = System.Drawing.Color.White;
            this.btnusus.Location = new System.Drawing.Point(18, 137);
            this.btnusus.Name = "btnusus";
            this.btnusus.Size = new System.Drawing.Size(196, 90);
            this.btnusus.TabIndex = 0;
            this.btnusus.Text = "Usuarios";
            this.btnusus.UseVisualStyleBackColor = true;
            this.btnusus.Click += new System.EventHandler(this.btnusus_Click);
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
            // btnelimiusu
            // 
            this.btnelimiusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnelimiusu.FlatAppearance.BorderSize = 0;
            this.btnelimiusu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnelimiusu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnelimiusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnelimiusu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnelimiusu.ForeColor = System.Drawing.Color.White;
            this.btnelimiusu.Location = new System.Drawing.Point(18, 425);
            this.btnelimiusu.Name = "btnelimiusu";
            this.btnelimiusu.Size = new System.Drawing.Size(196, 90);
            this.btnelimiusu.TabIndex = 25;
            this.btnelimiusu.Text = "Eliminar Usuarios";
            this.btnelimiusu.UseVisualStyleBackColor = true;
            this.btnelimiusu.Click += new System.EventHandler(this.btnelimiusu_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 618);
            this.Controls.Add(this.pnlcontent);
            this.Controls.Add(this.pnlbarranav);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.pnlcontent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlbarranav.ResumeLayout(false);
            this.pnlbarranav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlcontent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlbarranav;
        private System.Windows.Forms.Button btnregusu;
        private System.Windows.Forms.Button btnlects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbxlogo;
        private System.Windows.Forms.Button btnusus;
        private System.Windows.Forms.Panel pnlpags;
        private System.Windows.Forms.Button btnelimiusu;
    }
}