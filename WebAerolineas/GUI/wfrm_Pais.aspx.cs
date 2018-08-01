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
    public partial class wfrm_Pais : System.Web.UI.Page
    {
        srv_Pais srv = new srv_Pais();       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
            Listar();
        }
        public void Listar()
        {
            gv_Pais.DataSource = srv.ListarPais();
            gv_Pais.DataBind();
        }
        public void BuscarPais()
        {
            Hashtable map = new Hashtable();
            if (this.txt_NombrePais.Text.Trim().Length != 0)
            map["Nombre"] = this.txt_NombrePais.Text.Trim().ToUpper();

            gv_Pais.DataSource = srv.ListarPais(map);
            gv_Pais.DataBind();
        }

        protected void btn_BuscarPais_Click(object sender, EventArgs e)
        {
            BuscarPais();
        }

        protected void gv_Pais_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "editar")
            {
                Pais obj = new Pais();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                Int32 idPais = Convert.ToInt32(gv_Pais.Rows[index].Cells[0].Text.Trim());
                String nombre = gv_Pais.Rows[index].Cells[1].Text.Trim();            

                obj.Id_Pais = idPais;
                obj.Nombre = nombre;                

                Session["oPais"] = obj;
                Session["operacion"] = "editando";
                Response.Redirect("wfrm_PaisEdit.aspx");
            }
        }

        protected void btn_NuevoPais_Click(object sender, EventArgs e)
        {
            Session["operacion"] = "nuevo";
            Response.Redirect("wfrm_PaisEdit.aspx");
        }
    }
}