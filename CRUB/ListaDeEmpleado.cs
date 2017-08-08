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
    public partial class ListaDeEmpleado : Form
    {
        public ListaDeEmpleado()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            operacion oper = new operacion();
            oper.ConsultaConResultado("SELECT * FROM empleados");
            dataGridView1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaDeEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();

            DataSet dsempleado = new DataSet();

            DataTable dte = oper.ConsultaConResultado("SELECT * FROM empleados");
            dsempleado.Tables.Add(dte);

            // crea el archivo XML en una la carpeta XML para los reporte 
            dsempleado.WriteXml(@"C:\Users\leoni\Desktop\Programacion III\XML\Listaempleados.xml");

            ReporteDeEmpleado rpe = new ReporteDeEmpleado("ListaEmpleado.rpt");
            rpe.Show();
        }
    }
}
