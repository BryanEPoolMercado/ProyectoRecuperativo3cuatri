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
    public partial class frm_AerolineaEdit : Form
    {
        frm_Aerolineas frmPadre;

        public bool esnuevo;
        Aerolinea obj;
        srv_Aerolinea srv = new srv_Aerolinea();
        public frm_AerolineaEdit(frm_Aerolineas frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_AerolineaEdit(Aerolinea obj, frm_Aerolineas frm)
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
            txt_ClaveAeolinea.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {           
            txt_ClaveAeolinea.Clear();
            txt_NombreAerolinea.ResetText();
        }
        public void DatosInterface()
        {            
            txt_ClaveAeolinea.Text = Convert.ToString(obj.Id_Aerolinea);
            txt_NombreAerolinea.Text = obj.Nombre;
        }
        public Aerolinea InterfaceDatos()
        {
            obj = new Aerolinea();

            int id = 0; int.TryParse(txt_ClaveAeolinea.Text, out id);
            
            obj.Id_Aerolinea = id;
            obj.Nombre = txt_NombreAerolinea.Text.Trim();           
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarAerolinea(InterfaceDatos());
                frmPadre.Listar();
                this.Close();               
            }
            else
            {
                srv.ActualizarAerolinea(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarAerolinea(InterfaceDatos());
            frmPadre.Listar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv.EliminarAerolinea(this.obj);
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
