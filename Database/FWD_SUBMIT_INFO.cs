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
    
    public partial class FWD_SUBMIT_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FWD_SUBMIT_INFO()
        {
            this.FWD_SUBMIT_DATA = new HashSet<FWD_SUBMIT_DATA>();
        }
    
        public int SID { get; set; }
        public string DOCUMENT_MANAGEMENT_ID { get; set; }
        public string EDINET_CODE { get; set; }
        public string SEC_CODE { get; set; }
        public string JCN { get; set; }
        public string FILER_NAME { get; set; }
        public string FUND_CODE { get; set; }
        public string ORDINANCE_CODE { get; set; }
        public string ORDINANCE_NAME { get; set; }
        public string FORM_CODE { get; set; }
        public string FORM_ID { get; set; }
        public string FORM_NAME { get; set; }
        public string DOC_TYPE_CODE { get; set; }
        public string DOC_TYPE { get; set; }
        public Nullable<System.DateTime> PERIOD_START { get; set; }
        public Nullable<System.DateTime> PERIOD_END { get; set; }
        public System.DateTime SUBMIT_DATE_TIME { get; set; }
        public string DOC_DESCRIPTION { get; set; }
        public string ISSUER_EDINET_CODE { get; set; }
        public string SUBJECT_EDINET_CODE { get; set; }
        public string SUBSIDIARY_EDINET_CODE { get; set; }
        public string CURRENT_REPORT_REASON { get; set; }
        public string PARENT_DOC_ID { get; set; }
        public Nullable<System.DateTime> OPE_DATE_TIME { get; set; }
        public Nullable<int> ORDER_SID { get; set; }
        public bool WITHDRAWAL_STATUS { get; set; }
        public bool DOC_INFO_EDIT_STATUS { get; set; }
        public bool DISCLOSURE_STATUS { get; set; }
        public bool XBRL_FLAG { get; set; }
        public bool PDF_FLAG { get; set; }
        public bool ATTACH_DOC_FLAG { get; set; }
        public bool ENGLISH_DOC_FLAG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FWD_SUBMIT_DATA> FWD_SUBMIT_DATA { get; set; }
        public virtual OM_ORDER_INFO OM_ORDER_INFO { get; set; }
    }
}
