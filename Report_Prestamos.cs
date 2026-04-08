using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using Capa_Negocio;
using Capa_Entidades;

namespace Sistema_Gestion_Biblioteca
{
    public partial class Report_Prestamos : Form
    {
        int idPrestamo;

        public Report_Prestamos(int id)
        {
            InitializeComponent();
            idPrestamo = id;
        }

        private void Report_Prestamos_Load(object sender, EventArgs e)
        {
            CN_Usuarios obj = new CN_Usuarios();
            DataTable dt = obj.Report_Prestamos(idPrestamo);

            rvpres.LocalReport.ReportPath = "Report_Prestamos.rdlc";
            rvpres.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("Prestamo", dt);
            rvpres.LocalReport.DataSources.Add(rds);

            rvpres.RefreshReport();
        }

        private void rvpres_Load(object sender, EventArgs e)
        {

        }
    }
}
