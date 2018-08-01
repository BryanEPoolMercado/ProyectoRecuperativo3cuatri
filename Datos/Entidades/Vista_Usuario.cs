using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Vista_Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Direccion { get; set; }
        public string Telefono_us { get; set; }
        public string Apellido_mat { get; set; }
        public string Apellido_pat { get; set; }
        public Nullable<int> CodigoPos_Usuario { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre_perfil { get; set; }
    }
}
