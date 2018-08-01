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
    public partial class wfrm_Ciudad : System.Web.UI.Page
    {
        srv_Ciudad srv = new srv_Ciudad();
        protected void Page_Load(object sender, EventArgs e)
        {
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
        public void BuscarCiudad()
        {
            Hashtable map = new Hashtable();
            if (this.txt_NombreCiudad.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_NombreCiudad.Text.Trim().ToUpper();

            gv_Ciudad.DataSource = srv.FiltroCiudad(map);
            gv_Ciudad.DataBind();
        }

        protected void btn_BuscarCiudad_Click(object sender, EventArgs e)
        {
            BuscarCiudad();
        }

        protected void gv_Ciudad_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "editar")
            {
                Vista_Ciudad obj = new Vista_Ciudad();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                Int32 idciudad = Convert.ToInt32(gv_Ciudad.Rows[index].Cells[0].Text.Trim());
                String nombrepais = gv_Ciudad.Rows[index].Cells[1].Text.Trim();
                String nombreciudad = gv_Ciudad.Rows[index].Cells[2].Text.Trim();

                obj.Id_Ciudad = idciudad;
                obj.NombrePais = nombrepais;
                obj.Nombre = nombreciudad;

                Session["oCiudad"] = obj;
                Session["operacion"] = "editando";
                Response.Redirect("wfrm_CiudadEdit.aspx");
            }
        }

        protected void btn_NuevaCiudad_Click(object sender, EventArgs e)
        {
            Session["operacion"] = "nuevo";
            Response.Redirect("wfrm_CiudadEdit.aspx");
        }
    }

}