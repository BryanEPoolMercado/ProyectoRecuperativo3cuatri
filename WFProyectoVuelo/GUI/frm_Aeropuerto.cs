using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Datos.Servicios;
using Datos.Entidades;
using Datos.Modelo;
using WFProyectoVuelo.GUI;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Aeropuerto : Form
    {
        srv_Aeropuerto srv = new srv_Aeropuerto();

        public frm_Aeropuerto()
        {
            InitializeComponent();
        }

        private void frm_Aeropuerto_Load(object sender, EventArgs e)
        {
            listar();           
        }
        public void listar()
        {
            dgv_Aeropuerto.AutoGenerateColumns = false;
            Hashtable map = new Hashtable();
            dgv_Aeropuerto.DataSource = srv.getListAeropuerto(map);
        }
       
        public void LimpiarBusqueda()
        {
            txt_ClaveAeropuerto.Clear();
            txt_NombreAeropuerto.Clear();           
        }

        private void dgv_Aeropuerto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Vista_Aeropuerto obj = new Vista_Aeropuerto();
                obj.Id_Aeropuerto = Convert.ToInt32(dgv_Aeropuerto.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Nombre = dgv_Aeropuerto.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Ciudad = dgv_Aeropuerto.Rows[e.RowIndex].Cells[2].Value.ToString();


                frm_AeropuertoEdit ofrm = new frm_AeropuertoEdit(obj, this);
                ofrm.Show();
            }
        }

        private void btn_BuscarAerolinea_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.txt_NombreAeropuerto.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_NombreAeropuerto.Text.Trim().ToUpper();           

            dgv_Aeropuerto.AutoGenerateColumns = false;
            dgv_Aeropuerto.DataSource = srv.getListAeropuerto(map);
        }

        private void btn_NuevaAeropuerto_Click(object sender, EventArgs e)
        {
            

            frm_AeropuertoEdit ofrm = new frm_AeropuertoEdit(this);
            ofrm.Show();
        }
    }
}
