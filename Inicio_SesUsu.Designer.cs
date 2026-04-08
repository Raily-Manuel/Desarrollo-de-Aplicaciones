namespace Sistema_Gestion_Biblioteca
{
    partial class Inicio_SesUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_SesUsu));
            this.pnlfont = new System.Windows.Forms.Panel();
            this.ptbxlogo = new System.Windows.Forms.PictureBox();
            this.txtnomusu = new System.Windows.Forms.TextBox();
            this.btninises = new System.Windows.Forms.Button();
            this.cmbrol = new System.Windows.Forms.ComboBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvisi = new System.Windows.Forms.Button();
            this.pnlfont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlfont
            // 
            this.pnlfont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlfont.Controls.Add(this.btnvisi);
            this.pnlfont.Controls.Add(this.ptbxlogo);
            this.pnlfont.Controls.Add(this.txtnomusu);
            this.pnlfont.Controls.Add(this.btninises);
            this.pnlfont.Controls.Add(this.cmbrol);
            this.pnlfont.Controls.Add(this.txtcontra);
            this.pnlfont.Controls.Add(this.label4);
            this.pnlfont.Controls.Add(this.label3);
            this.pnlfont.Controls.Add(this.label2);
            this.pnlfont.Controls.Add(this.label1);
            this.pnlfont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfont.Location = new System.Drawing.Point(0, 0);
            this.pnlfont.Name = "pnlfont";
            this.pnlfont.Size = new System.Drawing.Size(1251, 618);
            this.pnlfont.TabIndex = 0;
            this.pnlfont.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlfont_Paint);
            // 
            // ptbxlogo
            // 
            this.ptbxlogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbxlogo.Image")));
            this.ptbxlogo.Location = new System.Drawing.Point(555, 33);
            this.ptbxlogo.Name = "ptbxlogo";
            this.ptbxlogo.Size = new System.Drawing.Size(118, 121);
            this.ptbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxlogo.TabIndex = 8;
            this.ptbxlogo.TabStop = false;
            // 
            // txtnomusu
            // 
            this.txtnomusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnomusu.Location = new System.Drawing.Point(361, 313);
            this.txtnomusu.Name = "txtnomusu";
            this.txtnomusu.Size = new System.Drawing.Size(278, 19);
            this.txtnomusu.TabIndex = 4;
            // 
            // btninises
            // 
            this.btninises.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninises.Location = new System.Drawing.Point(361, 486);
            this.btninises.Name = "btninises";
            this.btninises.Size = new System.Drawing.Size(269, 69);
            this.btninises.TabIndex = 7;
            this.btninises.Text = "Iniciar Sesion";
            this.btninises.UseVisualStyleBackColor = true;
            this.btninises.Click += new System.EventHandler(this.btninises_Click);
            // 
            // cmbrol
            // 
            this.cmbrol.FormattingEnabled = true;
            this.cmbrol.Location = new System.Drawing.Point(722, 313);
            this.cmbrol.Name = "cmbrol";
            this.cmbrol.Size = new System.Drawing.Size(141, 28);
            this.cmbrol.TabIndex = 6;
            this.cmbrol.SelectedIndexChanged += new System.EventHandler(this.cmbrol_SelectedIndexChanged);
            // 
            // txtcontra
            // 
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontra.Location = new System.Drawing.Point(361, 398);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(502, 19);
            this.txtcontra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(717, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(356, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(356, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(440, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inisio de Sesion";
            // 
            // btnvisi
            // 
            this.btnvisi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvisi.Location = new System.Drawing.Point(656, 486);
            this.btnvisi.Name = "btnvisi";
            this.btnvisi.Size = new System.Drawing.Size(207, 69);
            this.btnvisi.TabIndex = 9;
            this.btnvisi.Text = "Visitante";
            this.btnvisi.UseVisualStyleBackColor = true;
            this.btnvisi.Click += new System.EventHandler(this.btnvisi_Click);
            // 
            // Inicio_SesUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 618);
            this.Controls.Add(this.pnlfont);
            this.Name = "Inicio_SesUsu";
            this.Text = "Inicio_SesUsu";
            this.Load += new System.EventHandler(this.Inicio_SesUsu_Load);
            this.pnlfont.ResumeLayout(false);
            this.pnlfont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlfont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbrol;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtnomusu;
        private System.Windows.Forms.Button btninises;
        private System.Windows.Forms.PictureBox ptbxlogo;
        private System.Windows.Forms.Button btnvisi;
    }
}