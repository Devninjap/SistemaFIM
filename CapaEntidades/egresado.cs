//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class egresado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public egresado()
        {
            this.solicitud = new HashSet<solicitud>();
        }
    
        public int idEgresado { get; set; }
        public string nomEgresado { get; set; }
        public string apePatEgresado { get; set; }
        public string apeMatEgresado { get; set; }
        public string dniEgresado { get; set; }
        public string codMatEgresado { get; set; }
        public string condicionEgresado { get; set; }
        public string domicilioEgresado { get; set; }
        public string celEgresado { get; set; }
        public string emailEgresado { get; set; }
        public byte[] fotografiaEgresado { get; set; }
        public string idFacultad { get; set; }
    
        public virtual facultad facultad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitud> solicitud { get; set; }
    }
}
