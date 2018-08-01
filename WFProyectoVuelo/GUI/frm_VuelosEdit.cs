using Datos.Entidades;
using Datos.Modelo;
using Datos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFProyectoVuelo.GUI
{
    
    public partial class frm_VuelosEdit : Form
    {
        frm_Vuelos frmPadre;
        public bool esnuevo;
        Vista_Vuelos obj;
        srv_Vuelos srv = new srv_Vuelos();
        public frm_VuelosEdit(frm_Vuelos frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_VuelosEdit(Vista_Vuelos obj,frm_Vuelos frm)
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
            txt_ClaveVuelo.Enabled = false;

            limpiar();
        }
        public void limpiar()
        {
            txt_ClaveVuelo.Clear();
            cmb_Ruta.ResetText();
            cmb_Avion.ResetText();
            txt_HoraInicio.Clear();
            txt_HoraFin.Clear();
            dt_Fecha.ResetText();

        }
        public void datosInterface()
        {
            txt_ClaveVuelo.Text = Convert.ToString(obj.Id_Vuelo);
            txt_HoraInicio.Text = obj.Hora_Inicio;
            txt_HoraFin.Text = obj.Hora_Fin;
            cmb_Avion.Text = Convert.ToString(obj.NombreModelo);
            cmb_Ruta.Text = Convert.ToString(obj.Id_Ruta);
            dt_Fecha.Text = Convert.ToString(obj.Fecha);
        }
        public Vuelos interfaceDatos()
        {
            Vuelos obj = new Vuelos();

            int id = 0; int.TryParse(txt_ClaveVuelo.Text, out id);

            obj.Id_Vuelo = id;
            obj.Hora_Inicio = txt_HoraInicio.Text.Trim();
            obj.Hora_Fin = txt_HoraFin.Text.Trim();
            obj.Id_Avion = Convert.ToInt32(cmb_Avion.SelectedValue);
            obj.Id_Ruta = Convert.ToInt32(cmb_Ruta.SelectedValue);
            obj.Fecha = Convert.ToDateTime(dt_Fecha.Text.Trim());
            return obj;
        }
        public void listarModelo()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Modelo.ToList();

            if (Lista.Count > 0)
            {
                cmb_Avion.DataSource = Lista;
                cmb_Avion.DisplayMember = "NombreModelo";
                cmb_Avion.ValueMember = "IdModelo";
            }
        }
        public void listarRuta()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Ruta.ToList();

            if (Lista.Count > 0)
            {
                cmb_Ruta.DataSource = Lista;
                cmb_Ruta.DisplayMember = "Id_Ruta";
                cmb_Ruta.ValueMember = "Id_Ruta";
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarVuelos(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
            else
            {
                srv.ActualizarVuelos(interfaceDatos());
                frmPadre.listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarVuelos(interfaceDatos());
            frmPadre.listar();           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Vuelos obj = new Vuelos();

            srv.EliminarVuelos(obj);
            frmPadre.listar();
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frmPadre.listar();
            this.Close();
        }

        private void frm_VuelosEdit_Load(object sender, EventArgs e)
        {
            listarModelo();
            listarRuta();
        }
    }
}
