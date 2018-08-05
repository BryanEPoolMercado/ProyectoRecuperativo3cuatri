using Datos.Ds;
using Datos.Entidades;
using Datos.Modelo;
using Datos.Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Datos.Ds.ds_Carrito;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_InformacionAsientos : Form
    {
        frm_BuscarVuelos frmpadre;
        Vista_Vuelos obj = new Vista_Vuelos();
        srv_Asiento srv = new srv_Asiento();
        srv_Compra srvcomp = new srv_Compra();
        srv_Boleto srvbol = new srv_Boleto();
        srv_DetalleCompra srvdetcomp = new srv_DetalleCompra();
        Compra objcomp = new Compra();
        Boleto objbol = new Boleto();
        Detalle_Compra objdetcomp = new Detalle_Compra();
        Hashtable map = new Hashtable();
        ds_Carrito.dt_CarritoDataTable dt = new ds_Carrito.dt_CarritoDataTable();

        public frm_InformacionAsientos()
        {
            InitializeComponent();
        }
        public frm_InformacionAsientos(Vista_Vuelos obj, frm_BuscarVuelos frm, Hashtable map)
        {
            InitializeComponent();
            this.obj = obj;
            this.map = map;
            DatosInterfaz();
            frmpadre = frm;
            ActualizarTabla();
          
            this.dgv_Asientos.Columns[0].Visible = false;
            this.dgv_Asientos.Columns[5].Visible = false;
            this.dgv_Asientos.Columns[6].Visible = false;

        }
        public void ActualizarTabla()
        {
            dgv_Asientos.AutoGenerateColumns = false;
            dgv_Asientos.DataSource = srv.FiltroAsiento(map);
        }
        public void DatosInterfaz()
        {
                      
            lbl_Origen.Text = Convert.ToString(obj.Origen);
            lbl_Destino.Text = Convert.ToString(obj.Destino);
            lbl_Fecha.Text = Convert.ToString(obj.Fecha);
            lbl_HoraInicio.Text = obj.Hora_Inicio;
            lbl_HoraFinal.Text = obj.Hora_Fin;
            lbl_Aerolinea.Text = obj.Nombre;
            lbl_Avion.Text = obj.NombreModelo;
            txt_IdVuelo.Text = Convert.ToString(obj.Id_Vuelo);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Asientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    Asiento obj = new Asiento();

                    obj.Id_Asiento = Convert.ToInt32(dgv_Asientos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.letra = dgv_Asientos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    obj.numero = Convert.ToInt32(dgv_Asientos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    obj.posicion = dgv_Asientos.Rows[e.RowIndex].Cells[3].Value.ToString();
                    obj.Id_Seccion = Convert.ToInt32(dgv_Asientos.Rows[e.RowIndex].Cells[4].Value.ToString());
                    obj.Id_Vuelo = Convert.ToInt32(dgv_Asientos.Rows[e.RowIndex].Cells[5].Value.ToString());
                    obj.estado = Convert.ToBoolean(dgv_Asientos.Rows[e.RowIndex].Cells[6].Value.ToString());
                    obj.precio = Convert.ToDecimal(dgv_Asientos.Rows[e.RowIndex].Cells[7].Value.ToString());

                    dt.Rows.Add(obj.Id_Asiento, obj.letra, obj.numero, obj.precio);
                    dgv_AsientosComprados.DataSource = dt;
                    srv.updateAsiento(obj);
                    ActualizarTabla();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_RealizarPago_Click(object sender, EventArgs e)
        {
            int idvuelo = obj.Id_Vuelo;

            frm_PagoTarjeta tarjeta = new frm_PagoTarjeta(idvuelo, dt);
            tarjeta.ShowDialog();
        }

        private void btn_Reservar_Click(object sender, EventArgs e)
        {
            int numProd = dt.Rows.Count;
            objcomp.Id_Moneda = 1;
            objcomp.Id_pago = 2;
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
        }
        private void dgv_AsientosComprados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Asiento obj = new Asiento();

                    obj.Id_Asiento = Convert.ToInt32(dgv_AsientosComprados.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.letra = dgv_AsientosComprados.Rows[e.RowIndex].Cells[1].Value.ToString();
                    obj.numero = Convert.ToInt32(dgv_AsientosComprados.Rows[e.RowIndex].Cells[2].Value.ToString());                   
                    obj.precio = Convert.ToDecimal(dgv_AsientosComprados.Rows[e.RowIndex].Cells[3].Value.ToString());

                    dgv_AsientosComprados.Rows.Remove(dgv_AsientosComprados.CurrentRow);                    
                    srv.updateAsientoDisponible(obj);
                    ActualizarTabla();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
