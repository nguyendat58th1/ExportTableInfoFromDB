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
    
    public partial class DC_DOCUMENT_HISTORY_COPY_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DC_DOCUMENT_HISTORY_COPY_INFO()
        {
            this.DC_DOCUMENT_HISTORY_COPY_DATA = new HashSet<DC_DOCUMENT_HISTORY_COPY_DATA>();
        }
    
        public int SID { get; set; }
        public int JOB_SID { get; set; }
        public string TITLE { get; set; }
        public string ELEMET_ID { get; set; }
        public string EDINET_SEQ_CODE { get; set; }
        public byte INDEX_TYPE { get; set; }
        public bool AUDIT_TYPE { get; set; }
        public byte[] STYLE_DATA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DC_DOCUMENT_HISTORY_COPY_DATA> DC_DOCUMENT_HISTORY_COPY_DATA { get; set; }
        public virtual OM_JOB_INFO OM_JOB_INFO { get; set; }
    }
}
