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
    
    public partial class documento
    {
        public int idDocumento { get; set; }
        public string descDocumento { get; set; }
        public string tipoDocumento { get; set; }
        public System.DateTime fechaEmiDocumento { get; set; }
        public bool estadoDocumento { get; set; }
        public byte[] archivoDocumento { get; set; }
        public int idResponsable { get; set; }
        public string nomResponsable { get; set; }
        public string apePatResponsable { get; set; }
        public string apeMatResponsable { get; set; }
        public string cargoResponsable { get; set; }
        public string gradoAcaResponsable { get; set; }
        public int idSolicitud { get; set; }
        public int numRegSolicitud { get; set; }
        public System.DateTime fechaRecSolicitud { get; set; }
        public string nomEgreado { get; set; }
        public string apePatEgresado { get; set; }
        public string apeMatEgresado { get; set; }
        public string dniEgresado { get; set; }
        public string codMatEgresado { get; set; }
        public byte[] fotografiaEgresado { get; set; }
        public string nomUsuario { get; set; }
        public string contraUsuario { get; set; }
        public string nomPerUsuario { get; set; }
        public string apePatPerUsuario { get; set; }
        public string apeMatPerUsuario { get; set; }
        public string dniPerUsuario { get; set; }
    
        public virtual responsable responsable { get; set; }
        public virtual solicitud solicitud { get; set; }
    }
}