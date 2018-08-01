using Datos.Servicios;
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

namespace WFProyectoVuelo.GUI
{
    public partial class frm_MenuPrincipal : Form
    {
        
        public frm_MenuPrincipal()
        {
            InitializeComponent();
            AbrirFormulario(new frm_FondoPantalla());
            label1.Text = srv_DatosUsuario.NombreUsuario;
            label2.Text = Convert.ToString(srv_DatosUsuario.IdPerfil);           

            if (label2.Text =="1")
            {
                btn_catalogos.Visible = true;
            }
            else
            {
                btn_catalogos.Visible = false;
            }
        }
        private void AbrirFormulario(object Form_global)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Form formulario = Form_global as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(formulario);
            this.panel_Contenedor.Tag = formulario;
            formulario.Show();

        }

        private void btn_catalogos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Catalogos());
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_HacerReservacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_BuscarVuelos());
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_FondoPantalla());
        }

        private void btn_MisReservaciones_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            map["Id_Usuario"] = srv_DatosUsuario.IdUsuario;

            AbrirFormulario(new frm_MisReservaciones(map));
        }

        private void btn_MisCompras_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            map["Id_Usuario"] = srv_DatosUsuario.IdUsuario;

            AbrirFormulario(new frm_MisCompras(map));
        }
    }
}
