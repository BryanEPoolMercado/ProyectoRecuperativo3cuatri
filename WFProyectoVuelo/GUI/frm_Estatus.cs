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
using Datos.Modelo;
using System.Collections;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Estatus : Form
    {
        srv_Estatus srv = new srv_Estatus();
        public frm_Estatus()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Perfiles.AutoGenerateColumns = false;
            dgv_Perfiles.DataSource = srv.ListarEstatus();
        }

        private void frm_Estatus_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_BuscarEstatus_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.txt_Estatus.Text.Trim().Length != 0)
                map["Id_Estatus"] = this.txt_Estatus.Text.Trim().ToUpper();


            if (this.txt_Cantidad.Text.Trim().Length != 0)
                map["Cantidad"] = Convert.ToDecimal(this.txt_Cantidad.Text.Trim().ToUpper());


            dgv_Perfiles.AutoGenerateColumns = false;
            dgv_Perfiles.DataSource = srv.FiltroEstatus(map);
        }

        private void btn_NuevoEstatus_Click(object sender, EventArgs e)
        {
            frm_EstatusEdit ofrm = new frm_EstatusEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Perfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Estatus obj = new Estatus();
                obj.Id_pago = Convert.ToInt32(dgv_Perfiles.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Id_Estatus = dgv_Perfiles.Rows[e.RowIndex].Cells[1].Value.ToString();
                obj.Cantidad = Convert.ToDecimal(dgv_Perfiles.Rows[e.RowIndex].Cells[2].Value.ToString());

                frm_EstatusEdit ofrm = new frm_EstatusEdit(obj, this);
                ofrm.Show();
            }
        }
    }
}
