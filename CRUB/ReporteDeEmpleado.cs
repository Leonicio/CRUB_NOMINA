using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace CRUB
{
    public partial class ReporteDeEmpleado : Form
    {
        public ReporteDeEmpleado(string reporte)
        {
            InitializeComponent();

            // ver la lista de Empleado desde el visor de reporte 
            ReportDocument cryRptemp = new ReportDocument();
            cryRptemp.Load(@"C:\Users\leoni\OneDrive\Documentos\Visual Studio 2015\CRUB\CRUB\ListaEmpleado.rpt");
            crystalReportViewerEmpleado.ReportSource = cryRptemp;
            crystalReportViewerEmpleado.Refresh();
        }

        private void ReporteDeEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
