using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFProyectoVuelo.GUI;

namespace WFProyectoVuelo.GUI
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btn_Aeropuerto_Click(object sender, EventArgs e)
        {
      
            frmAeropuerto obj = new frmAeropuerto();
            obj.Show();

        }

        private void btn_Precio_Click(object sender, EventArgs e)
        {
            
            frmPrecio obj1 = new frmPrecio();
            obj1.Show();
        }

        private void btn_Ruta_Click(object sender, EventArgs e)
        {
            frmClase obj2 = new frmClase();
            obj2.Show();
        }
    }
}
