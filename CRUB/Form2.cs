using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;


namespace CRUB
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string antig = txtcalcularAntig.Text;
            DateTime f = Convert.ToDateTime(antig);
            int antiguedad = DateTime.Today.AddTicks(-f.Ticks).Year - 1;
            txtcalcularAntig.Text = Convert.ToString(antiguedad);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            operacion oper = new operacion();
            oper.ConsultaSinResultado("INSERT INTO Empleados (num_empleado, nombre, apellido, cedula, Sexo, fecha_nac, fecha_ingreso, id_cargo, salario) VALUES('" + txt_id_Empleado.Text + "','" + txtnombre.Text + "','" + txtApellido.Text + "','" + mtb_cadula.Text + "','" + txt_Sexo.Text + "' , '" + mtbFecha_nac.Text + "', '" + mtbFecha_ingreso.Text + "', " + txtcargo.Text + "," + txtsalario.Text + ")");


            MessageBox.Show("Los Datos Se Guardaron Correctamente");


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncrear2_Click(object sender, EventArgs e)
        {

            txt_id_Empleado.Clear();
            txtnombre.Clear();
            txtApellido.Clear();
            mtb_cadula.Clear();
            txt_Sexo.Clear();
            mtbFecha_nac.Clear();
            mtbFecha_ingreso.Clear();
            txtcargo.Clear();
            txtsalario.Clear();
            txtcalcularAntig.Clear();
            txtCal_edad.Clear();

            txt_id_Empleado.Focus();



        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txt_id_Empleado.Clear();
            txtnombre.Clear();
            txtApellido.Clear();
            mtb_cadula.Clear();
            txt_Sexo.Clear();
            mtbFecha_nac.Clear();
            mtbFecha_ingreso.Clear();
            txtcargo.Clear();
            txtsalario.Clear();
            txtcalcularAntig.Clear();
            txtCal_edad.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_Empleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtnombre.Focus();

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtApellido.Focus();

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                mtb_cadula.Focus();

        }

        private void mtb_cadula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_Sexo.Focus();

        }

        private void txt_Sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                mtbFecha_nac.Focus();

        }

        private void mtbFecha_nac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                mtbFecha_ingreso.Focus();

        }

        private void mtbFecha_ingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtcargo.Focus();

        }

        private void txtcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtsalario.Focus();

        }

        private void txtsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnguardar.Focus();

        }

        private void btncalcular_edad_Click(object sender, EventArgs e)
        {
            string fn = mtbFecha_nac.Text;
            DateTime f = Convert.ToDateTime(fn);
            int edad = DateTime.Today.AddTicks(-f.Ticks).Year - 1;
            txtCal_edad.Text = Convert.ToString(edad);

        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();


            DataTable dt_empleado = oper.ConsultaConResultado(" SELECT  * FROM empleados where num_empleado ='" + txt_id_Empleado.Text + "' ");
            foreach (DataRow dr in dt_empleado.Rows)
            {
                string num_empleado, nombre, apellidos, cedula, sexo, fecha_nac, fecha_ingreso, id_cargo, salario;
                num_empleado = dr["num_empleado"].ToString();
                nombre = dr["nombre"].ToString();
                apellidos = dr["apellido"].ToString();
                cedula = dr["cedula"].ToString();
                sexo = dr["sexo"].ToString();
                fecha_nac = dr["fecha_nac"].ToString();
                fecha_ingreso = dr["fecha_ingreso"].ToString();
                id_cargo = dr["id_cargo"].ToString();
                salario = dr["salario"].ToString();
                txtnombre.Text = nombre;
                txtApellido.Text = apellidos;
                txt_id_Empleado.Text = num_empleado;
                mtb_cadula.Text = cedula;
                txt_Sexo.Text = sexo;
                mtbFecha_nac.Text = fecha_nac;
                mtbFecha_ingreso.Text = fecha_ingreso;
                txtcargo.Text = id_cargo;
                txtsalario.Text = salario;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
        }
    }

}
