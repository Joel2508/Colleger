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
    
    public partial class TBG_Personas
    {
        public string Cedula { get; set; }
        public bool bPasaporte { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string idSexo { get; set; }
        public string idEstadoCivil { get; set; }
        public string idEtnia { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
        public string LugarNac { get; set; }
        public Nullable<int> idNacionalidad { get; set; }
        public string Pasaporte { get; set; }
        public Nullable<int> idProfesion { get; set; }
        public string LugarTrabajo { get; set; }
        public Nullable<int> idPuestoTrabajo { get; set; }
        public bool bEmpleado { get; set; }
        public bool bExAlumno { get; set; }
        public bool bAsocPadre { get; set; }
        public string Comentarios { get; set; }
    }
}
