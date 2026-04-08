using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_Biblioteca
{
    public partial class Eliminar_Lectores : Form
    {
        public Eliminar_Lectores()
        {
            InitializeComponent();
        }

        private void Eliminar_Lectores_Load(object sender, EventArgs e)
        {

        }

        private void btnelilec_Click(object sender, EventArgs e)
        {
            if(txtelilec.Text == "")
            {
                MessageBox.Show("Complete el campo requerido.");
                return;
            }

            string nombre = txtelilec.Text;

            CN_Usuarios obj = new CN_Usuarios();
            dgvlects.DataSource = obj.Mostrar_Lectores();
            int filas = obj.Eliminar_lec(nombre);

            if(filas > 0)
            {
                MessageBox.Show("Eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontro el lector.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtelilec_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
