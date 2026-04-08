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
    public partial class Visu_Usuarios : Form
    {
        public Visu_Usuarios()
        {
            InitializeComponent();
        }

        private void Visu_Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            CN_Usuarios obj = new CN_Usuarios();
            DataTable dt = obj.Mostrar_Usuarios();
            dgvusuarios.DataSource = dt;
        }
    }
}
