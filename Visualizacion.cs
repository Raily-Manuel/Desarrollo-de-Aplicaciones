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
    public partial class Visualizacion : Form
    {
        public Visualizacion()
        {
            InitializeComponent();
        }

        private void Visualizacion_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
        }


        public void CargarPrestamos()
        {
            CN_Usuarios obj = new CN_Usuarios();
            DataTable dt = obj.Mostrar_Prestamos();
            dgvvisu.DataSource = dt;
        }
    }
}
