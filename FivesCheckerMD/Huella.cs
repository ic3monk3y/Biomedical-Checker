//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Huella
    {
        public int ID { get; set; }
        public string Huella1 { get; set; }
        public string Foto { get; set; }
        public string IDEmpleado { get; set; }
        public int Dedo { get; set; }
        public Nullable<bool> SincroCheck { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public byte[] FotoPersonal { get; set; }
        public byte[] HuellaByte { get; set; }
        public Nullable<int> SucursalID { get; set; }
    }
}
