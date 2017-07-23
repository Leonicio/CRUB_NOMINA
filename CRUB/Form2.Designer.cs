namespace CRUB
{
    partial class FormEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtCal_edad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.txt_id_Empleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btncalcular_edad = new System.Windows.Forms.Button();
            this.btnCalcular_antiguedad = new System.Windows.Forms.Button();
            this.btncrear2 = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcalcularAntig = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtb_cadula = new System.Windows.Forms.MaskedTextBox();
            this.mtbFecha_ingreso = new System.Windows.Forms.MaskedTextBox();
            this.mtbFecha_nac = new System.Windows.Forms.MaskedTextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txt_Sexo = new System.Windows.Forms.TextBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(20, 130);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 2;
            this.lblsexo.Text = "Sexo";
            // 
            // txtCal_edad
            // 
            this.txtCal_edad.Location = new System.Drawing.Point(90, 18);
            this.txtCal_edad.Name = "txtCal_edad";
            this.txtCal_edad.Size = new System.Drawing.Size(167, 20);
            this.txtCal_edad.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(141, 42);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(169, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(169, 20);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de Ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salario :";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(141, 24);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(116, 20);
            this.txtsalario.TabIndex = 21;
            this.txtsalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalario_KeyPress);
            // 
            // txt_id_Empleado
            // 
            this.txt_id_Empleado.Location = new System.Drawing.Point(141, 13);
            this.txt_id_Empleado.Name = "txt_id_Empleado";
            this.txt_id_Empleado.Size = new System.Drawing.Size(116, 20);
            this.txt_id_Empleado.TabIndex = 22;
            this.txt_id_Empleado.TextChanged += new System.EventHandler(this.txt_id_Empleado_TextChanged);
            this.txt_id_Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_Empleado_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Fotografía";
            // 
            // btncalcular_edad
            // 
            this.btncalcular_edad.Location = new System.Drawing.Point(275, 355);
            this.btncalcular_edad.Name = "btncalcular_edad";
            this.btncalcular_edad.Size = new System.Drawing.Size(150, 23);
            this.btncalcular_edad.TabIndex = 25;
            this.btncalcular_edad.Text = "Calcular Edad";
            this.btncalcular_edad.UseVisualStyleBackColor = true;
            this.btncalcular_edad.Click += new System.EventHandler(this.btncalcular_edad_Click);
            // 
            // btnCalcular_antiguedad
            // 
            this.btnCalcular_antiguedad.Location = new System.Drawing.Point(275, 393);
            this.btnCalcular_antiguedad.Name = "btnCalcular_antiguedad";
            this.btnCalcular_antiguedad.Size = new System.Drawing.Size(150, 23);
            this.btnCalcular_antiguedad.TabIndex = 26;
            this.btnCalcular_antiguedad.Text = "Calcular Antiguedad";
            this.btnCalcular_antiguedad.UseVisualStyleBackColor = true;
            this.btnCalcular_antiguedad.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncrear2
            // 
            this.btncrear2.Location = new System.Drawing.Point(104, 443);
            this.btncrear2.Name = "btncrear2";
            this.btncrear2.Size = new System.Drawing.Size(87, 34);
            this.btncrear2.TabIndex = 27;
            this.btncrear2.Text = "Crear Nuevo";
            this.btncrear2.UseVisualStyleBackColor = true;
            this.btncrear2.Click += new System.EventHandler(this.btncrear2_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(12, 443);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(87, 34);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(198, 443);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(82, 34);
            this.btnborrar.TabIndex = 29;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(286, 443);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(87, 34);
            this.btnimprimir.TabIndex = 30;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Id Cargo";
            // 
            // txtcalcularAntig
            // 
            this.txtcalcularAntig.Location = new System.Drawing.Point(102, 393);
            this.txtcalcularAntig.Name = "txtcalcularAntig";
            this.txtcalcularAntig.Size = new System.Drawing.Size(167, 20);
            this.txtcalcularAntig.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnBuscar2);
            this.groupBox1.Controls.Add(this.txt_Sexo);
            this.groupBox1.Controls.Add(this.mtb_cadula);
            this.groupBox1.Controls.Add(this.mtbFecha_ingreso);
            this.groupBox1.Controls.Add(this.mtbFecha_nac);
            this.groupBox1.Controls.Add(this.txtcargo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_id_Empleado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblsexo);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 246);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // mtb_cadula
            // 
            this.mtb_cadula.Location = new System.Drawing.Point(141, 96);
            this.mtb_cadula.Mask = "000-0000000-0";
            this.mtb_cadula.Name = "mtb_cadula";
            this.mtb_cadula.Size = new System.Drawing.Size(169, 20);
            this.mtb_cadula.TabIndex = 42;
            this.mtb_cadula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtb_cadula_KeyPress);
            // 
            // mtbFecha_ingreso
            // 
            this.mtbFecha_ingreso.Location = new System.Drawing.Point(141, 176);
            this.mtbFecha_ingreso.Mask = "00/00/0000";
            this.mtbFecha_ingreso.Name = "mtbFecha_ingreso";
            this.mtbFecha_ingreso.Size = new System.Drawing.Size(116, 20);
            this.mtbFecha_ingreso.TabIndex = 40;
            this.mtbFecha_ingreso.ValidatingType = typeof(System.DateTime);
            this.mtbFecha_ingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbFecha_ingreso_KeyPress);
            // 
            // mtbFecha_nac
            // 
            this.mtbFecha_nac.Location = new System.Drawing.Point(141, 150);
            this.mtbFecha_nac.Mask = "00/00/0000";
            this.mtbFecha_nac.Name = "mtbFecha_nac";
            this.mtbFecha_nac.Size = new System.Drawing.Size(116, 20);
            this.mtbFecha_nac.TabIndex = 39;
            this.mtbFecha_nac.ValidatingType = typeof(System.DateTime);
            this.mtbFecha_nac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbFecha_nac_KeyPress);
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(141, 202);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(116, 20);
            this.txtcargo.TabIndex = 38;
            this.txtcargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcargo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Cedula";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRUB.Properties.Resources._02512;
            this.pictureBox1.Location = new System.Drawing.Point(338, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsalario);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 57);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salarios";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCal_edad);
            this.groupBox3.Location = new System.Drawing.Point(12, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 92);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculos";
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Location = new System.Drawing.Point(392, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 34);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txt_Sexo
            // 
            this.txt_Sexo.Location = new System.Drawing.Point(141, 123);
            this.txt_Sexo.Name = "txt_Sexo";
            this.txt_Sexo.Size = new System.Drawing.Size(169, 20);
            this.txt_Sexo.TabIndex = 43;
            this.txt_Sexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sexo_KeyPress);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(263, 13);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(85, 21);
            this.btnBuscar2.TabIndex = 37;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(357, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(85, 21);
            this.btnActualizar.TabIndex = 44;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 514);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtcalcularAntig);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear2);
            this.Controls.Add(this.btnCalcular_antiguedad);
            this.Controls.Add(this.btncalcular_edad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormEmpleado";
            this.Text = "Empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtCal_edad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.TextBox txt_id_Empleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncalcular_edad;
        private System.Windows.Forms.Button btnCalcular_antiguedad;
        private System.Windows.Forms.Button btncrear2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcalcularAntig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mtbFecha_ingreso;
        private System.Windows.Forms.MaskedTextBox mtbFecha_nac;
        private System.Windows.Forms.MaskedTextBox mtb_cadula;
        private System.Windows.Forms.TextBox txt_Sexo;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button btnActualizar;
    }
}