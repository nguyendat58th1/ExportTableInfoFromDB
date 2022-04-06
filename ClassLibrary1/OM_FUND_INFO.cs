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
    
    public partial class OM_FUND_INFO
    {
        public OM_FUND_INFO()
        {
            this.ID_PERFORMANCE_DATA = new HashSet<ID_PERFORMANCE_DATA>();
            this.LK_BLUE_LINK_RELATION_ENTRY = new HashSet<LK_BLUE_LINK_RELATION_ENTRY>();
            this.LK_BLUE_LINK_RELATION_PUBLISH = new HashSet<LK_BLUE_LINK_RELATION_PUBLISH>();
            this.OM_AGREEMENT_RELATION = new HashSet<OM_AGREEMENT_RELATION>();
            this.OM_ATTACH_DOC_SHINKYUU_INFO = new HashSet<OM_ATTACH_DOC_SHINKYUU_INFO>();
            this.OM_ORDER_GROUP = new HashSet<OM_ORDER_GROUP>();
            this.OM_ORDER_INFO = new HashSet<OM_ORDER_INFO>();
            this.OM_RELATION_FUND = new HashSet<OM_RELATION_FUND>();
            this.OM_RELATION_FUND1 = new HashSet<OM_RELATION_FUND>();
            this.OM_MST_GRP_FUND_REF = new HashSet<OM_MST_GRP_FUND_REF>();
        }
    
        public int SID { get; set; }
        public int COMPANY_SID { get; set; }
        public string FUND_CODE { get; set; }
        public string FUND_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public string FUND_FORMAL_NAME { get; set; }
        public short FUND_TYPE { get; set; }
        public short ACCOUNT_TYPE { get; set; }
        public string FUND_ABBREVIATION_NAME { get; set; }
    
        public virtual ICollection<ID_PERFORMANCE_DATA> ID_PERFORMANCE_DATA { get; set; }
        public virtual ICollection<LK_BLUE_LINK_RELATION_ENTRY> LK_BLUE_LINK_RELATION_ENTRY { get; set; }
        public virtual ICollection<LK_BLUE_LINK_RELATION_PUBLISH> LK_BLUE_LINK_RELATION_PUBLISH { get; set; }
        public virtual ICollection<OM_AGREEMENT_RELATION> OM_AGREEMENT_RELATION { get; set; }
        public virtual ICollection<OM_ATTACH_DOC_SHINKYUU_INFO> OM_ATTACH_DOC_SHINKYUU_INFO { get; set; }
        public virtual OM_COMPANY_INFO OM_COMPANY_INFO { get; set; }
        public virtual ICollection<OM_ORDER_GROUP> OM_ORDER_GROUP { get; set; }
        public virtual ICollection<OM_ORDER_INFO> OM_ORDER_INFO { get; set; }
        public virtual ICollection<OM_RELATION_FUND> OM_RELATION_FUND { get; set; }
        public virtual ICollection<OM_RELATION_FUND> OM_RELATION_FUND1 { get; set; }
        public virtual ICollection<OM_MST_GRP_FUND_REF> OM_MST_GRP_FUND_REF { get; set; }
    }
}
