using Datos.Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAerolineas.Backend.GUI
{
    public partial class Modelos : System.Web.UI.Page
    {
        srv_Modelo srv = new srv_Modelo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Listar();
        }
        public void Listar()
        {
            gv_Modelo.DataSource = srv.ListarModelo();
            gv_Modelo.DataBind();
        }
        public void BuscarModelo()
        {
            Hashtable map = new Hashtable();
            if (txt_NombreModelo.Text.Length != 0)
                map["NombreModelo"] = txt_NombreModelo.Text;

            gv_Modelo.DataSource = srv.FiltroModelo(map);
            gv_Modelo.DataBind();
        }
        public Datos.Modelo.Modelo DatosAgregar()
        {
            Datos.Modelo.Modelo obj = new Datos.Modelo.Modelo();

            int id = 0; int.TryParse(txtid.Text, out id);
            obj.IdModelo = id;
            obj.NombreModelo = txtnombre.Text;
            obj.NumeroFilas = Convert.ToInt32(txtnumfila.Text);
            obj.NumeroColumnas = Convert.ToInt32(txtnumcolumna.Text);

            return obj;
        }
        public Datos.Modelo.Modelo DatosModificar()
        {
            Datos.Modelo.Modelo obj = new Datos.Modelo.Modelo();

            int id = 0; int.TryParse(txtIdModelo.Text, out id);
            obj.IdModelo = id;
            obj.NombreModelo = txtNombreModelo.Text;
            obj.NumeroFilas = Convert.ToInt32(txtNumFil.Text);
            obj.NumeroColumnas = Convert.ToInt32(txtNumCol.Text);

            return obj;
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            BuscarModelo();
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.AgregarModelo(DatosAgregar());
                Listar();
            }
            catch (Exception)
            {

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.ActualizarModelo(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                srv.EliminarModelo(DatosModificar());
                Listar();
            }
            catch (Exception)
            {

            }
        }
    }
}