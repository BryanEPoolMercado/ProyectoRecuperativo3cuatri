using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Modelo;
using Datos.Servicios;

namespace WebAerolineas.GUI
{
    public partial class wfrm_Aerolinea : System.Web.UI.Page
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
            if (this.txt_NombreAerolinea.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_NombreAerolinea.Text.Trim().ToUpper();

            gv_Aerolinea.DataSource = srv.FiltroAerolinea(map);
            gv_Aerolinea.DataBind();
        }

        protected void btn_BuscarAerolinea_Click(object sender, EventArgs e)
        {
            BuscarAerolinea();
        }

        protected void gv_Aerolinea_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "editar")
            {
                Aerolinea obj = new Aerolinea();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                Int32 idaerolinea = Convert.ToInt32(gv_Aerolinea.Rows[index].Cells[0].Text.Trim());
                String nombre = gv_Aerolinea.Rows[index].Cells[1].Text.Trim();

                obj.Id_Aerolinea = idaerolinea;
                obj.Nombre = nombre;

                Session["oAerolinea"] = obj;
                Session["operacion"] = "editando";
                Response.Redirect("wfrm_AerolineaEdit.aspx");
            }
        }

        protected void btn_NuevaAerolinea_Click(object sender, EventArgs e)
        {
            Session["operacion"] = "nuevo";
            Response.Redirect("wfrm_AerolineaEdit.aspx");
        }
    }
}