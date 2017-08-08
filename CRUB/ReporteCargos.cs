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
    public partial class ReporteCargos : Form
    {
        private string v;

        public ReporteCargos(string nombre_reporte)
        {

            InitializeComponent();
            // ver la lista de cargos desde el visor de reporte 
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Users\leoni\OneDrive\Documentos\Visual Studio 2015\CRUB\CRUB\visordereporte.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ReporteCargos_Load(object sender, EventArgs e)
        {

        }
    }
}
