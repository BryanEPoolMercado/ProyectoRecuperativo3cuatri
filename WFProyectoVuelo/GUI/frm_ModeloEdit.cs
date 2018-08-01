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
    public partial class frm_ModeloEdit : Form
    {
        frm_Modelo frmPadre;

        public bool esnuevo;
        Modelo obj;
        srv_Modelo srv = new srv_Modelo();
        public frm_ModeloEdit(frm_Modelo frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_ModeloEdit(Modelo obj, frm_Modelo frm)
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
            txt_ClaveModelo.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_ClaveModelo.Clear();
            txt_NombreModelo.ResetText();
            txt_NumeroFilas.Clear();
            txt_NumeroColumnas.ResetText();
        }
        public void DatosInterface()
        {
            txt_ClaveModelo.Text = Convert.ToString(obj.IdModelo);
            txt_NombreModelo.Text = obj.NombreModelo;
            txt_NumeroFilas.Text = Convert.ToString(obj.NumeroFilas);
            txt_NumeroColumnas.Text = Convert.ToString(obj.NumeroColumnas);
        }
        public Modelo InterfaceDatos()
        {
            obj = new Modelo();

            int id = 0; int.TryParse(txt_ClaveModelo.Text, out id);

            obj.IdModelo = id;
            obj.NombreModelo = txt_NombreModelo.Text.Trim();
            obj.NumeroFilas = Convert.ToInt32(txt_NumeroFilas.Text.Trim());
            obj.NumeroColumnas = Convert.ToInt32(txt_NumeroColumnas.Text.Trim());
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.AgregarModelo(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.ActualizarModelo(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.AgregarModelo(InterfaceDatos());
            frmPadre.Listar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv.EliminarModelo(this.obj);
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
