using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Vista_DetalleCompra
    {
        public int Id_Boleto { get; set; }
        public Nullable<System.DateTime> Fecha_compra { get; set; }
        public string NombreUsuario { get; set; }
        public string estatus { get; set; }
        public int numero { get; set; }
        public string letra { get; set; }
        public string posicion { get; set; }
        public decimal precio { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
