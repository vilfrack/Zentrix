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
    
    public partial class Rates
    {
        public string ID_Currency { get; set; }
        public short siYear { get; set; }
        public byte siMonth { get; set; }
        public decimal CurrencyRate { get; set; }
    
        public virtual Currency Currency { get; set; }
    }
}