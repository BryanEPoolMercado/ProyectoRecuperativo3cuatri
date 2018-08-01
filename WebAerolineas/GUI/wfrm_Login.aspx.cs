using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Datos.Modelo;
using Datos.Servicios;


namespace WebAerolineas.GUI
{
    public partial class wfrm_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = txt_Correo.Text;
            string contra = txt_Contrasenia.Text;

            
        }
    }    
}