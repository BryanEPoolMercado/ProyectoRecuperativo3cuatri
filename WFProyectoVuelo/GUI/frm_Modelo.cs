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
using Datos.Modelo;
using Datos.Servicios;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Modelo : Form
    {
        srv_Modelo srv = new srv_Modelo();
        public frm_Modelo()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Modelos.AutoGenerateColumns = false;
            dgv_Modelos.DataSource = srv.ListarModelo();
        }

        private void frm_Modelo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_BuscarModelo_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();

            if (this.txt_NombreModelo.Text.Trim().Length != 0)
                map["NombreModelo"] = this.txt_NombreModelo.Text.Trim().ToUpper();

            dgv_Modelos.AutoGenerateColumns = false;
            dgv_Modelos.DataSource = srv.FiltroModelo(map);
        }

        private void btn_NuevoModelo_Click(object sender, EventArgs e)
        {
            frm_ModeloEdit ofrm = new frm_ModeloEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Aerolinea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Modelo obj = new Modelo();
                    obj.IdModelo = Convert.ToInt32(dgv_Modelos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.NombreModelo = dgv_Modelos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    obj.NumeroFilas = Convert.ToInt32(dgv_Modelos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    obj.NumeroColumnas = Convert.ToInt32(dgv_Modelos.Rows[e.RowIndex].Cells[3].Value.ToString());

                    frm_ModeloEdit ofrm = new frm_ModeloEdit(obj, this);
                    ofrm.Show();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
