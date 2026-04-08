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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            foreach (Control ctrl in pnlbarranav.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Paint += button_Paint;
                }
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnregusu_Click(object sender, EventArgs e)
        {
            pnlcontent.Controls.Clear();

            Regis_Usuarios frm = new Regis_Usuarios();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlcontent.Controls.Add(frm);
            frm.Show();
        }

        private void btnusus_Click(object sender, EventArgs e)
        {
            Report_Usuarios frm = new Report_Usuarios();
            frm.Show();
        }

        private void btnlects_Click(object sender, EventArgs e)
        {
            Report_Lectores frm = new Report_Lectores();
            frm.Show();
        }

        private void button_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            Pen pen = new Pen(Color.White, 1);

            int y = btn.Height - 2;
            e.Graphics.DrawLine(pen, 0, y, btn.Width, y);
        }

        private void pnlbarranav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnelimiusu_Click(object sender, EventArgs e)
        {
            Eliminar_Usuarios frm = new Eliminar_Usuarios();

            pnlcontent.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlcontent.Controls.Add(frm);
            frm.Show();
        }
    }
}
