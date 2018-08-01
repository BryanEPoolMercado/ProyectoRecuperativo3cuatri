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
    public partial class Pais : System.Web.UI.Page
    {
        srv_Pais srv = new srv_Pais();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void BuscarPais()
        {
            Hashtable map = new Hashtable();
            if (txt_NombrePais.Text.Length != 0)
                map["Nombre"] = txt_NombrePais.Text;

            gv_Pais.DataSource = srv.ListarPais(map);
            gv_Pais.DataBind();
        }
        public Datos.Modelo.Pais DatosAgregar()
        {
            Datos.Modelo.Pais obj = new Datos.Modelo.Pais();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.Id_Pais = id;
            obj.Nombre = txtnombre.Text;

            return obj;
        }
        public Datos.Modelo.Pais DatosModificar()
        {
            Datos.Modelo.Pais obj = new Datos.Modelo.Pais();

            int id = 0; int.TryParse(txtIdpais.Text, out id);
            obj.Id_Pais = id;
            obj.Nombre = txtNombrepais.Text;

            return obj;
        }
        public void Listar()
        {
            gv_Pais.DataSource = srv.ListarPais();
            gv_Pais.DataBind();
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.ActualizarPais(DatosModificar());
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
                srv.EliminarPais(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.AgregarPais(DatosAgregar());
                Listar();
            }
            catch (Exception)
            {

            }
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarPais();
        }
    }
}