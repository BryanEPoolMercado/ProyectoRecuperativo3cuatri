using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Servicios;
using Datos.Modelo;
using System.Collections;
using Datos.Entidades;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_BuscarVuelos : Form
    {
        srv_Vuelos srvvuelos = new srv_Vuelos();
        public frm_BuscarVuelos()
        {
            InitializeComponent();
        

            DateTime fechahoy = DateTime.Now;
            string fecha = string.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(fechahoy)); 
            label2.Text = Convert.ToString((fecha));

            this.dgv_Vuelos.Columns[0].Visible = false;
            this.dgv_Vuelos.Columns[8].Visible = false;
            this.dgv_Vuelos.Columns[9].Visible = false;
        }
        public void MostrarVuelos()
        {
            dgv_Vuelos.AutoGenerateColumns = false;
        }
        public void ListaRutaOrigen()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Aeropuerto.ToList();

            if (Lista.Count > 0)
            {
                cmb_Origen.DataSource = Lista;
                cmb_Origen.DisplayMember = "Nombre";
                cmb_Origen.ValueMember = "Id_Aeropuerto";
            }
        }
        public void ListaRutaDestino()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Aeropuerto.ToList();

            if (Lista.Count > 0)
            {
                cmb_Destino.DataSource = Lista;
                cmb_Destino.DisplayMember = "Nombre";
                cmb_Destino.ValueMember = "Id_Aeropuerto";
            }
        }

        private void frm_BuscarVuelos_Load(object sender, EventArgs e)
        {
            ListaRutaOrigen();
            ListaRutaDestino();
        }

        private void btn_BuscarVuelo_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.cmb_Origen.SelectedValue.ToString().CompareTo("") != 0)
                map["Id_Ruta"] = this.cmb_Origen.SelectedValue.ToString();
            if (this.cmb_Destino.SelectedValue.ToString().CompareTo("") != 0)
                map["Id_RutaD"] = this.cmb_Destino.SelectedValue.ToString();
            map["Fecha"] = label2.Text;

            dgv_Vuelos.AutoGenerateColumns = false;
            dgv_Vuelos.DataSource = srvvuelos.FiltrarListaVuelo(map);
        }

        private void dgv_Vuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                Vista_Vuelos obj = new Vista_Vuelos();
                obj.Id_Vuelo= Convert.ToInt32(dgv_Vuelos.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Origen = dgv_Vuelos.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Destino = dgv_Vuelos.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj.Hora_Inicio = dgv_Vuelos.Rows[e.RowIndex].Cells[3].Value.ToString();
                obj.Hora_Fin = dgv_Vuelos.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj.Fecha = Convert.ToDateTime(dgv_Vuelos.Rows[e.RowIndex].Cells[5].Value.ToString());
                obj.Nombre = dgv_Vuelos.Rows[e.RowIndex].Cells[6].Value.ToString();
                obj.NombreModelo = dgv_Vuelos.Rows[e.RowIndex].Cells[7].Value.ToString();
                obj.NumeroFilas = Convert.ToInt32(dgv_Vuelos.Rows[e.RowIndex].Cells[8].Value.ToString());
                obj.NumeroColumnas = Convert.ToInt32(dgv_Vuelos.Rows[e.RowIndex].Cells[9].Value.ToString());

                //frm_InformacionVuelo ofrm = new frm_InformacionVuelo(obj, this);
                //ofrm.ShowDialog();
                Hashtable map = new Hashtable();

                map["Id_Vuelo"] = obj.Id_Vuelo;

                frm_InformacionAsientos asientos = new frm_InformacionAsientos(obj, this,map);
                asientos.ShowDialog();

            }
        }
    }
}
