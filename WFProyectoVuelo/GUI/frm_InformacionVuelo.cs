using System;
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
    public partial class frm_InformacionVuelo : Form
    {
        frm_BuscarVuelos frmpadre;
        Vista_Vuelos obj = new Vista_Vuelos();
        srv_Vuelos vuelo = new srv_Vuelos();
        srv_Asiento srv = new srv_Asiento();       
        public frm_InformacionVuelo()
        {
            InitializeComponent();
        }
        public frm_InformacionVuelo(Vista_Vuelos obj, frm_BuscarVuelos frm)
        {
            InitializeComponent();
            this.obj = obj;
            DatosInterfaz();
            frmpadre = frm;
            Asientos();
        }
        public void Asientos()
        {
            int fil = Convert.ToInt32(obj.NumeroFilas);
            int col = Convert.ToInt32(obj.NumeroColumnas);

            int fila = fil;
            int colum = col;
            Button[,] boton = new Button[fila, colum];

            panel_Asientos.Controls.Clear();

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < colum; c++)
                {
                    boton[f, c] = new Button();
                    boton[f, c].Text = "A" + (f + 1) + "C" + (c + 1);
                    boton[f, c].BackColor = Color.Green;
                    boton[f, c].Font = new Font("Arial", 4, FontStyle.Regular);
                    boton[f, c].Width = 25;
                    boton[f, c].Height = 25;
                    boton[f, c].Top = f * 38;
                    boton[f, c].Left = c * 40;
                    panel_Asientos.Controls.Add(boton[f, c]);

                    boton[f, c].Click += new System.EventHandler(NuevoButton_Click);
                }
            }
        }
        public void NuevoButton_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            Asiento obj = new Asiento();

            if (boton.BackColor == Color.Green)
            {
                boton.BackColor = Color.Red;
                obj.posicion = Convert.ToString(boton.Text);                
                dgv_Asientos.Rows.Add(boton.Text);
            }
            else
            {
                boton.BackColor = Color.Green;
                obj.posicion = Convert.ToString(boton.Text);               
                dgv_Asientos.Rows.Remove(dgv_Asientos.CurrentRow);
            }
        }
        public void DatosInterfaz()
        {
            lbl_Origen.Text = Convert.ToString(obj.Origen);
            lbl_Destino.Text = Convert.ToString(obj.Destino);
            lbl_Fecha.Text = Convert.ToString(obj.Fecha);
            lbl_HoraInicio.Text = obj.Hora_Inicio;
            lbl_HoraFinal.Text = obj.Hora_Fin;
            lbl_Aerolinea.Text = obj.Nombre;
            lbl_Avion.Text = obj.NombreModelo;
        }
        
        public void Listar()
        {
            dgv_Asientos.AutoGenerateColumns = false;
            dgv_Asientos.DataSource = srv.ListarAsiento();
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_RealizarPago_Click(object sender, EventArgs e)
        {
            List<Asiento> asientos = new List<Asiento>();

            foreach (DataGridViewRow fila in dgv_Asientos.Rows)
            {
                var asiento = new Asiento();
                asiento.posicion = fila.Cells[0].ToString();

                asientos.Add(asiento);
            }
            MessageBox.Show("Filas" + asientos);
            //frm_PagoTarjeta ofrm = new frm_PagoTarjeta(asientos);
            //ofrm.Show();           
        }     
    }
}
