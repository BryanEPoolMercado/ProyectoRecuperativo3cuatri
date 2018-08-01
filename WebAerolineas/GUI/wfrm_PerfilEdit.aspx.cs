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
    public partial class wfrm_PerfilEdit : System.Web.UI.Page
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
            Perfil obj = (Perfil)Session["oPerfil"];
            txt_ClavePerfil.Text = Convert.ToString(obj.Id_Perfil);
            txt_NombrePerfil.Text = obj.Nombre_perfil;

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
            txt_ClavePerfil.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClavePerfil.Text = "";
            txt_NombrePerfil.Text = "";
        }
        public Perfil interfaceDatos()
        {
            Perfil obj = new Perfil();

            int id = 0; int.TryParse(txt_ClavePerfil.Text, out id);
            obj.Id_Perfil = id;
            obj.Nombre_perfil = txt_NombrePerfil.Text.Trim();

            return obj;
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            srv_Perfil srv = new srv_Perfil();
            if ((String)Session["operacion"] == "nuevo")
            {
                srv.AgregarPerfil(interfaceDatos());
                Response.Redirect("wfrm_Perfil.aspx");
            }
            else
            {
                srv.ActualizarPerfil(interfaceDatos());
                Response.Redirect("wfrm_Perfil.aspx");
            }
        }

        protected void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv_Perfil srv = new srv_Perfil();
            srv.AgregarPerfil(interfaceDatos());
            limpiar();
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv_Perfil srv = new srv_Perfil();
            srv.EliminarPerfil((Perfil)Session["oPerfil"]);
            Response.Redirect("wfrm_Perfil.aspx");
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfrm_Perfil.aspx");
        }
    }
}