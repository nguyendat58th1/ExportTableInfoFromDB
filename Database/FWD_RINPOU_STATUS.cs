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
    
    public partial class FWD_RINPOU_STATUS
    {
        public int SID { get; set; }
        public int REPORT_SCHEDULE_SID { get; set; }
        public int ORDER_SID { get; set; }
        public byte STP_RINPOU_STATUS { get; set; }
        public Nullable<int> STP_RINPOU_DATA_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
    
        public virtual FWD_REPORT_SCHEDULE FWD_REPORT_SCHEDULE { get; set; }
        public virtual OM_ORDER_INFO OM_ORDER_INFO { get; set; }
        public virtual FWD_STP_DATA FWD_STP_DATA { get; set; }
    }
}
