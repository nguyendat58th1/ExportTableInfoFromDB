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
    
    public partial class DC_INDEX_SYN_SETTING
    {
        public int SID { get; set; }
        public int SRC_JOB_SID { get; set; }
        public int DST_JOB_SID { get; set; }
        public int SRC_INDEX_SID { get; set; }
        public int DST_INDEX_SID { get; set; }
        public byte CONTENTS_COPY_TYPE { get; set; }
        public bool DISCONNECT_STATUS { get; set; }
        public bool DISCONNECTED_FLAG { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
    
        public virtual DC_INDEX_INFO DC_INDEX_INFO { get; set; }
        public virtual DC_INDEX_INFO DC_INDEX_INFO1 { get; set; }
        public virtual OM_JOB_INFO OM_JOB_INFO { get; set; }
        public virtual OM_JOB_INFO OM_JOB_INFO1 { get; set; }
    }
}
