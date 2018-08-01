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
    public partial class frm_PaisEdit : Form
    {
        frm_Pais frmPadre;

        public bool esnuevo;
        Pais obj;
        srv_Pais srv = new srv_Pais();

        public frm_PaisEdit(frm_Pais frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_PaisEdit(Pais obj, frm_Pais frm)
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
            txt_ClavePais.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClavePais.Clear();
            txt_NombrePais.ResetText();
        }
        public void DatosInterface()
        {
            txt_ClavePais.Text = Convert.ToString(obj.Id_Pais);
            txt_NombrePais.Text = obj.Nombre;
        }
        public Pais InterfaceDatos()
        {
            obj = new Pais();

            int id = 0; int.TryParse(txt_ClavePais.Text, out id);

            obj.Id_Pais = id;
            obj.Nombre = txt_NombrePais.Text.Trim();
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarPais(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.ActualizarPais(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarPais(InterfaceDatos());
            frmPadre.Listar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv.EliminarPais(this.obj);
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
