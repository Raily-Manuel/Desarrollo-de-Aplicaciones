using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Datos_Empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing; // CONFIRMACION-SALIR-DEL-PAPUS-PROYECTO
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Complete todos los campos antes de guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!masktelefono.MaskCompleted || !maskfecha.MaskCompleted)
            {
                MessageBox.Show("Complete correctamente el teléfono y la fecha.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // CREAR LA PAPU TABLA
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------------------------------------------------");
            sb.AppendLine("ID\tNombre\tApellidos\tTeléfono\tGénero\tDirección\tEmail\tCargo\tSalario\tFecha Ingreso");
            sb.AppendLine("-------------------------------------------------------------");
            sb.AppendLine($"{txtid.Text}\t{txtnombre.Text}\t{txtapellidos.Text}\t{masktelefono.Text}\t{txtgenero.Text}\t{txtdireccion.Text}\t{txtemail.Text}\t{txtcargo.Text}\t{txtsalario.Text}\t{maskfecha.Text}");

            // GGUARDAR EL PPAPUS EMPLEADO
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt";
            saveFileDialog.Title = "Guardar datos de empleado";

            if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ABRIR LA CAPETA AMARILLA DE ARCHIVOS 
                System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnombre.Clear();
            txtapellidos.Clear();
            txtgenero.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
            txtcargo.Clear();
            txtsalario.Clear();
            masktelefono.Clear();
            maskfecha.Clear();
        }
    }
}
