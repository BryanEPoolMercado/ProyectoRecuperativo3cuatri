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
    public partial class frm_AvionEdit : Form
    {
        frm_Aviones frmPadre;

        public bool esnuevo;
        Vista_Avion obj;
        srv_Avion srv = new srv_Avion();
        public frm_AvionEdit(frm_Aviones frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_AvionEdit(Vista_Avion obj, frm_Aviones frm)
        {
            InitializeComponent();
            preparaEdicion();
            esnuevo = false;
            this.obj = obj;
            DatosInterface();
            frmPadre = frm;
        }
        public void ListaAerolinea()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Aerolinea.ToList();

            if (Lista.Count > 0)
            {
                cmb_AerolineaAvion.DataSource = Lista;
                cmb_AerolineaAvion.DisplayMember = "Nombre";
                cmb_AerolineaAvion.ValueMember = "Id_Aerolinea";
            }
        }
        public void ListaModelo()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Modelo.ToList();

            if (Lista.Count > 0)
            {
                cmb_ModeloAvion.DataSource = Lista;
                cmb_ModeloAvion.DisplayMember = "NombreModelo";
                cmb_ModeloAvion.ValueMember = "IdModelo";
            }
        }
        public void preparaNuevo()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = false;
            limpiar();
            ListaAerolinea();
            ListaModelo();
        }
        public void preparaEdicion()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = false;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = true;
            txt_ClaveAvion.Enabled = false;
            limpiar();
            ListaAerolinea();
            ListaModelo();
        }
        public void limpiar()
        {
            txt_ClaveAvion.Clear();
            txt_NumeroPasajeros.ResetText();
            cmb_ModeloAvion.ResetText();
            cmb_AerolineaAvion.ResetText();
        }
        public void DatosInterface()
        {
            txt_ClaveAvion.Text = Convert.ToString(obj.Id_Avion);
            txt_NumeroPasajeros.Text = Convert.ToString(obj.NumeroPasajeros);
            cmb_AerolineaAvion.Text = Convert.ToString(obj.Nombre);
            cmb_ModeloAvion.Text = Convert.ToString(obj.NombreModelo);
        }
        public Avion InterfaceDatos()
        {
            Avion obj = new Avion();

            int id = 0; int.TryParse(txt_ClaveAvion.Text, out id);

            obj.Id_Avion = id;
            obj.NumeroPasajeros = Convert.ToInt32(txt_NumeroPasajeros.Text.Trim());
            obj.Id_Aerolinea = Convert.ToInt32(cmb_AerolineaAvion.SelectedValue);
            obj.IdModelo = Convert.ToInt32(cmb_ModeloAvion.SelectedValue);
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarAvion(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.ActualizarAvion(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarAvion(InterfaceDatos());
            frmPadre.Listar();            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Avion obj = new Avion();

            srv.EliminarAvion(obj);
            frmPadre.Listar();
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frmPadre.Listar();
            this.Close();
        }
    }
}
