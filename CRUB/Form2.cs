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
            string fecha = dtpFecha_ing.Value.ToString("dd/mm/yyyy");
            oper.ConsultaSinResultado("INSERT INTO Empleados (num_empleado, nombre, apellido, cedula, sexo, estatus, fecha_nac, fecha_ingreso, id_cargo, suerdo) VALUES('" + txt_id_Empleado.Text + "','" + txtnombre.Text + "','" + txtApellido.Text + "','" + mtb_cadula.Text + "','" + txt_Sexo.Text + "','"+txtEstatus.Text+"' , '" + mtbFecha_nac.Text + "', '" + dtpFecha_ing.Text + "', " + txtcargo.Text + "," + txtsalario.Text + ")");


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
            txtcargo.Clear();
            txtsalario.Clear();
            txtcalcularAntig.Clear();
            txtCal_edad.Clear();

            txt_id_Empleado.Focus();



        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            oper.ConsultaSinResultado(" DELETE FROM empleados where id_empleado ='" + txt_id_Empleado.Text + "' ");
            MessageBox.Show("Empleado Borrado");
            txt_id_Empleado.Clear();
            txtnombre.Clear();
            txtApellido.Clear();
            mtb_cadula.Clear();
            txt_Sexo.Clear();
            txtEstatus.Clear();
            mtbFecha_nac.Clear();
          
            txtcargo.Clear();
            txtsalario.Clear();
            txtcalcularAntig.Clear();
            txtCal_edad.Clear();
            txt_id_Empleado.Focus();

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
                txtEstatus.Focus();

        }

        private void mtbFecha_nac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                dtpFecha_ing.Focus();
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


            DataTable dt_empleado = oper.ConsultaConResultado(" SELECT  * FROM empleados where id_empleado ='" + txt_id_Empleado.Text + "' ");
            foreach (DataRow dr in dt_empleado.Rows)
            {
                string id_empleado, nombre, apellidos, cedula, sexo, estatus, fecha_nac, fecha_ingreso, id_cargo, salario;
                id_empleado = dr["id_empleado"].ToString();
                nombre = dr["nombre"].ToString();
                apellidos = dr["apellido"].ToString();
                cedula = dr["cedula"].ToString();
                sexo = dr["sexo"].ToString();
                estatus = dr["estatus"].ToString();
                fecha_nac = dr["fecha_nac"].ToString();
                fecha_ingreso = dr["fecha_ingreso"].ToString();
                id_cargo = dr["id_cargo"].ToString();
                salario = dr["suerdo"].ToString();
                txtnombre.Text = nombre;
                txtApellido.Text = apellidos;
                txt_id_Empleado.Text = id_empleado;
                mtb_cadula.Text = cedula;
                txt_Sexo.Text = sexo;
                txtEstatus.Text = estatus;
                mtbFecha_nac.Text = fecha_nac;
                dtpFecha_ing.Text = fecha_ingreso;
                
                txtcargo.Text = id_cargo;
                txtsalario.Text = salario;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            string fecha = dtpFecha_ing.Value.ToString("dd/mm/yyyy");
            oper.ConsultaSinResultado ("UPDATE empleados SET nombre = '" + txtnombre.Text + "', apellido = '" + txtApellido.Text + "', cedula = '" + mtb_cadula.Text + "', sexo = '" + txt_Sexo.Text + "', estatus = '" + txtEstatus.Text + "', fecha_nac = '" + mtbFecha_nac.Text + "', fecha_ingreso = '" + dtpFecha_ing.Text + "', id_cargo = '" + txtcargo.Text + "', suerdo = '"+txtsalario.Text+"' where id_empleado = '"+txt_id_Empleado.Text+"'");
            MessageBox.Show("Empleado Actualizado");
        }

        private void dtpFecha_ing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtcargo.Focus();
        }

        private void txtEstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                mtbFecha_nac.Focus();
        }
    }

}
