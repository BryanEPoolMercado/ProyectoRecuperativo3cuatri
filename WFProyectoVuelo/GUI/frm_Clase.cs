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

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Clase : Form
    {
        srv_Clase srv = new srv_Clase();

        public frm_Clase()
        {
            InitializeComponent();
        }

        private void frm_Clase_Load(object sender, EventArgs e)
        {
            listar();
            listarClase();
        }
        public void listar()
        {
            dgv_Clase.AutoGenerateColumns = false;           
            dgv_Clase.DataSource = srv.ListarClase();
        }
        public void listarClase()
        {
            PROYECTOVUELO03Entities con = new PROYECTOVUELO03Entities();

            var Lista = con.Modelo.ToList();

            if (Lista.Count > 0)
            {
                cmb_Avion.DataSource = Lista;
                cmb_Avion.DisplayMember = "NombreModelo";
                cmb_Avion.ValueMember = "IdModelo";
            }
        }
        public void LimpiarBusqueda()
        {
            txt_Nombre.Clear();
            cmb_Avion.SelectedIndex = 0;
        }

        private void dgv_Clase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Vista_Clase obj = new Vista_Clase();
                obj.Id_Seccion = Convert.ToInt32(dgv_Clase.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.NombreModelo = dgv_Clase.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Nombre = dgv_Clase.Rows[e.RowIndex].Cells[2].Value.ToString();


                frm_ClaseEdit ofrm = new frm_ClaseEdit(obj, this);
                ofrm.Show();
            }
        }

        private void btnNuevaClase_Click(object sender, EventArgs e)
        {
            frm_ClaseEdit ofrm = new frm_ClaseEdit(this);
            ofrm.Show();
        }
    }
}
