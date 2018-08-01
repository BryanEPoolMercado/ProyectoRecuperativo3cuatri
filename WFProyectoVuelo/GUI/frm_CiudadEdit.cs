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
    public partial class frm_CiudadEdit : Form
    {
        frm_Ciudad frmPadre;

        public bool esnuevo;
        Vista_Ciudad obj;
        srv_Ciudad srv = new srv_Ciudad();
        public frm_CiudadEdit(frm_Ciudad frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_CiudadEdit(Vista_Ciudad obj, frm_Ciudad frm)
        {
            InitializeComponent();
            preparaEdicion();
            esnuevo = false;
            this.obj = obj;
            DatosInterface();
            frmPadre = frm;
        }
        public void ListaPais()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Pais.ToList();

            if (Lista.Count > 0)
            {
                cmb_Pais.DataSource = Lista;
                cmb_Pais.DisplayMember = "Nombre";
                cmb_Pais.ValueMember = "Id_Pais";
            }

        }
        public void preparaNuevo()
        {
            btnGuardar.Visible = true;
            btnGuardarNext.Visible = true;
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            limpiar();
            ListaPais();
        }
        public void preparaEdicion()
        {
            btnGuardar.Visible = true;
            btnGuardarNext.Visible = false;
            btnCancelar.Visible = true;
            btnEliminar.Visible = true;
            txt_ClaveCiudad.Enabled = false;
            limpiar();
            ListaPais();
        }
        public void limpiar()
        {
            txt_ClaveCiudad.Clear();
            txt_NombreCiudad.Clear();
            cmb_Pais.ResetText();
        }
        public void DatosInterface()
        {
            txt_ClaveCiudad.Text = Convert.ToString(obj.Id_Ciudad);
            txt_NombreCiudad.Text = Convert.ToString(obj.Nombre);
            cmb_Pais.Text = obj.NombrePais;
        }
        public Ciudad InterfaceDatos()
        {
            Ciudad obj = new Ciudad();

            int id = 0; int.TryParse(txt_ClaveCiudad.Text, out id);

            obj.Id_Ciudad = id;
            obj.Nombre = txt_NombreCiudad.Text.Trim();
            obj.Id_Pais = Convert.ToInt32(cmb_Pais.SelectedValue);
            return obj;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarCiudad(InterfaceDatos());
                frmPadre.listar();
                this.Close();
            }
            else
            {
                srv.ModificarCiudad(InterfaceDatos());
                frmPadre.listar();
                this.Close();
            }
        }

        private void btnGuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarCiudad(InterfaceDatos());            
            frmPadre.listar();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            srv.EliminarCiudad(InterfaceDatos());
            frmPadre.listar();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPadre.listar();
            this.Close();
        }
    }
}
