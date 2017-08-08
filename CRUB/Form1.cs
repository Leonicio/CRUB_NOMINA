using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;


namespace CRUB
{
    public partial class Formbusqueda : Form
    {
        public Formbusqueda()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FormEmpleado f = new FormEmpleado();
            f.Show();
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            {
                operacion oper = new operacion();

                if (txtBuscador.Text.Length == 0)
                {
                    DataTable dt = oper.ConsultaConResultado(" SELECT  * FROM empleados ");
                    dgvEmpleado.DataSource = dt;
                    return;
                }

                if (rdbid.Checked == true)
                { 
                    DataTable dt = oper.ConsultaConResultado("select *from empleados WHERE id_empleado = '" +txtBuscador.Text.Trim() +"'");
                    dgvEmpleado.DataSource = dt;
                }
              
               if(rdbnombre.Checked == true)
                 {
                    DataTable dt = oper.ConsultaConResultado("select *from empleados WHERE nombre ='" + txtBuscador.Text.Trim() + "'");
                    dgvEmpleado.DataSource = dt;
                }
          
              if (rdbApellido.Checked  == true)
                {
                    DataTable dt = oper.ConsultaConResultado("select *from empleados WHERE apellido = '" + txtBuscador.Text.Trim() + "'");
                    dgvEmpleado.DataSource = dt;
                }
          
              if (rdbCedula.Checked== true )
                {
                    DataTable dt = oper.ConsultaConResultado("select *from empleados WHERE cedula = '" + txtBuscador.Text.Trim() + "'");
                    dgvEmpleado.DataSource = dt;
                }
        }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Formbusqueda_Load(object sender, EventArgs e)
        {
            {
                
               
               
               
            }
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void cREAREMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormEmpleado f = new FormEmpleado();
            //f.Show();
        }

        private void cREARCARGOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormCargo f = new FormCargo();
            f.Show();
        }

        private void bUSCARNOMINAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusquedaNomina f = new FormBusquedaNomina();
            f.Show();
        }

        private void dETALLESDENOMINASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDestalle_de_Nominas f = new FormDestalle_de_Nominas();
            f.Show();
        }

        private void bUSCARCARGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargo f = new FormCargo();
            f.Show();
        }

        private void bUSCARCARGOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCargo f = new FormCargo();
            f.Show();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir1_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();

            DataSet dsempleado = new DataSet();

            DataTable dte = oper.ConsultaConResultado("SELECT * FROM empleados");
            dsempleado.Tables.Add(dte);

            // crea el archivo XML en una la carpeta XML para los reporte 
            dsempleado.WriteXml(@"C:\Users\leoni\Desktop\Programacion III\XML\empleados.xml");

            ReporteDeEmpleado rpe = new ReporteDeEmpleado("VisorEmpleado.rpt");
            rpe.Show();
        }

        private void bUSCAREMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleado f = new FormEmpleado();
            f.Show();
        }

        private void lISTADEEMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeEmpleado f = new ListaDeEmpleado();
            f.Show();
        }
    }
}
