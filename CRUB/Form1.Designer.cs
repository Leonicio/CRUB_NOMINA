﻿namespace CRUB
{
    partial class Formbusqueda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnImprimir1 = new System.Windows.Forms.Button();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.rdbApellido = new System.Windows.Forms.RadioButton();
            this.rdbCedula = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(537, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 34);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(329, 26);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(186, 20);
            this.txtBuscador.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(720, 12);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 34);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImprimir1
            // 
            this.btnImprimir1.Location = new System.Drawing.Point(628, 12);
            this.btnImprimir1.Name = "btnImprimir1";
            this.btnImprimir1.Size = new System.Drawing.Size(75, 34);
            this.btnImprimir1.TabIndex = 5;
            this.btnImprimir1.Text = "Imprimir";
            this.btnImprimir1.UseVisualStyleBackColor = true;
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(76, 29);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(34, 17);
            this.rdbid.TabIndex = 10;
            this.rdbid.TabStop = true;
            this.rdbid.Text = "Id";
            this.rdbid.UseVisualStyleBackColor = true;
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Location = new System.Drawing.Point(116, 29);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 11;
            this.rdbnombre.TabStop = true;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // rdbApellido
            // 
            this.rdbApellido.AutoSize = true;
            this.rdbApellido.Location = new System.Drawing.Point(184, 29);
            this.rdbApellido.Name = "rdbApellido";
            this.rdbApellido.Size = new System.Drawing.Size(62, 17);
            this.rdbApellido.TabIndex = 12;
            this.rdbApellido.TabStop = true;
            this.rdbApellido.Text = "Apellido";
            this.rdbApellido.UseVisualStyleBackColor = true;
            // 
            // rdbCedula
            // 
            this.rdbCedula.AutoSize = true;
            this.rdbCedula.Location = new System.Drawing.Point(252, 29);
            this.rdbCedula.Name = "rdbCedula";
            this.rdbCedula.Size = new System.Drawing.Size(58, 17);
            this.rdbCedula.TabIndex = 13;
            this.rdbCedula.TabStop = true;
            this.rdbCedula.Text = "Cedula";
            this.rdbCedula.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(814, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(12, 63);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(949, 355);
            this.dgvEmpleado.TabIndex = 16;
            this.dgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellContentClick);
            this.dgvEmpleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleado_CellMouseClick);
            // 
            // Formbusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 449);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdbCedula);
            this.Controls.Add(this.rdbApellido);
            this.Controls.Add(this.rdbnombre);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.btnImprimir1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnbuscar);
            this.Name = "Formbusqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Formbusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnImprimir1;
        private System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.RadioButton rdbnombre;
        private System.Windows.Forms.RadioButton rdbApellido;
        private System.Windows.Forms.RadioButton rdbCedula;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvEmpleado;
    }
}

