using Datos.Entidades;
using Datos.Modelo;
using Datos.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAerolineas.GUI
{
    public partial class wfrm_CiudadEdit : System.Web.UI.Page
    {
        
        srv_Pais pais = new srv_Pais();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCombo();

            if (!IsPostBack)
            {
                if ((String)Session["operacion"] == "editando")
                {
                    preparaEdicion();                    
                    DatosInterface();
                }
                else
                {
                    preparaNuevo();                    
                }                
            }
        }
        private void CargarCombo()
        {
            ddl_Pais.DataSource = pais.ListarPais();
            ddl_Pais.DataBind();
        }
        public void DatosInterface()
        {
            Vista_Ciudad obj = (Vista_Ciudad)Session["oCiudad"];
            txt_ClaveCiudad.Text = Convert.ToString(obj.Id_Ciudad);
            txt_NombreCiudad.Text = obj.Nombre;
            ddl_Pais.SelectedValue = obj.NombrePais;

        }
        public void preparaNuevo()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = false;
            limpiar();
        }
        public void preparaEdicion()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = false;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = true;
            txt_ClaveCiudad.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClaveCiudad.Text = "";
            txt_NombreCiudad.Text = "";
            ddl_Pais.Text = "";
        }
        public Ciudad interfaceDatos()
        {
            Ciudad obj = new Ciudad();

            int id = 0; int.TryParse(txt_ClaveCiudad.Text, out id);
            obj.Id_Pais = id;
            obj.Nombre = txt_NombreCiudad.Text.Trim();
            obj.Id_Pais = Convert.ToInt32(ddl_Pais.SelectedValue);

            return obj;
        }
        
        protected void btn_Guardar_Click1(object sender, EventArgs e)
        {
            srv_Ciudad srv = new srv_Ciudad();
            if ((String)Session["operacion"] == "nuevo")
            {
                srv.AgregarCiudad(interfaceDatos());
                Response.Redirect("wfrm_Ciudad.aspx");
            }
            else
            {
                srv.ModificarCiudad(interfaceDatos());
                Response.Redirect("wfrm_Ciudad.aspx");
            }
        }

        protected void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv_Ciudad srv = new srv_Ciudad();
            srv.AgregarCiudad(interfaceDatos());
            limpiar();
        }

        protected void btn_Eliminar_Click1(object sender, EventArgs e)
        {
            srv_Ciudad srv = new srv_Ciudad();
            srv.EliminarCiudad((Ciudad)Session["oCiudad"]);
            Response.Redirect("wfrm_Ciudad.aspx");
        }

        protected void btn_Cancelar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("wfrm_Ciudad.aspx");
        }
    }
}