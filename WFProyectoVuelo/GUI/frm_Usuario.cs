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
using Datos.Servicios;

namespace WFProyectoVuelo.GUI
{
    public partial class frm_Usuario : Form
    {
        srv_Usuario srv = new srv_Usuario();
        public frm_Usuario()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Usuario.AutoGenerateColumns = false;
            dgv_Usuario.DataSource = srv.ListarUsuario();
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();

            if (this.txt_Usuario.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_Usuario.Text.Trim().ToUpper();

            if (this.txt_ApellidoMat.Text.Trim().Length != 0)
                map["Apellido_mat"] = this.txt_ApellidoMat.Text.Trim().ToUpper();

            if (this.txt_ApellidoPat.Text.Trim().Length != 0)
                map["Apellido_pat"] = this.txt_ApellidoPat.Text.Trim().ToUpper();

            dgv_Usuario.AutoGenerateColumns = false;
            dgv_Usuario.DataSource = srv.FiltroUsuario(map);
        }

        private void btn_NuevoUsuario_Click(object sender, EventArgs e)
        {
            frm_UsuarioEdit ofrm = new frm_UsuarioEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 11)
                {
                    Vista_Usuario obj = new Vista_Usuario();
                    obj.Id_Usuario = Convert.ToInt32(dgv_Usuario.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.Nombre = dgv_Usuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                    obj.Apellido_pat = dgv_Usuario.Rows[e.RowIndex].Cells[2].Value.ToString();
                    obj.Apellido_mat = dgv_Usuario.Rows[e.RowIndex].Cells[3].Value.ToString();
                    obj.Fecha = Convert.ToDateTime(dgv_Usuario.Rows[e.RowIndex].Cells[4].Value.ToString());
                    obj.Direccion = dgv_Usuario.Rows[e.RowIndex].Cells[5].Value.ToString();
                    obj.Telefono_us = dgv_Usuario.Rows[e.RowIndex].Cells[6].Value.ToString();
                    obj.CodigoPos_Usuario = Convert.ToInt32(dgv_Usuario.Rows[e.RowIndex].Cells[7].Value.ToString());
                    obj.Nombre_perfil = dgv_Usuario.Rows[e.RowIndex].Cells[8].Value.ToString();
                    obj.Correo = dgv_Usuario.Rows[e.RowIndex].Cells[9].Value.ToString();
                    obj.Contrasenia = dgv_Usuario.Rows[e.RowIndex].Cells[10].Value.ToString();

                    frm_UsuarioEdit ofrm = new frm_UsuarioEdit(obj, this);
                    ofrm.Show();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
