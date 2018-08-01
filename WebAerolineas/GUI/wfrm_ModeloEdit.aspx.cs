using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Modelo;
using Datos.Servicios;

namespace WebAerolineas.GUI
{
    public partial class wfrm_ModeloEdit : System.Web.UI.Page
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
            Modelo obj = (Modelo)Session["oModelo"];
            txt_ClaveModelo.Text = Convert.ToString(obj.IdModelo);
            txt_NombreModelo.Text = obj.NombreModelo;
            txt_NumeroFilas.Text = Convert.ToString(obj.NumeroFilas);
            txt_NumeroColumnas.Text = Convert.ToString(obj.NumeroColumnas);

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
            txt_ClaveModelo.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClaveModelo.Text = "";
            txt_NombreModelo.Text = "";
            txt_NumeroColumnas.Text = "";
            txt_NumeroFilas.Text = "";
        }
        public Modelo interfaceDatos()
        {
            Modelo obj = new Modelo();

            int id = 0; int.TryParse(txt_ClaveModelo.Text, out id);
            obj.IdModelo = id;
            obj.NombreModelo = txt_NombreModelo.Text.Trim();
            obj.NumeroFilas = Convert.ToInt32(txt_NumeroFilas.Text.Trim());
            obj.NumeroColumnas = Convert.ToInt32(txt_NumeroColumnas.Text.Trim());

            return obj;
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            srv_Modelo srv = new srv_Modelo();
            if ((String)Session["operacion"] == "nuevo")
            {
                srv.AgregarModelo(interfaceDatos());
                Response.Redirect("wfrm_Modelo.aspx");
            }
            else
            {
                srv.ActualizarModelo(interfaceDatos());
                Response.Redirect("wfrm_Modelo.aspx");
            }
        }

        protected void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv_Modelo srv = new srv_Modelo();
            srv.AgregarModelo(interfaceDatos());
            limpiar();
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv_Modelo srv = new srv_Modelo();
            srv.EliminarModelo((Modelo)Session["oModelo"]);
            Response.Redirect("wfrm_Modelo.aspx");
        }

        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfrm_Modelo.aspx");
        }
    }
}