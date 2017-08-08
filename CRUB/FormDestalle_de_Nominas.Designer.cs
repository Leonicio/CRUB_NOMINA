namespace CRUB
{
    partial class FormDestalle_de_Nominas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardarDetalleN = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgDestalleNomina = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDestalleNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Leer Nomina";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardarDetalleN
            // 
            this.btnGuardarDetalleN.Location = new System.Drawing.Point(192, 16);
            this.btnGuardarDetalleN.Name = "btnGuardarDetalleN";
            this.btnGuardarDetalleN.Size = new System.Drawing.Size(138, 40);
            this.btnGuardarDetalleN.TabIndex = 3;
            this.btnGuardarDetalleN.Text = "Guardar Destalle Nom";
            this.btnGuardarDetalleN.UseVisualStyleBackColor = true;
            this.btnGuardarDetalleN.Click += new System.EventHandler(this.btnGuardarDetalleN_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(800, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 27);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgDestalleNomina
            // 
            this.dtgDestalleNomina.AllowUserToDeleteRows = false;
            this.dtgDestalleNomina.AllowUserToOrderColumns = true;
            this.dtgDestalleNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDestalleNomina.Location = new System.Drawing.Point(12, 62);
            this.dtgDestalleNomina.Name = "dtgDestalleNomina";
            this.dtgDestalleNomina.Size = new System.Drawing.Size(923, 304);
            this.dtgDestalleNomina.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Borrar Nomina";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(529, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(138, 40);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FormDestalle_de_Nominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 479);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarDetalleN);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtgDestalleNomina);
            this.Name = "FormDestalle_de_Nominas";
            this.Text = "FormDestalle_de_Nominas";
            this.Load += new System.EventHandler(this.FormDestalle_de_Nominas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDestalleNomina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardarDetalleN;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgDestalleNomina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImprimir;
    }
}