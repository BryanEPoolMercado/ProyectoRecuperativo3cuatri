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
    public partial class wfrm_PaisEdit : System.Web.UI.Page
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
            Pais obj = (Pais)Session["oPais"];
            txt_ClavePais.Text = Convert.ToString(obj.Id_Pais);
            txt_NombrePais.Text = obj.Nombre;
           
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
            txt_ClavePais.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClavePais.Text = "";
            txt_NombrePais.Text = "";           
        }
        public Pais interfaceDatos()
        {
            Pais obj = new Pais();
           
            int id = 0; int.TryParse(txt_ClavePais.Text, out id);
            obj.Id_Pais = id;
            obj.Nombre = txt_NombrePais.Text.Trim();
            
            return obj;
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            srv_Pais srv = new srv_Pais();
            if ((String)Session["operacion"] == "nuevo")
            {
                srv.AgregarPais(interfaceDatos());
                Response.Redirect("wfrm_Pais.aspx");
            }
            else
            {
                srv.ActualizarPais(interfaceDatos());
                Response.Redirect("wfrm_Pais.aspx");
            }
        }

        protected void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv_Pais srv = new srv_Pais();
            srv.AgregarPais(interfaceDatos());
            limpiar();
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv_Pais srv = new srv_Pais();
            srv.EliminarPais((Pais)Session["oPais"]);
            Response.Redirect("wfrm_Pais.aspx");
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfrm_Pais.aspx");
        }
    }
}