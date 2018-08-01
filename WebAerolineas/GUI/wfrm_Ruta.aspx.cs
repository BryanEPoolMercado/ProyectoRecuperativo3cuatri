using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Entidades;
using Datos.Modelo;
using Datos.Servicios;

namespace WebAerolineas.GUI
{
    public partial class wfrm_Ruta : System.Web.UI.Page
    {
        srv_Ruta srv = new srv_Ruta();
        srv_Aeropuerto aero = new srv_Aeropuerto();
        protected void Page_Load(object sender, EventArgs e)
        {
            AeropuertoOrigen();
            AeropuertoDestino();
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            Hashtable map = new Hashtable();
            gv_Ruta.DataSource = srv.getListRutaP(map);
            gv_Ruta.DataBind();
        }
        private void AeropuertoOrigen()
        {
            ddl_Origen.DataSource = aero.ListarAeropuerto();
            ddl_Origen.DataBind();
        }
        private void AeropuertoDestino()
        {
            ddl_Destino.DataSource = aero.ListarAeropuerto();
            ddl_Destino.DataBind();
        }
        public void BuscarRuta()
        {
            Hashtable map = new Hashtable();
            if (this.ddl_Origen.SelectedValue.ToString().CompareTo("") != 0)
                map["Origen_Aeropuerto"] = this.ddl_Origen.SelectedValue;

            if (this.ddl_Destino.SelectedValue.ToString().CompareTo("") != 0)
                map["Destino_Aeropuerto"] = this.ddl_Destino.SelectedValue;


            gv_Ruta.DataSource = srv.getListRutaP(map);
            gv_Ruta.DataBind();
        }

        protected void btn_BuscarRuta_Click(object sender, EventArgs e)
        {
            BuscarRuta();
        }
    }
}