//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIDEMO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EVALUACION_TED
    {
        public decimal CODEVALUACION { get; set; }
        public decimal CODEVALUACIONTIPO { get; set; }
        public decimal CODEVALUACIONINTERPRETACION { get; set; }
        public string EVALUACION { get; set; }
        public System.DateTime FECHAINI { get; set; }
        public System.DateTime FECHAFIN { get; set; }
        public System.DateTime FECHACIERRE { get; set; }
        public string OBS { get; set; }
        public string ESTADO { get; set; }
        public decimal CODEVALUACIONCLASE { get; set; }
        public string ESVERSIONANTERIOR { get; set; }
        public Nullable<System.DateTime> fechaconcertacion { get; set; }
        public Nullable<System.DateTime> fechaseguimiento1 { get; set; }
        public Nullable<System.DateTime> fechaseguimiento2 { get; set; }
        public Nullable<System.DateTime> fechacalificacion { get; set; }
        public Nullable<System.DateTime> fechacalificacion2 { get; set; }
        public Nullable<System.DateTime> fechaseguimiento3 { get; set; }
    }
}
