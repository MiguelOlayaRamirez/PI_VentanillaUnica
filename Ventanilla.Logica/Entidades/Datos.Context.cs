﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Cnx : DbContext
    {
        public Cnx()
            : base("name=Cnx")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Administracion> Administracion { get; set; }
        public DbSet<Despacho> Despacho { get; set; }
        public DbSet<Proceso> Proceso { get; set; }
        public DbSet<Radicado> Radicado { get; set; }
        public DbSet<Terceros> Terceros { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
