using Datos.Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAerolineas.Frontend.GUI
{
    public partial class BuscarVuelos : System.Web.UI.Page
    {
        srv_Aeropuerto srva = new srv_Aeropuerto();
        srv_Vuelos srvvuelos = new srv_Vuelos();
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime fechahoy = DateTime.Now;
            string fecha = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fechahoy));
            label2.Text = Convert.ToString((fecha));
           
            LlenarOrigen();
            LlenarDestino();

            if (!IsPostBack)
            {

            }
            Listar();
        }
        
        public void Listar()
        {
            gv_Vuelos.AutoGenerateColumns = false;
            gv_Vuelos.DataSource = srvvuelos.VuelosWeb();
        }
        private void LlenarOrigen()
        {
            ddl_origen.DataSource = srva.ListarAeropuerto();
            ddl_origen.DataBind();
        }       
        private void LlenarDestino()
        {
            ddl_destino.DataSource = srva.ListarAeropuerto();
            ddl_destino.DataBind();
        }
        public void BuscarRuta()
        {
            Hashtable map = new Hashtable();
            if (this.ddl_origen.SelectedValue.ToString().CompareTo("") != 0)
                map["Id_Ruta"] = this.ddl_origen.SelectedValue.ToString();
            if (this.ddl_destino.SelectedValue.ToString().CompareTo("") != 0)
                map["Id_RutaD"] = this.ddl_destino.SelectedValue.ToString();
            map["Fecha"] = label2.Text;

            gv_Vuelos.AutoGenerateColumns = false;
            gv_Vuelos.DataSource = srvvuelos.FiltrarListaVuelo(map);
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarRuta();
        }
    }
}