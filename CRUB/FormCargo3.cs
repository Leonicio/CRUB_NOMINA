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
    public partial class FormCargo : Form
    {
        public FormCargo()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            oper.ConsultaSinResultado("INSERT INTO cargos (id_cargo, nombre_cargo) VALUES('" + txtIdCargo.Text + "','" + txtNombreCargo.Text + "')");

            DataTable dt_cargos = oper.ConsultaConResultado(" SELECT  * FROM cargos ");
            dtgCargos.DataSource = dt_cargos;


            MessageBox.Show("Los Datos Se Guardaron Correctamente");
        }

        private void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            txtIdCargo.Clear();
            txtNombreCargo.Clear();
            txtIdCargo.Focus();


        }

        private void txtIdCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txtNombreCargo.Focus();
        }

        private void btnBorrarCargo_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            oper.ConsultaSinResultado(" DELETE FROM cargos where id_cargo ='" + txtIdCargo.Text + "' ");
            txtIdCargo.Clear();
            txtNombreCargo.Clear();
            txtIdCargo.Focus();
            DataTable dt_cargos = oper.ConsultaConResultado(" SELECT  * FROM cargos ");
            dtgCargos.DataSource = dt_cargos;
            MessageBox.Show("Cargo Borrado");

        }

        private void btnBuscarCargo_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();


            DataTable dt_cargos = oper.ConsultaConResultado(" SELECT  * FROM cargos where id_cargo ='" + txtIdCargo.Text + "' ");
            foreach (DataRow dr in dt_cargos.Rows)
            {
                string id_cargo, nombre_cargo;
                id_cargo = dr["id_cargo"].ToString();
                nombre_cargo = dr["nombre_cargo"].ToString();
                txtIdCargo.Text = id_cargo;
                txtNombreCargo.Text = nombre_cargo;
                dtgCargos.DataSource = dt_cargos;
            }

               
        }

        private void lblIdCargo_Click(object sender, EventArgs e)
        {

        }

        private void FormCargo_Load(object sender, EventArgs e)
        {
            operacion oper = new operacion();
            DataTable dt_cargos = oper.ConsultaConResultado(" SELECT  * FROM cargos ");
            dtgCargos.DataSource = dt_cargos;
            return;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            operacion oper = new operacion();

            DataSet ds = new DataSet();

            DataTable dt = oper.ConsultaConResultado("SELECT * FROM cargos");
            ds.Tables.Add(dt);

            // crea el archivo XML en una la carpeta XML para los reporte 
            ds.WriteXml(@"C:\Users\leoni\Desktop\Programacion III\cargo.xml");

            ReporteCargos rp = new ReporteCargos("visordereporte.rpt");
            rp.Show();


        }
    }
}
