//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class DC_PRINT_INFO_DETAIL
    {
        public int SID { get; set; }
        public int JOB_SID { get; set; }
        public decimal PAGE_MARGIN_TOP { get; set; }
        public decimal PAGE_MARGIN_BOTTOM { get; set; }
        public decimal PAGE_MARGIN_LEFT { get; set; }
        public decimal PAGE_MARGIN_RIGHT { get; set; }
        public Nullable<decimal> ODD_BODY_MARGIN_LEFT { get; set; }
        public Nullable<decimal> ODD_BODY_MARGIN_RIGHT { get; set; }
        public Nullable<decimal> EVEN_BODY_MARGIN_LEFT { get; set; }
        public Nullable<decimal> EVEN_BODY_MARGIN_RIGHT { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public byte INDEX_TYPE { get; set; }
        public Nullable<byte> INDEX_SUFFIX_NUMBER { get; set; }
        public decimal FIRST_PAGE_MARGIN_TOP { get; set; }
        public decimal BODY_MARGIN_TOP { get; set; }
        public decimal BODY_MARGIN_BOTTOM { get; set; }
        public decimal BODY_MARGIN_LEFT { get; set; }
        public decimal BODY_MARGIN_RIGHT { get; set; }
    
        public virtual OM_JOB_INFO OM_JOB_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
    }
}
