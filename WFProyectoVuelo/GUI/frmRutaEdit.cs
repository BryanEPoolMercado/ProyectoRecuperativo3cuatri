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
    public partial class frmRutaEdit : Form
    {
        frmRuta frmPadre;

        public bool esnuevo;
       Vista_Ruta obj;
        SrvRuta srv = new SrvRuta();

        public frmRutaEdit(frmRuta frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frmRutaEdit(Vista_Ruta obj, frmRuta frm)
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
            txt_IdRuta.Enabled = false;
            limpiar();
        }
        public void listarOrigenRuta()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Ruta.ToList();

            if (Lista.Count > 0)
            {
                cbo_Origen.DataSource = Lista;
                cbo_Origen.DisplayMember = "Nombre";
                cbo_Origen.ValueMember = "Origen_Aeropuerto";
            }
        }
        public void listarDestinoRuta()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Ruta.ToList();

            if (Lista.Count > 0)
            {
                cbo_Destino.DataSource = Lista;
                cbo_Destino.DisplayMember = "Nombre";
                cbo_Destino.ValueMember = "Destino_Aeropuerto";
            }
        }
        public void limpiar()
        {
            txt_Distancia.Clear();
            cbo_Origen.ResetText();
            cbo_Destino.ResetText();
            txt_IdRuta.Clear();

        }
        public void datosInterface()
        {
            txt_IdRuta.Text = Convert.ToString(obj.Id_Ruta);
            txt_Distancia.Text = Convert.ToString(obj.Distancia);
            cbo_Origen.Text = Convert.ToString(obj.Origen_Aeropuerto);
            cbo_Destino.Text = Convert.ToString(obj.Destino_Aeropuerto);      
        }
        public Ruta interfaceDatos()
        {
            Ruta obj = new Ruta();

            int id = 0; int.TryParse(txt_IdRuta.Text, out id);

            obj.Id_Ruta = id;
            obj.Distancia = txt_Distancia.Text.Trim();
            obj.Origen_Aeropuerto = Convert.ToInt32(cbo_Origen.Text.Trim());
            obj.Destino_Aeropuerto = Convert.ToInt32(cbo_Destino.Text.Trim());
            return obj;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ruta obj = new Ruta();

            srv.deleteRuta(obj);
            frmPadre.listar();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPadre.listar();
            this.Close();
        }

        private void frmRutaEdit_Load(object sender, EventArgs e)
        {
            listarOrigenRuta();
            listarDestinoRuta();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.addRuta(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
            else
            {
                srv.updateRuta(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
        }

        private void btnGuardarNext_Click(object sender, EventArgs e)
        {
            srv.addRuta(interfaceDatos());
            limpiar();
        }
    }
}
