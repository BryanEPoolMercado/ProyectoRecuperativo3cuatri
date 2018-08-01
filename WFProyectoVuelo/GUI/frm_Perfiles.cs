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
    public partial class frm_Perfiles : Form
    {
        srv_Perfil srv = new srv_Perfil();
        public frm_Perfiles()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Perfiles.AutoGenerateColumns = false;
            dgv_Perfiles.DataSource = srv.ListarPerfil();
        }

        private void frm_Perfiles_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btn_BuscarPerfil_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();

            if (this.txt_Perfil.Text.Trim().Length != 0)
                map["Nombre_perfil"] = this.txt_Perfil.Text.Trim().ToUpper();

            dgv_Perfiles.AutoGenerateColumns = false;
            dgv_Perfiles.DataSource = srv.FiltroPerfil(map);
        }

        private void btn_NuevoPerfil_Click(object sender, EventArgs e)
        {
            frm_PerfilEdit ofrm = new frm_PerfilEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Perfiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    Perfil obj = new Perfil();
                    obj.Id_Perfil = Convert.ToInt32(dgv_Perfiles.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.Nombre_perfil = dgv_Perfiles.Rows[e.RowIndex].Cells[1].Value.ToString();                  

                    frm_PerfilEdit ofrm = new frm_PerfilEdit(obj, this);
                    ofrm.Show();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
