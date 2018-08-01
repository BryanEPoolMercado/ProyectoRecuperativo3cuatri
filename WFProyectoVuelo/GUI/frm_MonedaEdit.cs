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
    public partial class frm_MonedaEdit : Form
    {
        frm_Moneda FrmPadre;

        public bool EsNuevo;
        Tipo_de_Moneda obj;
        srv_Moneda srv = new srv_Moneda();
        public frm_MonedaEdit(frm_Moneda Frm)
        {
            InitializeComponent();
            preparaNuevo();
            EsNuevo = true;
            FrmPadre = Frm;
        }
        public frm_MonedaEdit(Tipo_de_Moneda obj, frm_Moneda Frm)
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
            txt_ClaveMoneda.Enabled = false;
            limpiar();          
        }
        public void limpiar()
        {
            txt_ClaveMoneda.Clear();
            txt_NombreMoneda.ResetText();         
        }
        public void DatosInterface()
        {
            txt_ClaveMoneda.Text = Convert.ToString(obj.Id_Moneda);
            txt_NombreMoneda.Text = obj.Nombre_Moneda;
        }
        public Tipo_de_Moneda InterfaceDatos()
        {
            obj = new Tipo_de_Moneda();
            int Id = 0; int.TryParse(txt_ClaveMoneda.Text.Trim(), out Id);
            obj.Id_Moneda = Id;
            obj.Nombre_Moneda = txt_NombreMoneda.Text.Trim();
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (EsNuevo == true)
            {
                srv.addMoneda(InterfaceDatos());
                FrmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.updateMoneda(InterfaceDatos());
                FrmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.addMoneda(InterfaceDatos());
            FrmPadre.Listar();
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv.deleteMoneda(this.obj);
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
