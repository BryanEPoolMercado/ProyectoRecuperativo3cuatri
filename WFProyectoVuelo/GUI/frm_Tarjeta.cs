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
    public partial class frm_Tarjeta : Form
    {
        srv_Tarjeta srv = new srv_Tarjeta();
        public frm_Tarjeta()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Tarjeta.AutoGenerateColumns = false;
            dgv_Tarjeta.DataSource = srv.getListTarjeta();
        }

        private void frm_Tarjeta_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_BuscarTarjeta_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.txt_NumCuenta.Text.Trim().Length != 0)
                map["Num_Cuenta"] = Convert.ToInt32(this.txt_NumCuenta.Text.Trim().ToUpper());

            if (this.txt_TipoTarjeta.Text.Trim().Length != 0)
                map["Tipo_Tarjeta"] = this.txt_TipoTarjeta.Text.Trim().ToUpper();

            if (this.dtm_VenciTarje.Text.Trim().CompareTo("") != 0)
                map["Fecha_Venc"] = this.dtm_VenciTarje.Text.Trim().ToUpper();


            if (this.txt_Nombre.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_Nombre.Text.Trim().ToUpper();

            if (this.txt_ApePat.Text.Trim().Length != 0)
                map["Apellido_Pat"] = this.txt_ApePat.Text.Trim().ToUpper();

            dgv_Tarjeta.AutoGenerateColumns = false;
            dgv_Tarjeta.DataSource = srv.getListTarjeta(map);
        }

        private void btn_NuevaTarjeta_Click(object sender, EventArgs e)
        {
            frm_TarjetaEdit ofrm = new frm_TarjetaEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Tarjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                Tarjeta obj = new Tarjeta();

                obj.Id_Tarjeta = Convert.ToInt32(dgv_Tarjeta.Rows[e.RowIndex].Cells[0].Value.ToString());
                obj.Num_Cuenta = Convert.ToInt32(dgv_Tarjeta.Rows[e.RowIndex].Cells[1].Value.ToString());
                obj.Tipo_Tarjeta = dgv_Tarjeta.Rows[e.RowIndex].Cells[2].Value.ToString();
                obj.Fecha_Venc = Convert.ToDateTime(dgv_Tarjeta.Rows[e.RowIndex].Cells[3].Value.ToString());
                obj.CVC = Convert.ToInt32(dgv_Tarjeta.Rows[e.RowIndex].Cells[4].Value.ToString());
                obj.Apellido_Pat = dgv_Tarjeta.Rows[e.RowIndex].Cells[5].Value.ToString();
                obj.Apellido_Mat = dgv_Tarjeta.Rows[e.RowIndex].Cells[6].Value.ToString();
                obj.Nombre = dgv_Tarjeta.Rows[e.RowIndex].Cells[7].Value.ToString();

                frm_TarjetaEdit ofrm = new frm_TarjetaEdit(obj, this);
                ofrm.Show();
            }
        }
    }

}
