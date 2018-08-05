using Datos.Entidades;
using Datos.Servicios;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFProyectoVuelo.Reportes;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_TicketVenta : Form
    {
        srv_DetalleCompra detcom = new srv_DetalleCompra();
        public Reportes.Datos dt = new Reportes.Datos();
        public frm_TicketVenta(int idcomp)
        {
            InitializeComponent();

            Contenedor_Reporte.Reset();
            Contenedor_Reporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            Hashtable map = new Hashtable();
            map["Id_Compra"] = idcomp;

            DataSet datos = detcom.MostrarTicket(map);
            DataTable dt = datos.Tables[0];

            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("Datos", dt);
            Contenedor_Reporte.LocalReport.DataSources.Add(rds);

            Contenedor_Reporte.LocalReport.ReportEmbeddedResource = "WFProyectoVuelo.Reportes.RepVuelos.rdlc";

            Contenedor_Reporte.RefreshReport();

        }

        private void frm_TicketVenta_Load(object sender, EventArgs e)
        {

            this.Contenedor_Reporte.RefreshReport();
         
        }
    }
}
