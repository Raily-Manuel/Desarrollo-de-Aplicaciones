using Capa_Negocio;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (Control ctrl in pnlbarranav.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += button_MouseEnter;
                    btn.MouseLeave += button_MouseLeave;
                    btn.Paint += button_Paint;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Logo();
        }

        //LOGO STYLE
        private void Logo()
        {
            System.Drawing.Drawing2D.GraphicsPath ruta = new System.Drawing.Drawing2D.GraphicsPath();
            ruta.AddEllipse(0, 0, ptbxlogo.Width, ptbxlogo.Height);

            ptbxlogo.Region = new Region(ruta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro_Prestamos frm = new Registro_Prestamos();

            pnlcontent.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlcontent.Controls.Add(frm);
            frm.Show();
        }
        private void button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            Pen pen = new Pen(Color.White, 1);

            int y = btn.Height - 2;
            e.Graphics.DrawLine(pen, 0, y, btn.Width, y);
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(64, 64, 64);
        }


        private void btnreglec_Click(object sender, EventArgs e)
        {
            pnlcontent.Controls.Clear();

            Login frm = new Login();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlcontent.Controls.Add(frm);
            frm.Show();
        }
        private void btnregusu_Click(object sender, EventArgs e)
        {
            pnlcontent.Controls.Clear();

            Data_Pres frm = new Data_Pres();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlcontent.Controls.Add(frm);
            frm.Show();
        }

        private void btnini_Click(object sender, EventArgs e)
        {
            
        }

        private void btnelimilec_Click(object sender, EventArgs e)
        {
            Eliminar_Lectores frm = new Eliminar_Lectores();

            pnlcontent.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlcontent.Controls.Add(frm);
            frm.Show();
        }
    }
    
}
