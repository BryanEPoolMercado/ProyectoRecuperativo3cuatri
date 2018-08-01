//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asiento()
        {
            this.Boleto = new HashSet<Boleto>();
        }
    
        public int Id_Asiento { get; set; }
        public string posicion { get; set; }
        public Nullable<int> numero { get; set; }
        public string letra { get; set; }
        public int Id_Seccion { get; set; }
        public int Id_Vuelo { get; set; }
        public Nullable<bool> estado { get; set; }
        public Nullable<decimal> precio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleto> Boleto { get; set; }
        public virtual Clase Clase { get; set; }
        public virtual Vuelos Vuelos { get; set; }
    }
}