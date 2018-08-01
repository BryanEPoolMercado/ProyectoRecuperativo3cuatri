using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Modelo;
using Datos.Servicios;


namespace WebAerolineas.Backend.GUI
{
    public partial class Usuario : System.Web.UI.Page
    {
        srv_Usuario srv = new srv_Usuario();
        srv_Perfil srvp = new srv_Perfil();
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarPaisMod();
            LlenarPaisAdd();
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Usuarios.DataSource = srv.ListarUsuario();
            gv_Usuarios.DataBind();
        }
        private void LlenarPaisMod()
        {
            ddl_Perfil.DataSource = srvp.ListarPerfil();
            ddl_Perfil.DataBind();
        }
        private void LlenarPaisAdd()
        {
            ddlperfil.DataSource = srvp.ListarPerfil();
            ddlperfil.DataBind();
        }
        public void BuscarUsuario()
        {
            Hashtable map = new Hashtable();
            if (txt_BuscarUsuario.Text.Length != 0)
                map["Nombre"] = txt_BuscarUsuario.Text;

            gv_Usuarios.DataSource = srv.FiltroUsuario(map);
            gv_Usuarios.DataBind();
        }
        public Datos.Modelo.Usuario DatosAgregar()
        {
            Datos.Modelo.Usuario obj = new Datos.Modelo.Usuario();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.Id_Usuario = id;
            obj.Nombre = txtnombre.Text;
            obj.Id_Perfil = Convert.ToInt32(ddlperfil.SelectedValue);
            obj.Fecha = Convert.ToDateTime(dtfechanac.Text);
            obj.Apellido_pat = txtapepat.Text;
            obj.Apellido_mat = txtapemat.Text;
            obj.Direccion = txtdireccion.Text;
            obj.Codigo_p = Convert.ToInt32(txtcp.Text);
            obj.Telefono_us = txttelefono.Text;
            obj.Correo = txtcorreo.Text;
            obj.Contrasenia = txtcontra.Text;

            return obj;
        }
        public Datos.Modelo.Usuario DatosModificar()
        {
            Datos.Modelo.Usuario obj = new Datos.Modelo.Usuario();

            int id = 0; int.TryParse(txt_IdUsuario.Text, out id);
            obj.Id_Usuario = id;
            obj.Nombre = txt_NombreUsuario.Text;
            obj.Id_Perfil = Convert.ToInt32(ddl_Perfil.SelectedValue);
            obj.Fecha = Convert.ToDateTime(dt_FechaNacimiento.Text);
            obj.Apellido_pat = txt_ApellidoPat.Text;
            obj.Apellido_mat = txt_ApellidoMat.Text;
            obj.Direccion = txt_Direccion.Text;
            obj.Codigo_p = Convert.ToInt32(txt_CodPost.Text);
            obj.Telefono_us = txt_Telefono.Text;
            obj.Correo = txt_Correo.Text;
            obj.Contrasenia = txt_Contrasenia.Text;

            return obj;
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.AgregarUsuario(DatosAgregar());
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
                srv.ActualizarUsuario(DatosModificar());
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
                srv.EliminarUsuario(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }
    }
}