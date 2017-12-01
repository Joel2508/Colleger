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
    
    public partial class TBA_Evaluaciones
    {
        public string idEvaluacion { get; set; }
        public string idPeriodo { get; set; }
        public string idSemestre { get; set; }
        public string idCurso { get; set; }
        public string Nombre { get; set; }
        public string Prefijo { get; set; }
        public string Tipo { get; set; }
        public bool bFinal { get; set; }
        public string Formula { get; set; }
        public string FormulaConducta { get; set; }
        public int Orden { get; set; }
        public int OrdenActa { get; set; }
        public string idTipoEvaluacion { get; set; }
        public string PrefijoGrupal { get; set; }
        public Nullable<int> OrdenPrefijoGrupal { get; set; }
        public bool bMostrarPromedio { get; set; }
        public bool bMostrarConducta { get; set; }
        public bool bMostrarIndice { get; set; }
        public bool bMostrarBoletin { get; set; }
        public bool bPromediable { get; set; }
        public Nullable<System.DateTime> FechaInicioDigitacion { get; set; }
        public Nullable<System.DateTime> FechaLimiteDigitacion { get; set; }
        public Nullable<System.DateTime> FechaPublicacion { get; set; }
        public Nullable<System.DateTime> FechaInicioAsistencia { get; set; }
        public Nullable<System.DateTime> FechaFinAsistencia { get; set; }
    }
}
