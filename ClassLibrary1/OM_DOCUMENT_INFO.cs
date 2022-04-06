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
    
    public partial class OM_DOCUMENT_INFO
    {
        public OM_DOCUMENT_INFO()
        {
            this.DC_DOCUMENT_DATA = new HashSet<DC_DOCUMENT_DATA>();
            this.DC_DOCUMENT_HISTORY = new HashSet<DC_DOCUMENT_HISTORY>();
            this.DC_INDEX_INFO = new HashSet<DC_INDEX_INFO>();
            this.ID_INDESIGN_IMG = new HashSet<ID_INDESIGN_IMG>();
            this.OM_DOC_COMMENT = new HashSet<OM_DOC_COMMENT>();
            this.OM_DOCUMENT_ACCESS_INFO = new HashSet<OM_DOCUMENT_ACCESS_INFO>();
            this.OM_DOCUMENT_BASE_INFO = new HashSet<OM_DOCUMENT_BASE_INFO>();
            this.OM_DOCUMENT_CHECKOUT = new HashSet<OM_DOCUMENT_CHECKOUT>();
            this.XB_CONTEXT = new HashSet<XB_CONTEXT>();
            this.XB_FOOTNOTE = new HashSet<XB_FOOTNOTE>();
            this.XB_MEDURE = new HashSet<XB_MEDURE>();
            this.XB_UNIT = new HashSet<XB_UNIT>();
        }
    
        public int SID { get; set; }
        public int JOB_SID { get; set; }
        public string IDENTIFICATION { get; set; }
        public int EDIT_AUTHORITY { get; set; }
        public Nullable<System.DateTime> CHECKOUT_DATE { get; set; }
        public Nullable<int> CHECKOUT_USER_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public short UPDATE_CONTENTS_REQUEST_FLAG { get; set; }
    
        public virtual ICollection<DC_DOCUMENT_DATA> DC_DOCUMENT_DATA { get; set; }
        public virtual ICollection<DC_DOCUMENT_HISTORY> DC_DOCUMENT_HISTORY { get; set; }
        public virtual ICollection<DC_INDEX_INFO> DC_INDEX_INFO { get; set; }
        public virtual ICollection<ID_INDESIGN_IMG> ID_INDESIGN_IMG { get; set; }
        public virtual ICollection<OM_DOC_COMMENT> OM_DOC_COMMENT { get; set; }
        public virtual ICollection<OM_DOCUMENT_ACCESS_INFO> OM_DOCUMENT_ACCESS_INFO { get; set; }
        public virtual ICollection<OM_DOCUMENT_BASE_INFO> OM_DOCUMENT_BASE_INFO { get; set; }
        public virtual ICollection<OM_DOCUMENT_CHECKOUT> OM_DOCUMENT_CHECKOUT { get; set; }
        public virtual ICollection<XB_CONTEXT> XB_CONTEXT { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO1 { get; set; }
        public virtual OM_USER_INFO OM_USER_INFO2 { get; set; }
        public virtual OM_JOB_INFO OM_JOB_INFO { get; set; }
        public virtual ICollection<XB_FOOTNOTE> XB_FOOTNOTE { get; set; }
        public virtual ICollection<XB_MEDURE> XB_MEDURE { get; set; }
        public virtual ICollection<XB_UNIT> XB_UNIT { get; set; }
    }
}
