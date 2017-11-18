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
    
    public partial class SBDTRN
    {
        public int NOpe { get; set; }
        public int NLinea { get; set; }
        public int EsTransf { get; set; }
        public int EsCuenta { get; set; }
        public string CodUsua { get; set; }
        public string CodOper { get; set; }
        public string CodEsta { get; set; }
        public int CDCD { get; set; }
        public int EncOpe { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Origen { get; set; }
        public int Estado { get; set; }
        public int DH { get; set; }
        public int NMo { get; set; }
        public decimal BaseTr { get; set; }
        public decimal Monto { get; set; }
        public decimal MtoDb { get; set; }
        public decimal MtoCr { get; set; }
        public int Consolidado { get; set; }
        public Nullable<System.DateTime> FConsolidado { get; set; }
        public int SiCentro { get; set; }
        public int SiTercero { get; set; }
        public string CodCenCto { get; set; }
        public string CodTercero { get; set; }
        public string Tercero { get; set; }
        public string CodBanc { get; set; }
        public string CodCta { get; set; }
        public string CodSucu { get; set; }
        public Nullable<decimal> FlujoE { get; set; }
    }
}
