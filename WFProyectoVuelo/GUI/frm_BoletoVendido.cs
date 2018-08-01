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
        public frm_BoletoVendido()
        {
            InitializeComponent();
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
