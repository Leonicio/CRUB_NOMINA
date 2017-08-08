namespace CRUB
{
    partial class ReporteDeEmpleado
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
            this.crystalReportViewerEmpleado = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerEmpleado
            // 
            this.crystalReportViewerEmpleado.ActiveViewIndex = -1;
            this.crystalReportViewerEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerEmpleado.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerEmpleado.Name = "crystalReportViewerEmpleado";
            this.crystalReportViewerEmpleado.Size = new System.Drawing.Size(1037, 434);
            this.crystalReportViewerEmpleado.TabIndex = 0;
            this.crystalReportViewerEmpleado.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReporteDeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 434);
            this.Controls.Add(this.crystalReportViewerEmpleado);
            this.Name = "ReporteDeEmpleado";
            this.Text = "ReporteDeEmpleado";
            this.Load += new System.EventHandler(this.ReporteDeEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerEmpleado;
    }
}