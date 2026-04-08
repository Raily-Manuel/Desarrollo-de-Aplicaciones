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
    public partial class Visitante : Form
    {
        public Visitante()
        {
            InitializeComponent();
        }

        private void Visitante_Load(object sender, EventArgs e)
        {
            CN_Usuarios obj = new CN_Usuarios();

            dgvlibros.DataSource = obj.MostrarLibs_NoId();

            dgvlibros.Columns["id_Libro"].Visible = false;

            dgvlibros.Columns["Titulo_Libro"].HeaderText = "Título";
            dgvlibros.Columns["Nom_Autor"].HeaderText = "Autor";
            dgvlibros.Columns["Nom_Genero"].HeaderText = "Categoría";
            dgvlibros.Columns["Cant_Paginas"].HeaderText = "Cantidad de Paginas";

            dgvlibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            CN_Usuarios obj = new CN_Usuarios();
            dgvlibros.DataSource = obj.Buscar_Libros(txtsearch.Text);
        }

        private void dgvlibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
