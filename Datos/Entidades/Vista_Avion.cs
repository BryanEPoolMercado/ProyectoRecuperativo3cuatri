using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Vista_Avion
    {
        public int Id_Avion { get; set; }
        public Nullable<int> NumeroPasajeros { get; set; }        
        public string Nombre { get; set; }
        public string NombreModelo { get; set; }
    }
}
