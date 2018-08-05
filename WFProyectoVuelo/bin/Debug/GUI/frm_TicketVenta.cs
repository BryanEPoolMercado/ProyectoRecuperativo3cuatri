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
        srv_Compra compra = new srv_Compra();
        public Reportes.Datos dt = new Reportes.Datos();
        public frm_TicketVenta()
        {
            InitializeComponent();

            Contendor_Reporte.Reset();
            Contendor_Reporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

           
          
        }

        private void frm_TicketVenta_Load(object sender, EventArgs e)
        {

            this.Contendor_Reporte.RefreshReport();           
        }
    }
}
