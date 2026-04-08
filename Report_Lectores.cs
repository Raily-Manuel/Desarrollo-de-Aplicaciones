using Capa_Negocio;
using Microsoft.Reporting.WinForms;
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
    public partial class Report_Lectores : Form
    {
        public Report_Lectores()
        {
            InitializeComponent();
        }

        private void Report_Lectores_Load(object sender, EventArgs e)
        {
            CN_Usuarios obj = new CN_Usuarios();

            DataTable dt = obj.Report_Lectores();

            rvlects.LocalReport.ReportPath = "Report_Lectores.rdlc";

            ReportDataSource rds = new ReportDataSource("Lectores", dt);

            rvlects.LocalReport.DataSources.Clear();
            rvlects.LocalReport.DataSources.Add(rds);

            rvlects.RefreshReport();

            this.rvlects.RefreshReport();
        }
    }
}
