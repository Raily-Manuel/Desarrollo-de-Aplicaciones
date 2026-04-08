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
    public partial class Seleccionar_Libros : Form
    {
        public DataTable librosSeleccionados = new DataTable();

        public Seleccionar_Libros()
        {
            InitializeComponent();
        }

        private void Seleccionar_Libros_Load(object sender, EventArgs e)
        {
            CN_Usuarios obj = new CN_Usuarios();

            dgvlibros.DataSource = obj.MostrarLibs_NoId();

            dgvlibros.Columns["id_Libro"].Visible = false;

            dgvlibros.Columns["Titulo_Libro"].HeaderText = "Título";
            dgvlibros.Columns["Nom_Autor"].HeaderText = "Autor";
            dgvlibros.Columns["Nom_Genero"].HeaderText = "Categoría";
            dgvlibros.Columns["Cant_Paginas"].HeaderText = "Cantidad de Paginas";

            dgvlibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "Seleccionar";
            chk.HeaderText = "Seleccionar";
            chk.Width = 50;

            dgvlibros.Columns.Insert(0, chk);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            librosSeleccionados.Clear();
            librosSeleccionados.Columns.Clear();

            librosSeleccionados.Columns.Add("id_Libro");
            librosSeleccionados.Columns.Add("Titulo_Libro");

            foreach (DataGridViewRow fila in dgvlibros.Rows)
            {
                bool seleccionado = fila.Cells["Seleccionar"].Value != null &&
                                    (bool)fila.Cells["Seleccionar"].Value;

                if (seleccionado)
                {
                    librosSeleccionados.Rows.Add(
                        fila.Cells["id_Libro"].Value,
                        fila.Cells["Titulo_Libro"].Value
                    );
                }
            }
            MessageBox.Show("Seleccionados: " + librosSeleccionados.Rows.Count);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvlibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvlibros.IsCurrentCellDirty)
            {
                dgvlibros.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
