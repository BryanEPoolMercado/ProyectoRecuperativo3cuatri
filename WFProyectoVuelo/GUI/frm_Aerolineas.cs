
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
    public partial class frm_Aerolineas : Form
    {
        srv_Aerolinea srv = new srv_Aerolinea();
        public frm_Aerolineas()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Aerolinea.AutoGenerateColumns = false;
            dgv_Aerolinea.DataSource = srv.ListarAerolinea();
        }

        private void frm_Aerolineas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_BuscarAerolinea_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            
            if (this.txt_NombreAerolinea.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_NombreAerolinea.Text.Trim().ToUpper();

            dgv_Aerolinea.AutoGenerateColumns = false;
            dgv_Aerolinea.DataSource = srv.FiltroAerolinea(map);
        }

        private void btn_NuevaAerolinea_Click(object sender, EventArgs e)
        {
            frm_AerolineaEdit ofrm = new frm_AerolineaEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Aerolinea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    Aerolinea obj = new Aerolinea();
                    obj.Id_Aerolinea = Convert.ToInt32(dgv_Aerolinea.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.Nombre = dgv_Aerolinea.Rows[e.RowIndex].Cells[1].Value.ToString();                    

                    frm_AerolineaEdit ofrm = new frm_AerolineaEdit(obj, this);
                    ofrm.Show();                  
                }
            }
            catch(Exception)
            {

            }
            
        }
    }
}
