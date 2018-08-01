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
    public partial class frm_Moneda : Form
    {
        srv_Moneda srv = new srv_Moneda();
        public frm_Moneda()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Moneda.AutoGenerateColumns = false;
            dgv_Moneda.DataSource = srv.getListMoneda();
        }

        private void frm_Moneda_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_BuscarMoneda_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.txt_NombreMoneda.Text.Trim().Length != 0)
                map["Nombre_Moneda"] = this.txt_NombreMoneda.Text.Trim().ToUpper();


            dgv_Moneda.AutoGenerateColumns = false;
            dgv_Moneda.DataSource = srv.getListMoneda(map);
        }

        private void btn_NuevaMoneda_Click(object sender, EventArgs e)
        {
            frm_MonedaEdit ofrm = new frm_MonedaEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Moneda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Tipo_de_Moneda obj = new Tipo_de_Moneda();
                obj.Id_Moneda = Convert.ToInt32(dgv_Moneda.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Nombre_Moneda = dgv_Moneda.Rows[e.RowIndex].Cells[1].Value.ToString();

                frm_MonedaEdit ofrm = new frm_MonedaEdit(obj,this);
                ofrm.ShowDialog();
            }
        }
    }
}
