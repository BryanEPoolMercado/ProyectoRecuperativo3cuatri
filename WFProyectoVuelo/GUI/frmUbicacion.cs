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
    public partial class frmUbicacion : Form
    {
        Hashtable map = new Hashtable();
        SrvUbicacion srv = new SrvUbicacion();

        public frmUbicacion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.txt_Nombre.Text.Trim().Length != 0)
                map["nombre_ubicacion"] = this.txt_Nombre.Text.Trim().ToUpper();

            if (this.cmb_Asiento.SelectedValue.ToString().CompareTo("") != 0)
                map["Id_Asiento"] = this.cmb_Asiento.SelectedValue.ToString();

            dgv_Ubicacion.AutoGenerateColumns = false;
            dgv_Ubicacion.DataSource = srv.getListUbicacion(map);
        }

        private void frmUbicacion_Load(object sender, EventArgs e)
        {
            listar();
            LlenarComboboxAsiento();
        }
        public void listar()
        {
            dgv_Ubicacion.AutoGenerateColumns = false;
            dgv_Ubicacion.DataSource = srv.getListUbicacion(map);
        }
        public void LlenarComboboxAsiento()
        {
            var ListaUbicacion = srv.getListUbicacion(map).ToList();
            if (ListaUbicacion.Count > 0)
            {
                cmb_Asiento.DataSource = ListaUbicacion;
                cmb_Asiento.DisplayMember = "Id_Asiento";
                cmb_Asiento.ValueMember = "Id_Asiento";

                if (cmb_Asiento.Items.Count > 0)
                {
                    cmb_Asiento.SelectedIndex = -1;
                }

            }
        }

        private void btnNuevaClase_Click(object sender, EventArgs e)
        {
            frmUbicacionEdit ofrm = new frmUbicacionEdit(this);
            ofrm.ShowDialog();
        }
    }
}
