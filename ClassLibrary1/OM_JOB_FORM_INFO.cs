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
    
    public partial class OM_JOB_FORM_INFO
    {
        public int SID { get; set; }
        public int JOB_SID { get; set; }
        public int DOC_BIND_ID { get; set; }
        public int DOC_FORM_ID { get; set; }
        public int DOC_ORDINANCE_ID { get; set; }
        public int DOC_COUNTRY_ID { get; set; }
        public int DOC_FORM_NUM_ID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual OM_JOB_INFO OM_JOB_INFO { get; set; }
    }
}
