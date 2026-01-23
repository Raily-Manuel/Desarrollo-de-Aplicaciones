using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_07_Sebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtCompletivo.Visible = false;
            txtExtraordinario.Visible = false;

            lblCompletivo.Visible = false;
            lblExtraordinario.Visible = false;
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            // Captura de notas
            int nota1 = int.Parse(txtnota1.Text);
            int nota2 = int.Parse(txtnota2.Text);
            int nota3 = int.Parse(txtnota3.Text);
            int nota4 = int.Parse(txtnota4.Text);

            // Promedio
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4.0;

            if (promedio >= 70)
            {
                MessageBox.Show($"Pasaste de curso\nNota final: {promedio}");
            }
            else
            {
                // Completivo
                if (string.IsNullOrWhiteSpace(txtCompletivo.Text))
                {
                    txtCompletivo.Visible = true;
                    lblCompletivo.Visible = true;
                    txtCompletivo.Focus();
                    txtCompletivo.Enabled = true;
                    MessageBox.Show("Ingrese la nota del completivo");
                    return;
                }

                int notaCompletivo = int.Parse(txtCompletivo.Text);
                double completivo = (promedio * 0.5) + (notaCompletivo * 0.5);

                if (completivo >= 70)
                {
                    MessageBox.Show($"Pasaste en completivo\nNota final: {completivo}");
                }
                else
                {
                    // Extraordinario
                    if (string.IsNullOrWhiteSpace(txtExtraordinario.Text))
                    {
                        txtExtraordinario.Visible = true;
                        lblExtraordinario.Visible = true;
                        txtExtraordinario.Focus();
                        MessageBox.Show("Ingrese la nota del extraordinario");
                        txtExtraordinario.Enabled = true;
                        return;
                    }

                    int notaExtraordinario = int.Parse(txtExtraordinario.Text);
                    double extraordinario = (promedio * 0.3) + (notaExtraordinario * 0.7);

                    if (extraordinario >= 70)
                    {
                        MessageBox.Show($"Pasaste en extraordinario\nNota final: {extraordinario}");
                    }
                    else
                    {
                        MessageBox.Show("Reprobado 😢");
                    }
                }
            }
        }

        private void btnlim_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();
            txtCompletivo.Clear();
            txtExtraordinario.Clear();
        }

        private void btnsal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
        



