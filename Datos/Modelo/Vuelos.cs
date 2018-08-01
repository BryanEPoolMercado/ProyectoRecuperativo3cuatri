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
    
    public partial class Vuelos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vuelos()
        {
            this.Boleto = new HashSet<Boleto>();
            this.Asiento = new HashSet<Asiento>();
        }
    
        public int Id_Vuelo { get; set; }
        public string Hora_Inicio { get; set; }
        public string Hora_Fin { get; set; }
        public Nullable<int> Id_Avion { get; set; }
        public Nullable<int> Id_Ruta { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual Avion Avion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleto> Boleto { get; set; }
        public virtual Ruta Ruta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asiento> Asiento { get; set; }
    }
}
