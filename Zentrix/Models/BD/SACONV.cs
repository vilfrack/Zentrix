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
    
    public partial class SACONV
    {
        public string CodConv { get; set; }
        public string CodSucu { get; set; }
        public string Descrip { get; set; }
        public string Autori { get; set; }
        public string Respon { get; set; }
        public Nullable<System.DateTime> FechaE { get; set; }
        public Nullable<System.DateTime> FechaV { get; set; }
        public short EsFijo { get; set; }
        public short TipoCnv { get; set; }
        public short EsBase { get; set; }
        public int Frecuencia { get; set; }
        public Nullable<System.DateTime> FechaUC { get; set; }
        public short Activo { get; set; }
    }
}
