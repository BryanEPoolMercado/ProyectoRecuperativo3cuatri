using Datos.Ds;
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
    public partial class frm_PagoTarjeta : Form
    {
        srv_Compra srvcomp = new srv_Compra();
        srv_Boleto srvbol = new srv_Boleto();
        srv_DetalleCompra srvdetcomp = new srv_DetalleCompra();
        Compra objcomp = new Compra();
        Boleto objbol = new Boleto();
        Detalle_Compra objdetcomp = new Detalle_Compra();
        ds_Carrito.dt_CarritoDataTable dt = new ds_Carrito.dt_CarritoDataTable();
        public frm_PagoTarjeta(int id, ds_Carrito.dt_CarritoDataTable table)
        {
            InitializeComponent();
            txt_IdVuelo.Text = Convert.ToString(id);
            dgv_Carrito.DataSource = table;
            this.dt = table;
            dgv_Carrito.Visible = false;
            Panel_Contenido.Visible = false;
            txt_IdVuelo.Visible = false;
            lbl_Cantidad.Text = Convert.ToString(MostrarPrecio());
        }
        public decimal MostrarPrecio()
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dgv_Carrito.Rows)
            {
                decimal valor = decimal.Parse(row.Cells[4].Value.ToString());
                suma += valor;              
            }
            return suma;
        }
        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_RealizarPago_Click(object sender, EventArgs e)
        {
            if(txt_NumeroCuenta.Text!="" && txt_NIP.Text!="")
            {
                int numProd = dt.Rows.Count;
                objcomp.Id_Moneda = 1;
                objcomp.Id_pago = 1;
                objcomp.Fecha_compra = System.DateTime.Now;
                objcomp.Id_TipoPago = 1;
                objcomp.Id_Usuario = srv_DatosUsuario.IdUsuario;

                int idcompra = srvcomp.AgregarCompra(objcomp);

                for (int i = 0; i < numProd; i++)
                {

                    int asiento = Convert.ToInt32(dt.Rows[i]["Id_Asiento"].ToString());

                    objbol.Id_Vuelo = Convert.ToInt32(txt_IdVuelo.Text);
                    objbol.Id_Asiento = asiento;
                    objbol.NombrePasajero = srv_DatosUsuario.NombreUsuario;

                    int idboleto = srvbol.AgregarBoleto(objbol);

                    objdetcomp.Id_Boleto = idboleto;
                    objdetcomp.Id_Compra = idcompra;

                    srvdetcomp.AgregarDetalleCompra(objdetcomp);

                }
                frm_BoletoVendido venta = new frm_BoletoVendido();
                venta.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos");
            }
                                 
        }

        private void cmb_Tarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Tarjeta.Text=="")
            {
                Panel_Contenido.Visible = false;
            }
            else
            {
                Panel_Contenido.Visible = true;
            }
        }
    }
}
