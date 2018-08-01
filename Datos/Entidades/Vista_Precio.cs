using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Vista_Precio
    {
        public int Id_Precio { get; set; }
        public decimal Precio1 { get; set; }
        public int Id_Avion { get; set; }
        public int Id_Ruta { get; set; }
        public int Id_Seccion { get; set; }
        public string Avion { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Clase { get; set; }
    }
}
