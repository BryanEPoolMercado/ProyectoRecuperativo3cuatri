using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFProyectoVuelo.GUI;
using Datos.Modelo;
using Datos.Servicios;

namespace WFProyectoVuelo
{
    public partial class frm_Login : Form
    {
        srv_Usuario srv = new srv_Usuario();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txt_CorreoUsuario.Text;
            string contra = txt_ContraseniaUsuario.Text;

            using (PROYECTOVUELO03Entities mod = new PROYECTOVUELO03Entities())
            {
                var user = mod.Usuario.FirstOrDefault(u => u.Correo == correo);               
                if (user != null)
                {
                    if (user.Contrasenia == contra)
                    {
                        srv_DatosUsuario.NombreUsuario = user.Nombre + " " + user.Apellido_pat + " " + user.Apellido_mat;
                        srv_DatosUsuario.IdUsuario = Convert.ToInt32(user.Id_Usuario);
                        srv_DatosUsuario.IdPerfil = Convert.ToInt32(user.Id_Perfil);

                        frm_MenuPrincipal menu = new frm_MenuPrincipal();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Verifique los datos ingresados");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no valido");
                }
            }
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            frm_OpcionRegistrar registro = new frm_OpcionRegistrar();
            registro.ShowDialog();
        }

        private void txt_ContraseniaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string correo = txt_CorreoUsuario.Text;
                string contra = txt_ContraseniaUsuario.Text;

                using (PROYECTOVUELO03Entities mod = new PROYECTOVUELO03Entities())
                {
                    var user = mod.Usuario.FirstOrDefault(u => u.Correo == correo);
                    if (user != null)
                    {
                        if (user.Contrasenia == contra)
                        {
                            srv_DatosUsuario.NombreUsuario = user.Nombre + " " + user.Apellido_pat + " " + user.Apellido_mat;
                            srv_DatosUsuario.IdUsuario = Convert.ToInt32(user.Id_Usuario);
                            srv_DatosUsuario.IdPerfil = Convert.ToInt32(user.Id_Perfil);

                            frm_MenuPrincipal menu = new frm_MenuPrincipal();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Verifique los datos ingresados");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no valido");
                    }
                }            
            }
        }
    }
}
