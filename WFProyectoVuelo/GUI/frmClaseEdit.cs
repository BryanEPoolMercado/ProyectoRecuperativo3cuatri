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
using Datos.Entidades;


namespace WFProyectoVuelo.GUI
{
    public partial class frmClaseEdit : Form
    {
        frmClase frmPadre;
        public bool esnuevo;
        Clase obj;
        srvClase srv = new srvClase();

        public frmClaseEdit(frmClase frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }

        public frmClaseEdit(Clase obj, frmClase frm)
        {
            InitializeComponent();
            preparaEdicion();
            esnuevo = false;
            this.obj = obj;
            datosInterface();
            frmPadre = frm;
        }
        public void preparaNuevo()
        {
            btnGuardar.Visible = true;
            btnGuardarNext.Visible = true;
            btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            limpiar();
        }
        public void preparaEdicion()
        {
            btnGuardar.Visible = true;
            btnGuardarNext.Visible = false;
            btnCancelar.Visible = true;
            btnEliminar.Visible = true;
            txt_ClaveClase.Enabled = false;
            limpiar();
        }

        public void LlenarComboboxAvion()
        {
            var listaAvion = srv.ListarClase().ToList();
            if (listaAvion.Count > 0)
            {
                cmb_avion.DataSource = listaAvion;
                cmb_avion.DisplayMember = "Nombre";
                cmb_avion.ValueMember = "Id_Avion";

                if (cmb_avion.Items.Count > 0)
                {
                    cmb_avion.SelectedIndex = -1;
                }

            }


        }
        public void limpiar()
        {
            txt_ClaveClase.Clear();
            cmb_avion.ResetText();


        }
        public void datosInterface()
        {
            txt_ClaveClase.Text = Convert.ToString(obj.Id_Seccion);
            cmb_avion.Text = Convert.ToString(obj.Id_Avion);
            txt_Nombre.Text = obj.Nombre;
        }
        public Clase interfaceDatos()
        {
            Clase obj = new Clase();

            int id = 0; int.TryParse(txt_ClaveClase.Text, out id);

            obj.Id_Seccion = id;
            obj.Id_Avion = Convert.ToInt32(cmb_avion.Text.Trim());
            obj.Nombre = txt_Nombre.Text.Trim();
            return obj;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clase obj = new Clase();
            srv.deleteClase(obj);
            frmPadre.Listar();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.addClase(interfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.updateClase(interfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btnGuardarNext_Click(object sender, EventArgs e)
        {
            srv.addClase(interfaceDatos());
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPadre.Listar();
            this.Close();
        }

        private void frmClaseEdit_Load(object sender, EventArgs e)
        {
            LlenarComboboxAvion();

        }
    }
    
}
