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
    public partial class frm_MisCompras : Form
    {
        srv_Compra srv = new srv_Compra();
        Hashtable map = new Hashtable();
        public frm_MisCompras(Hashtable id)
        {
            InitializeComponent();
            this.map = id;
            ActualizarTabla();
        }
        public void ActualizarTabla()
        {
            dgv_Compras.AutoGenerateColumns = false;
            dgv_Compras.DataSource = srv.FiltroCompras(map);
        }
    }
}
