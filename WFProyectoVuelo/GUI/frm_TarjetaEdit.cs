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
    public partial class frm_TarjetaEdit : Form
    {
        frm_Tarjeta frmPadre;

        public bool esnuevo;
        Tarjeta obj;
        srv_Tarjeta srv = new srv_Tarjeta();
        public frm_TarjetaEdit(frm_Tarjeta frm)
        {
            InitializeComponent();
            preparaNuevo();
            esnuevo = true;
            frmPadre = frm;
        }
        public frm_TarjetaEdit(Tarjeta obj, frm_Tarjeta frm)
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
            txt_IdTarjeta.Enabled = false;
            limpiar();
        }
        public void limpiar()
        {
            txt_IdTarjeta.Clear();
            txt_NomCuenta.Clear();
            cmb_TipoTarjeta.ResetText();
            txt_CvcTarje.Clear();
            txt_Nombre.Clear();
            txt_ApePat.Clear();
            txt_ApeMat.Clear();
        }
        public void DatosInterface()
        {
            txt_IdTarjeta.Text = Convert.ToString(obj.Id_Tarjeta);
            txt_NomCuenta.Text = Convert.ToString(obj.Num_Cuenta);
            cmb_TipoTarjeta.Text = obj.Tipo_Tarjeta;
            dtm_VenciTarje.Text = Convert.ToString(obj.Fecha_Venc);
            txt_CvcTarje.Text = Convert.ToString(obj.CVC);
            txt_ApePat.Text = obj.Apellido_Pat;
            txt_ApeMat.Text = obj.Apellido_Mat;
            txt_Nombre.Text = obj.Nombre;

        }
        public Tarjeta InterfaceDatos()
        {
            obj = new Tarjeta();
            int Id = 0; int.TryParse(txt_IdTarjeta.Text.Trim(), out Id);
            obj.Id_Tarjeta = Id;
            obj.Num_Cuenta = Convert.ToInt32(txt_NomCuenta.Text.Trim());
            obj.Tipo_Tarjeta = cmb_TipoTarjeta.Text.Trim();
            obj.Fecha_Venc = Convert.ToDateTime(dtm_VenciTarje.Text.Trim());
            obj.CVC = Convert.ToInt32(txt_CvcTarje.Text.Trim());
            obj.Apellido_Pat = txt_ApePat.Text.Trim();
            obj.Apellido_Mat = txt_ApeMat.Text.Trim();
            obj.Nombre = txt_Nombre.Text.Trim();
            return obj;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (esnuevo == true)
            {
                srv.addTarjeta(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
            else
            {
                srv.updateTarjeta(InterfaceDatos());
                frmPadre.Listar();
                this.Close();
            }
        }

        private void btn_GuardarNext_Click(object sender, EventArgs e)
        {
            srv.addTarjeta(InterfaceDatos());
            frmPadre.Listar();           
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            srv.deleteTarjeta(obj);
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
