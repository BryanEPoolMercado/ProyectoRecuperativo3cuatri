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
    public partial class frm_MisReservaciones : Form
    {
        srv_Compra srv = new srv_Compra();
        Hashtable map = new Hashtable();
        public frm_MisReservaciones(Hashtable id)
        {
            InitializeComponent();
            this.map = id;
            ActualizarTabla();
        }
        public void ActualizarTabla()
        {
            dgv_Reservaciones.AutoGenerateColumns = false;
            dgv_Reservaciones.DataSource = srv.FiltroReservaciones(map);
        }
    }
}
