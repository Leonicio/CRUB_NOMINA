namespace ReporteCargo
{
    partial class ReportCargo
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
            this.reporteCargo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reporteCargo
            // 
            this.reporteCargo.ActiveViewIndex = -1;
            this.reporteCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporteCargo.Cursor = System.Windows.Forms.Cursors.Default;
            this.reporteCargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteCargo.Location = new System.Drawing.Point(0, 0);
            this.reporteCargo.Name = "reporteCargo";
            this.reporteCargo.Size = new System.Drawing.Size(750, 261);
            this.reporteCargo.TabIndex = 0;
            this.reporteCargo.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReportCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 261);
            this.Controls.Add(this.reporteCargo);
            this.Name = "ReportCargo";
            this.Text = "Reporte cargos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reporteCargo;
    }
}

