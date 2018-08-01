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
    public partial class wfrm_Modelo : System.Web.UI.Page
    {
        srv_Modelo srv = new srv_Modelo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Modelo.DataSource = srv.ListarModelo();
            gv_Modelo.DataBind();
        }
        public void BuscarModelo()
        {
            Hashtable map = new Hashtable();
            if (this.txt_NombreModelo.Text.Trim().Length != 0)
                map["NombreModelo"] = this.txt_NombreModelo.Text.Trim().ToUpper();

            gv_Modelo.DataSource = srv.FiltroModelo(map);
            gv_Modelo.DataBind();
        }

        protected void btn_BuscarModelo_Click(object sender, EventArgs e)
        {
            BuscarModelo();
        }

        protected void gv_Modelo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "editar")
            {
                Modelo obj = new Modelo();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                Int32 idmodelo = Convert.ToInt32(gv_Modelo.Rows[index].Cells[0].Text.Trim());
                String nombre = gv_Modelo.Rows[index].Cells[1].Text.Trim();
                Int32 numfila= Convert.ToInt32(gv_Modelo.Rows[index].Cells[2].Text.Trim());
                Int32 numcol = Convert.ToInt32(gv_Modelo.Rows[index].Cells[3].Text.Trim());

                obj.IdModelo = idmodelo;
                obj.NombreModelo = nombre;
                obj.NumeroFilas = numfila;
                obj.NumeroColumnas = numcol;

                Session["oModelo"] = obj;
                Session["operacion"] = "editando";
                Response.Redirect("wfrm_ModeloEdit.aspx");
            }
        }

        protected void btn_NuevoModelo_Click(object sender, EventArgs e)
        {
            Session["operacion"] = "nuevo";
            Response.Redirect("wfrm_ModeloEdit.aspx");
        }
    }
}