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

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Precio : Form
    {
        srv_Precio srvPr = new srv_Precio();
        srv_Ruta srvRu = new srv_Ruta();
        srv_Aeropuerto srv = new srv_Aeropuerto();
        srv_Avion srvAvi = new srv_Avion();

        public frm_Precio()
        {
            InitializeComponent();
        }

        private void frm_Precio_Load(object sender, EventArgs e)
        {
            listar();
            LlenarComboboxAvion();
            LlenarComboboxOrigenAeropuerto();
            LlenarComboboxDestinoAeropuerto();
            LlenarComboboxSeccion();
        }
        public void listar()
        {
            dgv_Precio.AutoGenerateColumns = false;
            Hashtable map = new Hashtable();
            dgv_Precio.DataSource = srvPr.getListPrecio(map);
        }
        public void LlenarComboboxAvion()
        {
            var listaAvion = srvAvi.ListarAvion().ToList();
            if (listaAvion.Count > 0)
            {
                cbo_Avion.DataSource = listaAvion;
                cbo_Avion.DisplayMember = "NombreModelo";
                cbo_Avion.ValueMember = "Id_Avion";

                if (cbo_Avion.Items.Count > 0)
                {
                    cbo_Avion.SelectedIndex = -1;
                }

            }
        }
        public void LlenarComboboxOrigenAeropuerto()
        {
            var listaAeropuerto = srv.getListAeropuerto().ToList();
            if (listaAeropuerto.Count > 0)
            {
                cbo_Origen.DataSource = listaAeropuerto;
                cbo_Origen.DisplayMember = "Nombre";
                cbo_Origen.ValueMember = "Origen_Aeropuerto";

                if (cbo_Origen.Items.Count > 0)
                {
                    cbo_Origen.SelectedIndex = -1;
                }

            }
        }
        public void LlenarComboboxDestinoAeropuerto()
        {
            var listaAeropuerto = srv.getListAeropuerto().ToList();
            if (listaAeropuerto.Count > 0)
            {
                cbo_Destino.DataSource = listaAeropuerto;
                cbo_Destino.DisplayMember = "Nombre";
                cbo_Destino.ValueMember = "Destino_Aeropuerto";

                if (cbo_Origen.Items.Count > 0)
                {
                    cbo_Origen.SelectedIndex = -1;
                }

            }
        }
        public void LlenarComboboxSeccion()
        {
            var listaSeccion = srv.getListAeropuerto().ToList();
            if (listaSeccion.Count > 0)
            {
                cbo_Clase.DataSource = listaSeccion;
                cbo_Clase.DisplayMember = "Nombre";
                cbo_Clase.ValueMember = "Id_Seccion";

                if (cbo_Clase.Items.Count > 0)
                {
                    cbo_Clase.SelectedIndex = -1;
                }

            }
        }
        public void LimpiarBusqueda()
        {
            cbo_Origen.SelectedIndex = 0;
            cbo_Destino.SelectedIndex = 0;
            cbo_Avion.SelectedIndex = 0;
            cbo_Clase.SelectedIndex = 0;
        }

        private void dgv_Precio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Precio obj = new Precio();
                obj.Id_Precio = Convert.ToInt32(dgv_Precio.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Id_Avion = Convert.ToInt32(dgv_Precio.Rows[e.RowIndex].Cells[1].Value.ToString());
                obj.Id_Ruta = Convert.ToInt32(dgv_Precio.Rows[e.RowIndex].Cells[2].Value.ToString());
                obj.Id_Seccion = Convert.ToInt32(dgv_Precio.Rows[e.RowIndex].Cells[3].Value.ToString());
                obj.Precio1 = Convert.ToDecimal(dgv_Precio.Rows[e.RowIndex].Cells[4].Value.ToString());


                //frm_PrecioEdit ofrm = new frm_PrecioEdit(obj, this);
                //ofrm.Show();
            }
        }

        private void btn_NuevaPrecio_Click(object sender, EventArgs e)
        {
           // frmPrecioEdit ofrm = new frmPrecioEdit(this);
            //  ofrm.ShowDialog();  
        }

        private void btn_BuscarAerolinea_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();

            if (this.txt_Precio.Text.Trim().Length != 0)
                map["Precio"] = this.txt_Precio.Text.Trim().ToUpper();

            if (this.cbo_Avion.SelectedValue.ToString().CompareTo("") != 0)
                map["Id_Avion"] = this.cbo_Origen.SelectedValue.ToString();

            if (this.cbo_Origen.SelectedValue.ToString().CompareTo("") != 0)
                map["Origen_Aerpuerto"] = this.cbo_Origen.SelectedValue.ToString();

            if (this.cbo_Avion.SelectedValue.ToString().CompareTo("") != 0)
                map["Destino_Aeropuerto"] = this.cbo_Origen.SelectedValue.ToString();

            dgv_Precio.AutoGenerateColumns = false;
            dgv_Precio.DataSource = srv.getListAeropuerto
                (map);
        }
    }
}
