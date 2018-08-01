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
    public partial class frmRuta : Form
    {
        SrvRuta srv = new SrvRuta();
        SrvAeropuerto srvAe = new SrvAeropuerto();

        public frmRuta()
        {
            InitializeComponent();
        }
        private void frmRuta_Load(object sender, EventArgs e)
        {
            listar();
            //LlenarComboboxOrigenAeropuerto();

            //LlenarComboboxDestinoAeropuerto();
        }
        public void listar()
        {
            dgv_Ruta.AutoGenerateColumns = false;
            Hashtable map = new Hashtable();
            dgv_Ruta.DataSource = srv.getListRutaP(map);
        }

        /*public void LlenarComboboxOrigenAeropuerto()
        {
            var listaAeropuerto = srvAe.getListAeropuerto().ToList();
            if(listaAeropuerto.Count>0)
            {
                cbo_Origen.DataSource = listaAeropuerto;
                cbo_Origen.DisplayMember = "Nombre";
                cbo_Origen.ValueMember = "Id_Aeropuerto";

                if(cbo_Origen.Items.Count>0)
                {
                    cbo_Origen.SelectedIndex = -1;
                }

            }
        }*/
        /*public void LlenarComboboxDestinoAeropuerto()
        {
            var listaAeropuerto = srvAe.getListAeropuerto().ToList();
            if (listaAeropuerto.Count > 0)
            {
                cbo_Destino.DataSource = listaAeropuerto;
                cbo_Destino.DisplayMember = "Nombre";
                cbo_Destino.ValueMember = "Id_Aeropuerto";

                if (cbo_Destino.Items.Count > 0)
                {
                    cbo_Destino.SelectedIndex = -1;
                }

            }
        }*/
        public void LimpiarBusqueda()
        {
            cbo_Origen.SelectedIndex = 0;
            cbo_Destino.SelectedIndex = 0;
        }
       
        private void dgv_Precio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Vista_Ruta obj = new Vista_Ruta();
                obj.Id_Ruta = Convert.ToInt32(dgv_Ruta.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Distancia = dgv_Ruta.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Origen = dgv_Ruta.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj.Destino = dgv_Ruta.Rows[e.RowIndex].Cells[3].Value.ToString();

                frmRutaEdit ofrm = new frmRutaEdit(obj, this);
                ofrm.Show();
            }
        }

        private void btnNuevoPrecio_Click(object sender, EventArgs e)
        {
            frmRutaEdit ofrm = new frmRutaEdit(this);
            ofrm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.cbo_Origen.SelectedValue.ToString().CompareTo("")!= 0)
                map["Origen_Aeropuerto"] = this.cbo_Origen.SelectedValue.ToString();

            if (this.cbo_Destino.SelectedValue.ToString().CompareTo("") != 0)
                map["Destino_Aeropuerto"] = this.cbo_Destino.SelectedValue.ToString();


            dgv_Ruta.AutoGenerateColumns = false;
            dgv_Ruta.DataSource = srv.getListRutaP(map);
        }
    }
}
