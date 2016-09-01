//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.ENTITY
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actividad
    {
        public int idActividad { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public int idCuenta { get; set; }
        public string asunto { get; set; }
        public int idObjetivo { get; set; }
        public int idPrioridad { get; set; }
        public int idTipoActividad { get; set; }
        public string descripcion { get; set; }
        public int idResponsable { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFinal { get; set; }
        public System.TimeSpan horaInicio { get; set; }
        public System.TimeSpan horaFin { get; set; }
        public System.TimeSpan tiempoReal { get; set; }
        public string alerta { get; set; }
        public string estado { get; set; }
        public string resultado { get; set; }
        public string direccion { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
        public virtual Cuenta Cuenta { get; set; }
        public virtual Objetivo Objetivo { get; set; }
        public virtual Prioridad Prioridad { get; set; }
        public virtual TipoActividad TipoActividad { get; set; }
    }
}