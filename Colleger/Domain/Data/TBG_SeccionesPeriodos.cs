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
    
    public partial class TBG_SeccionesPeriodos
    {
        public string idPeriodo { get; set; }
        public string idCurso { get; set; }
        public string idSeccion { get; set; }
        public Nullable<int> Capacidad { get; set; }
        public Nullable<int> CapacidadAlerta { get; set; }
        public Nullable<int> idMaestroGuia { get; set; }
        public string CedulaPadreGuia1 { get; set; }
        public string CedulaPadreGuia2 { get; set; }
        public string CedulaPadreGuia3 { get; set; }
        public string CedulaPadreGuia4 { get; set; }
    }
}
