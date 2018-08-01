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
using System.Collections;
using Datos.Servicios;
using Datos.Entidades;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Ruta : Form
    {
        srv_Ruta srv = new srv_Ruta();
        srv_Aeropuerto srvAe = new srv_Aeropuerto();
        public frm_Ruta()
        {
            InitializeComponent();
        }
        public void listar()
        {
            dgv_Ruta.AutoGenerateColumns = false;
            Hashtable map = new Hashtable();
            dgv_Ruta.DataSource = srv.getListRutaP(map);
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
            txt_ClaveRuta.Clear();          
        }

        private void frm_Ruta_Load(object sender, EventArgs e)
        {
            listar();
            LlenarComboboxOrigenAeropuerto();
            LlenarComboboxDestinoAeropuerto();
        }

        private void btn_BuscarRuta_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.cmb_Origen.SelectedValue.ToString().CompareTo("") != 0)
                map["Origen_Aeropuerto"] = this.cmb_Origen.SelectedValue.ToString();

            if (this.cmb_Destino.SelectedValue.ToString().CompareTo("") != 0)
                map["Destino_Aeropuerto"] = this.cmb_Destino.SelectedValue.ToString();


            dgv_Ruta.AutoGenerateColumns = false;
            dgv_Ruta.DataSource = srv.getListRutaP(map);
        }

        private void btn_NuevaRuta_Click(object sender, EventArgs e)
        {
            frm_RutaEdit ofrm = new frm_RutaEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Ruta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Vista_Ruta obj = new Vista_Ruta();
                obj.Id_Ruta = Convert.ToInt32(dgv_Ruta.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Distancia = dgv_Ruta.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Origen = dgv_Ruta.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj.Destino = dgv_Ruta.Rows[e.RowIndex].Cells[3].Value.ToString();

                frm_RutaEdit ofrm = new frm_RutaEdit(obj, this);
                ofrm.Show();
            }
        }
    }
}
