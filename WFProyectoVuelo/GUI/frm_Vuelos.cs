using Datos.Entidades;
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

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Vuelos : Form
    {
        srv_Vuelos srv = new srv_Vuelos();
        srv_Aeropuerto srvAe = new srv_Aeropuerto();
        public frm_Vuelos()
        {
            InitializeComponent();
        }
        public void listar()
        {
            dgv_Vuelos.AutoGenerateColumns = false;          
            dgv_Vuelos.DataSource = srv.MostrarVuelos();
        }
        public void LlenarComboboxOrigenAeropuerto()
        {
            var listaAeropuerto = srvAe.getListAeropuerto().ToList();

            if (listaAeropuerto.Count > 0)
            {
                cmb_Origen.DataSource = listaAeropuerto;
                cmb_Origen.DisplayMember = "Nombre";
                cmb_Origen.ValueMember = "Id_Aeropuerto";

                if (cmb_Origen.Items.Count > 0)
                {
                    cmb_Origen.SelectedIndex = -1;
                }

            }
        }
        public void LlenarComboboxDestinoAeropuerto()
        {
            var listaAeropuerto = srvAe.getListAeropuerto().ToList();
            if (listaAeropuerto.Count > 0)
            {
                cmb_Destino.DataSource = listaAeropuerto;
                cmb_Destino.DisplayMember = "Nombre";
                cmb_Destino.ValueMember = "Id_Aeropuerto";

                if (cmb_Destino.Items.Count > 0)
                {
                    cmb_Destino.SelectedIndex = -1;
                }

            }
        }
        public void Limpiar()
        {
            cmb_Origen.SelectedIndex = 0;
            cmb_Destino.SelectedIndex = 0;
            txt_ClaveVuelos.Clear();           
        }

        private void frm_Vuelos_Load(object sender, EventArgs e)
        {
            listar();
            LlenarComboboxDestinoAeropuerto();
            LlenarComboboxOrigenAeropuerto();
        }

        private void btn_BuscarVuelos_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.cmb_Origen.SelectedValue.ToString().CompareTo("") != 0)
                map["Origen_Aeropuerto"] = this.cmb_Origen.SelectedValue.ToString();

            if (this.cmb_Destino.SelectedValue.ToString().CompareTo("") != 0)
                map["Destino_Aeropuerto"] = this.cmb_Destino.SelectedValue.ToString();


            dgv_Vuelos.AutoGenerateColumns = false;
            dgv_Vuelos.DataSource = srv.FilterFly(map);
        }

        private void btn_NuevoVuelo_Click(object sender, EventArgs e)
        {
            frm_VuelosEdit vuelos = new frm_VuelosEdit(this);
            vuelos.ShowDialog();
        }

        private void dgv_Vuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Vista_Vuelos obj = new Vista_Vuelos();

                obj.Id_Vuelo = Convert.ToInt32(dgv_Vuelos.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Fecha = Convert.ToDateTime(dgv_Vuelos.Rows[e.RowIndex].Cells[1].Value.ToString());
                obj.Hora_Inicio = dgv_Vuelos.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj.Hora_Fin = dgv_Vuelos.Rows[e.RowIndex].Cells[3].Value.ToString();                               
                obj.NombreModelo = dgv_Vuelos.Rows[e.RowIndex].Cells[4].Value.ToString();
                obj.Id_Ruta= Convert.ToInt32(dgv_Vuelos.Rows[e.RowIndex].Cells[5].Value.ToString());

                frm_VuelosEdit asientos = new frm_VuelosEdit(obj,this);
                asientos.ShowDialog();

            }
        }
    }
}
