namespace CRUB
{
    partial class FormCargo
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
            this.lblIdCargo = new System.Windows.Forms.Label();
            this.lblNombreCargo = new System.Windows.Forms.Label();
            this.txtIdCargo = new System.Windows.Forms.TextBox();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCrearNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrarCargo = new System.Windows.Forms.Button();
            this.btnBuscarCargo = new System.Windows.Forms.Button();
            this.dtgCargos = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCargo
            // 
            this.lblIdCargo.AutoSize = true;
            this.lblIdCargo.Location = new System.Drawing.Point(17, 42);
            this.lblIdCargo.Name = "lblIdCargo";
            this.lblIdCargo.Size = new System.Drawing.Size(67, 18);
            this.lblIdCargo.TabIndex = 0;
            this.lblIdCargo.Text = "ID Cargo";
            this.lblIdCargo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblIdCargo.Click += new System.EventHandler(this.lblIdCargo_Click);
            // 
            // lblNombreCargo
            // 
            this.lblNombreCargo.AutoSize = true;
            this.lblNombreCargo.Location = new System.Drawing.Point(205, 42);
            this.lblNombreCargo.Name = "lblNombreCargo";
            this.lblNombreCargo.Size = new System.Drawing.Size(98, 18);
            this.lblNombreCargo.TabIndex = 1;
            this.lblNombreCargo.Text = "Nombre Cargo";
            // 
            // txtIdCargo
            // 
            this.txtIdCargo.Location = new System.Drawing.Point(99, 33);
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.Size = new System.Drawing.Size(88, 26);
            this.txtIdCargo.TabIndex = 2;
            this.txtIdCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCargo_KeyPress);
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.Location = new System.Drawing.Point(309, 34);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(191, 26);
            this.txtNombreCargo.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(46, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 35);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar Nuevo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCrearNuevo
            // 
            this.btnCrearNuevo.Location = new System.Drawing.Point(242, 122);
            this.btnCrearNuevo.Name = "btnCrearNuevo";
            this.btnCrearNuevo.Size = new System.Drawing.Size(87, 35);
            this.btnCrearNuevo.TabIndex = 5;
            this.btnCrearNuevo.Text = "Crear Nuevo";
            this.btnCrearNuevo.UseVisualStyleBackColor = true;
            this.btnCrearNuevo.Click += new System.EventHandler(this.btnCrearNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalir.Location = new System.Drawing.Point(456, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 24);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreCargo);
            this.groupBox1.Controls.Add(this.lblNombreCargo);
            this.groupBox1.Controls.Add(this.txtIdCargo);
            this.groupBox1.Controls.Add(this.lblIdCargo);
            this.groupBox1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cargos";
            // 
            // btnBorrarCargo
            // 
            this.btnBorrarCargo.Location = new System.Drawing.Point(345, 120);
            this.btnBorrarCargo.Name = "btnBorrarCargo";
            this.btnBorrarCargo.Size = new System.Drawing.Size(94, 35);
            this.btnBorrarCargo.TabIndex = 8;
            this.btnBorrarCargo.Text = "Borrar Cargo";
            this.btnBorrarCargo.UseVisualStyleBackColor = true;
            this.btnBorrarCargo.Click += new System.EventHandler(this.btnBorrarCargo_Click);
            // 
            // btnBuscarCargo
            // 
            this.btnBuscarCargo.Location = new System.Drawing.Point(152, 122);
            this.btnBuscarCargo.Name = "btnBuscarCargo";
            this.btnBuscarCargo.Size = new System.Drawing.Size(84, 35);
            this.btnBuscarCargo.TabIndex = 9;
            this.btnBuscarCargo.Text = "Buscar";
            this.btnBuscarCargo.UseVisualStyleBackColor = true;
            this.btnBuscarCargo.Click += new System.EventHandler(this.btnBuscarCargo_Click);
            // 
            // dtgCargos
            // 
            this.dtgCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCargos.Location = new System.Drawing.Point(46, 175);
            this.dtgCargos.Name = "dtgCargos";
            this.dtgCargos.Size = new System.Drawing.Size(506, 228);
            this.dtgCargos.TabIndex = 10;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(456, 122);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(96, 35);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FormCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 433);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtgCargos);
            this.Controls.Add(this.btnBuscarCargo);
            this.Controls.Add(this.btnBorrarCargo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCargo";
            this.Text = "FormCargo";
            this.Load += new System.EventHandler(this.FormCargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdCargo;
        private System.Windows.Forms.Label lblNombreCargo;
        private System.Windows.Forms.TextBox txtIdCargo;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCrearNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrarCargo;
        private System.Windows.Forms.Button btnBuscarCargo;
        private System.Windows.Forms.DataGridView dtgCargos;
        private System.Windows.Forms.Button btnImprimir;
    }
}