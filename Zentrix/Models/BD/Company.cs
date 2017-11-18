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
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.CompanyJoin = new HashSet<CompanyJoin>();
        }
    
        public string ID_Entity { get; set; }
        public string Descrip { get; set; }
        public string IDLabel { get; set; }
        public string IDFiscal { get; set; }
        public string ID_TypeEntity { get; set; }
        public byte EtySize { get; set; }
        public byte EtyCapital { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WEB { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Nullable<System.DateTime> dtDate { get; set; }
        public short siPeriodDef { get; set; }
        public bool boStatus { get; set; }
        public string DBPassword { get; set; }
        public string MaskCode { get; set; }
        public short EtyConsol { get; set; }
        public string ID_Master { get; set; }
        public Nullable<System.DateTime> dtMigrated { get; set; }
        public string Reserved { get; set; }
        public short Prefix { get; set; }
    
        public virtual CompaniyType CompaniyType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyJoin> CompanyJoin { get; set; }
    }
}
