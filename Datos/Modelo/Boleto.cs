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
    
    public partial class Boleto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boleto()
        {
            this.Detalle_Compra = new HashSet<Detalle_Compra>();
        }
    
        public int Id_Boleto { get; set; }
        public Nullable<int> Id_Vuelo { get; set; }
        public Nullable<int> Id_Asiento { get; set; }
        public string NombrePasajero { get; set; }
    
        public virtual Asiento Asiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }
        public virtual Vuelos Vuelos { get; set; }
    }
}
