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
    
    public partial class RegistroXML
    {
        public int ID { get; set; }
        public Nullable<int> OrigenID { get; set; }
        public string OrigenXML { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
        public Nullable<bool> Enviado { get; set; }
        public Nullable<System.DateTime> FechaEnviado { get; set; }
        public Nullable<System.DateTime> FechaProcesado { get; set; }
        public Nullable<int> Sucursal { get; set; }
    }
}
