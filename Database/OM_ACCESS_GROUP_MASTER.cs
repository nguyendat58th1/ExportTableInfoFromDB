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
    
    public partial class OM_ACCESS_GROUP_MASTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OM_ACCESS_GROUP_MASTER()
        {
            this.OM_ACCESS_GROUP_INFO = new HashSet<OM_ACCESS_GROUP_INFO>();
            this.OM_DOCUMENT_ACCESS_INFO = new HashSet<OM_DOCUMENT_ACCESS_INFO>();
        }
    
        public int SID { get; set; }
        public Nullable<int> COMPANY_SID { get; set; }
        public string GROUP_NAME { get; set; }
        public bool INVALIDATED { get; set; }
        public System.DateTime ENTRY_DATE { get; set; }
        public int ENTRY_USER_SID { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_USER_SID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OM_ACCESS_GROUP_INFO> OM_ACCESS_GROUP_INFO { get; set; }
        public virtual OM_COMPANY_INFO OM_COMPANY_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OM_DOCUMENT_ACCESS_INFO> OM_DOCUMENT_ACCESS_INFO { get; set; }
    }
}
