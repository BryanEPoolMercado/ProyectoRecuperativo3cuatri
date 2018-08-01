using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Vista_Ruta
    {
        public int Id_Ruta { get; set; }
        public string Distancia { get; set; }
        public int Destino_Aeropuerto { get; set; }
        public int Origen_Aeropuerto { get; set; }
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
