using System;
using System.Collections;
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
    public partial class wfrm_Aeropuerto : System.Web.UI.Page
    {
        srv_Aeropuerto srv = new srv_Aeropuerto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Aeropuerto.DataSource = srv.getListAeropuerto();
            gv_Aeropuerto.DataBind();
        }
        public void BuscarAeropuerto()
        {
            Hashtable map = new Hashtable();
            if (this.txt_NombreAeropuerto.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_NombreAeropuerto.Text.Trim().ToUpper();

            gv_Aeropuerto.DataSource = srv.getListAeropuerto(map);
            gv_Aeropuerto.DataBind();
        }
        protected void btn_BuscarAeropuerto_Click(object sender, EventArgs e)
        {
            BuscarAeropuerto();
        }

        protected void gv_Aeropuerto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "editar")
            {
                Vista_Aeropuerto obj = new Vista_Aeropuerto();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                Int32 idaeropuerto = Convert.ToInt32(gv_Aeropuerto.Rows[index].Cells[0].Text.Trim());
                String nombreciudad = gv_Aeropuerto.Rows[index].Cells[1].Text.Trim();
                String nombreaeropuerto = gv_Aeropuerto.Rows[index].Cells[2].Text.Trim();

                obj.Id_Aeropuerto = idaeropuerto;
                obj.Ciudad = nombreciudad;
                obj.Nombre = nombreaeropuerto;

                Session["oAeropuerto"] = obj;
                Session["operacion"] = "editando";
                Response.Redirect("wfrm_AeropuertoEdit.aspx");
            }
        }

        protected void btn_NuevoAeropuerto_Click(object sender, EventArgs e)
        {
            Session["operacion"] = "nuevo";
            Response.Redirect("wfrm_AeropuertoEdit.aspx");
        }
    }
}