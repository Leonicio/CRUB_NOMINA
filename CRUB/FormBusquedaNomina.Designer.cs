namespace CRUB
{
    partial class FormBusquedaNomina
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
            this.btnBuscarNomina = new System.Windows.Forms.Button();
            this.txtBusqNomina = new System.Windows.Forms.TextBox();
            this.btnImprimirNomina = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgBusquedaCabeceraN = new System.Windows.Forms.DataGridView();
            this.dtgBusNomina = new System.Windows.Forms.DataGridView();
            this.txtTotalDeduciones = new System.Windows.Forms.TextBox();
            this.txtTotalNominas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusquedaCabeceraN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarNomina
            // 
            this.btnBuscarNomina.Location = new System.Drawing.Point(503, 11);
            this.btnBuscarNomina.Name = "btnBuscarNomina";
            this.btnBuscarNomina.Size = new System.Drawing.Size(87, 29);
            this.btnBuscarNomina.TabIndex = 0;
            this.btnBuscarNomina.Text = "Buscar";
            this.btnBuscarNomina.UseVisualStyleBackColor = true;
            this.btnBuscarNomina.Click += new System.EventHandler(this.btnBuscarNomina_Click);
            // 
            // txtBusqNomina
            // 
            this.txtBusqNomina.Location = new System.Drawing.Point(311, 20);
            this.txtBusqNomina.Name = "txtBusqNomina";
            this.txtBusqNomina.Size = new System.Drawing.Size(169, 20);
            this.txtBusqNomina.TabIndex = 2;
            // 
            // btnImprimirNomina
            // 
            this.btnImprimirNomina.Location = new System.Drawing.Point(596, 11);
            this.btnImprimirNomina.Name = "btnImprimirNomina";
            this.btnImprimirNomina.Size = new System.Drawing.Size(87, 29);
            this.btnImprimirNomina.TabIndex = 5;
            this.btnImprimirNomina.Text = "Imprimir";
            this.btnImprimirNomina.UseVisualStyleBackColor = true;
            this.btnImprimirNomina.Click += new System.EventHandler(this.btnImprimirNomina_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(702, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 29);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgBusquedaCabeceraN
            // 
            this.dtgBusquedaCabeceraN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBusquedaCabeceraN.Location = new System.Drawing.Point(98, 58);
            this.dtgBusquedaCabeceraN.Name = "dtgBusquedaCabeceraN";
            this.dtgBusquedaCabeceraN.Size = new System.Drawing.Size(616, 132);
            this.dtgBusquedaCabeceraN.TabIndex = 7;
            // 
            // dtgBusNomina
            // 
            this.dtgBusNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBusNomina.Location = new System.Drawing.Point(12, 196);
            this.dtgBusNomina.Name = "dtgBusNomina";
            this.dtgBusNomina.Size = new System.Drawing.Size(777, 199);
            this.dtgBusNomina.TabIndex = 8;
            // 
            // txtTotalDeduciones
            // 
            this.txtTotalDeduciones.Location = new System.Drawing.Point(394, 428);
            this.txtTotalDeduciones.Name = "txtTotalDeduciones";
            this.txtTotalDeduciones.Size = new System.Drawing.Size(169, 20);
            this.txtTotalDeduciones.TabIndex = 9;
            // 
            // txtTotalNominas
            // 
            this.txtTotalNominas.Location = new System.Drawing.Point(596, 428);
            this.txtTotalNominas.Name = "txtTotalNominas";
            this.txtTotalNominas.Size = new System.Drawing.Size(169, 20);
            this.txtTotalNominas.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Deduciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Nominas";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(270, 419);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 29);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dijite Numero de Nomina";
            // 
            // FormBusquedaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalNominas);
            this.Controls.Add(this.txtTotalDeduciones);
            this.Controls.Add(this.dtgBusNomina);
            this.Controls.Add(this.dtgBusquedaCabeceraN);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimirNomina);
            this.Controls.Add(this.txtBusqNomina);
            this.Controls.Add(this.btnBuscarNomina);
            this.Name = "FormBusquedaNomina";
            this.Text = "FormBusquedaNomina";
            this.Load += new System.EventHandler(this.FormBusquedaNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusquedaCabeceraN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBusNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarNomina;
        private System.Windows.Forms.TextBox txtBusqNomina;
        private System.Windows.Forms.Button btnImprimirNomina;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgBusquedaCabeceraN;
        private System.Windows.Forms.DataGridView dtgBusNomina;
        private System.Windows.Forms.TextBox txtTotalDeduciones;
        private System.Windows.Forms.TextBox txtTotalNominas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
    }
}