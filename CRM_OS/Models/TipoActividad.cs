//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_OS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public  class TipoActividad
    {
        public TipoActividad()
        {
            this.Actividad = new HashSet<Actividad>();
        }
        [Key]
        public int idTipo { get; set; }
        public string nombre { get; set; }
        public string color { get; set; }
        public string imagen { get; set; }
    
        public virtual ICollection<Actividad> Actividad { get; set; }
    }
}
