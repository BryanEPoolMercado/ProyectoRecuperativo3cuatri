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
    public partial class frmAsientoEdit : Form
    {
        frmAsiento frmPadre;
        public bool esnuevo;
        Asiento obj;
        srvAsiento srv = new srvAsiento();

        public frmAsientoEdit(frmAsiento frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frmAsientoEdit(Asiento obj, frmAsiento frm)
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

        public void listarAsiento()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Clase.ToList();
            var Lista2 = con.Ubicacion.ToList();

            if (Lista.Count > 0)
            {
                cmb_Clase.DataSource = Lista;
                cmb_Clase.DisplayMember = "Id_Seccion";
                cmb_Clase.ValueMember = "Id_Seccion";
            }
            if(Lista2.Count>0)
            {
                cmb_Ubicacion.DataSource = Lista2;
                cmb_Ubicacion.DisplayMember = "nombre_ubicacion";
                cmb_Ubicacion.ValueMember = "Id_";
            }

        }
        public void limpiar()
        {
            txt_ClaveClase.Clear();
            cmb_Clase.ResetText();
            cmb_Ubicacion.ResetText();
            txt_ClaveClase.Clear();

        }
        public void datosInterface()
        {
            txt_ClaveClase.Text = Convert.ToString(obj.Id_Seccion);
            cmb_Clase.Text = Convert.ToString(obj.Id_Seccion);
            cmb_Ubicacion.Text = Convert.ToString(obj.id_);
            txtFila.Text = Convert.ToString(obj.Fila);
            txt_Letra.Text = obj.Letra;
        }
        public Asiento interfaceDatos()
        {
            obj = new Asiento();

            int id = 0; int.TryParse(txt_ClaveClase.Text, out id);

            obj.Id_Seccion = id;
            obj.Id_Seccion = Convert.ToInt32(cmb_Clase);
            obj.id_ = Convert.ToInt32(cmb_Ubicacion);
            obj.Letra = txt_Letra.Text.Trim();
            obj.Fila = Convert.ToInt32(txtFila.Text);
            return obj;
        }
    }
}
