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
    
    public partial class DC_SUBMIT_FILE_INIT_SETTING
    {
        public long SID { get; set; }
        public int ORDER_SID { get; set; }
        public int CREATE_USER_SID { get; set; }
        public short SUBMIT_COUNT { get; set; }
        public System.DateTime FILLING_DATE { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public Nullable<System.DateTime> CORRECTION_TARGET_SUBMIT_DATE { get; set; }
        public Nullable<System.DateTime> DUTY_TO_REPORT_DATE { get; set; }
        public Nullable<short> SUBMITTING_DOC_SEQ { get; set; }
        public Nullable<short> CORRECT_SUBMIT_DATE_USED_FLAG { get; set; }
        public short ATTACH_DOC_OUTPUT_FLAG { get; set; }
        public short SUBMIT_TYPE { get; set; }
    
        public virtual OM_ORDER_INFO OM_ORDER_INFO { get; set; }
    }
}
