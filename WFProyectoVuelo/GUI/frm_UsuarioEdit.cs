    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Entidades;
using Datos.Modelo;
using Datos.Servicios;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_UsuarioEdit : Form
    {
        frm_Usuario frmPadre;

        public bool esnuevo;
        Vista_Usuario obj;
        srv_Usuario srv = new srv_Usuario();

        public frm_UsuarioEdit(frm_Usuario frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_UsuarioEdit(Vista_Usuario obj, frm_Usuario frm)
        {
            InitializeComponent();
            preparaEdicion();
            esnuevo = false;
            this.obj = obj;
            DatosInterface();
            frmPadre = frm;
        }
        public void preparaNuevo()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = false;
            limpiar();
            ListarUsuario();
        }
        public void preparaEdicion()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = false;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = true;
            txt_ClaveUsuario.Enabled = false;
            limpiar();
            ListarUsuario();
        }
        public void ListarUsuario()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var lista = con.Perfil.ToList();

            if (lista.Count > 0)
            {
                cmb_Perfil.DataSource = lista;
                cmb_Perfil.DisplayMember = "Nombre_Perfil";
                cmb_Perfil.ValueMember = "Id_Perfil";
            }
        }
        public void limpiar()
        {
            txt_ClaveUsuario.Clear();
            txt_Nombre.ResetText();
            txt_ApePat.Clear();
            txt_ApetMat.Clear();
            txt_Direccion.Clear();
            txt_Cp.Clear();
            txt_Telefono.ResetText();
            cmb_Perfil.ResetText();
            txt_CorreoUsuario.Clear();
            txt_ContraseniaUsuario.Clear();

        }
        public void DatosInterface()
        {
            txt_ClaveUsuario.Text = Convert.ToString(obj.Id_Usuario);
            txt_Nombre.Text = obj.Nombre;
            txt_ApePat.Text = obj.Apellido_pat;
            txt_ApetMat.Text = obj.Apellido_mat;
            txt_Direccion.Text = obj.Direccion;
            txt_Cp.Text = Convert.ToString(obj.CodigoPos_Usuario);
            txt_Telefono.Text = obj.Telefono_us;
            txt_CorreoUsuario.Text = obj.Correo;
            txt_ContraseniaUsuario.Text = obj.Contrasenia;
            cmb_Perfil.SelectedValue = Convert.ToString(obj.Nombre_perfil);

        }
        public Usuario InterfaceDatos()
        {
            Usuario obj = new Usuario();

            int id = 0; int.TryParse(txt_ClaveUsuario.Text, out id);

            obj.Id_Usuario = id;
            obj.Nombre = txt_Nombre.Text.Trim();
            obj.Apellido_pat = txt_ApePat.Text.Trim();
            obj.Apellido_mat = txt_ApetMat.Text.Trim();
            obj.Direccion = txt_Direccion.Text.Trim();
            obj.Fecha = Convert.ToDateTime(dtm_FechaNacUsu.Text.Trim());
            obj.Codigo_p = Convert.ToInt32(txt_Cp.Text.Trim());
            obj.Telefono_us = txt_Telefono.Text.Trim();
            obj.Correo = txt_CorreoUsuario.Text;
            obj.Contrasenia = txt_ContraseniaUsuario.Text;
            obj.Id_Perfil = Convert.ToInt32(cmb_Perfil.SelectedValue);
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarUsuario(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.ActualizarUsuario(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarUsuario(InterfaceDatos());
            frmPadre.Listar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Usuario obj = new Usuario();

            srv.EliminarUsuario(obj);
            frmPadre.Listar();
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frmPadre.Listar();
            this.Close();
        }

        private void frm_UsuarioEdit_Load(object sender, EventArgs e)
        {
            ListarUsuario();
        }
    }
}
