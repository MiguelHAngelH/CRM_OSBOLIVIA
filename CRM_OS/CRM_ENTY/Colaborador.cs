//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_OS.CRM_ENTY
{
    using System;
    using System.Collections.Generic;
    
    public partial class Colaborador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colaborador()
        {
            this.Actividad = new HashSet<Actividad>();
            this.Cuenta = new HashSet<Cuenta>();
            this.OportunidadNegocio = new HashSet<OportunidadNegocio>();
            this.Colaborador1 = new HashSet<Colaborador>();
            this.Colaborador2 = new HashSet<Colaborador>();
        }
    
        public int idColaborador { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public int idCargo { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public string correo { get; set; }
        public string nroDocumento { get; set; }
        public string area { get; set; }
        public string estado { get; set; }
    
        
        public virtual ICollection<Actividad> Actividad { get; set; }
        public virtual Usuario Usuario { get; set; }
        
        public virtual ICollection<Cuenta> Cuenta { get; set; }
        
        public virtual ICollection<OportunidadNegocio> OportunidadNegocio { get; set; }
        
        public virtual ICollection<Colaborador> Colaborador1 { get; set; }
        
        public virtual ICollection<Colaborador> Colaborador2 { get; set; }
    }
}
