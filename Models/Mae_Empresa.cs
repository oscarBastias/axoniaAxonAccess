//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AxonAccessMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mae_Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mae_Empresa()
        {
            this.Mae_Puerta = new HashSet<Mae_Puerta>();
            this.Mae_Usuario = new HashSet<Mae_Usuario>();
            this.Mae_Sucursal = new HashSet<Mae_Sucursal>();
        }
    
        public int id_empresa { get; set; }
        public Nullable<int> id_comuna { get; set; }
        public string desc_empresa { get; set; }
    
        public virtual Mae_Comuna Mae_Comuna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mae_Puerta> Mae_Puerta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mae_Usuario> Mae_Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mae_Sucursal> Mae_Sucursal { get; set; }
    }
}
