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
    
    public partial class XB_PTRN_REF
    {
        public long SID { get; set; }
        public int FS_SID { get; set; }
        public string INDUSTRY_CODE { get; set; }
        public string REGULATION_CODE { get; set; }
        public string FS_CODE { get; set; }
        public string PATTERN_NAME { get; set; }
    
        public virtual XB_FS_INFO XB_FS_INFO { get; set; }
    }
}
