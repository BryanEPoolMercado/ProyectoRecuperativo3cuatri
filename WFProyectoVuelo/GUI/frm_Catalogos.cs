using System;
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
    public partial class frm_Catalogos : Form
    {
        public frm_Catalogos()
        {
            InitializeComponent();
        }

        private void btn_Perfil_Click(object sender, EventArgs e)
        {
            frm_Perfiles perfil = new frm_Perfiles();
            perfil.Show();
        }

        private void btn_Avion_Click(object sender, EventArgs e)
        {
            frm_Aviones avion = new frm_Aviones();
            avion.Show();
        }

        private void btn_Modelo_Click(object sender, EventArgs e)
        {
            frm_Modelo modelo = new frm_Modelo();
            modelo.Show();
        }

        private void btn_Aerolinea_Click(object sender, EventArgs e)
        {
            frm_Aerolineas aerolinea = new frm_Aerolineas();
            aerolinea.Show();
        }

        private void btn_Tarjeta_Click(object sender, EventArgs e)
        {
            frm_Tarjeta tarjeta = new frm_Tarjeta();
            tarjeta.Show();
        }

        private void btn_Moneda_Click(object sender, EventArgs e)
        {
            frm_Moneda moneda = new frm_Moneda();
            moneda.ShowDialog();
        }

        private void btn_Estatus_Click(object sender, EventArgs e)
        {
            frm_Estatus estatus = new frm_Estatus();
            estatus.ShowDialog();
        }

        private void btn_Ruta_Click(object sender, EventArgs e)
        {
            frm_Ruta ruta = new frm_Ruta();
            ruta.ShowDialog();
        }

        private void btn_Usuario_Click(object sender, EventArgs e)
        {
            frm_Usuario usuario = new frm_Usuario();
            usuario.ShowDialog();
        }

        private void btn_Aeropuerto_Click(object sender, EventArgs e)
        {
            frm_Aeropuerto aeropuerto = new frm_Aeropuerto();
            aeropuerto.ShowDialog();
        }

        private void btn_Clase_Click(object sender, EventArgs e)
        {
            frm_Clase clase = new frm_Clase();
            clase.ShowDialog();
        }

        private void btn_Asiento_Click(object sender, EventArgs e)
        {
            frm_Asiento asiento = new frm_Asiento();
            asiento.ShowDialog();
        }

        private void btn_Pais_Click(object sender, EventArgs e)
        {
            frm_Pais pais = new frm_Pais();
            pais.ShowDialog();
        }

        private void btn_Ubicacion_Click(object sender, EventArgs e)
        {
            frm_Ubicacion ubicacion = new frm_Ubicacion();
            ubicacion.ShowDialog();
        }

        private void btn_Ciudad_Click(object sender, EventArgs e)
        {
            frm_Ciudad ciudad = new frm_Ciudad();
            ciudad.ShowDialog();
        }

        private void btn_Vuelos_Click(object sender, EventArgs e)
        {
            frm_Vuelos vuelos = new frm_Vuelos();
            vuelos.ShowDialog();
        }
    }
}
