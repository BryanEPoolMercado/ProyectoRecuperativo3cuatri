using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Entidades;
using Datos.Modelo;
using Datos.Servicios;


namespace WFProyectoVuelo.GUI
{
    public partial class frm_Ubicacion : Form
    {
        srv_Ubicacion srv = new srv_Ubicacion();
        public frm_Ubicacion()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Ubicacion.AutoGenerateColumns = false;
            dgv_Ubicacion.DataSource = srv.ListarUbicacion();
        }

        private void frm_Ubicacion_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnBuscarUbicacion_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();

            if (this.txt_Ubicacion.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_Ubicacion.Text.Trim().ToUpper();

            dgv_Ubicacion.AutoGenerateColumns = false;
            dgv_Ubicacion.DataSource = srv.ListarUbicacion(map);
        }

        private void btnNuevaUbicacion_Click(object sender, EventArgs e)
        {
            frm_UbicacionEdit ofrm = new frm_UbicacionEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Ubicacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    Vista_Ubicaciones obj = new Vista_Ubicaciones();
                    obj.Id_Ubicacion = Convert.ToInt32(dgv_Ubicacion.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.nombre_ubicacion = dgv_Ubicacion.Rows[e.RowIndex].Cells[1].Value.ToString();
                    obj.NombreModelo= dgv_Ubicacion.Rows[e.RowIndex].Cells[2].Value.ToString();

                    frm_UbicacionEdit ofrm = new frm_UbicacionEdit(obj, this);
                    ofrm.Show();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
