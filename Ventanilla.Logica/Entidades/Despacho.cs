//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ventanilla.Logica.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Despacho
    {
        public Despacho()
        {
            this.Administracion = new HashSet<Administracion>();
        }
    
        public long CodDespacho { get; set; }
        public string DescDespacho { get; set; }
        public string DestinoDespacho { get; set; }
        public string Fecha_Despacho { get; set; }
    
        public virtual ICollection<Administracion> Administracion { get; set; }
    }
}
