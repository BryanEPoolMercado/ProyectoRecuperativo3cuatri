using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Vista_Vuelos
    {
        public int Id_Vuelo { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }
        public string NombreModelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> NumeroFilas { get; set; }
        public Nullable<int> NumeroColumnas { get; set; }
        public int Id_Ruta { get; set; }

    }
}
