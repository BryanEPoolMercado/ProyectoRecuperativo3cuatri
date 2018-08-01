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
    public partial class Aeropuerto : System.Web.UI.Page
    {
        srv_Aeropuerto srv = new srv_Aeropuerto();
        srv_Ciudad srvc = new srv_Ciudad();
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarCiudadAdd();
            LlenarCiudadMod();
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Aeropuerto.DataSource = srv.getListAeropuerto();
            gv_Aeropuerto.DataBind();
        }
        private void LlenarCiudadMod()
        {
            ddl_Ciudad.DataSource = srvc.ListaCiudad();
            ddl_Ciudad.DataBind();
        }
        private void LlenarCiudadAdd()
        {
            ddlciudad.DataSource = srvc.ListaCiudad();
            ddlciudad.DataBind();
        }
        public void BuscarAeropuerto()
        {
            Hashtable map = new Hashtable();
            if (txt_BuscarAeropuerto.Text.Length != 0)
                map["Nombre"] = txt_BuscarAeropuerto.Text;

            gv_Aeropuerto.DataSource = srv.getListAeropuerto(map);
            gv_Aeropuerto.DataBind();
        }
        public Datos.Modelo.Aeropuerto DatosAgregar()
        {
            Datos.Modelo.Aeropuerto obj = new Datos.Modelo.Aeropuerto();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.Id_Aeropuerto = id;
            obj.Nombre = txtnombre.Text;
            obj.Id_Ciudad = Convert.ToInt32(ddlciudad.SelectedValue);

            return obj;
        }
        public Datos.Modelo.Aeropuerto DatosModificar()
        {
            Datos.Modelo.Aeropuerto obj = new Datos.Modelo.Aeropuerto();

            int id = 0; int.TryParse(txt_IdAeropuerto.Text, out id);
            obj.Id_Aeropuerto = id;
            obj.Nombre = txt_NombreAeropuerto.Text;
            obj.Id_Ciudad = Convert.ToInt32(ddl_Ciudad.SelectedValue);

            return obj;
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarAeropuerto();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.addAeropuerto(DatosAgregar());
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
                srv.updateAeropuerto(DatosModificar());
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
                srv.deleteAeropuerto(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }
    }
}