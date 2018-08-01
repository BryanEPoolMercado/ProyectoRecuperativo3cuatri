using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    class Vista_Asiento
    {
        public int Id_Asiento { get; set; }
        public string posicion { get; set; }
        public Nullable<int> numero { get; set; }
        public string letra { get; set; }
        public string NombreClase { get; set; }
        public int Id_Vuelo { get; set; }
        public Nullable<bool> estado { get; set; }
        public Nullable<decimal> precio { get; set; }
    }
}
