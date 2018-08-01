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
    public partial class frmPrecioEdit : Form
    {
        frmPrecio frmPadre;

        public bool esnuevo;
        Precio obj;
        SrvPrecio srv = new SrvPrecio();

        public frmPrecioEdit(frmPrecio frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }

        public frmPrecioEdit(Precio obj, frmPrecio frm)
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
            txt_IdPrecio.Enabled = false;
            limpiar();
        }
        public void listarSeccion()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Clase.ToList();

            if (Lista.Count > 0)
            {
                cbo_Seccion.DataSource = Lista;
                cbo_Seccion.DisplayMember = "Nombre";
                cbo_Seccion.ValueMember = "Id_Seccion";
            }
        }
        public void listarAvion()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Avion.ToList();

            if (Lista.Count > 0)
            {
                cbo_Avion.DataSource = Lista;
                cbo_Avion.DisplayMember = "Id_Avion";
                cbo_Avion.ValueMember = "Id_Avion";
            }
        }
        public void listarRuta()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Ruta.ToList();

            if (Lista.Count > 0)
            {
                cbo_Ruta.DataSource = Lista;
                cbo_Ruta.DisplayMember = "Id_Ruta";
                cbo_Ruta.ValueMember = "Id_Ruta";
            }
        }
        public void limpiar()
        {
            txt_IdPrecio.Clear();
            cbo_Avion.ResetText();
            cbo_Ruta.ResetText();
            cbo_Seccion.ResetText();
            txt_Precio.Clear();

        }
        public void datosInterface()
        {
            txt_IdPrecio.Text = Convert.ToString(obj.Id_Precio);
            cbo_Avion.Text = Convert.ToString(obj.Id_Avion);
            cbo_Ruta.Text = Convert.ToString(obj.Id_Ruta);
            cbo_Seccion.Text = Convert.ToString(obj.Id_Seccion);
            txt_Precio.Text = Convert.ToString(obj.Precio1);
        }
        public Precio interfaceDatos()
        {
            obj = new Precio();

            int id = 0; int.TryParse(txt_IdPrecio.Text, out id);

            obj.Id_Precio = id;
            obj.Id_Avion = Convert.ToInt32(cbo_Avion.Text.Trim());
            obj.Id_Ruta = Convert.ToInt32(cbo_Ruta.Text.Trim());
            obj.Id_Seccion = Convert.ToInt32(cbo_Seccion.Text.Trim());
            obj.Precio1 = Convert.ToDecimal(txt_Precio.Text.Trim());
            return obj;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            srv.deletePrecio(this.obj);
            frmPadre.listar();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.addPrecio(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
            else
            {
                srv.updatePrecio(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
        }

        private void btnGuardarNext_Click(object sender, EventArgs e)
        {
            srv.addPrecio(interfaceDatos());
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPadre.listar();
            this.Close();
        }

        private void frmPrecioEdit_Load(object sender, EventArgs e)
        {
            listarAvion();
            listarSeccion();
            listarRuta();
        }
    }
}
