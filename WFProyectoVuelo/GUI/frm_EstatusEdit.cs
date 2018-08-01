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
    public partial class frm_EstatusEdit : Form
    {
        frm_Estatus FrmPadre;

        public bool EsNuevo;
        Estatus obj;
        srv_Estatus srv = new srv_Estatus();
        public frm_EstatusEdit(frm_Estatus Frm)
        {
            InitializeComponent();
            preparaNuevo();
            EsNuevo = true;
            FrmPadre = Frm;
        }
        public frm_EstatusEdit(Estatus obj, frm_Estatus Frm)
        {
            InitializeComponent();
            preparaEdicion();
            EsNuevo = false;
            this.obj = obj;
            DatosInterface();
            FrmPadre = Frm;
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
            txt_ClaveEstatus.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClaveEstatus.Clear();
            txt_Cantidad.ResetText();
            txt_Estatus.Clear();            
        }
        public void DatosInterface()
        {
            txt_ClaveEstatus.Text = Convert.ToString(obj.Id_pago);
            txt_Estatus.Text = obj.Id_Estatus;
            txt_Cantidad.Text = Convert.ToString(obj.Cantidad);
        }

        public Estatus InterfaceDatos()
        {
            obj = new Estatus();
            int Id = 0; int.TryParse(txt_ClaveEstatus.Text.Trim(), out Id);
            obj.Id_pago = Id;
            obj.Id_Estatus = txt_Estatus.Text.Trim();
            obj.Cantidad = Convert.ToDecimal(txt_Cantidad.Text.Trim());
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (EsNuevo == true)
            {
                srv.AgregarEstatus(InterfaceDatos());
                FrmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.ActualizarEstatus(InterfaceDatos());
                FrmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarEstatus(InterfaceDatos());
            FrmPadre.Listar();           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv.EliminarEstatus(this.obj);
            FrmPadre.Listar();
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            FrmPadre.Listar();
            this.Close();
        }
    }
}
