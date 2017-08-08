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
    public partial class FormBusquedaNomina : Form
    {
        public FormBusquedaNomina()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarNomina_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
                     
                      
            if (txtBusqNomina.Text == "")
            {
                MessageBox.Show("Dijite el Numero de Nomina");

            }

            else
            {
                 DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM encabezado  where id_nomina = '"+txtBusqNomina.Text.Trim()+ "'");
                dtgBusquedaCabeceraN.DataSource = dt;

            }

            DataTable dn = oper.ConsultaConResultado(" select id_empleado AS ID, nombre AS NOMBRE, apellido AS APELLIDO, cedula AS CEDULA, nombre_cargo AS CARGO, suerdo AS SUERDO, (suerdo *0.12) ISR, (suerdo *0.04 ) SS, (suerdo * 0.02) AHORRO, ((suerdo *0.12) + (suerdo *0.04 )+ (suerdo * 0.02)) TOTAL_DESCUENTO, (suerdo -((suerdo *0.12) + (suerdo *0.04 )+ (suerdo * 0.02)) ) SUERDO_NETO from empleados inner join cargos on empleados.id_cargo= cargos.Id_cargo  ");
            dtgBusNomina.DataSource = dn;


                return;

            
            }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormBusquedaNomina_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int total_deducciones = 0;
            int total_nomina = 0;
            for (int a = 0; a < dtgBusNomina.Rows.Count; a++)

            {
                total_deducciones += Convert.ToInt32(dtgBusNomina.Rows[a].Cells["total_desc"].Value.ToString());
                total_nomina += Convert.ToInt32(dtgBusNomina.Rows[a].Cells["suerdo_neto"].Value.ToString());

            }
            txtTotalDeduciones.Text = total_deducciones.ToString();
            txtTotalNominas.Text = total_nomina.ToString();
        }

        private void radioNumNomina_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimirNomina_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();

            DataSet Nomina = new DataSet();

            DataTable dtnom = oper.ConsultaConResultado("SELECT * FROM encabezado");
            Nomina.Tables.Add(dtnom);
            DataTable dtn = oper.ConsultaConResultado("SELECT * FROM detalle_nomina");
            Nomina.Tables.Add(dtn);

            // crea el archivo XML en una la carpeta XML para los reporte 
            Nomina.WriteXml(@"C:\Users\leoni\Desktop\Programacion III\XML\ListaNomina.xml");

            Nominadetalle rpenom = new Nominadetalle("NominaDetalle.rpt");
            rpenom.Show();

        }
    }
}
