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
    public partial class Ciudad : System.Web.UI.Page
    {
        srv_Ciudad srv = new srv_Ciudad();
        srv_Pais srvp = new srv_Pais();
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarPaisAdd();
            LlenarPaisMod();
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Ciudad.DataSource = srv.ListarCiudad();
            gv_Ciudad.DataBind();
        }
        private void LlenarPaisMod()
        {
            ddl_Pais.DataSource = srvp.ListarPais();
            ddl_Pais.DataBind();
        }
        private void LlenarPaisAdd()
        {
            ddlpais.DataSource = srvp.ListarPais();
            ddlpais.DataBind();
        }
        public void BuscarCiudad()
        {
            Hashtable map = new Hashtable();
            if (txt_NombreCiudad.Text.Length != 0)
                map["Nombre"] = txt_NombreCiudad.Text;

            gv_Ciudad.DataSource = srv.FiltroCiudad(map);
            gv_Ciudad.DataBind();
        }
        public Datos.Modelo.Ciudad DatosAgregar()
        {
            Datos.Modelo.Ciudad obj = new Datos.Modelo.Ciudad();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.Id_Ciudad = id;
            obj.Nombre = txtnombre.Text;
            obj.Id_Pais = Convert.ToInt32(ddlpais.SelectedValue);

            return obj;
        }
        public Datos.Modelo.Ciudad DatosModificar()
        {
            Datos.Modelo.Ciudad obj = new Datos.Modelo.Ciudad();

            int id = 0; int.TryParse(txtIdciudad.Text, out id);
            obj.Id_Ciudad = id;
            obj.Nombre = txtNombreciudad.Text;
            obj.Id_Pais = Convert.ToInt32(ddl_Pais.SelectedValue);

            return obj;
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarCiudad();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.AgregarCiudad(DatosAgregar());
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
                srv.ModificarCiudad(DatosModificar());
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
                srv.EliminarCiudad(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }
    }
}