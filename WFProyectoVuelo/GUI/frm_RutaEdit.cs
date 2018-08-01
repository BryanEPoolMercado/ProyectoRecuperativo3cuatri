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
    public partial class frm_RutaEdit : Form
    {
        frm_Ruta frmPadre;

        public bool esnuevo;
        Vista_Ruta obj;
        srv_Ruta srv = new srv_Ruta();
        srv_Aeropuerto srvAe = new srv_Aeropuerto();
        public frm_RutaEdit(frm_Ruta frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_RutaEdit(Vista_Ruta obj, frm_Ruta frm)
        {
            InitializeComponent();
            preparaEdicion();
            esnuevo = false;
            this.obj = obj;
            datosInterface();
            frmPadre = frm;
        }
        public void ListarOrigenRuta()
        {
            var listaAeropuerto = srvAe.getListAeropuerto().ToList();
            if (listaAeropuerto.Count > 0)
            {
                cmb_Origen.DataSource = listaAeropuerto;
                cmb_Origen.DisplayMember = "Nombre";
                cmb_Origen.ValueMember = "Id_Aeropuerto";

                //if (cmb_Origen.Items.Count > 0)
                //{
                //    cmb_Origen.SelectedIndex = -1;
                //}

            }
        }
        public void ListarDestinoRuta()
        {
            var listaAeropuerto = srvAe.getListAeropuerto().ToList();
            if (listaAeropuerto.Count > 0)
            {
                cmb_Destino.DataSource = listaAeropuerto;
                cmb_Destino.DisplayMember = "Nombre";
                cmb_Destino.ValueMember = "Id_Aeropuerto";

                //if (cmb_Destino.Items.Count > 0)
                //{
                //    cmb_Destino.SelectedIndex = -1;
                //}

            }
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
            txt_ClaveRuta.Enabled = false;
            limpiar();
           
        }
        public void limpiar()
        {
            txt_Distancia.Clear();
            cmb_Origen.ResetText();
            cmb_Destino.ResetText();
            txt_ClaveRuta.Clear();
        }
        public void datosInterface()
        {
            txt_ClaveRuta.Text = Convert.ToString(obj.Id_Ruta);
            txt_Distancia.Text = Convert.ToString(obj.Distancia);
            cmb_Origen.Text = Convert.ToString(obj.Origen_Aeropuerto);
            cmb_Destino.Text = Convert.ToString(obj.Destino_Aeropuerto);
        }
        public Ruta interfaceDatos()
        {
            Ruta obj = new Ruta();

            int id = 0; int.TryParse(txt_ClaveRuta.Text, out id);

            obj.Id_Ruta = id;
            obj.Distancia = txt_Distancia.Text.Trim();
            obj.Origen_Aeropuerto = Convert.ToInt32(cmb_Origen.SelectedValue);
            obj.Destino_Aeropuerto = Convert.ToInt32(cmb_Destino.SelectedValue);
            return obj;
        }

        private void frm_RutaEdit_Load(object sender, EventArgs e)
        {
            ListarOrigenRuta();
            ListarDestinoRuta();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
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

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.addRuta(interfaceDatos());
            limpiar();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Ruta obj = new Ruta();

            srv.deleteRuta(obj);
            frmPadre.listar();
            this.Close();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frmPadre.listar();
            this.Close();
        }
    }
}
