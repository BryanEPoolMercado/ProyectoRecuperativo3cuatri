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
    
    public partial class Tarjeta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarjeta()
        {
            this.Tipo_de_Pago = new HashSet<Tipo_de_Pago>();
        }
    
        public int Id_Tarjeta { get; set; }
        public Nullable<int> Num_Cuenta { get; set; }
        public string Tipo_Tarjeta { get; set; }
        public Nullable<System.DateTime> Fecha_Venc { get; set; }
        public Nullable<int> CVC { get; set; }
        public string Apellido_Pat { get; set; }
        public string Apellido_Mat { get; set; }
        public string Nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tipo_de_Pago> Tipo_de_Pago { get; set; }
    }
}