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
    public partial class frm_BoletoVendido : Form
    {
        int id;
        public frm_BoletoVendido(int idcompra)
        {
            InitializeComponent();
            this.id = idcompra;
            label2.Text = Convert.ToString(id);
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ImprimirTicket_Click(object sender, EventArgs e)
        {
            frm_TicketVenta ticket = new frm_TicketVenta(id);
            ticket.ShowDialog();
        }

    }
}
