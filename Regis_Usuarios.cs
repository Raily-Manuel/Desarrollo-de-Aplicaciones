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
    public partial class Regis_Usuarios : Form
    {
        public Regis_Usuarios()
        {
            InitializeComponent();
            
            CN_Usuarios obj = new CN_Usuarios();

            cmbroles.DataSource = obj.Mostrar_rol();
            cmbroles.DisplayMember = "Nom_Rol"; 
            cmbroles.SelectedIndex = 0;
            cmbroles.Text = "Seleccione un rol";
        }

        private void Regis_Usuarios_Load(object sender, EventArgs e)
        {
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Height = 2;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Height = 2;
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            if (txtusu.Text == "" || txttel.Text == "" || txtregisusu.Text == "" || txtregiscontra.Text == "" || txtemail.Text == "" || cmbroles.Text == "")
            {
                MessageBox.Show("Complete los campos requeridos.");
                return;
            }

            Usuarios usu = new Usuarios();
            CN_Usuarios negocio = new CN_Usuarios();

            usu.Nom_Usuario = txtregisusu.Text;
            usu.Email = txtemail.Text;
            usu.Telefono = txttel.Text;
            usu.Usuario = txtusu.Text;
            usu.Clave = txtregiscontra.Text;
            usu.Rol = cmbroles.Text;

            negocio.Insertar_usu(usu);

            bool existe = negocio.ExisteUsuario(usu.Usuario);

            if (existe == false)
            {
                MessageBox.Show("Usuario registrado correctamente");
            }
            else
            {
                MessageBox.Show("Usuario actualizado correctamente");
            }
        }

        private void btnvisuusu_Click(object sender, EventArgs e)
        {
            Visu_Usuarios frm = new Visu_Usuarios();
            frm.Show();
        }
    }
}
