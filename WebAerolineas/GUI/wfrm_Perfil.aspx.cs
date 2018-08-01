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
    public partial class wfrm_Perfil : System.Web.UI.Page
    {
        srv_Perfil srv = new srv_Perfil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Perfil.DataSource = srv.ListarPerfil();
            gv_Perfil.DataBind();
        }
        public void BuscarPerfil()
        {
            Hashtable map = new Hashtable();
            if (this.txt_NombrePerfil.Text.Trim().Length != 0)
                map["Nombre_perfil"] = this.txt_NombrePerfil.Text.Trim().ToUpper();

            gv_Perfil.DataSource = srv.FiltroPerfil(map);
            gv_Perfil.DataBind();
        }

        protected void btn_BuscarPerfil_Click(object sender, EventArgs e)
        {
            BuscarPerfil();
        }

        protected void gv_Perfil_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "editar")
            {
                Perfil obj = new Perfil();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                Int32 idperfil = Convert.ToInt32(gv_Perfil.Rows[index].Cells[0].Text.Trim());
                String nombre = gv_Perfil.Rows[index].Cells[1].Text.Trim();

                obj.Id_Perfil = idperfil;
                obj.Nombre_perfil = nombre;

                Session["oPerfil"] = obj;
                Session["operacion"] = "editando";
                Response.Redirect("wfrm_PerfilEdit.aspx");
            }
        }

        protected void btn_NuevoPerfil_Click(object sender, EventArgs e)
        {
            Session["operacion"] = "nuevo";
            Response.Redirect("wfrm_PerfilEdit.aspx");
        }
    }
}