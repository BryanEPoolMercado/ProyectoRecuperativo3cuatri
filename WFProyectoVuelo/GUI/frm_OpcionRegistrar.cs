using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Modelo;
using Datos.Servicios;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_OpcionRegistrar : Form
    {
       
        srv_Usuario servicioUsuario = new srv_Usuario();
        public frm_OpcionRegistrar()
        {
            InitializeComponent();
        }
        public Usuario InterfaceDatos()
        {
            Usuario obj = new Usuario();

            int id = 0; int.TryParse(txt_ClaveUsuario.Text, out id);

            obj.Id_Usuario = id;
            obj.Nombre = txt_NombreUsuario.Text.Trim();
            obj.Apellido_pat = txt_ApellidoPat.Text.Trim();
            obj.Apellido_mat = txt_ApellidoMat.Text.Trim();
            obj.Direccion = txt_Direccion.Text.Trim();
            obj.Fecha = Convert.ToDateTime(dt_FechaNac.Text.Trim());
            obj.Codigo_p = Convert.ToInt32(txt_CodigoPostal.Text.Trim());
            obj.Telefono_us = txt_Telefono.Text.Trim();
            obj.Correo = txt_CorreoUsuario.Text.Trim();
            obj.Contrasenia = txt_Contrasenia.Text.Trim();
            obj.Id_Perfil = Convert.ToInt32(txt_Perfil.Text.Trim());
            return obj;
        }
        public void limpiar()
        {
            txt_ClaveUsuario.Clear();
            txt_NombreUsuario.ResetText();
            txt_ApellidoPat.Clear();
            txt_ApellidoMat.Clear();
            txt_Direccion.Clear();
            txt_CodigoPostal.Clear();
            txt_Telefono.ResetText();
            txt_Perfil.ResetText();
            txt_CorreoUsuario.Clear();
            txt_Contrasenia.Clear();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            servicioUsuario.AgregarUsuario(InterfaceDatos());
            limpiar();
            frm_MensajeRegistro mensaje = new frm_MensajeRegistro();
            mensaje.Show();
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_CancelarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
