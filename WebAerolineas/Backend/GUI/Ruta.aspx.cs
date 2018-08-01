using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Modelo;
using Datos.Servicios;

namespace WebAerolineas.Backend.GUI
{
    public partial class Ruta : System.Web.UI.Page
    {
        srv_Ruta srv = new srv_Ruta();
        srv_Aeropuerto srva = new srv_Aeropuerto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Ruta.DataSource = srv.ListarRuta();
            gv_Ruta.DataBind();
        }
        private void LlenarOrigenMod()
        {
            ddl_AeropuertoOrigen.DataSource = srva.ListarAeropuerto();
            ddl_AeropuertoOrigen.DataBind();
        }
        private void LlenarOrigenAdd()
        {
            ddlorigen.DataSource = srva.ListarAeropuerto();
            ddlorigen.DataBind();
        }
        private void LlenarDestinoMod()
        {
            ddl_AeropuertoDestino.DataSource = srva.ListarAeropuerto();
            ddl_AeropuertoDestino.DataBind();
        }
        private void LlenarDestinoAdd()
        {
            ddldestino.DataSource = srva.ListarAeropuerto();
            ddldestino.DataBind();
        }
        public void BuscarRuta()
        {
            Hashtable map = new Hashtable();
            if (txt_BuscarOrigen.Text.Length != 0)
                map["NombreModelo"] = txt_BuscarOrigen.Text;
            if (txt_BuscarDestino.Text.Length != 0)
                map["NombreModelo"] = txt_BuscarDestino.Text;

            gv_Ruta.DataSource = srv.getListRutaP(map);
            gv_Ruta.DataBind();
        }
        public Datos.Modelo.Ruta DatosAgregar()
        {
            Datos.Modelo.Ruta obj = new Datos.Modelo.Ruta();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.Id_Ruta = id;
            obj.Origen_Aeropuerto = Convert.ToInt32(ddlorigen.SelectedValue);
            obj.Destino_Aeropuerto = Convert.ToInt32(ddldestino.SelectedValue);
            obj.Distancia = txtdistancia.Text;

            return obj;
        }
        public Datos.Modelo.Ruta DatosModificar()
        {
            Datos.Modelo.Ruta obj = new Datos.Modelo.Ruta();

            int id = 0; int.TryParse(txt_IdRuta.Text, out id);
            obj.Id_Ruta = id;
            obj.Origen_Aeropuerto = Convert.ToInt32(ddl_AeropuertoOrigen.SelectedValue);
            obj.Destino_Aeropuerto = Convert.ToInt32(ddl_AeropuertoDestino.SelectedValue);
            obj.Distancia = txt_Distancia.Text;

            return obj;
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarRuta();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.addRuta(DatosAgregar());
                Listar();
            }
            catch (Exception)
            {

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.updateRuta(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.deleteRuta(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }
    }
}