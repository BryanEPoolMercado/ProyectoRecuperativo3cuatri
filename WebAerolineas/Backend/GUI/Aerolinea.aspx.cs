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
    public partial class Aerolinea : System.Web.UI.Page
    {
        srv_Aerolinea srv = new srv_Aerolinea();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Aerolinea.DataSource = srv.ListarAerolinea();
            gv_Aerolinea.DataBind();
        }
        public void BuscarAerolinea()
        {
            Hashtable map = new Hashtable();
            if (txt_Nombreaerolinea.Text.Length != 0)
                map["Nombre"] = txt_Nombreaerolinea.Text;

            gv_Aerolinea.DataSource = srv.FiltroAerolinea(map);
            gv_Aerolinea.DataBind();
        }
        public Datos.Modelo.Aerolinea DatosAgregar()
        {
            Datos.Modelo.Aerolinea obj = new Datos.Modelo.Aerolinea();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.Id_Aerolinea = id;
            obj.Nombre = txtnombre.Text;

            return obj;
        }
        public Datos.Modelo.Aerolinea DatosModificar()
        {
            Datos.Modelo.Aerolinea obj = new Datos.Modelo.Aerolinea();

            int id = 0; int.TryParse(txtIdaerolinea.Text, out id);
            obj.Id_Aerolinea = id;
            obj.Nombre = txtNombreaerolinea.Text;

            return obj;
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarAerolinea();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.AgregarAerolinea(DatosAgregar());
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
                srv.ActualizarAerolinea(DatosModificar());
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
                srv.EliminarAerolinea(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }
    }
}