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
    public partial class Visu_Lectores : Form
    {
        public Visu_Lectores()
        {
            InitializeComponent();
        }

        private void Visu_Lectores_Load(object sender, EventArgs e)
        {
            CargarLectores();
        }

        private void dgvlectores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CargarLectores()
        {
            CN_Usuarios obj = new CN_Usuarios();
            DataTable dt = obj.Mostrar_Lectores();
            dgvlectores.DataSource = dt;
        }
    }
}
