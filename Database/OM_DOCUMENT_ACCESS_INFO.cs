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
    
    public partial class OM_DOCUMENT_ACCESS_INFO
    {
        public long SID { get; set; }
        public int ACCESS_GROUP_MASTER_ID { get; set; }
        public int JOB_ID { get; set; }
        public int DOC_ID { get; set; }
        public bool DOC_ACCESS_RIGHT { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual OM_ACCESS_GROUP_MASTER OM_ACCESS_GROUP_MASTER { get; set; }
        public virtual OM_DOCUMENT_INFO OM_DOCUMENT_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_JOB_INFO OM_JOB_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
    }
}
