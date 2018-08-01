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
    public partial class frmUbicacionEdit : Form
    {
        frmUbicacion frmPadre;
        public bool esnuevo;
        Ubicacion obj;
        SrvUbicacion srv = new SrvUbicacion();

        public frmUbicacionEdit(frmUbicacion frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frmUbicacionEdit(Ubicacion obj, frmUbicacion frm)
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
        public void listarClase()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Ubicacion.ToList();

            if (Lista.Count > 0)
            {
                cmb_asiento.DataSource = Lista;
                cmb_asiento.DisplayMember = "Id_Asiento";
                cmb_asiento.ValueMember = "Id_Asiento";
            }

        }
        public void limpiar()
        {
            txt_ClaveClase.Clear();
            cmb_asiento.ResetText();
            txt_ClaveClase.Clear();

        }
        public void datosInterface()
        {
            txt_ClaveClase.Text = Convert.ToString(obj.id_);
            cmb_asiento.Text = Convert.ToString(obj.id_asiento);
            txt_Nombre.Text = obj.nombre_ubicacion;
        }
        public Ubicacion interfaceDatos()
        {
            obj = new Ubicacion();

            int id = 0; int.TryParse(txt_ClaveClase.Text, out id);

            obj.id_ = id;
            obj.id_asiento = Convert.ToInt32(cmb_asiento.Text.Trim());
            obj.nombre_ubicacion = txt_Nombre.Text.Trim();
            return obj;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.addUbicacion(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
            else
            {
                srv.updateUbicacion(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
        }

        private void btnGuardarNext_Click(object sender, EventArgs e)
        {
            srv.addUbicacion(interfaceDatos());
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            srv.deleteUbicacion(this.obj);
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
