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
    
    public partial class OM_AGREEMENT_RELATION
    {
        public int SID { get; set; }
        public int FUND_SID { get; set; }
        public int ATTACH_DOC_SID { get; set; }
        public byte DISPLAY_ORDER { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual OM_ATTACH_DOC_INFO OM_ATTACH_DOC_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_FUND_INFO OM_FUND_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
    }
}
