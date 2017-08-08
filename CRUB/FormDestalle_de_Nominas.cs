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
    public partial class FormDestalle_de_Nominas : Form
    {
        public FormDestalle_de_Nominas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                operacion oper = new operacion();

                DataTable dt = oper.ConsultaConResultado(" select id_empleado AS ID, nombre AS NOMBRE, apellido AS APELLIDO, cedula AS CEDULA, nombre_cargo AS CARGO, suerdo AS SUERDO, (suerdo *0.12) ISR, (suerdo *0.04 ) SS, (suerdo * 0.02) AHORRO, ((suerdo *0.12) + (suerdo *0.04 )+ (suerdo * 0.02)) TOTAL_DESCUENTO, (suerdo -((suerdo *0.12) + (suerdo *0.04 )+ (suerdo * 0.02)) ) SUERDO_NETO from empleados inner join cargos on empleados.id_cargo= cargos.Id_cargo ");
                dtgDestalleNomina.DataSource = dt;
                return;



            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarDetalleN_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
           
            foreach (DataGridViewRow f in dtgDestalleNomina.Rows)
            {

                 oper.ConsultaSinResultado("INSERT INTO detalle_nomina SELECT id_empleado, nombre, apellido, cedula, nombre_cargo, suerdo, (suerdo *0.12) irs, (suerdo *0.04 ) ss, (suerdo * 0.02) otros_dec, ((suerdo *0.12) + (suerdo *0.04 )+ (suerdo * 0.02)) total_desc, (suerdo -((suerdo *0.12) + (suerdo *0.04 )+ (suerdo * 0.02)) ) suerdo_neto FROM empleados inner join cargos WHERE empleados.id_cargo= cargos.Id_cargo");

            }


            MessageBox.Show("Los Datos Se Guardaron Correctamente");

  

            
          

        }

        private void FormDestalle_de_Nominas_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
