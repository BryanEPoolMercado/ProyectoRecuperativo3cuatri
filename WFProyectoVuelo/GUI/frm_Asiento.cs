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
    public partial class frm_Asiento : Form
    {
        srv_Asiento srv = new srv_Asiento();

        public frm_Asiento()
        {
            InitializeComponent();
        }

        private void frm_Asiento_Load(object sender, EventArgs e)
        {
            listar();
           
        }
        public void listar()
        {
            dgv_Asiento.AutoGenerateColumns = false;
            dgv_Asiento.DataSource = srv.ListarAsiento();
        }
        
        public void LimpiarBusqueda()
        {
            txtFila.Clear();
            txt_Clave.Clear();
                       
        }

        private void dgv_Clase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Asiento obj = new Asiento();
                obj.Id_Asiento = Convert.ToInt32(dgv_Asiento.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.posicion = dgv_Asiento.Rows[e.RowIndex].Cells[1].Value.ToString();                

                frm_AsientoEdit ofrm = new frm_AsientoEdit(obj, this);
                ofrm.Show();
            }
        }

        private void btnNuevaClase_Click(object sender, EventArgs e)
        {
            frm_AsientoEdit ofrm = new frm_AsientoEdit(this);
            ofrm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
