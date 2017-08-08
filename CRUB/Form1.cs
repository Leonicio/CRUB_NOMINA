using System;
using System.Data;
using System.Windows.Forms;

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
                    DataTable dt = oper.ConsultaConResultado("select *from empleados WHERE num_empleado = '" +txtBuscador.Text.Trim() +"'");
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
    }
}
