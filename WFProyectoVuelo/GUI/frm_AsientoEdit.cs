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
    public partial class frm_AsientoEdit : Form
    {
        frm_Asiento  frmPadre;

        public bool esnuevo;
        Asiento obj;
        srv_Asiento srv = new srv_Asiento();

        public frm_AsientoEdit(frm_Asiento frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_AsientoEdit(Asiento obj, frm_Asiento frm)
        {
            InitializeComponent();
            preparaEdicion();
            esnuevo = false;
            this.obj = obj;
            DatosInterface();
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
            txt_ClaveAsiento.Enabled = false;
            limpiar();
           
        }
        public void limpiar()
        {
            txt_ClaveAsiento.Clear();          
            txt_Posicion.Clear();
            txt_LetraAsiento.Clear();
            txt_NumeroAsiento.Clear();
            txt_Precio.Clear();
            cmb_Clase.ResetText();
            cmb_Vuelo.ResetText();
        }
        public void DatosInterface()
        {
            txt_ClaveAsiento.Text = Convert.ToString(obj.Id_Asiento);
            txt_Posicion.Text = Convert.ToString(obj.posicion);
            txt_LetraAsiento.Text = obj.letra;
            txt_NumeroAsiento.Text = Convert.ToString(obj.numero);
            txt_Precio.Text = Convert.ToString(obj.precio);            
        }
        public Asiento InterfaceDatos()
        {
            Asiento obj = new Asiento();

            int id = 0; int.TryParse(txt_ClaveAsiento.Text, out id);

            obj.Id_Asiento = id;
            obj.posicion = txt_Posicion.Text.Trim();
            obj.letra = txt_LetraAsiento.Text.Trim();
            obj.numero = Convert.ToInt32(txt_NumeroAsiento.Text.Trim());
            obj.precio = Convert.ToDecimal(txt_Precio.Text.Trim());
            obj.Id_Seccion = Convert.ToInt32(cmb_Clase.SelectedValue);
            obj.Id_Vuelo = Convert.ToInt32(cmb_Vuelo.SelectedValue);
            return obj;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.addAsiento(InterfaceDatos());
                frmPadre.listar();
                this.Close();
            }
            else
            {
                srv.ModificarAsiento(InterfaceDatos());
                frmPadre.listar();
                this.Close();
            }
        }

        private void btnGuardarNext_Click(object sender, EventArgs e)
        {
            srv.addAsiento(InterfaceDatos());
            frmPadre.listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            srv.deleteAsiento(InterfaceDatos());
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
