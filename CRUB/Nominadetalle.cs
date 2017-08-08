using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUB
{
    public partial class Nominadetalle : Form
    {
        private readonly object crystalReportViewerNominadetalle;

        public Nominadetalle(string Nomina)
        {
            InitializeComponent();

            // ver la lista de Empleado desde el visor de reporte 
            ReportDocument cryRptemp = new ReportDocument();
            cryRptemp.Load(@"C:\Users\leoni\OneDrive\Documentos\Visual Studio 2015\CRUB\CRUB\NominaDetalle.rpt");
            crystalReportViewer1.ReportSource = cryRptemp;
            crystalReportViewer1.Refresh();
        }

        private void Nominadetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
