//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBG_Empleados
    {
        public int idEmpleado { get; set; }
        public string Cedula { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaContrato { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public string SeguroSocial { get; set; }
        public Nullable<bool> bPensionado { get; set; }
        public string Conyugue { get; set; }
        public string Labor { get; set; }
        public bool bStatus { get; set; }
    }
}