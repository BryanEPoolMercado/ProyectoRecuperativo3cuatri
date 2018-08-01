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
    public partial class frm_UbicacionEdit : Form
    {
        frm_Ubicacion frmPadre;

        public bool esnuevo;
        Vista_Ubicaciones obj;
        srv_Ubicacion srv = new srv_Ubicacion();
        public frm_UbicacionEdit(frm_Ubicacion frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_UbicacionEdit(Vista_Ubicaciones obj,frm_Ubicacion frm)
        {
            InitializeComponent();
            preparaEdicion();
            esnuevo = false;
            this.obj = obj;
            DatosInterface();
            frmPadre = frm;
        }
        public void ListaModelo()
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
        public void preparaNuevo()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = false;
            limpiar();
            ListaModelo();
        }
        public void preparaEdicion()
        {
            btn_Guardar.Visible = true;
            btn_GuardarNext.Visible = false;
            btn_Cancelar.Visible = true;
            btn_Eliminar.Visible = true;
            txt_ClaveClase.Enabled = false;
            limpiar();
            ListaModelo();
        }
        public void limpiar()
        {
            txt_ClaveClase.Clear();
            txt_Nombre.ResetText();
        }
        public void DatosInterface()
        {
            txt_ClaveClase.Text = Convert.ToString(obj.Id_Ubicacion);
            txt_Nombre.Text = obj.nombre_ubicacion;
            cmb_Avion.Text = obj.NombreModelo;
        }
        public Ubicacion InterfaceDatos()
        {
            Ubicacion obj = new Ubicacion();

            int id = 0; int.TryParse(txt_ClaveClase.Text, out id);

            obj.Id_Ubicacion = id;
            obj.nombre_ubicacion = txt_Nombre.Text.Trim();
            obj.id_avion = Convert.ToInt32(cmb_Avion.SelectedValue);
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarUbicacion(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.ActualizarUbicacion(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarUbicacion(InterfaceDatos());
            frmPadre.Listar();          
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv.EliminarUbicacion(InterfaceDatos());
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
