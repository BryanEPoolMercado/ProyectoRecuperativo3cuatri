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
using WFProyectoVuelo.GUI;

namespace WFProyectoVuelo.GUI
{
    public partial class frmPrecio : Form
    {
        SrvPrecio srv = new SrvPrecio();

        public frmPrecio()
        {
            InitializeComponent();
        }

        private void frmPrecio_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void listar()
        {
            dgv_Precio.AutoGenerateColumns = false;
            dgv_Precio.DataSource = srv.getListPrecio();
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


                frmPrecioEdit ofrm = new frmPrecioEdit(obj, this);
                ofrm.Show();
            }
        }

        private void btnNuevoPrecio_Click(object sender, EventArgs e)
        {
            frmPrecioEdit ofrm = new frmPrecioEdit(this);
            ofrm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.txt_IdPrecio.Text.Trim().Length != 0)
                map["Precio"] = this.txt_Precio.Text.Trim().ToUpper();

            dgv_Precio.AutoGenerateColumns = false;
            dgv_Precio.DataSource = srv.getListPrecio(map);
        }
    }
}
