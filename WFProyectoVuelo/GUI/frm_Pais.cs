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
    public partial class frm_Pais : Form
    {
        srv_Pais srv = new srv_Pais();

        public frm_Pais()
        {
            InitializeComponent();
        }
        
        public void Listar()
        {
            dgv_Pais.AutoGenerateColumns = false;
            dgv_Pais.DataSource = srv.ListarPais();
        }

        private void btn_BuscarPais_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();

            if (this.txt_Pais.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_Pais.Text.Trim().ToUpper();

            dgv_Pais.AutoGenerateColumns = false;
            dgv_Pais.DataSource = srv.ListarPais(map);
        }

        private void btn_NuevoPais_Click(object sender, EventArgs e)
        {
            frm_PaisEdit ofrm = new frm_PaisEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Pais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    Pais obj = new Pais();
                    obj.Id_Pais = Convert.ToInt32(dgv_Pais.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.Nombre = dgv_Pais.Rows[e.RowIndex].Cells[1].Value.ToString();

                    frm_PaisEdit ofrm = new frm_PaisEdit(obj, this);
                    ofrm.Show();
                }
            }
            catch (Exception)
            {

            }
        }
        private void frm_Pais_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
