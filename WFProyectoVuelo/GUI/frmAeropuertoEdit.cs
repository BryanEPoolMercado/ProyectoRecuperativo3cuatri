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
    public partial class frmAeropuertoEdit : Form
    {
        frmAeropuerto frmPadre;

        public bool esnuevo;
        Aeropuerto obj;
        SrvAeropuerto srv = new SrvAeropuerto(); 

        public frmAeropuertoEdit(frmAeropuerto frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frmAeropuertoEdit(Aeropuerto obj, frmAeropuerto frm)
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
            txt_ClaveAeropuerto.Enabled = false;
            limpiar();
        }
        public void listarAeropuerto()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Ciudad.ToList();

            if(Lista.Count>0)
            {
                cbo_IdCiudad.DataSource = Lista;
                cbo_IdCiudad.DisplayMember = "Nombre";
                cbo_IdCiudad.ValueMember = "Id_Ciudad";
            }
        }
        public void limpiar()
        {
            txt_ClaveAeropuerto.Clear();
            cbo_IdCiudad.ResetText();
            txt_NomAeropuerto.Clear();
           
        }
        public void datosInterface()
        {
            txt_ClaveAeropuerto.Text = Convert.ToString(obj.Id_Aeropuerto);
            cbo_IdCiudad.Text = Convert.ToString(obj.Id_Ciudad);
            txt_NomAeropuerto.Text = obj.Nombre;
        }
        public Aeropuerto interfaceDatos()
        {
            obj = new Aeropuerto();

            int id = 0; int.TryParse(txt_ClaveAeropuerto.Text, out id);

            obj.Id_Aeropuerto = id;
            obj.Id_Ciudad = Convert.ToInt32(cbo_IdCiudad.Text.Trim());
            obj.Nombre = txt_NomAeropuerto.Text.Trim();
            return obj;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            srv.deleteAeropuerto(this.obj);
            frmPadre.listar();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.addAeropuerto(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
            else
            {
                srv.updateAeropuerto(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
        }

        private void btnGuardarNext_Click(object sender, EventArgs e)
        {
            srv.addAeropuerto(interfaceDatos());
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPadre.listar();
            this.Close();
        }

        private void frmAeropuertoEdit_Load(object sender, EventArgs e)
        {
            listarAeropuerto();
        }
    }
}
