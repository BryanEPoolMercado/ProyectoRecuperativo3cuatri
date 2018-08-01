using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Modelo;
using System.Collections;
using Datos.Servicios;
using Datos.Entidades;
using WFProyectoVuelo.GUI;

namespace WFProyectoVuelo.GUI
{
    public partial class frmClase : Form
    {
        srvClase srv = new srvClase();

        public frmClase()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgv_Clase.AutoGenerateColumns = false;
            Hashtable map = new Hashtable();
            dgv_Clase.DataSource = srv.getListClase(map);
        }


        private void frmClase_Load(object sender, EventArgs e)
        {
            Listar();
            LlenarComboboxAvion();
        }

        public void LlenarComboboxAvion()
        {
            PROYECTOVUELO02Entities1 con = new PROYECTOVUELO02Entities1();

            var Lista = con.Modelo.ToList();

            if (Lista.Count > 0)
            {
                cmb_Avion.DataSource = Lista;
                cmb_Avion.DisplayMember = "NombreModelo";
                cmb_Avion.ValueMember = "Id_Modelo";
            }

            if (cmb_Avion.Items.Count>0)
                {
                    cmb_Avion.SelectedIndex = -1;
                }

            }


        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Hashtable map = new Hashtable();
            if (this.txt_Nombre.Text.Trim().Length != 0)
                map["Nombre"] = this.txt_Nombre.Text.Trim().ToUpper();

            if (this.cmb_Avion.SelectedValue.ToString().CompareTo("") != 0)
                map["Id_Avion"] = this.cmb_Avion.SelectedValue.ToString();


            dgv_Clase.AutoGenerateColumns = false;
            dgv_Clase.DataSource = srv.getListClase(map);
        }
        public void listar()

        {
            dgv_Clase.AutoGenerateColumns = false;
            Hashtable map = new Hashtable();
            dgv_Clase.DataSource = srv.getListClase(map);

        }
        private void btnNuevaClase_Click(object sender, EventArgs e)
        {
            frmClaseEdit ofrm = new frmClaseEdit(this);
            ofrm.ShowDialog();
        }

        private void dgv_Clase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    Clase obj = new Clase();
                    obj.Id_Seccion = Convert.ToInt32(dgv_Clase.Rows[e.RowIndex].Cells[0].Value.ToString());
                    obj.Id_Avion = Convert.ToInt32(dgv_Clase.Rows[e.RowIndex].Cells[1].Value.ToString());
                    obj.Nombre = dgv_Clase.Rows[e.RowIndex].Cells[2].Value.ToString();

                    frmClaseEdit ofrm = new frmClaseEdit(obj,this);
                    ofrm.Show();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
