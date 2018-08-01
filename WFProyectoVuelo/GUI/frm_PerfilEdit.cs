using Datos.Modelo;
using Datos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_PerfilEdit : Form
    {
        frm_Perfiles frmPadre;

        public bool esnuevo;
        Perfil obj;
        srv_Perfil srv = new srv_Perfil();
        public frm_PerfilEdit(frm_Perfiles frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_PerfilEdit(Perfil obj, frm_Perfiles frm)
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
        }
        public void preparaEdicion()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = false;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = true;
            txt_ClavePerfil.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClavePerfil.Clear();
            txt_NombrePerfil.ResetText();
        }
        public void DatosInterface()
        {
            txt_ClavePerfil.Text = Convert.ToString(obj.Id_Perfil);
            txt_NombrePerfil.Text = obj.Nombre_perfil;
        }
        public Perfil InterfaceDatos()
        {
            obj = new Perfil();

            int id = 0; int.TryParse(txt_ClavePerfil.Text, out id);

            obj.Id_Perfil = id;
            obj.Nombre_perfil = txt_NombrePerfil.Text.Trim();
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarPerfil(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.ActualizarPerfil(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarPerfil(InterfaceDatos());
            frmPadre.Listar();          
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv.EliminarPerfil(this.obj);
            frmPadre.Listar();
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frmPadre.Listar();
            this.Close();
        }
    }
}
