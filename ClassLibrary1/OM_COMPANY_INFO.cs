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
    
    public partial class OM_COMPANY_INFO
    {
        public OM_COMPANY_INFO()
        {
            this.FWD_BUSINESS_CALENDER = new HashSet<FWD_BUSINESS_CALENDER>();
            this.ID_SCHEDULE_DATA = new HashSet<ID_SCHEDULE_DATA>();
            this.LK_BLUE_LINK_DURATION = new HashSet<LK_BLUE_LINK_DURATION>();
            this.LK_BLUE_LINK_ITEM = new HashSet<LK_BLUE_LINK_ITEM>();
            this.LK_ORANGE_LINK_ITEM = new HashSet<LK_ORANGE_LINK_ITEM>();
            this.LK_RED_LINK_TARGET_INDEX = new HashSet<LK_RED_LINK_TARGET_INDEX>();
            this.OM_ACCESS_GROUP_MASTER = new HashSet<OM_ACCESS_GROUP_MASTER>();
            this.OM_ATTACH_DOC_INFO = new HashSet<OM_ATTACH_DOC_INFO>();
            this.OM_AUTO_GRP_MST = new HashSet<OM_AUTO_GRP_MST>();
            this.OM_CHARGE_COMPANY_INFO = new HashSet<OM_CHARGE_COMPANY_INFO>();
            this.OM_COMPANY_ADDITIONAL_INFO = new HashSet<OM_COMPANY_ADDITIONAL_INFO>();
            this.OM_MST_GRP_MST = new HashSet<OM_MST_GRP_MST>();
            this.OM_FUND_INFO = new HashSet<OM_FUND_INFO>();
            this.OM_GENERAL_AUTHORITY_INFO = new HashSet<OM_GENERAL_AUTHORITY_INFO>();
            this.OM_OPTION_CONTRACT_INFO = new HashSet<OM_OPTION_CONTRACT_INFO>();
            this.OM_ORDER_INFO = new HashSet<OM_ORDER_INFO>();
            this.OM_PDF_INDEX_MODEL = new HashSet<OM_PDF_INDEX_MODEL>();
            this.OM_PDF_OUTPUT_PATTERN_SETTING = new HashSet<OM_PDF_OUTPUT_PATTERN_SETTING>();
            this.OM_USER_INFO = new HashSet<OM_USER_INFO>();
        }
    
        public int SID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string EDINET_CODE { get; set; }
        public string COMPANY_NAME { get; set; }
        public string COMPANY_NAME_RB { get; set; }
        public short VIP_FLAG { get; set; }
        public Nullable<int> PARENT_COMPANY_ID { get; set; }
        public short MAX_USER_NUMBER { get; set; }
        public short LOST_FLAG { get; set; }
        public short INVALIDATED_FLAG { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
    
        public virtual ICollection<FWD_BUSINESS_CALENDER> FWD_BUSINESS_CALENDER { get; set; }
        public virtual ICollection<ID_SCHEDULE_DATA> ID_SCHEDULE_DATA { get; set; }
        public virtual ICollection<LK_BLUE_LINK_DURATION> LK_BLUE_LINK_DURATION { get; set; }
        public virtual ICollection<LK_BLUE_LINK_ITEM> LK_BLUE_LINK_ITEM { get; set; }
        public virtual ICollection<LK_ORANGE_LINK_ITEM> LK_ORANGE_LINK_ITEM { get; set; }
        public virtual ICollection<LK_RED_LINK_TARGET_INDEX> LK_RED_LINK_TARGET_INDEX { get; set; }
        public virtual ICollection<OM_ACCESS_GROUP_MASTER> OM_ACCESS_GROUP_MASTER { get; set; }
        public virtual ICollection<OM_ATTACH_DOC_INFO> OM_ATTACH_DOC_INFO { get; set; }
        public virtual ICollection<OM_AUTO_GRP_MST> OM_AUTO_GRP_MST { get; set; }
        public virtual ICollection<OM_CHARGE_COMPANY_INFO> OM_CHARGE_COMPANY_INFO { get; set; }
        public virtual ICollection<OM_COMPANY_ADDITIONAL_INFO> OM_COMPANY_ADDITIONAL_INFO { get; set; }
        public virtual ICollection<OM_MST_GRP_MST> OM_MST_GRP_MST { get; set; }
        public virtual ICollection<OM_FUND_INFO> OM_FUND_INFO { get; set; }
        public virtual ICollection<OM_GENERAL_AUTHORITY_INFO> OM_GENERAL_AUTHORITY_INFO { get; set; }
        public virtual ICollection<OM_OPTION_CONTRACT_INFO> OM_OPTION_CONTRACT_INFO { get; set; }
        public virtual ICollection<OM_ORDER_INFO> OM_ORDER_INFO { get; set; }
        public virtual ICollection<OM_PDF_INDEX_MODEL> OM_PDF_INDEX_MODEL { get; set; }
        public virtual ICollection<OM_PDF_OUTPUT_PATTERN_SETTING> OM_PDF_OUTPUT_PATTERN_SETTING { get; set; }
        public virtual ICollection<OM_USER_INFO> OM_USER_INFO { get; set; }
    }
}
