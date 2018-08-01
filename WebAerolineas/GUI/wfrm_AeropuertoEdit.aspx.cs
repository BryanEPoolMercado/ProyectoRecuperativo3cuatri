using System;
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
    public partial class AeropuertoEdit : System.Web.UI.Page
    {
        srv_Ciudad srv = new srv_Ciudad();
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
            ddl_Ciudad.DataSource = srv.ListarCiudad();
            ddl_Ciudad.DataBind();
        }
        public void DatosInterface()
        {
            Vista_Aeropuerto obj = (Vista_Aeropuerto)Session["oAeropuerto"];
            txt_ClaveAeropuerto.Text = Convert.ToString(obj.Id_Aeropuerto);
            txt_NombreAeropuerto.Text = obj.Nombre;
            ddl_Ciudad.SelectedValue = obj.Ciudad;
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
            txt_ClaveAeropuerto.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClaveAeropuerto.Text = "";
            txt_NombreAeropuerto.Text = "";
            ddl_Ciudad.Text = "";
        }
        public Aeropuerto interfaceDatos()
        {
            Aeropuerto obj = new Aeropuerto();

            int id = 0; int.TryParse(txt_ClaveAeropuerto.Text, out id);
            obj.Id_Aeropuerto = id;
            obj.Nombre = txt_NombreAeropuerto.Text.Trim();
            obj.Id_Ciudad = Convert.ToInt32(ddl_Ciudad.SelectedValue);

            return obj;
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            srv_Aeropuerto srv = new srv_Aeropuerto();
            if ((String)Session["operacion"] == "nuevo")
            {
                srv.addAeropuerto(interfaceDatos());
                Response.Redirect("wfrm_Aeropuerto.aspx");
            }
            else
            {
                srv.updateAeropuerto(interfaceDatos());
                Response.Redirect("wfrm_Aeropuerto.aspx");
            }
        }

        protected void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv_Aeropuerto srv = new srv_Aeropuerto();
            srv.addAeropuerto(interfaceDatos());
            limpiar();
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv_Aeropuerto srv = new srv_Aeropuerto();
            srv.deleteAeropuerto((Aeropuerto)Session["oAeropuerto"]);
            Response.Redirect("wfrm_Aeropuerto.aspx");
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfrm_Aeropuerto.aspx");
        }
    }
}