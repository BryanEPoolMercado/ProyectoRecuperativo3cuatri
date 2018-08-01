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
    public partial class frm_ClaseEdit : Form
    {
        frm_Clase frmPadre;

        public bool esnuevo;
        Vista_Clase obj;
        srv_Clase srv = new srv_Clase();

        public frm_ClaseEdit(frm_Clase frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_ClaseEdit(Vista_Clase obj, frm_Clase frm)
        {
            InitializeComponent();
            preparaEdicion();
            esnuevo = false;
            this.obj = obj;
            DatosInterface();
            frmPadre = frm;
        }
        public void ListaClase()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Modelo.ToList();

            if (Lista.Count > 0)
            {
                cmb_avion.DataSource = Lista;
                cmb_avion.DisplayMember = "NombreModelo";
                cmb_avion.ValueMember = "IdModelo";
            }
        }
        public void preparaNuevo()
        {
            btnGuardar.Visible = true;
            btnGuardarNext.Visible = true;
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            limpiar();
            ListaClase();
        }
        public void preparaEdicion()
        {
            btnGuardar.Visible = true;
            btnGuardarNext.Visible = false;
            btnCancelar.Visible = true;
            btnEliminar.Visible = true;
            txt_ClaveClase.Enabled = false;
            limpiar();
            ListaClase();
        }
        public void limpiar()
        {
            txt_ClaveClase.Clear();
            txt_Nombre.Clear();
            cmb_avion.ResetText();
        }
        public void DatosInterface()
        {
            txt_ClaveClase.Text = Convert.ToString(obj.Id_Seccion);
            txt_Nombre.Text = Convert.ToString(obj.Nombre);
            cmb_avion.Text = obj.NombreModelo;
        }
        public Clase InterfaceDatos()
        {
            Clase obj = new Clase();

            int id = 0; int.TryParse(txt_ClaveClase.Text, out id);

            obj.Id_Seccion = id;
            obj.Nombre = txt_Nombre.Text.Trim();
            obj.Id_Avion = Convert.ToInt32(cmb_avion.SelectedValue);
            return obj;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.addClase(InterfaceDatos());
                frmPadre.listar();
                this.Close();
            }
            else
            {
                srv.updateClase(InterfaceDatos());
                frmPadre.listar();
                this.Close();
            }
        }

        private void btnGuardarNext_Click(object sender, EventArgs e)
        {
            srv.addClase(InterfaceDatos());
            frmPadre.listar();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            srv.deleteClase(InterfaceDatos());           
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
