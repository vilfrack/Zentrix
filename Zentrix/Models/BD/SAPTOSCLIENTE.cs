//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zentrix.Models.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAPTOSCLIENTE
    {
        public string CodClie { get; set; }
        public string Periodo { get; set; }
        public int NroFacts { get; set; }
        public decimal Credito { get; set; }
        public decimal Contado { get; set; }
        public decimal MtoVentas { get; set; }
        public decimal Descto { get; set; }
        public decimal ValorPtos { get; set; }
        public Nullable<System.DateTime> FechaE { get; set; }
    }
}