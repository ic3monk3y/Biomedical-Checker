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
    
    public partial class Jornada
    {
        public int ID { get; set; }
        public string Jornada1 { get; set; }
        public Nullable<int> Tipo { get; set; }
        public bool Domingo { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public Nullable<bool> DescansoRompeRutina { get; set; }
        public Nullable<bool> DescansaFestivos { get; set; }
        public Nullable<bool> FestivoRompeRutina { get; set; }
        public Nullable<double> HorasPromedio { get; set; }
        public Nullable<double> HorasSemana { get; set; }
        public Nullable<double> HorasComida { get; set; }
        public Nullable<double> FactorAusentismo { get; set; }
        public Nullable<bool> JornadaReducida { get; set; }
        public Nullable<int> ClaveSAT { get; set; }
        public Nullable<int> Estatus { get; set; }
        public Nullable<int> EmpresaID { get; set; }
    }
}
