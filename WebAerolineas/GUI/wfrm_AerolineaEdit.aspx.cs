using Datos.Modelo;
using Datos.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAerolineas.GUI
{
    public partial class wfrm_AerolineaEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
        public void DatosInterface()
        {
            Aerolinea obj = (Aerolinea)Session["oAerolinea"];
            txt_ClaveAerolinea.Text = Convert.ToString(obj.Id_Aerolinea);
            txt_NombreAerolinea.Text = obj.Nombre;

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
            txt_ClaveAerolinea.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClaveAerolinea.Text = "";
            txt_NombreAerolinea.Text = "";
        }
        public Aerolinea interfaceDatos()
        {
            Aerolinea obj = new Aerolinea();

            int id = 0; int.TryParse(txt_ClaveAerolinea.Text, out id);
            obj.Id_Aerolinea = id;
            obj.Nombre = txt_NombreAerolinea.Text.Trim();

            return obj;
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            srv_Aerolinea srv = new srv_Aerolinea();
            if ((String)Session["operacion"] == "nuevo")
            {
                srv.AgregarAerolinea(interfaceDatos());
                Response.Redirect("wfrm_Aerolinea.aspx");
            }
            else
            {
                srv.ActualizarAerolinea(interfaceDatos());
                Response.Redirect("wfrm_Aerolinea.aspx");
            }
        }

        protected void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv_Aerolinea srv = new srv_Aerolinea();
            srv.AgregarAerolinea(interfaceDatos());
            limpiar();
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv_Aerolinea srv = new srv_Aerolinea();
            srv.EliminarAerolinea((Aerolinea)Session["oAerolinea"]);
            Response.Redirect("wfrm_Aerolinea.aspx");
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfrm_Aerolinea.aspx");
        }
    }
}