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
using Datos.Entidades;
using Datos.Modelo;
using System.Collections;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Ciudad : Form
    {
        srv_Ciudad srv = new srv_Ciudad();
        public frm_Ciudad()
        {
            InitializeComponent();
        }
        public void listar()
        {
            dgv_Ciudad.AutoGenerateColumns = false;
            dgv_Ciudad.DataSource = srv.ListarCiudad();
        }

        private void frm_Ciudad_Load(object sender, EventArgs e)
        {
            listar();          
        }
        
        public void LimpiarBusqueda()
        {
            txt_ClaveCiudad.Clear();
            txt_NombreCiudad.Clear();           
        }

        private void btn_BuscarCiudad_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();

            if (this.txt_NombreCiudad.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_NombreCiudad.Text.Trim().ToUpper();           

            dgv_Ciudad.AutoGenerateColumns = false;
            dgv_Ciudad.DataSource = srv.FiltroCiudad(map);
        }

        private void btn_NuevaCiudad_Click(object sender, EventArgs e)
        {
            frm_CiudadEdit ofrm = new frm_CiudadEdit(this);
            ofrm.Show();
        }

        private void dgv_Ciudad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Vista_Ciudad obj = new Vista_Ciudad();
                obj.Id_Ciudad = Convert.ToInt32(dgv_Ciudad.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.NombrePais = dgv_Ciudad.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Nombre = dgv_Ciudad.Rows[e.RowIndex].Cells[2].Value.ToString();


                frm_CiudadEdit ofrm = new frm_CiudadEdit(obj, this);
                ofrm.Show();
            }
        }
    }
}
