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

    public  class TipoProducto
    {
        public TipoProducto()
        {
            this.Producto = new HashSet<Producto>();
        }
        [Key]
        public int idTipo { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
