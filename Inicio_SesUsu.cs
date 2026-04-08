using Capa_Entidades;
using Capa_Negocio;
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
    public partial class Inicio_SesUsu : Form
    {
        public Inicio_SesUsu()
        {
            InitializeComponent();

            CN_Usuarios obj = new CN_Usuarios();

            cmbrol.DataSource = obj.Mostrar_rol();
            cmbrol.DisplayMember = "Nom_Rol";
            cmbrol.SelectedIndex = 0;
            cmbrol.Text = "Seleccione un rol";
        }

        private void Inicio_SesUsu_Load(object sender, EventArgs e)
        {
            pnlfont.BackColor = Color.FromArgb(180, 0, 0, 0);

            txtnomusu.BackColor = Color.White;
            txtcontra.BackColor = Color.White;
            txtnomusu.Font = new Font("Segoe UI", 10);
            txtcontra.Font = new Font("Segoe UI", 10);

            Logo();
        }

        //LOGO STYLE
        private void Logo()
        {
            System.Drawing.Drawing2D.GraphicsPath ruta = new System.Drawing.Drawing2D.GraphicsPath();
            ruta.AddEllipse(0, 0, ptbxlogo.Width, ptbxlogo.Height);

            ptbxlogo.Region = new Region(ruta);
        }

        private void pnlfont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninises_Click(object sender, EventArgs e)
        {
            if (txtnomusu.Text == "" || txtcontra.Text == "" || cmbrol.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            Usuarios user = new Usuarios()
            {
                Usuario = txtnomusu.Text,
                Clave = txtcontra.Text
            };

            string rol = cmbrol.Text;

            CN_Usuarios negocio = new CN_Usuarios();

            if (negocio.Login(user, rol))
            {
                MessageBox.Show("Acceso concedido.");

                if(rol == "Administrador")
                {
                    FormAdmin frm = new FormAdmin();

                    pnlfont.Controls.Clear();

                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;

                    pnlfont.Controls.Add(frm);
                    frm.Show();
                }
                else if(rol == "Bibliotecario")
                {
                    Form1 frm = new Form1();

                    pnlfont.Controls.Clear();

                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;

                    pnlfont.Controls.Add(frm);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Rol no reconocido");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Usuario, contraseña o rol incorrectos.");
            }
        }

        private void btnvisi_Click(object sender, EventArgs e)
        {
            Visitante frm = new Visitante();
            frm.Show();
        }
    }
}
