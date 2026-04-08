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
    public partial class Eliminar_Usuarios : Form
    {
        public Eliminar_Usuarios()
        {
            InitializeComponent();
        }

        private void Eliminar_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void btneliusu_Click(object sender, EventArgs e)
        {
            if (txteliusu.Text == "")
            {
                MessageBox.Show("Complete el campo requerido.");
                return;
            }

            string nombre = txteliusu.Text;

            CN_Usuarios obj = new CN_Usuarios();
            dgvusus.DataSource = obj.Mostrar_Usuarios();
            int filas = obj.Eliminar_usu(nombre);

            if (filas > 0)
            {
                MessageBox.Show("Eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontro el lector.");
            }
        }
    }
}
