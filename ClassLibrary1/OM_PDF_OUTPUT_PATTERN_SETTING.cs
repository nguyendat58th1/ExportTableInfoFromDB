//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class OM_PDF_OUTPUT_PATTERN_SETTING
    {
        public int SID { get; set; }
        public int COMPANY_SID { get; set; }
        public byte[] SEIMOKU_PDF_SETTING { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual OM_COMPANY_INFO OM_COMPANY_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
    }
}
