﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FivesCheckerMD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FivescheckerEntities : DbContext
    {
        public FivescheckerEntities()
            : base("name=FivescheckerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Huella> Huella { get; set; }
        public virtual DbSet<Jornada> Jornada { get; set; }
        public virtual DbSet<JornadaD> JornadaD { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Puestos> Puestos { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }
        public virtual DbSet<RegistroXML> RegistroXML { get; set; }
        public virtual DbSet<Solicitud> Solicitud { get; set; }
        public virtual DbSet<SolicitudD> SolicitudD { get; set; }
        public virtual DbSet<SolicitudLog> SolicitudLog { get; set; }
        public virtual DbSet<SolicitudXML> SolicitudXML { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }
        public virtual DbSet<Tiempo> Tiempo { get; set; }
        public virtual DbSet<ZonaHoraria> ZonaHoraria { get; set; }
    
        public virtual ObjectResult<string> sp_Huella(string accion, string huella, string foto, string iDEmpleado, string dedo, string usuario, Nullable<int> sucursal)
        {
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var huellaParameter = huella != null ?
                new ObjectParameter("Huella", huella) :
                new ObjectParameter("Huella", typeof(string));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(string));
    
            var iDEmpleadoParameter = iDEmpleado != null ?
                new ObjectParameter("IDEmpleado", iDEmpleado) :
                new ObjectParameter("IDEmpleado", typeof(string));
    
            var dedoParameter = dedo != null ?
                new ObjectParameter("Dedo", dedo) :
                new ObjectParameter("Dedo", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var sucursalParameter = sucursal.HasValue ?
                new ObjectParameter("Sucursal", sucursal) :
                new ObjectParameter("Sucursal", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_Huella", accionParameter, huellaParameter, fotoParameter, iDEmpleadoParameter, dedoParameter, usuarioParameter, sucursalParameter);
        }
    
        public virtual int spActualiarImgPersonal(string user, byte[] fotoByte)
        {
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            var fotoByteParameter = fotoByte != null ?
                new ObjectParameter("FotoByte", fotoByte) :
                new ObjectParameter("FotoByte", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spActualiarImgPersonal", userParameter, fotoByteParameter);
        }
    
        public virtual int spActualizaEstaPresente(string tipo)
        {
            var tipoParameter = tipo != null ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spActualizaEstaPresente", tipoParameter);
        }
    
        public virtual ObjectResult<string> spEnviarCheckerSincroID(Nullable<int> registroID)
        {
            var registroIDParameter = registroID.HasValue ?
                new ObjectParameter("RegistroID", registroID) :
                new ObjectParameter("RegistroID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spEnviarCheckerSincroID", registroIDParameter);
        }
    
        public virtual ObjectResult<string> spNvoRegistroAsistencia(string accion, string personal, string usuario, string huella)
        {
            var accionParameter = accion != null ?
                new ObjectParameter("Accion", accion) :
                new ObjectParameter("Accion", typeof(string));
    
            var personalParameter = personal != null ?
                new ObjectParameter("Personal", personal) :
                new ObjectParameter("Personal", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var huellaParameter = huella != null ?
                new ObjectParameter("Huella", huella) :
                new ObjectParameter("Huella", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spNvoRegistroAsistencia", accionParameter, personalParameter, usuarioParameter, huellaParameter);
        }
    
        public virtual int spRegistroHuellas(string personal, Nullable<int> dedo, byte[] huella)
        {
            var personalParameter = personal != null ?
                new ObjectParameter("Personal", personal) :
                new ObjectParameter("Personal", typeof(string));
    
            var dedoParameter = dedo.HasValue ?
                new ObjectParameter("Dedo", dedo) :
                new ObjectParameter("Dedo", typeof(int));
    
            var huellaParameter = huella != null ?
                new ObjectParameter("Huella", huella) :
                new ObjectParameter("Huella", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRegistroHuellas", personalParameter, dedoParameter, huellaParameter);
        }
    
        public virtual int spRegistrosChecker()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRegistrosChecker");
        }
    
        public virtual int spSincroAUTO(string tIPO, string server)
        {
            var tIPOParameter = tIPO != null ?
                new ObjectParameter("TIPO", tIPO) :
                new ObjectParameter("TIPO", typeof(string));
    
            var serverParameter = server != null ?
                new ObjectParameter("server", server) :
                new ObjectParameter("server", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSincroAUTO", tIPOParameter, serverParameter);
        }
    
        public virtual int spSincroInicial(string parametro1, Nullable<int> parametro2, byte[] parametro3)
        {
            var parametro1Parameter = parametro1 != null ?
                new ObjectParameter("Parametro1", parametro1) :
                new ObjectParameter("Parametro1", typeof(string));
    
            var parametro2Parameter = parametro2.HasValue ?
                new ObjectParameter("Parametro2", parametro2) :
                new ObjectParameter("Parametro2", typeof(int));
    
            var parametro3Parameter = parametro3 != null ?
                new ObjectParameter("Parametro3", parametro3) :
                new ObjectParameter("Parametro3", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSincroInicial", parametro1Parameter, parametro2Parameter, parametro3Parameter);
        }
    
        public virtual int spSolicitudAUTO(string personal, Nullable<int> tincidencia, Nullable<double> cantidad, Nullable<System.DateTime> fechad, Nullable<System.DateTime> fechaa, string referencia, Nullable<int> concepto)
        {
            var personalParameter = personal != null ?
                new ObjectParameter("Personal", personal) :
                new ObjectParameter("Personal", typeof(string));
    
            var tincidenciaParameter = tincidencia.HasValue ?
                new ObjectParameter("Tincidencia", tincidencia) :
                new ObjectParameter("Tincidencia", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(double));
    
            var fechadParameter = fechad.HasValue ?
                new ObjectParameter("Fechad", fechad) :
                new ObjectParameter("Fechad", typeof(System.DateTime));
    
            var fechaaParameter = fechaa.HasValue ?
                new ObjectParameter("Fechaa", fechaa) :
                new ObjectParameter("Fechaa", typeof(System.DateTime));
    
            var referenciaParameter = referencia != null ?
                new ObjectParameter("Referencia", referencia) :
                new ObjectParameter("Referencia", typeof(string));
    
            var conceptoParameter = concepto.HasValue ?
                new ObjectParameter("Concepto", concepto) :
                new ObjectParameter("Concepto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSolicitudAUTO", personalParameter, tincidenciaParameter, cantidadParameter, fechadParameter, fechaaParameter, referenciaParameter, conceptoParameter);
        }
    
        public virtual int spSolicitudchecker()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSolicitudchecker");
        }
    
        public virtual ObjectResult<spValidarPersonal_Result> spValidarPersonal(string personal)
        {
            var personalParameter = personal != null ?
                new ObjectParameter("Personal", personal) :
                new ObjectParameter("Personal", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spValidarPersonal_Result>("spValidarPersonal", personalParameter);
        }
    }
}