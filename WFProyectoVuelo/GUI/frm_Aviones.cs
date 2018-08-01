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
    public partial class frm_Aviones : Form
    {
        srv_Avion srv = new srv_Avion();
        public frm_Aviones()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Aviones.AutoGenerateColumns = false;
            dgv_Aviones.DataSource = srv.ListarAvion();
        }
       
        private void frm_Aviones_Load(object sender, EventArgs e)
        {
            Listar();           
        }

        private void btn_BuscarAvion_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            
            if (this.txt_ModeloAvion.Text.Trim().Length != 0)
                map["NombreModelo"] = this.txt_ModeloAvion.Text.Trim().ToUpper();

            dgv_Aviones.AutoGenerateColumns = false;
            dgv_Aviones.DataSource = srv.FiltroAvion(map);
        }

        private void btn_NuevoAvion_Click(object sender, EventArgs e)
        {
            frm_AvionEdit ofrm = new frm_AvionEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Aviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Vista_Avion obj = new Vista_Avion();

                    obj.Id_Avion = Convert.ToInt32(dgv_Aviones.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.NumeroPasajeros = Convert.ToInt32(dgv_Aviones.Rows[e.RowIndex].Cells[1].Value.ToString());
                    obj.Nombre = dgv_Aviones.Rows[e.RowIndex].Cells[2].Value.ToString();
                    obj.NombreModelo = dgv_Aviones.Rows[e.RowIndex].Cells[3].Value.ToString();

                    frm_AvionEdit ofrm = new frm_AvionEdit(obj, this);
                    ofrm.Show();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
