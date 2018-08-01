using Datos.Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAerolineas.Backend.GUI
{
    public partial class Perfil : System.Web.UI.Page
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
            gv_Perfiles.DataSource = srv.ListarPerfil();
            gv_Perfiles.DataBind();
        }
        public void BuscarPerfil()
        {
            Hashtable map = new Hashtable();
            if (txt_BuscarPerfil.Text.Length != 0)
                map["Nombre_perfil"] = txt_BuscarPerfil.Text;

            gv_Perfiles.DataSource = srv.FiltroPerfil(map);
            gv_Perfiles.DataBind();
        }
        public Datos.Modelo.Perfil DatosAgregar()
        {
            Datos.Modelo.Perfil obj = new Datos.Modelo.Perfil();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.Id_Perfil = id;
            obj.Nombre_perfil = txtnombre.Text;

            return obj;
        }
        public Datos.Modelo.Perfil DatosModificar()
        {
            Datos.Modelo.Perfil obj = new Datos.Modelo.Perfil();

            int id = 0; int.TryParse(txt_Idperfil.Text, out id);
            obj.Id_Perfil = id;
            obj.Nombre_perfil = txt_Nombreperfil.Text;

            return obj;
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarPerfil();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.AgregarPerfil(DatosAgregar());
                Listar();
            }
            catch (Exception)
            {

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.ActualizarPerfil(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.EliminarPerfil(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }
    }
}