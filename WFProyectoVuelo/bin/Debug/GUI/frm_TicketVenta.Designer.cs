namespace WFProyectoVuelo.GUI
{
    partial class frm_TicketVenta
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
            this.Contendor_Reporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Contendor_Reporte
            // 
            this.Contendor_Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contendor_Reporte.Location = new System.Drawing.Point(0, 0);
            this.Contendor_Reporte.Name = "Contendor_Reporte";
            this.Contendor_Reporte.ServerReport.BearerToken = null;
            this.Contendor_Reporte.Size = new System.Drawing.Size(793, 635);
            this.Contendor_Reporte.TabIndex = 0;
            // 
            // frm_TicketVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 635);
            this.Controls.Add(this.Contendor_Reporte);
            this.Name = "frm_TicketVenta";
            this.Text = "frm_TicketVenta";
            this.Load += new System.EventHandler(this.frm_TicketVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Contendor_Reporte;
    }
}