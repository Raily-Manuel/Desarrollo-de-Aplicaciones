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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Gestion_Biblioteca
{
    public partial class Registro_Prestamos : Form
    {
        DataTable tablaLibros = new DataTable();
        public DataTable librosSeleccionados = new DataTable();
        public Registro_Prestamos()
        {
            InitializeComponent();

            CN_Usuarios obj = new CN_Usuarios();

            cmbestado.Items.Add("Entregado");
            cmbestado.Items.Add("Pendiente");
            cmbestado.SelectedIndex = 0;
        }

        private void Registro_Prestamos_Load(object sender, EventArgs e)
        {
            dtpfecha.Value = DateTime.Now;
            dtpfechaen.MinDate = new DateTime(2020, 3, 24);
            dtpfechadevo.MinDate = new DateTime(2020, 3, 24);

            
        }


        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnom_lec.Text) || string.IsNullOrWhiteSpace(txtidusu.Text) || string.IsNullOrWhiteSpace(txtlibros.Text))
            {
                MessageBox.Show("Complete los campos requeridos.");
                return;
            }

            Capa_Entidades.Prestamos pres = new Capa_Entidades.Prestamos();
            Detalle_Prestamo det = new Detalle_Prestamo();

            pres.Fecha_Prestamo = dtpfecha.Value;
            pres.Nom_Lector = txtnom_lec.Text;
            pres.Fecha_Entrega = dtpfechaen.Value;
            pres.id_Usuario = int.Parse(txtidusu.Text);

            CN_Usuarios obj = new CN_Usuarios();

            try
            {
                int idprestamo = obj.Insertar_pres(pres);

                if (idprestamo > 0)
                {
                    MessageBox.Show("Préstamo registrado correctamente. ID: " + idprestamo);

                    det.id_Prestamo = idprestamo;
                    det.id_Libro = Convert.ToInt32(txtlibros.Text);

                    obj.Insertar_det(det);

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtnom_lec.Clear();
            txtidusu.Clear();
            txtlibros.Clear();

            dtpfecha.Value = DateTime.Now;
            dtpfechaen.Value = DateTime.Now;
        }

        private void btnactu_Click(object sender, EventArgs e)
        {
            if (cmbestado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado");
                return;
            }

            Capa_Entidades.Prestamos pres = new Capa_Entidades.Prestamos();

            pres.Fecha_Devolucion = dtpfechadevo.Value;

            int idPrestamo = int.Parse(txtidpr.Text);

            string estad = cmbestado.Text;

            CN_Usuarios obj = new CN_Usuarios();

            obj.Actu_pres(idPrestamo, dtpfechadevo.Value, estad);

            MessageBox.Show("Préstamo actualizado correctamente");

            LimpiarCampos2();
        }

        private void LimpiarCampos2()
        {
            txtidpr.Clear();
            dtpfechadevo.Value = DateTime.Now;
        }


        private void btnvisu_Click(object sender, EventArgs e)
        {
        }

        private void btnvisu2_Click(object sender, EventArgs e)
        {
            Visualizacion frm = new Visualizacion();
            frm.Show();
        }

        private void btnselec_Click(object sender, EventArgs e)
        {
            Seleccionar_Libros frm = new Seleccionar_Libros();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.librosSeleccionados.Rows.Count == 0)
                {
                    MessageBox.Show("No seleccionaste ningún libro");
                    return;
                }

                txtlibros.Clear();

                List<string> nombres = new List<string>();

                foreach (DataRow row in frm.librosSeleccionados.Rows)
                {
                    nombres.Add(row["Titulo_Libro"].ToString());
                }

                txtlibros.Text = string.Join(", ", nombres);
            }
        }
    }
}
