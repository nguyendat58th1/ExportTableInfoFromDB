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
    
    public partial class FWD_FINANCIAL_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FWD_FINANCIAL_STATUS()
        {
            this.FWD_KANRYU_SCHEDULE = new HashSet<FWD_KANRYU_SCHEDULE>();
        }
    
        public int SID { get; set; }
        public int REPORT_SCHEDULE_SID { get; set; }
        public int ORDER_SID { get; set; }
        public byte STP_ACCOUNTING_STATUS { get; set; }
        public Nullable<int> STP_ACCOUNTING_DATA_SID { get; set; }
        public byte STP_OPERATIONAL_STATUS { get; set; }
        public Nullable<int> STP_OPERATIONAL_DATA_SID { get; set; }
        public byte STP_REFERENCE_STATUS { get; set; }
        public Nullable<int> STP_REFERENCE_DATA_SID { get; set; }
        public byte STP_BUSINESS_STATUS { get; set; }
        public Nullable<int> STP_BUSINESS_DATA_SID { get; set; }
        public byte K_COOPETATION_STATUS { get; set; }
        public byte K_CORRECTION_STATUS { get; set; }
        public bool KANRYU_FUND_ENTRY_ERROR { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
    
        public virtual FWD_STP_DATA FWD_STP_DATA { get; set; }
        public virtual FWD_STP_DATA FWD_STP_DATA1 { get; set; }
        public virtual FWD_STP_DATA FWD_STP_DATA2 { get; set; }
        public virtual OM_ORDER_INFO OM_ORDER_INFO { get; set; }
        public virtual FWD_STP_DATA FWD_STP_DATA3 { get; set; }
        public virtual FWD_REPORT_SCHEDULE FWD_REPORT_SCHEDULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FWD_KANRYU_SCHEDULE> FWD_KANRYU_SCHEDULE { get; set; }
    }
}
