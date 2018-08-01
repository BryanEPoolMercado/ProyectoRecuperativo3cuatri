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
    public partial class frm_AeropuertoEdit : Form
    {
        frm_Aeropuerto frmPadre;

        public bool esnuevo;
        Vista_Aeropuerto obj;
        srv_Aeropuerto srv = new srv_Aeropuerto();

        public frm_AeropuertoEdit(frm_Aeropuerto frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_AeropuertoEdit(Vista_Aeropuerto obj, frm_Aeropuerto frm)
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
            txt_ClaveAeopuerto.Enabled = false;

            limpiar();
        }
        public void limpiar()
        {
            txt_ClaveAeopuerto.Clear();
            cbo_IdCiudad.ResetText();
            txt_NombreAeropuerto.Clear();

        }
        public void datosInterface()
        {
            txt_ClaveAeopuerto.Text = Convert.ToString(obj.Id_Aeropuerto);
            txt_NombreAeropuerto.Text = obj.Nombre;
            cbo_IdCiudad.Text = Convert.ToString(obj.Id_Ciudad);     
        }
         public Aeropuerto interfaceDatos()
        {
            Aeropuerto obj = new Aeropuerto();

            int id = 0; int.TryParse(txt_ClaveAeopuerto.Text, out id);

            obj.Id_Aeropuerto = id;
            obj.Nombre = txt_NombreAeropuerto.Text.Trim();
            obj.Id_Ciudad = Convert.ToInt32(cbo_IdCiudad.SelectedValue);
            return obj;
        }
        public void listarAeropuerto()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Ciudad.ToList();

            if (Lista.Count > 0)
            {
                cbo_IdCiudad.DataSource = Lista;
                cbo_IdCiudad.DisplayMember = "Nombre";
                cbo_IdCiudad.ValueMember = "Id_Ciudad";
            }
        }
       

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Aeropuerto obj = new Aeropuerto();

            srv.deleteAeropuerto(obj);
            frmPadre.listar();
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
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

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.addAeropuerto(interfaceDatos());
            frmPadre.listar();
            limpiar();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frmPadre.listar();
            this.Close();
        }

        private void frm_AeropuertoEdit_Load(object sender, EventArgs e)
        {
            listarAeropuerto();
        }
    }
}
