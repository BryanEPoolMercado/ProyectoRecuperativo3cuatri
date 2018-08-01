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
using WFProyectoVuelo.GUI;

namespace WFProyectoVuelo.GUI
{
    public partial class frmAsiento : Form
    {
        Hashtable map = new Hashtable();
        srvAsiento srv = new srvAsiento();

        public frmAsiento()
        {
            InitializeComponent();
        }             

        private void frmAsiento_Load(object sender, EventArgs e)
        {
            listar();
            LlenarComboboxClase();
            LlenarComboboxUbicacion();
        }
        public void listar()
        {
            dgv_Clase.AutoGenerateColumns = false;
            dgv_Clase.DataSource = srv.getListAsiento(map);
        }

        public void LlenarComboboxClase()
        {
            var listaAeropuerto = srv.getListAsiento(map).ToList();
            if (listaAeropuerto.Count > 0)
            {
                cmb_Clase.DataSource = listaAeropuerto;
                cmb_Clase.DisplayMember = "Id_seccion";
                cmb_Clase.ValueMember = "Id_Seccion";

                if (cmb_Clase.Items.Count > 0)
                {
                    cmb_Clase.SelectedIndex = -1;
                }

            }
        }
        public void LlenarComboboxUbicacion()
        {
            var listaAeropuerto = srv.getListAsiento(map).ToList();
            if (listaAeropuerto.Count > 0)
            {
                cmb_Ubicacion.DataSource = listaAeropuerto;
                cmb_Ubicacion.DisplayMember = "nombre_ubicacion";
                cmb_Ubicacion.ValueMember = "Id_";

                if (cmb_Clase.Items.Count > 0)
                {
                    cmb_Clase.SelectedIndex = -1;
                }

            }
        }
    }
}
