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
    
    public partial class FWD_AUDIT_SCHEDULE
    {
        public int SID { get; set; }
        public System.DateTime FISCAL_DATE { get; set; }
        public Nullable<System.DateTime> PERIOD_START { get; set; }
        public string EDINET_FUND_CODE { get; set; }
        public string FUND_CODE { get; set; }
        public string FUND_NAME { get; set; }
        public string MOTHER_FUND_CODE { get; set; }
        public string MOTHER_FUND_NAME { get; set; }
        public string PERIOD { get; set; }
        public string CREATE_REASON { get; set; }
        public string OFFERING { get; set; }
        public string INVESTMENT_TRUST_TYPE { get; set; }
        public Nullable<short> OLD_COMPANY_DIVISION { get; set; }
        public string AUDIT_NOTE { get; set; }
        public Nullable<System.DateTime> SUBMISSION_DEADLINE { get; set; }
        public Nullable<System.DateTime> AUDIT_COMPLETION_PERIOD { get; set; }
        public Nullable<System.DateTime> AUDIT_PERIOD { get; set; }
        public Nullable<System.DateTime> SUBMIT_DATE { get; set; }
        public string SCHEDULE_STATUS { get; set; }
    }
}
