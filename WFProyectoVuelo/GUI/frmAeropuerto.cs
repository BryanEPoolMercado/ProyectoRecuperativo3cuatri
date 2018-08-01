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

namespace WFProyectoVuelo
{
    public partial class frmAeropuerto : Form
    {
        SrvAeropuerto srv = new SrvAeropuerto();
        
        public frmAeropuerto()
        {
            InitializeComponent();
        }

        private void frmAerolinea_Load(object sender, EventArgs e)
        {
            listar();
            //LlenarComboboxCiudad();

        }
        public void listar()
        {
            dgv_Aeropuerto.AutoGenerateColumns = false;
            Hashtable map = new Hashtable();
            dgv_Aeropuerto.DataSource = srv.getListAeropuer(map);
        }

        /*public void LlenarComboboxCiudad()
        {
            var listaAeropuerto = srv.getListAeropuertos().ToList();
            if (listaAeropuerto.Count > 0)
            {
                cbo_IdCiudad.DataSource = listaAeropuerto;
                cbo_IdCiudad.DisplayMember = "Nombre";
                cbo_IdCiudad.ValueMember = "Id_Ciudad";

                if (cbo_IdCiudad.Items.Count > 0)
                {
                    cbo_IdCiudad.SelectedIndex = -1;
                }

            }
        }*/

        public void LimpiarBusqueda()
        {
            txt_NomAeropuerto.Clear();
            cbo_IdCiudad.SelectedIndex = 0;
        }

        private void dgv_Aerolinea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Vista_Aeropuerto obj = new Vista_Aeropuerto();
                obj.Id_Aeropuerto = Convert.ToInt32(dgv_Aeropuerto.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Ciudad = dgv_Aeropuerto.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Nombre = dgv_Aeropuerto.Rows[e.RowIndex].Cells[2].Value.ToString();


                frmAeropuertoEdit ofrm = new frmAeropuertoEdit(this);
                ofrm.Show();
            }
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.txt_NomAeropuerto.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_NomAeropuerto.Text.Trim().ToUpper();

            if (this.cbo_IdCiudad.SelectedValue.ToString().CompareTo("") != 0)
                map["Id_Ciudad"] = this.cbo_IdCiudad.SelectedValue.ToString();

            dgv_Aeropuerto.AutoGenerateColumns = false;
            dgv_Aeropuerto.DataSource = srv.getListAeropuer(map);

        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            frmAeropuertoEdit ofrm = new frmAeropuertoEdit(this);
            ofrm.ShowDialog();
        }
    }
}
