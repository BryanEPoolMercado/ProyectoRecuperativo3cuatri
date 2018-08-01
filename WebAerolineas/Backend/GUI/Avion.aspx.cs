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
    public partial class Avion : System.Web.UI.Page
    {
        srv_Avion srv = new srv_Avion();
        srv_Aerolinea srva = new srv_Aerolinea();
        srv_Modelo srvm = new srv_Modelo();
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarModeloMod();
            LlenarModeloAdd();
            LlenarAerolineaAdd();
            LlenarAerolineaMod();

            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Avion.DataSource = srv.ListarAvion();
            gv_Avion.DataBind();
        }
        private void LlenarAerolineaMod()
        {
            ddl_Aerolinea.DataSource = srva.ListarAerolinea();
            ddl_Aerolinea.DataBind();
        }
        private void LlenarModeloAdd()
        {
            ddlmodelo.DataSource = srvm.ListarModelo();
            ddlmodelo.DataBind();
        }
        private void LlenarModeloMod()
        {
            ddl_Modelo.DataSource = srvm.ListarModelo();
            ddl_Modelo.DataBind();
        }
        private void LlenarAerolineaAdd()
        {
            ddlaerolinea.DataSource = srva.ListarAerolinea();
            ddlaerolinea.DataBind();
        }
        public void BuscarAvion()
        {
            Hashtable map = new Hashtable();
            if (txt_BuscarAvion.Text.Length != 0)
                map["NombreModelo"] = txt_BuscarAvion.Text;

            gv_Avion.DataSource = srv.FiltroAvion(map);
            gv_Avion.DataBind();
        }
        public Datos.Modelo.Avion DatosAgregar()
        {
            Datos.Modelo.Avion obj = new Datos.Modelo.Avion();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.Id_Avion = id;
            obj.Id_Aerolinea = Convert.ToInt32(ddlaerolinea.SelectedValue);
            obj.IdModelo = Convert.ToInt32(ddlmodelo.SelectedValue);
            obj.NumeroPasajeros = Convert.ToInt32(txtnumpasajeros.Text);

            return obj;
        }
        public Datos.Modelo.Avion DatosModificar()
        {
            Datos.Modelo.Avion obj = new Datos.Modelo.Avion();

            int id = 0; int.TryParse(txt_IdAvion.Text, out id);
            obj.Id_Avion = id;
            obj.Id_Aerolinea = Convert.ToInt32(ddl_Aerolinea.SelectedValue);
            obj.IdModelo = Convert.ToInt32(ddl_Modelo.SelectedValue);
            obj.NumeroPasajeros = Convert.ToInt32(txt_NumPasajeros.Text);

            return obj;
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarAvion();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.AgregarAvion(DatosAgregar());
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
                srv.ActualizarAvion(DatosModificar());
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
                srv.EliminarAvion(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }
    }
}