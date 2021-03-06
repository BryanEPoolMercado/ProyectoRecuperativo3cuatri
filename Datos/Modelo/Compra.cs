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
    
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            this.Detalle_Compra = new HashSet<Detalle_Compra>();
        }
    
        public int Id_Compra { get; set; }
        public Nullable<System.DateTime> Fecha_compra { get; set; }
        public Nullable<int> Id_Usuario { get; set; }
        public Nullable<int> Id_pago { get; set; }
        public Nullable<int> Id_Moneda { get; set; }
        public Nullable<int> Id_TipoPago { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }
        public virtual Tipo_de_Moneda Tipo_de_Moneda { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Tipo_de_Pago Tipo_de_Pago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
