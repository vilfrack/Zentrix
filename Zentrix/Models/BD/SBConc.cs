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
    
    public partial class SBConc
    {
        public int NoConc { get; set; }
        public string CodUsua { get; set; }
        public string Descripcion { get; set; }
        public string NoCuenta { get; set; }
        public System.DateTime FechaI { get; set; }
        public decimal SaldoI { get; set; }
        public int NoDepoC { get; set; }
        public int NoCredC { get; set; }
        public int NoCheqC { get; set; }
        public int NoNDebC { get; set; }
        public decimal MtDepoC { get; set; }
        public decimal MtCredC { get; set; }
        public decimal MtCheqC { get; set; }
        public decimal MtNDebC { get; set; }
        public int NoDepoT { get; set; }
        public int NoCredT { get; set; }
        public int NoCheqT { get; set; }
        public int NoNDebT { get; set; }
        public decimal MtDepoT { get; set; }
        public decimal MtCredT { get; set; }
        public decimal MtCheqT { get; set; }
        public decimal MtNDebT { get; set; }
        public System.DateTime FechaF { get; set; }
        public decimal SaldoF { get; set; }
        public decimal SaldoLib { get; set; }
        public string CodBanc { get; set; }
    }
}
