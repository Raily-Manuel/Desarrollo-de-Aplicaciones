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
    public partial class Data_Pres : Form
    {
        public Data_Pres()
        {
            InitializeComponent();
        }

        private void Data_Pres_Load(object sender, EventArgs e)
        {
            CargarPres();
        }

        private void dgvpres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idPrestamo = Convert.ToInt32(dgvpres.CurrentRow.Cells["id_Prestamo"].Value);

                Report_Prestamos frm = new Report_Prestamos(idPrestamo);
                frm.ShowDialog();
            }
        }

        public void CargarPres()
        {
            CN_Usuarios obj = new CN_Usuarios();
            dgvpres.DataSource = obj.Cargar_Prestamos();

            // Opcional: ocultar ID
            dgvpres.Columns["id_Prestamo"].Visible = false;
        }
    }
}
