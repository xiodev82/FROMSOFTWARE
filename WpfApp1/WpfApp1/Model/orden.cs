//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class orden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orden()
        {
            this.ordenProductos = new HashSet<ordenProductos>();
            this.ordenPromocion = new HashSet<ordenPromocion>();
            this.factura = new HashSet<factura>();
        }
    
        public int codOrden { get; set; }
        public string nitClienteFK { get; set; }
        public string observaciones { get; set; }
        public Nullable<bool> estadoOrden { get; set; }
        public Nullable<int> codUsuarioFK { get; set; }
        public Nullable<bool> eliminar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordenProductos> ordenProductos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ordenPromocion> ordenPromocion { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual clientes clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> factura { get; set; }
    }
}
