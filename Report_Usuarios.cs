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
    public partial class Report_Usuarios : Form
    {
        public Report_Usuarios()
        {
            InitializeComponent();
        }

        private void Report_Usuarios_Load(object sender, EventArgs e)
        {
            CN_Usuarios obj = new CN_Usuarios();

            DataTable dt = obj.Report_Usuarios();

            rvusus.LocalReport.ReportPath = "Report_Usuarios.rdlc";

            ReportDataSource rds = new ReportDataSource("Usuarios", dt);

            rvusus.LocalReport.DataSources.Clear();
            rvusus.LocalReport.DataSources.Add(rds);

            rvusus.RefreshReport();

            this.rvusus.RefreshReport();
        }
    }
}
